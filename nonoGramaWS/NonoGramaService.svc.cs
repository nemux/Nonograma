using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace NonoGramaWS
{    
    public class NonoGramaService : INonoGramaService
    {
        String error_coords; 
        String error_values; 

        public NonoGramaService(){
            this.error_coords = "Error Coords:\n";
            this.error_values = "Error Values:\n";
        }

        /**
         * Method for create a nonogram
         * @param int n Number of Rows
         * @param int m, Number of Columns
         * @param int[][]values Selected x,y coords for the nonogram
         *          values[0] = [1,2]
         *          values[1] = [0,0]
         *          ...
         *          values[n] = [x,y]
         * 
         * return DiscreteTomograpy          
         */
        public DiscreteTomography createNonoGrama(int n, int m, int[][] values)
        {
            DiscreteTomography dT = new DiscreteTomography(n,m);
            //Create a NxM matrix
            if (n > 20 || m > 20)
                return null;
            
            int[][] columns = null;
            int[][] rows = null;

            int[,] matrix = createMatrix(n, m, values);
            //saveNonogram(n, m, values);

            //Get the columns and its values.
            columns = countColumns(matrix);
            //Get the rows and its values.
            rows = countRows(matrix);
                
            //Fill the values of the rows in the discreteTomography
            foreach (int[] r in rows)
                dT.createRow(r);
            //Fill the values of the columns in the discreteTomography
            foreach (int[] c in columns)
                dT.createColumn(c);
            //Fill the errors
            dT.Error_Coord = error_coords;
            dT.Error_Values = error_values;
                 
            //Return the discrete tomography
            return dT;
        }

        private int[,] createMatrix(int n, int m, int[][] values)
        {
            int[,] matrix = new int[n, m];
            //Fill the matrix with 0
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    matrix[i, j] = 0;

            for (int i = 0; i < values.Length; i++)
            {
                //Check the values and set the points given for the nonogram. Save bad coords, and ignore them.
                if (values[i].Length == 2)
                    if (values[i][0] < n && values[i][1] < m)
                        matrix[values[i][0], values[i][1]] = 1;
                    else
                        error_coords += (i + 1).ToString() + ".- [" + values[i][0] + "," + values[i][1] + "]\n";
                else
                {
                    error_values += (i + 1).ToString() + ".- [";
                    foreach (int v in values[i])
                    {
                        error_values += v.ToString() + ",";
                    }
                    error_values = error_values.Substring(0, error_values.Length - 1);
                    error_values += "]\n";
                }
            }

            return matrix;
        }

        /*
         *
         * This method count the number of points given by row
         */
        private int[][] countRows(int[,] matrix){
            
            int count = 0;
            List<int> tempRows = null;
            int[][] rows = new int[matrix.GetLength(0)][];

            //We cross the matrix from LEFT to RIGHT & UP to DOWN
            for (int i = 0; i < matrix.GetLength(0); i++){
                tempRows = new List<int>();
                for(int j = 0; j < matrix.GetLength(1); j++){
                    //Check if is a selected point
                    if (matrix[i, j] == 1)
                    {   
                        //Save it on temp counter
                        count++;
                        if (j == (matrix.GetLength(1) - 1))
                        {
                            //Add it to the temp list and reset the counter, only if is the end of the row
                            tempRows.Add(count);
                            count = 0;
                        }
                    }
                    else
                    {
                        if (count != 0)
                            //Add it to the temp list and reset the counter
                            tempRows.Add(count);
                        count = 0;
                    }
                }
                rows[i] = tempRows.ToArray();
            }              
  
            //Return a map with the asociated values, every number defines the consecutive fields in row
            //
            // rows[0] = [1,2...z]
            // rows[1] = [2]
            // ...
            // rows[n] = [a,b,...z]
            //
            return rows;
        }


        /*
         *
         * This method count the number of points given by column
         */
        private int[][] countColumns(int[,] matrix)
        {

            int count = 0;
            List<int> tempColumns = null;
            int[][] columns = new int[matrix.GetLength(1)][];

            //We cross the matrix fromUP to DOWN & LEFT to RIGHT
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                tempColumns = new List<int>();
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    //Check if is a selected point
                    if (matrix[j, i] == 1)
                    {
                        //Save it on temp counter
                        count++;
                        if (j == (matrix.GetLength(0) - 1))
                        {
                            //Add it to the temp list and reset the counter, only if is the end of the column
                            tempColumns.Add(count);
                            count = 0;
                        }
                    }
                    else
                    {
                        if (count != 0)
                            //Add it to the temp list and reset the counter
                            tempColumns.Add(count);
                        count = 0;
                    }
                }
                columns[i] = tempColumns.ToArray();
            }
            //Return a map with the asociated values, every number defines the consecutive fields in column
            //
            // columns[0] = [1,2...z]
            // columns[1] = [2]
            // ...
            // columns[n] = [a,b,...z]
            //
            return columns;
        }

        /**
         * Save the nonogram and its solution
         */
        public void saveNonogram(int rows, int columns, int[][] values)
        {
            String stringConnection = "Data Source=localhost;Initial Catalog=nonograma;User ID=temp;Password=temp";
            Int32 id = 0;

            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand("sp_savenonogram", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@total_columns", SqlDbType.Int).Value = rows ;
                    cmd.Parameters.Add("@total_rows", SqlDbType.Int).Value = columns;

                    con.Open();
                   id = Convert.ToInt32(cmd.ExecuteScalar());
                }

                foreach (int[] v in values)
                {
                    if (v.Length == 2 && v[0] < rows && v[1] < columns)
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_savesolution", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@nonograma_id", SqlDbType.Int).Value = id;
                            cmd.Parameters.Add("@column", SqlDbType.Int).Value = v[0];
                            cmd.Parameters.Add("@row", SqlDbType.Int).Value = v[1];

                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }                    
                }
            }
        }
    }
}
