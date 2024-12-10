using Tyuiu.TalalaevaAV.Sprint6.Task2.V18.Lib;
namespace Tyuiu.TalalaevaAV.Sprint6.Task2.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxResult_TAV_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDoneResult_TAV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction.Titles.Add("График функции f(x)");
                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i < len - 1; i++)
                {
                    this.dataGridView_TAV.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chartFunction_Click(object sender, EventArgs e)
        {

        }

        private void buttonData_TAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студент группы ИИПб-24-1 Талалаева Александра Васильевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDoneResult_TAV_MouseEnter(object sender, EventArgs e)
        {
            buttonDoneResult_TAV.BackColor = Color.Red;
        }

        private void buttonDoneResult_TAV_MouseLeave(object sender, EventArgs e)
        {
            buttonDoneResult_TAV.BackColor = Color.Blue;
        }

        private void buttonDoneResult_TAV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDoneResult_TAV.BackColor = Color.Green;
        }
    }
}
