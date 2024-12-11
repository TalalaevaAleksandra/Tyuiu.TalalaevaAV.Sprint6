namespace Tyuiu.TalalaevaAV.Sprint6.Tasr4.V11
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelData_TAV = new Panel();
            buttonSave = new Button();
            buttonDone = new Button();
            buttonData = new Button();
            groupBoxDataInput_TAV = new GroupBox();
            textBoxStopStep = new TextBox();
            textBoxStartStep = new TextBox();
            textBox3 = new TextBox();
            textBoxVarStartStep_TAV = new TextBox();
            groupBoxCondition_TAV = new GroupBox();
            textBox1 = new TextBox();
            panelDataOutPut = new Panel();
            groupBoxDataOutPut_TAV = new GroupBox();
            textBoxResult = new TextBox();
            panelChart_TAV = new Panel();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelData_TAV.SuspendLayout();
            groupBoxDataInput_TAV.SuspendLayout();
            groupBoxCondition_TAV.SuspendLayout();
            panelDataOutPut.SuspendLayout();
            groupBoxDataOutPut_TAV.SuspendLayout();
            panelChart_TAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // panelData_TAV
            // 
            panelData_TAV.Controls.Add(buttonSave);
            panelData_TAV.Controls.Add(buttonDone);
            panelData_TAV.Controls.Add(buttonData);
            panelData_TAV.Controls.Add(groupBoxDataInput_TAV);
            panelData_TAV.Controls.Add(groupBoxCondition_TAV);
            panelData_TAV.Dock = DockStyle.Top;
            panelData_TAV.Location = new Point(0, 0);
            panelData_TAV.Name = "panelData_TAV";
            panelData_TAV.Size = new Size(784, 117);
            panelData_TAV.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Blue;
            buttonSave.Location = new Point(684, 40);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(88, 36);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Cyan;
            buttonDone.Location = new Point(586, 40);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(92, 36);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonData
            // 
            buttonData.BackColor = Color.Cyan;
            buttonData.Location = new Point(497, 40);
            buttonData.Name = "buttonData";
            buttonData.Size = new Size(83, 36);
            buttonData.TabIndex = 2;
            buttonData.Text = "Справка";
            buttonData.UseVisualStyleBackColor = false;
            buttonData.Click += buttonData_Click;
            // 
            // groupBoxDataInput_TAV
            // 
            groupBoxDataInput_TAV.Controls.Add(textBoxStopStep);
            groupBoxDataInput_TAV.Controls.Add(textBoxStartStep);
            groupBoxDataInput_TAV.Controls.Add(textBox3);
            groupBoxDataInput_TAV.Controls.Add(textBoxVarStartStep_TAV);
            groupBoxDataInput_TAV.Location = new Point(279, 14);
            groupBoxDataInput_TAV.Name = "groupBoxDataInput_TAV";
            groupBoxDataInput_TAV.Size = new Size(212, 97);
            groupBoxDataInput_TAV.TabIndex = 1;
            groupBoxDataInput_TAV.TabStop = false;
            groupBoxDataInput_TAV.Text = "Ввод данных";
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(110, 52);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(78, 23);
            textBoxStopStep.TabIndex = 1;
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(13, 52);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(78, 23);
            textBoxStartStep.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(109, 26);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(79, 16);
            textBox3.TabIndex = 0;
            textBox3.Text = "Конец шага";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBoxVarStartStep_TAV
            // 
            textBoxVarStartStep_TAV.BackColor = SystemColors.Menu;
            textBoxVarStartStep_TAV.BorderStyle = BorderStyle.None;
            textBoxVarStartStep_TAV.Location = new Point(8, 26);
            textBoxVarStartStep_TAV.Name = "textBoxVarStartStep_TAV";
            textBoxVarStartStep_TAV.ReadOnly = true;
            textBoxVarStartStep_TAV.Size = new Size(79, 16);
            textBoxVarStartStep_TAV.TabIndex = 0;
            textBoxVarStartStep_TAV.Text = "Старт шага";
            textBoxVarStartStep_TAV.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBoxCondition_TAV
            // 
            groupBoxCondition_TAV.Controls.Add(textBox1);
            groupBoxCondition_TAV.Location = new Point(6, 5);
            groupBoxCondition_TAV.Name = "groupBoxCondition_TAV";
            groupBoxCondition_TAV.Size = new Size(260, 106);
            groupBoxCondition_TAV.TabIndex = 0;
            groupBoxCondition_TAV.TabStop = false;
            groupBoxCondition_TAV.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(6, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 84);
            textBox1.TabIndex = 0;
            textBox1.Text = "Протабулировать функцию на заданном диапозоне.\r\nРезультат вывести в textBox, построить график функции и сохранить\r\nв файл OutPutFileTask4V11.txt по нажатию кнопки. \r\n";
            // 
            // panelDataOutPut
            // 
            panelDataOutPut.Controls.Add(groupBoxDataOutPut_TAV);
            panelDataOutPut.Dock = DockStyle.Left;
            panelDataOutPut.Location = new Point(0, 117);
            panelDataOutPut.Name = "panelDataOutPut";
            panelDataOutPut.Size = new Size(266, 294);
            panelDataOutPut.TabIndex = 1;
            // 
            // groupBoxDataOutPut_TAV
            // 
            groupBoxDataOutPut_TAV.Controls.Add(textBoxResult);
            groupBoxDataOutPut_TAV.Dock = DockStyle.Fill;
            groupBoxDataOutPut_TAV.Location = new Point(0, 0);
            groupBoxDataOutPut_TAV.Name = "groupBoxDataOutPut_TAV";
            groupBoxDataOutPut_TAV.Size = new Size(266, 294);
            groupBoxDataOutPut_TAV.TabIndex = 0;
            groupBoxDataOutPut_TAV.TabStop = false;
            groupBoxDataOutPut_TAV.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Location = new Point(3, 19);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(260, 272);
            textBoxResult.TabIndex = 0;
            // 
            // panelChart_TAV
            // 
            panelChart_TAV.Controls.Add(chartFunction);
            panelChart_TAV.Dock = DockStyle.Fill;
            panelChart_TAV.Location = new Point(266, 117);
            panelChart_TAV.Name = "panelChart_TAV";
            panelChart_TAV.Size = new Size(518, 294);
            panelChart_TAV.TabIndex = 2;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            chartFunction.Dock = DockStyle.Fill;
            chartFunction.Location = new Point(0, 0);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(518, 294);
            chartFunction.TabIndex = 0;
            chartFunction.Text = "chart1";
            title1.Alignment = ContentAlignment.TopCenter;
            title1.Name = "График функции";
            chartFunction.Titles.Add(title1);
            // 
            // splitter1
            // 
            splitter1.Location = new Point(266, 117);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 294);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(splitter1);
            Controls.Add(panelChart_TAV);
            Controls.Add(panelDataOutPut);
            Controls.Add(panelData_TAV);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 11 | Талалаева А.В.";
            Load += Form1_Load;
            panelData_TAV.ResumeLayout(false);
            groupBoxDataInput_TAV.ResumeLayout(false);
            groupBoxDataInput_TAV.PerformLayout();
            groupBoxCondition_TAV.ResumeLayout(false);
            groupBoxCondition_TAV.PerformLayout();
            panelDataOutPut.ResumeLayout(false);
            groupBoxDataOutPut_TAV.ResumeLayout(false);
            groupBoxDataOutPut_TAV.PerformLayout();
            panelChart_TAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelData_TAV;
        private GroupBox groupBoxCondition_TAV;
        private TextBox textBox1;
        private GroupBox groupBoxDataInput_TAV;
        private TextBox textBox3;
        private TextBox textBoxVarStartStep_TAV;
        private TextBox textBoxStopStep;
        private TextBox textBoxStartStep;
        private Button buttonData;
        private Button buttonSave;
        private Button buttonDone;
        private Panel panelDataOutPut;
        private GroupBox groupBoxDataOutPut_TAV;
        private TextBox textBoxResult;
        private Panel panelChart_TAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private Splitter splitter1;
    }
}
