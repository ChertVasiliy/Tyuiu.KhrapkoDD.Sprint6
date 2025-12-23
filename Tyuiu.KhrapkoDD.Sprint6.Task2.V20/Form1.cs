using System.Windows.Forms.VisualStyles;
using Tyuiu.KhrapkoDD.Sprint6.Task2.V20.Lib;
namespace Tyuiu.KhrapkoDD.Sprint6.Task2.V20
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            int startValue = Convert.ToInt32(textBoxStartVal.Text);
            int stopValue = Convert.ToInt32(textBoxEndVal.Text);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);

            this.chartResult.Titles.Add("Уравнение F(X)= sin(x) / x + 1,2 + cos(x) * 7x - 2");
            this.chartResult.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult.ChartAreas[0].AxisY.Title = "Ось Y";
            for (int i = 0; i <= len - 1; i++)
            {
                this.dataGridViewResult.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                this.chartResult.Series[0].Points.AddXY(startValue, valueArray[i]);
                startValue++;
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {

        }
    }
}