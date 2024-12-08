using Tyuiu.TalalaevaAV.Sprint6.Task0.V23.Lib;
namespace Tyuiu.TalalaevaAV.Sprint6.Task0.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBoxDataOutput_TAV_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxInputX_TAV_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDoneResult_TAV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_TAV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_TAV.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxResult_TAV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVarX_TAV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVarX_TAV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBoxResult_TAV_ReadOnlyChanged(object sender, EventArgs e)
        {

        }

        private void buttonData_TAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студент группы ИИПб-24-1 Талалаева Александра Васильевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
