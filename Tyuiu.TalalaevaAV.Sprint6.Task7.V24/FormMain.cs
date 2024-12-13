using Tyuiu.TalalaevaAV.Sprint6.Task7.V24.Lib;
namespace Tyuiu.TalalaevaAV.Sprint6.Task7.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_TAV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMtrx_TAV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        int rows;
        int columns;
        string openFilePath;
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonData_TAV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_TAV_Click(object sender, EventArgs e)
        {
            openFileDialog_TAV.ShowDialog();
            openFilePath = openFileDialog_TAV.FileName;

            string filedata = File.ReadAllText(openFilePath);

            filedata = filedata.Replace('\n', '\r');
            string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }

            dataGridViewInput_TAV.ColumnCount = columns;
            dataGridViewInput_TAV.RowCount = rows;
            dataGridViewOutPut_TAV.ColumnCount = columns;
            dataGridViewOutPut_TAV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_TAV.Columns[i].Width = 35;
                dataGridViewOutPut_TAV.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInput_TAV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            buttonResult_TAV.Enabled = true;
        }

        private void buttonResult_TAV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPut_TAV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            buttonSaveFile_TAV.Enabled = true;
        }

        private void buttonSaveFile_TAV_Click(object sender, EventArgs e)
        {
            saveFileDialogMtrx_TAV.FileName = "OutPutFileTask7.csv";
            saveFileDialogMtrx_TAV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMtrx_TAV.ShowDialog();

            string path = saveFileDialogMtrx_TAV.FileName;

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_TAV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_TAV.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_TAV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_TAV.ToolTipTitle = "Открыть файл";
        }

        private void buttonResult_TAV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_TAV.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_TAV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_TAV.ToolTipTitle = "Сохранить файл";
        }

        private void buttonData_TAV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_TAV.ToolTipTitle = "Сведения";
        }
    }
}
