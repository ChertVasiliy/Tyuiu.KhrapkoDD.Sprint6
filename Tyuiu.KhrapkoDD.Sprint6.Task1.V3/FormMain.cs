using System;
using System.Windows.Forms;
using Tyuiu.KhrapkoDD.Sprint6.Task1.V3.Lib;

namespace Tyuiu.KhrapkoDD.Sprint6.Task1.V3
{
    public partial class Form1 : Form
    {
        private DataService _dataService;

        public Form1()
        {
            InitializeComponent();
            _dataService = new DataService();
            CalculateAndDisplay();
        }

        private void CalculateAndDisplay()
        {
            int startValue = -5;
            int stopValue = 5;
            double[] results = _dataService.GetMassFunction(startValue, stopValue);

            string output = "Таблица значений функции F(x) = 5 - 3x + (1 + sin(x))/(2x - 0.5)\n";
            output += "Диапазон: [" + startValue + "; " + stopValue + "] с шагом 1.\n\n";
            output += "X\tF(x)\n";
            output += "---------------------\n";

            for (int i = 0; i < results.Length; i++)
            {
                int x = startValue + i;
                output += x.ToString() + "\t" + results[i].ToString() + "\n";
            }

            textBox1.Text = output;
        }
    }
}