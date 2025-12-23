using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.KhrapkoDD.Sprint6.Task7.V11.Lib;

namespace Tyuiu.KhrapkoDD.Sprint6.Task7.V11
{
    public partial class Form1 : Form
    {
        private int[,] _matrix;   // храним матрицу

        public Form1() => InitializeComponent();

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using OpenFileDialog d = new() { Filter = "CSV|*.csv" };
            if (d.ShowDialog() != DialogResult.OK) return;

            var svc = new DataService();
            _matrix = svc.GetMatrix(d.FileName);

            FillGrid(dataGridViewIn, _matrix); // исходник
            FillGrid(dataGridViewOut, _matrix); // результат
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_matrix == null) return;
            using SaveFileDialog d = new()
            {
                Filter = "CSV|*.csv",
                FileName = "OutPutFileTask7.csv"
            };
            if (d.ShowDialog() != DialogResult.OK) return;

            int rows = _matrix.GetLength(0);
            int cols = _matrix.GetLength(1);
            using StreamWriter w = new(d.FileName);
            for (int r = 0; r < rows; r++)
            {
                var line = new string[cols];
                for (int c = 0; c < cols; c++)
                    line[c] = _matrix[r, c].ToString();
                w.WriteLine(string.Join(";", line));
            }
            MessageBox.Show("Сохранено");
        }

        private static void FillGrid(DataGridView dgv, int[,] m)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            int cols = m.GetLength(1);
            for (int c = 0; c < cols; c++) dgv.Columns.Add("", "");

            int rows = m.GetLength(0);
            for (int r = 0; r < rows; r++)
            {
                var row = new object[cols];
                for (int c = 0; c < cols; c++) row[c] = m[r, c];
                dgv.Rows.Add(row);
            }
        }
    }
}