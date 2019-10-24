using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Детерминант
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rand_Click(object sender, EventArgs e)
        {            
            int sizex = 1;
            if (!int.TryParse(SizeX.Text, out sizex))
                sizex = 1;
            matrix.ColumnCount = sizex;
            int sizey = 1;
            if (!int.TryParse(SizeY.Text, out sizey))
                sizey = 1;
            matrix.RowCount = sizey;
            for(int i = 0; i < sizex; i++)
            {
                matrix.Columns[i].HeaderText = $"{i}";
                matrix.Columns[i].Width = 40;
             }
            for (int i = 0; i < sizey; i++)
            {
                matrix.Rows[i].HeaderCell.Value = $"{i}" ;
                matrix.Rows[i].Height = 40;

            }
            Random rand = new Random();
            double[,] array=new double[100,100];
            for(int i = 0; i < sizex; i++)
            {
                for(int j=0;j< sizey; j++)
                {
                    matrix[i, j].Value = rand.Next(1, 2);
                    array[i, j] = (int)matrix[i, j].Value;
                }
            }
            if (sizex != sizey) MessageBox.Show("Введите квадратную матрицу чтобы найти детерминант!", "Error!!!", MessageBoxButtons.OK);
            double det =1;
            double v;
            int row = 0;
            int k = 0;
            while (k < sizex - 1)
            {
                int i, j;
                int gr = row;
                for (i = row + 1; i < sizex; i++)
                {
                    if (Math.Abs(array[row,k]) < Math.Abs(array[i,k]))
                        gr = i;
                }

                if ((row == gr) && (array[row,k] == 0))
                {
                    k++;
                    continue;
                }
                for (i = row + 1; i < sizex; i++)
                {

                    v = array[i,k] / array[row,k];
                    array[i,k] = 0;
                    if (v != 0)
                        for (j = k + 1; j < sizex; j++)
                            array[i,j] = array[i,j] - v * array[k,j];

                }
                row++;
                k++;
                
            }
            for (int i = 0;i< sizex;i++)
            det *= array[i, i];
            MessageBox.Show($"Детерминант: {det}", "Answer!", MessageBoxButtons.OK);
        }
        private void SizeX_TextChanged(object sender, EventArgs e)
        {

        }
        private void det_Click(object sender, EventArgs e)
        {
            
        }
    }
}
