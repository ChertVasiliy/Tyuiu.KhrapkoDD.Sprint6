using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Tyuiu.KhrapkoDD.Sprint6.Task0.V13.Lib;

namespace Tyuiu.KhrapkoDD.Sprint6.Task0.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxX.Text))
                {
                    MessageBox.Show("Поле обязательно для заполнения!");
                    return;
                }

                int x = Convert.ToInt32(textBoxX.Text);

                DataService ds = new DataService();
                double result = ds.Calculate(x);

                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное число.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            // Пустой обработчик. Если не используется — можно удалить.
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Пустой обработчик. Если не используется — можно удалить.
        }

        private void labelResult_Click(object sender, EventArgs e)
        {
            // Пустой обработчик. Если не используется — можно удалить.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Пустой обработчик. Если не используется — можно удалить.
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Пустой обработчик. Если не используется — можно удалить.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Пустой обработчик. Если не используется — можно удалить.
        }
    }
}
