using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nonoGrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawGrid(object sender, EventArgs e)
        {            
            Graphics g = pictureBox.CreateGraphics();            
            int numOfColumns = (int) (numericUpDownColumns.Value + 1m);
            int numOfRows = (int)(numericUpDownRows.Value + 1m);
            Pen pen = new Pen(Color.Black);
            float x = 0f, y = 0f;
            float xSpace = pictureBox.Width / numOfColumns;
            float ySpace = pictureBox.Height / numOfRows;
            Font myFont = new Font("Arial",(pictureBox.Width < pictureBox.Height) ? xSpace /5 : ySpace /5);
            ServiceReferenceNanoGrama.DiscreteTomography data = new ServiceReferenceNanoGrama.DiscreteTomography();

            ServiceReferenceNanoGrama.NonoGramaServiceClient client = new ServiceReferenceNanoGrama.NonoGramaServiceClient();
            data = client.createNonoGrama(numOfRows - 1, numOfColumns - 1, getMatrixValues());
                                   
            g.Clear(Color.Beige);
            for (int i = 0; i <= numOfColumns; i++)
            {
                g.DrawLine(pen,x,y,x,pictureBox.Height);
                if (i > 0 && i < numOfColumns)
                {
                    String header = String.Empty;
                    foreach (int v in data.Columns[i - 1])
                        header += v.ToString() + "\n";
                    g.DrawString(header.Substring(0, header.Length == 0 ? header.Length : header.Length - 1), myFont, new SolidBrush(Color.Black), x + myFont.Size, y);
                }
                x += xSpace;
            }

            x = 0f;
            y = 0f;
            for (int i = 0; i <= numOfRows; i++)
            {
                g.DrawLine(pen, x, y, pictureBox.Width, y);
                if (i > 0 && i < numOfRows)
                {
                    String header = String.Empty;
                    foreach (int v in data.Rows[i-1])
                        header += v.ToString() + ",";
                    g.DrawString(header.Substring(0,header.Length == 0? header.Length : header.Length - 1) , myFont, new SolidBrush(Color.Black), x, y + myFont.Size);
                }
                y += ySpace;
            }
        }

        private int[][] getMatrixValues()
        {
            String stringValues = textBoxValues.Text;
            string[] split = stringValues.Split(new Char[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
            int[][] values = new int [split.Length / 2][];

            for (int i = 0, j = 0; i < split.Length / 2; i++, j+=2)
            {
                values[i] = new int [2];
                values[i][0] = Convert.ToInt32(split[j]);
                values[i][1] = Convert.ToInt32(split[j+1]);
            }
                return values;
        }

        private void buttonAddValues_Click(object sender, EventArgs e)
        {
            String values = string.Empty;

            if (textBoxValues.Text != "")
                values += ",";
            values += "(" + numericUpDownFilas.Value.ToString() + "," + numericUpDownColumnas.Value.ToString() + ")";

            textBoxValues.AppendText(values);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxValues.Text = String.Empty;
        }
    }
}
