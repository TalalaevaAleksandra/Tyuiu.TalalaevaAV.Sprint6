namespace Tyuiu.TalalaevaAV.Sprint6.Task2.V18
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
            groupBoxCondition_TAV = new GroupBox();
            textBox1 = new TextBox();
            groupBoxDataEntry_TAV = new GroupBox();
            textBoxStopStep = new TextBox();
            textBoxStartStep = new TextBox();
            textBoxVarStopStep_TAV = new TextBox();
            textBoxVarStartStep_TAV = new TextBox();
            buttonData_TAV = new Button();
            buttonDoneResult_TAV = new Button();
            groupBoxDataOutput_TAV = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView_TAV = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            textBoxResult_TAV = new TextBox();
            groupBoxCondition_TAV.SuspendLayout();
            groupBoxDataEntry_TAV.SuspendLayout();
            groupBoxDataOutput_TAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_TAV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_TAV
            // 
            groupBoxCondition_TAV.Controls.Add(textBox1);
            groupBoxCondition_TAV.Location = new Point(13, 16);
            groupBoxCondition_TAV.Name = "groupBoxCondition_TAV";
            groupBoxCondition_TAV.Size = new Size(456, 200);
            groupBoxCondition_TAV.TabIndex = 0;
            groupBoxCondition_TAV.TabStop = false;
            groupBoxCondition_TAV.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(10, 25);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(440, 160);
            textBox1.TabIndex = 0;
            textBox1.Text = "Протабулировать функцию на заданном диапозоне.\r\nРезультат вывести в DataGridView и построить график функции.\r\n";
            // 
            // groupBoxDataEntry_TAV
            // 
            groupBoxDataEntry_TAV.Controls.Add(textBoxStopStep);
            groupBoxDataEntry_TAV.Controls.Add(textBoxStartStep);
            groupBoxDataEntry_TAV.Controls.Add(textBoxVarStopStep_TAV);
            groupBoxDataEntry_TAV.Controls.Add(textBoxVarStartStep_TAV);
            groupBoxDataEntry_TAV.Location = new Point(19, 222);
            groupBoxDataEntry_TAV.Name = "groupBoxDataEntry_TAV";
            groupBoxDataEntry_TAV.Size = new Size(295, 123);
            groupBoxDataEntry_TAV.TabIndex = 1;
            groupBoxDataEntry_TAV.TabStop = false;
            groupBoxDataEntry_TAV.Text = "Ввод данных";
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(175, 65);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(101, 23);
            textBoxStopStep.TabIndex = 3;
            textBoxStopStep.KeyPress += textBox3_KeyPress;
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(22, 65);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(101, 23);
            textBoxStartStep.TabIndex = 2;
            textBoxStartStep.KeyPress += textBox2_KeyPress;
            // 
            // textBoxVarStopStep_TAV
            // 
            textBoxVarStopStep_TAV.BackColor = SystemColors.Menu;
            textBoxVarStopStep_TAV.BorderStyle = BorderStyle.None;
            textBoxVarStopStep_TAV.Location = new Point(161, 37);
            textBoxVarStopStep_TAV.Name = "textBoxVarStopStep_TAV";
            textBoxVarStopStep_TAV.Size = new Size(128, 16);
            textBoxVarStopStep_TAV.TabIndex = 1;
            textBoxVarStopStep_TAV.Text = "Конец шага";
            textBoxVarStopStep_TAV.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxVarStartStep_TAV
            // 
            textBoxVarStartStep_TAV.BackColor = SystemColors.Menu;
            textBoxVarStartStep_TAV.BorderStyle = BorderStyle.None;
            textBoxVarStartStep_TAV.Location = new Point(8, 37);
            textBoxVarStartStep_TAV.Name = "textBoxVarStartStep_TAV";
            textBoxVarStartStep_TAV.Size = new Size(128, 16);
            textBoxVarStartStep_TAV.TabIndex = 0;
            textBoxVarStartStep_TAV.Text = "Старт шага";
            textBoxVarStartStep_TAV.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonData_TAV
            // 
            buttonData_TAV.BackColor = Color.Cyan;
            buttonData_TAV.FlatStyle = FlatStyle.Flat;
            buttonData_TAV.Location = new Point(330, 241);
            buttonData_TAV.Name = "buttonData_TAV";
            buttonData_TAV.Size = new Size(132, 37);
            buttonData_TAV.TabIndex = 2;
            buttonData_TAV.Text = "Справка";
            buttonData_TAV.UseVisualStyleBackColor = false;
            buttonData_TAV.Click += buttonData_TAV_Click;
            // 
            // buttonDoneResult_TAV
            // 
            buttonDoneResult_TAV.BackColor = Color.Lime;
            buttonDoneResult_TAV.Location = new Point(330, 297);
            buttonDoneResult_TAV.Name = "buttonDoneResult_TAV";
            buttonDoneResult_TAV.Size = new Size(135, 40);
            buttonDoneResult_TAV.TabIndex = 3;
            buttonDoneResult_TAV.Text = "Выполнить";
            buttonDoneResult_TAV.UseVisualStyleBackColor = false;
            buttonDoneResult_TAV.Click += buttonDoneResult_TAV_Click;
            buttonDoneResult_TAV.MouseDown += buttonDoneResult_TAV_MouseDown;
            buttonDoneResult_TAV.MouseEnter += buttonDoneResult_TAV_MouseEnter;
            buttonDoneResult_TAV.MouseLeave += buttonDoneResult_TAV_MouseLeave;
            // 
            // groupBoxDataOutput_TAV
            // 
            groupBoxDataOutput_TAV.Controls.Add(chartFunction);
            groupBoxDataOutput_TAV.Controls.Add(dataGridView_TAV);
            groupBoxDataOutput_TAV.Controls.Add(textBoxResult_TAV);
            groupBoxDataOutput_TAV.Location = new Point(486, 16);
            groupBoxDataOutput_TAV.Name = "groupBoxDataOutput_TAV";
            groupBoxDataOutput_TAV.Size = new Size(525, 325);
            groupBoxDataOutput_TAV.TabIndex = 4;
            groupBoxDataOutput_TAV.TabStop = false;
            groupBoxDataOutput_TAV.Text = "Вывод данных";
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            chartFunction.Location = new Point(175, 44);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(344, 264);
            chartFunction.TabIndex = 2;
            chartFunction.Text = "chart1";
            chartFunction.Click += chartFunction_Click;
            // 
            // dataGridView_TAV
            // 
            dataGridView_TAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_TAV.Columns.AddRange(new DataGridViewColumn[] { X, F });
            dataGridView_TAV.Location = new Point(8, 44);
            dataGridView_TAV.Name = "dataGridView_TAV";
            dataGridView_TAV.RowHeadersVisible = false;
            dataGridView_TAV.Size = new Size(151, 264);
            dataGridView_TAV.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // F
            // 
            F.HeaderText = "F(X)";
            F.Name = "F";
            F.Width = 50;
            // 
            // textBoxResult_TAV
            // 
            textBoxResult_TAV.BackColor = SystemColors.Menu;
            textBoxResult_TAV.BorderStyle = BorderStyle.None;
            textBoxResult_TAV.Location = new Point(8, 22);
            textBoxResult_TAV.Name = "textBoxResult_TAV";
            textBoxResult_TAV.Size = new Size(496, 16);
            textBoxResult_TAV.TabIndex = 0;
            textBoxResult_TAV.Text = "Результат";
            textBoxResult_TAV.TextChanged += textBoxResult_TAV_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 357);
            Controls.Add(groupBoxDataOutput_TAV);
            Controls.Add(buttonDoneResult_TAV);
            Controls.Add(buttonData_TAV);
            Controls.Add(groupBoxDataEntry_TAV);
            Controls.Add(groupBoxCondition_TAV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 18 | Талалаева А.В.";
            groupBoxCondition_TAV.ResumeLayout(false);
            groupBoxCondition_TAV.PerformLayout();
            groupBoxDataEntry_TAV.ResumeLayout(false);
            groupBoxDataEntry_TAV.PerformLayout();
            groupBoxDataOutput_TAV.ResumeLayout(false);
            groupBoxDataOutput_TAV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_TAV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_TAV;
        private TextBox textBox1;
        private GroupBox groupBoxDataEntry_TAV;
        private TextBox textBoxStopStep;
        private TextBox textBoxStartStep;
        private TextBox textBoxVarStopStep_TAV;
        private TextBox textBoxVarStartStep_TAV;
        private Button buttonData_TAV;
        private Button buttonDoneResult_TAV;
        private GroupBox groupBoxDataOutput_TAV;
        private TextBox textBoxResult_TAV;
        private DataGridView dataGridView_TAV;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
