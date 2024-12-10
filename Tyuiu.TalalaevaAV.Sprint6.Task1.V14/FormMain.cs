using Tyuiu.TalalaevaAV.Sprint6.Task1.V14.Lib;
namespace Tyuiu.TalalaevaAV.Sprint6.Task1.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void textBoxVarStartStep_TAV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStartStep_TAV_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxStopStep_TAV_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttonResult_TAV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_TAV.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_TAV.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_TAV.Text = "";
                textBoxResult_TAV.AppendText("+-----------+------------+" + Environment.NewLine);
                textBoxResult_TAV.AppendText("|     X     |    f(x)    |" + Environment.NewLine);
                textBoxResult_TAV.AppendText("+-----------+------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|  {0,5:d}    |   {1, 6:f2}   |", startStep, valueArray[i]);
                    textBoxResult_TAV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_TAV.AppendText("+-----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonData_TAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студент группы ИИПб-24-1 Талалаева Александра Васильевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStartStep_TAV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
