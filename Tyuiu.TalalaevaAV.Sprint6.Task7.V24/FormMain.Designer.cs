namespace Tyuiu.TalalaevaAV.Sprint6.Task7.V24
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons_TAV = new Panel();
            buttonData_TAV = new Button();
            buttonSaveFile_TAV = new Button();
            buttonResult_TAV = new Button();
            buttonOpenFile_TAV = new Button();
            panelCondition_TAV = new Panel();
            groupBoxCondition_TAV = new GroupBox();
            panelOutPut_TAV = new Panel();
            textBox1 = new TextBox();
            panelInPut_TAV = new Panel();
            groupBoxInput_TAV = new GroupBox();
            dataGridViewInput_TAV = new DataGridView();
            panel_TAV = new Panel();
            groupBoxOutput_TAV = new GroupBox();
            dataGridViewOutPut_TAV = new DataGridView();
            openFileDialog_TAV = new OpenFileDialog();
            saveFileDialogMtrx_TAV = new SaveFileDialog();
            toolTipButton_TAV = new ToolTip(components);
            panelButtons_TAV.SuspendLayout();
            panelCondition_TAV.SuspendLayout();
            groupBoxCondition_TAV.SuspendLayout();
            panelInPut_TAV.SuspendLayout();
            groupBoxInput_TAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_TAV).BeginInit();
            panel_TAV.SuspendLayout();
            groupBoxOutput_TAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_TAV).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_TAV
            // 
            panelButtons_TAV.Controls.Add(buttonData_TAV);
            panelButtons_TAV.Controls.Add(buttonSaveFile_TAV);
            panelButtons_TAV.Controls.Add(buttonResult_TAV);
            panelButtons_TAV.Controls.Add(buttonOpenFile_TAV);
            panelButtons_TAV.Dock = DockStyle.Top;
            panelButtons_TAV.Location = new Point(0, 0);
            panelButtons_TAV.Name = "panelButtons_TAV";
            panelButtons_TAV.Size = new Size(1584, 66);
            panelButtons_TAV.TabIndex = 0;
            // 
            // buttonData_TAV
            // 
            buttonData_TAV.FlatStyle = FlatStyle.Flat;
            buttonData_TAV.Image = (Image)resources.GetObject("buttonData_TAV.Image");
            buttonData_TAV.Location = new Point(240, 12);
            buttonData_TAV.Name = "buttonData_TAV";
            buttonData_TAV.Size = new Size(70, 46);
            buttonData_TAV.TabIndex = 0;
            toolTipButton_TAV.SetToolTip(buttonData_TAV, "Открыть файл для обработки в формате CSV");
            buttonData_TAV.UseVisualStyleBackColor = true;
            buttonData_TAV.Click += buttonData_TAV_Click;
            buttonData_TAV.MouseEnter += buttonData_TAV_MouseEnter;
            // 
            // buttonSaveFile_TAV
            // 
            buttonSaveFile_TAV.Enabled = false;
            buttonSaveFile_TAV.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_TAV.Image = (Image)resources.GetObject("buttonSaveFile_TAV.Image");
            buttonSaveFile_TAV.Location = new Point(164, 12);
            buttonSaveFile_TAV.Name = "buttonSaveFile_TAV";
            buttonSaveFile_TAV.Size = new Size(70, 46);
            buttonSaveFile_TAV.TabIndex = 0;
            toolTipButton_TAV.SetToolTip(buttonSaveFile_TAV, "Сохранить обработаннеы данные в формате CSV");
            buttonSaveFile_TAV.UseVisualStyleBackColor = true;
            buttonSaveFile_TAV.Click += buttonSaveFile_TAV_Click;
            buttonSaveFile_TAV.MouseEnter += buttonSaveFile_TAV_MouseEnter;
            // 
            // buttonResult_TAV
            // 
            buttonResult_TAV.Enabled = false;
            buttonResult_TAV.FlatStyle = FlatStyle.Flat;
            buttonResult_TAV.Image = (Image)resources.GetObject("buttonResult_TAV.Image");
            buttonResult_TAV.Location = new Point(88, 12);
            buttonResult_TAV.Name = "buttonResult_TAV";
            buttonResult_TAV.Size = new Size(70, 46);
            buttonResult_TAV.TabIndex = 0;
            toolTipButton_TAV.SetToolTip(buttonResult_TAV, "Выполнить обработку данных");
            buttonResult_TAV.UseVisualStyleBackColor = true;
            buttonResult_TAV.Click += buttonResult_TAV_Click;
            buttonResult_TAV.MouseEnter += buttonResult_TAV_MouseEnter;
            // 
            // buttonOpenFile_TAV
            // 
            buttonOpenFile_TAV.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_TAV.Image = (Image)resources.GetObject("buttonOpenFile_TAV.Image");
            buttonOpenFile_TAV.Location = new Point(12, 12);
            buttonOpenFile_TAV.Name = "buttonOpenFile_TAV";
            buttonOpenFile_TAV.Size = new Size(70, 46);
            buttonOpenFile_TAV.TabIndex = 0;
            buttonOpenFile_TAV.UseVisualStyleBackColor = true;
            buttonOpenFile_TAV.Click += buttonOpenFile_TAV_Click;
            buttonOpenFile_TAV.MouseEnter += buttonOpenFile_TAV_MouseEnter;
            // 
            // panelCondition_TAV
            // 
            panelCondition_TAV.Controls.Add(groupBoxCondition_TAV);
            panelCondition_TAV.Dock = DockStyle.Top;
            panelCondition_TAV.Location = new Point(0, 66);
            panelCondition_TAV.Name = "panelCondition_TAV";
            panelCondition_TAV.Size = new Size(1584, 72);
            panelCondition_TAV.TabIndex = 1;
            // 
            // groupBoxCondition_TAV
            // 
            groupBoxCondition_TAV.Controls.Add(panelOutPut_TAV);
            groupBoxCondition_TAV.Controls.Add(textBox1);
            groupBoxCondition_TAV.Dock = DockStyle.Fill;
            groupBoxCondition_TAV.Location = new Point(0, 0);
            groupBoxCondition_TAV.Name = "groupBoxCondition_TAV";
            groupBoxCondition_TAV.Size = new Size(1584, 72);
            groupBoxCondition_TAV.TabIndex = 0;
            groupBoxCondition_TAV.TabStop = false;
            groupBoxCondition_TAV.Text = "Условие";
            // 
            // panelOutPut_TAV
            // 
            panelOutPut_TAV.Location = new Point(286, 78);
            panelOutPut_TAV.Name = "panelOutPut_TAV";
            panelOutPut_TAV.Size = new Size(204, 131);
            panelOutPut_TAV.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1578, 50);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panelInPut_TAV
            // 
            panelInPut_TAV.Controls.Add(groupBoxInput_TAV);
            panelInPut_TAV.Dock = DockStyle.Left;
            panelInPut_TAV.Location = new Point(0, 138);
            panelInPut_TAV.Name = "panelInPut_TAV";
            panelInPut_TAV.Size = new Size(453, 723);
            panelInPut_TAV.TabIndex = 1;
            // 
            // groupBoxInput_TAV
            // 
            groupBoxInput_TAV.Controls.Add(dataGridViewInput_TAV);
            groupBoxInput_TAV.Dock = DockStyle.Fill;
            groupBoxInput_TAV.Location = new Point(0, 0);
            groupBoxInput_TAV.Name = "groupBoxInput_TAV";
            groupBoxInput_TAV.Size = new Size(453, 723);
            groupBoxInput_TAV.TabIndex = 0;
            groupBoxInput_TAV.TabStop = false;
            groupBoxInput_TAV.Text = "Ввод";
            // 
            // dataGridViewInput_TAV
            // 
            dataGridViewInput_TAV.BackgroundColor = SystemColors.ButtonShadow;
            dataGridViewInput_TAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_TAV.Dock = DockStyle.Fill;
            dataGridViewInput_TAV.Location = new Point(3, 19);
            dataGridViewInput_TAV.Name = "dataGridViewInput_TAV";
            dataGridViewInput_TAV.ReadOnly = true;
            dataGridViewInput_TAV.ScrollBars = ScrollBars.Vertical;
            dataGridViewInput_TAV.Size = new Size(447, 701);
            dataGridViewInput_TAV.TabIndex = 0;
            // 
            // panel_TAV
            // 
            panel_TAV.Controls.Add(groupBoxOutput_TAV);
            panel_TAV.Dock = DockStyle.Fill;
            panel_TAV.Location = new Point(453, 138);
            panel_TAV.Name = "panel_TAV";
            panel_TAV.Size = new Size(1131, 723);
            panel_TAV.TabIndex = 2;
            // 
            // groupBoxOutput_TAV
            // 
            groupBoxOutput_TAV.Controls.Add(dataGridViewOutPut_TAV);
            groupBoxOutput_TAV.Dock = DockStyle.Fill;
            groupBoxOutput_TAV.Location = new Point(0, 0);
            groupBoxOutput_TAV.Name = "groupBoxOutput_TAV";
            groupBoxOutput_TAV.Size = new Size(1131, 723);
            groupBoxOutput_TAV.TabIndex = 0;
            groupBoxOutput_TAV.TabStop = false;
            groupBoxOutput_TAV.Text = "Вывод";
            // 
            // dataGridViewOutPut_TAV
            // 
            dataGridViewOutPut_TAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_TAV.Dock = DockStyle.Fill;
            dataGridViewOutPut_TAV.Location = new Point(3, 19);
            dataGridViewOutPut_TAV.Name = "dataGridViewOutPut_TAV";
            dataGridViewOutPut_TAV.Size = new Size(1125, 701);
            dataGridViewOutPut_TAV.TabIndex = 0;
            // 
            // openFileDialog_TAV
            // 
            openFileDialog_TAV.FileName = "openFileDialog1";
            // 
            // toolTipButton_TAV
            // 
            toolTipButton_TAV.ForeColor = SystemColors.Highlight;
            toolTipButton_TAV.IsBalloon = true;
            toolTipButton_TAV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Controls.Add(panel_TAV);
            Controls.Add(panelInPut_TAV);
            Controls.Add(panelCondition_TAV);
            Controls.Add(panelButtons_TAV);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1600, 900);
            Name = "FormMain";
            Text = "Спринт6 | Таск 7 | Вариант 24 | Талалаева А.В.";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            panelButtons_TAV.ResumeLayout(false);
            panelCondition_TAV.ResumeLayout(false);
            groupBoxCondition_TAV.ResumeLayout(false);
            groupBoxCondition_TAV.PerformLayout();
            panelInPut_TAV.ResumeLayout(false);
            groupBoxInput_TAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_TAV).EndInit();
            panel_TAV.ResumeLayout(false);
            groupBoxOutput_TAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_TAV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons_TAV;
        private Button buttonOpenFile_TAV;
        private Button buttonData_TAV;
        private Button buttonSaveFile_TAV;
        private Button buttonResult_TAV;
        private Panel panelCondition_TAV;
        private GroupBox groupBoxCondition_TAV;
        private TextBox textBox1;
        private Panel panelOutPut_TAV;
        private Panel panelInPut_TAV;
        private GroupBox groupBoxInput_TAV;
        private DataGridView dataGridViewInput_TAV;
        private Panel panel_TAV;
        private GroupBox groupBoxOutput_TAV;
        private DataGridView dataGridViewOutPut_TAV;
        private OpenFileDialog openFileDialog_TAV;
        private SaveFileDialog saveFileDialogMtrx_TAV;
        private ToolTip toolTipButton_TAV;
    }
}
