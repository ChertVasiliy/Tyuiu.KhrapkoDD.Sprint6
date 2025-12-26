using System.Drawing.Drawing2D;
using Tyuiu.KhrapkoDD.Sprint6.Task3.V12.Lib;

namespace Tyuiu.KhrapkoDD.Sprint6.Task3.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }



        public void FormMain_Load(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5]
            {
            {-6,-13,-1,-7,10},
            {14,-18,18,1,11},
            {-2,-17,-15,-10,-8 },
            {19,-4,-6,-11,8 },
            {-17,17,14,13,19 }
            };
            matrix = ds.Calculate(matrix);
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewResult_KFA.ColumnCount = columns;
            dataGridViewResult_KFA.RowCount = rows;

            dataGridViewSorted_KFA.ColumnCount = columns;
            dataGridViewSorted_KFA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_KFA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_KFA.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
        public void buttonResult_KFA_Click(object sender, EventArgs e)
        {

        }
    }
}
