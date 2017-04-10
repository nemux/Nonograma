using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NonoGramaWS
{    
    [ServiceContract]
    public interface INonoGramaService
    {
        [OperationContract]
        DiscreteTomography createNonoGrama(int n, int m, int [][]values);
    }

    [DataContract]
    public class DiscreteTomography
    {
        private int[][] rows;
        [DataMember]
        public int[][] Rows {
            get { return rows; }
            set { rows = value;}
        }
        private int[][] columns;
        [DataMember]
        public int[][] Columns
        {
            get { return columns; }
            set { columns = value; }
        }

        private String error_values;
        [DataMember]
        public String Error_Values
        {
            get { return error_values; }
            set { error_values = value;}
        }

        private String error_coord;
        [DataMember]
        public String Error_Coord
        {
            get { return error_coord; }
            set { error_coord = value; }
        }

        private int currentRow;
        private int currentColumn;
        
        public DiscreteTomography(int r, int c)
        {
            rows = new int[r][];
            columns = new int[c][];

            Error_Values = String.Empty;
            Error_Coord = String.Empty;
            currentColumn = 0;
            currentRow = 0;
        }

        public void createRow(int[] values)
        {
            Rows[currentRow] = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
                Rows[currentRow][i] = values[i];
            currentRow++;
        }

        public void createColumn(int[] values)
        {
            Columns[currentColumn] = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
                Columns[currentColumn][i] = values[i];
            currentColumn++;
        }        
    }
}
