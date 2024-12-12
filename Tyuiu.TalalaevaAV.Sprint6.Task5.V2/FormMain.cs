using Tyuiu.TalalaevaAV.Sprint6.Task5.V2.Lib;
namespace Tyuiu.TalalaevaAV.Sprint6.Task5.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint5\InPutDataFileTask5V2.txt";
        private void buttonDone_TAV_Click(object sender, EventArgs e)
        {
            dataGridView_TAV.ColumnCount = 2;
            dataGridView_TAV.Columns[0].Width = 50;
            dataGridView_TAV.Columns[1].Width = 50;
            this.chartFunction_TAV.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_TAV.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_TAV.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridView_TAV.Rows.Add(Convert.ToString(numsMass[i]));
                chartFunction_TAV.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpenFile_TAV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonData_TAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студент группы ИИПб-24-1 Талалаева Александра Васильевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
