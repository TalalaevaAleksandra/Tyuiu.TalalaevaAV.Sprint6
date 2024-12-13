namespace Tyuiu.TalalaevaAV.Sprint6.Task5.V2
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelMain_TAV = new Panel();
            buttonDone_TAV = new Button();
            buttonOpenFile_TAV = new Button();
            buttonData_TAV = new Button();
            groupBoxCondition_TAV = new GroupBox();
            textBoxCondition_TAV = new TextBox();
            panelDataOutPut_TAV = new Panel();
            groupBoxDataOutPut_TAV = new GroupBox();
            dataGridView_TAV = new DataGridView();
            panelChart_TAV = new Panel();
            chartFunction_TAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelMain_TAV.SuspendLayout();
            groupBoxCondition_TAV.SuspendLayout();
            panelDataOutPut_TAV.SuspendLayout();
            groupBoxDataOutPut_TAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_TAV).BeginInit();
            panelChart_TAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_TAV).BeginInit();
            SuspendLayout();
            // 
            // panelMain_TAV
            // 
            panelMain_TAV.Controls.Add(buttonDone_TAV);
            panelMain_TAV.Controls.Add(buttonOpenFile_TAV);
            panelMain_TAV.Controls.Add(buttonData_TAV);
            panelMain_TAV.Controls.Add(groupBoxCondition_TAV);
            panelMain_TAV.Dock = DockStyle.Top;
            panelMain_TAV.Location = new Point(0, 0);
            panelMain_TAV.Name = "panelMain_TAV";
            panelMain_TAV.Size = new Size(784, 81);
            panelMain_TAV.TabIndex = 0;
            // 
            // buttonDone_TAV
            // 
            buttonDone_TAV.BackColor = Color.Lime;
            buttonDone_TAV.Location = new Point(484, 22);
            buttonDone_TAV.Name = "buttonDone_TAV";
            buttonDone_TAV.Size = new Size(78, 40);
            buttonDone_TAV.TabIndex = 1;
            buttonDone_TAV.Text = "Выполнить";
            buttonDone_TAV.UseVisualStyleBackColor = false;
            buttonDone_TAV.Click += buttonDone_TAV_Click;
            // 
            // buttonOpenFile_TAV
            // 
            buttonOpenFile_TAV.BackColor = Color.Cyan;
            buttonOpenFile_TAV.Location = new Point(579, 22);
            buttonOpenFile_TAV.Name = "buttonOpenFile_TAV";
            buttonOpenFile_TAV.Size = new Size(93, 40);
            buttonOpenFile_TAV.TabIndex = 1;
            buttonOpenFile_TAV.Text = "Открыть файл";
            buttonOpenFile_TAV.UseVisualStyleBackColor = false;
            buttonOpenFile_TAV.Click += buttonOpenFile_TAV_Click;
            // 
            // buttonData_TAV
            // 
            buttonData_TAV.BackColor = Color.Cyan;
            buttonData_TAV.Location = new Point(689, 22);
            buttonData_TAV.Name = "buttonData_TAV";
            buttonData_TAV.Size = new Size(92, 40);
            buttonData_TAV.TabIndex = 1;
            buttonData_TAV.Text = "Справка";
            buttonData_TAV.UseVisualStyleBackColor = false;
            buttonData_TAV.Click += buttonData_TAV_Click;
            // 
            // groupBoxCondition_TAV
            // 
            groupBoxCondition_TAV.Controls.Add(textBoxCondition_TAV);
            groupBoxCondition_TAV.Location = new Point(5, 6);
            groupBoxCondition_TAV.Name = "groupBoxCondition_TAV";
            groupBoxCondition_TAV.Size = new Size(460, 69);
            groupBoxCondition_TAV.TabIndex = 0;
            groupBoxCondition_TAV.TabStop = false;
            groupBoxCondition_TAV.Text = "Условие";
            // 
            // textBoxCondition_TAV
            // 
            textBoxCondition_TAV.BackColor = SystemColors.Menu;
            textBoxCondition_TAV.BorderStyle = BorderStyle.None;
            textBoxCondition_TAV.Location = new Point(7, 16);
            textBoxCondition_TAV.Multiline = true;
            textBoxCondition_TAV.Name = "textBoxCondition_TAV";
            textBoxCondition_TAV.Size = new Size(450, 47);
            textBoxCondition_TAV.TabIndex = 0;
            textBoxCondition_TAV.Text = "Прочитать данные из файла InPutFileTask5V2.txt. Вывести в dataGridView. Вывести все отрицательные числа. Построить диаграмму по этим значениям";
            textBoxCondition_TAV.TextChanged += textBoxCondition_TAV_TextChanged;
            // 
            // panelDataOutPut_TAV
            // 
            panelDataOutPut_TAV.Controls.Add(groupBoxDataOutPut_TAV);
            panelDataOutPut_TAV.Dock = DockStyle.Left;
            panelDataOutPut_TAV.Location = new Point(0, 81);
            panelDataOutPut_TAV.Name = "panelDataOutPut_TAV";
            panelDataOutPut_TAV.Size = new Size(257, 360);
            panelDataOutPut_TAV.TabIndex = 1;
            // 
            // groupBoxDataOutPut_TAV
            // 
            groupBoxDataOutPut_TAV.Controls.Add(dataGridView_TAV);
            groupBoxDataOutPut_TAV.Dock = DockStyle.Fill;
            groupBoxDataOutPut_TAV.Location = new Point(0, 0);
            groupBoxDataOutPut_TAV.Name = "groupBoxDataOutPut_TAV";
            groupBoxDataOutPut_TAV.Size = new Size(257, 360);
            groupBoxDataOutPut_TAV.TabIndex = 0;
            groupBoxDataOutPut_TAV.TabStop = false;
            groupBoxDataOutPut_TAV.Text = "Вывод данных";
            // 
            // dataGridView_TAV
            // 
            dataGridView_TAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_TAV.Dock = DockStyle.Fill;
            dataGridView_TAV.Location = new Point(3, 19);
            dataGridView_TAV.Name = "dataGridView_TAV";
            dataGridView_TAV.Size = new Size(251, 338);
            dataGridView_TAV.TabIndex = 0;
            // 
            // panelChart_TAV
            // 
            panelChart_TAV.Controls.Add(chartFunction_TAV);
            panelChart_TAV.Dock = DockStyle.Fill;
            panelChart_TAV.Location = new Point(257, 81);
            panelChart_TAV.Name = "panelChart_TAV";
            panelChart_TAV.Size = new Size(527, 360);
            panelChart_TAV.TabIndex = 2;
            // 
            // chartFunction_TAV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_TAV.ChartAreas.Add(chartArea1);
            chartFunction_TAV.Dock = DockStyle.Fill;
            chartFunction_TAV.Location = new Point(0, 0);
            chartFunction_TAV.Name = "chartFunction_TAV";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chartFunction_TAV.Series.Add(series1);
            chartFunction_TAV.Size = new Size(527, 360);
            chartFunction_TAV.TabIndex = 0;
            chartFunction_TAV.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 441);
            Controls.Add(panelChart_TAV);
            Controls.Add(panelDataOutPut_TAV);
            Controls.Add(panelMain_TAV);
            MinimumSize = new Size(800, 480);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 2 | Талалаева А.В.";
            panelMain_TAV.ResumeLayout(false);
            groupBoxCondition_TAV.ResumeLayout(false);
            groupBoxCondition_TAV.PerformLayout();
            panelDataOutPut_TAV.ResumeLayout(false);
            groupBoxDataOutPut_TAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_TAV).EndInit();
            panelChart_TAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_TAV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain_TAV;
        private GroupBox groupBoxCondition_TAV;
        private TextBox textBoxCondition_TAV;
        private Panel panelDataOutPut_TAV;
        private Panel panelChart_TAV;
        private Button buttonDone_TAV;
        private Button buttonOpenFile_TAV;
        private Button buttonData_TAV;
        private GroupBox groupBoxDataOutPut_TAV;
        private DataGridView dataGridView_TAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_TAV;
    }
}
