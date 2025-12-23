using Tyuiu.KhrapkoDD.Sprint6.Task1.V3.Lib;

namespace Tyuiu.KhrapkoDD.Sprint6.Task1.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void buttonHelp_NVI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 1 âûïîëíèë ñòóäåíò ãðóïïû ÏÊÒá-24-1 Íîñêîâ Âèòàëèé Èãîðåâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        string strLine;
        private void buttonDone_NVI_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();

                int start = Convert.ToInt32(textBoxStart_NVI.Text);
                int end = Convert.ToInt32(textBoxEnd_NVI.Text);

                double[] valueArray = ds.GetMassFunction(start, end);
                textBoxResult_NVI.Text = "";
                textBoxResult_NVI.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult_NVI.AppendText("|     X     |    f(x)   |" + Environment.NewLine);
                textBoxResult_NVI.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i < valueArray.Length; i++)
                {
                    strLine = String.Format("| {0,5:d}     |  {1, 7:f2}  | ", start, valueArray[i]);
                    textBoxResult_NVI.AppendText(strLine + Environment.NewLine);
                    start++;
                }
                textBoxResult_NVI.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
