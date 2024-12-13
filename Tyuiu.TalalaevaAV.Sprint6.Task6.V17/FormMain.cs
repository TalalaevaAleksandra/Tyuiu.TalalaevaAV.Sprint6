using Tyuiu.TalalaevaAV.Sprint6.Task6.V17.Lib;
namespace Tyuiu.TalalaevaAV.Sprint6.Task6.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void buttonOpen_TAV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_TAV.ShowDialog();
            openFilePath = openFileDialogTask_TAV.FileName;
            textBoxInput_TAV.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_TAV.Text = groupBoxOutPut_TAV + " " + openFileDialogTask_TAV.FileName;
            buttonDone_TAV.Enabled = true;
        }

        private void buttonDone_TAV_Click(object sender, EventArgs e)
        {
            textBoxOut_Put_TAV.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonData_TAV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
