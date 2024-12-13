namespace Tyuiu.TalalaevaAV.Sprint6.Task6.V17
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
            panelMain_TAV = new Panel();
            buttonData_TAV = new Button();
            buttonDone_TAV = new Button();
            buttonOpen_TAV = new Button();
            panelDo_TAV = new Panel();
            groupBoxCondition_TAV = new GroupBox();
            textBoxCondition_TAV = new TextBox();
            panelInput_TAV = new Panel();
            groupBoxInPut_TAV = new GroupBox();
            textBoxInput_TAV = new TextBox();
            panelOutPut_TAV = new Panel();
            groupBoxOutPut_TAV = new GroupBox();
            textBoxOut_Put_TAV = new TextBox();
            openFileDialogTask_TAV = new OpenFileDialog();
            toolTip_TAV = new ToolTip(components);
            panelMain_TAV.SuspendLayout();
            panelDo_TAV.SuspendLayout();
            groupBoxCondition_TAV.SuspendLayout();
            panelInput_TAV.SuspendLayout();
            groupBoxInPut_TAV.SuspendLayout();
            panelOutPut_TAV.SuspendLayout();
            groupBoxOutPut_TAV.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain_TAV
            // 
            panelMain_TAV.Controls.Add(buttonData_TAV);
            panelMain_TAV.Controls.Add(buttonDone_TAV);
            panelMain_TAV.Controls.Add(buttonOpen_TAV);
            panelMain_TAV.Dock = DockStyle.Top;
            panelMain_TAV.Location = new Point(0, 0);
            panelMain_TAV.Name = "panelMain_TAV";
            panelMain_TAV.Size = new Size(800, 79);
            panelMain_TAV.TabIndex = 0;
            // 
            // buttonData_TAV
            // 
            buttonData_TAV.Image = (Image)resources.GetObject("buttonData_TAV.Image");
            buttonData_TAV.Location = new Point(703, 16);
            buttonData_TAV.Name = "buttonData_TAV";
            buttonData_TAV.Size = new Size(74, 46);
            buttonData_TAV.TabIndex = 2;
            toolTip_TAV.SetToolTip(buttonData_TAV, "Сведения о программе");
            buttonData_TAV.UseVisualStyleBackColor = true;
            buttonData_TAV.Click += buttonData_TAV_Click;
            // 
            // buttonDone_TAV
            // 
            buttonDone_TAV.Image = (Image)resources.GetObject("buttonDone_TAV.Image");
            buttonDone_TAV.Location = new Point(94, 10);
            buttonDone_TAV.Name = "buttonDone_TAV";
            buttonDone_TAV.Size = new Size(79, 50);
            buttonDone_TAV.TabIndex = 1;
            toolTip_TAV.SetToolTip(buttonDone_TAV, "Выводит третье слово каждой строки в результирующую строку");
            buttonDone_TAV.UseVisualStyleBackColor = true;
            buttonDone_TAV.Click += buttonDone_TAV_Click;
            // 
            // buttonOpen_TAV
            // 
            buttonOpen_TAV.Image = (Image)resources.GetObject("buttonOpen_TAV.Image");
            buttonOpen_TAV.Location = new Point(12, 12);
            buttonOpen_TAV.Name = "buttonOpen_TAV";
            buttonOpen_TAV.Size = new Size(76, 48);
            buttonOpen_TAV.TabIndex = 0;
            toolTip_TAV.SetToolTip(buttonOpen_TAV, "Открыть файл\r\nВыберите нужный файл для обработки\r\n\r\n");
            buttonOpen_TAV.UseVisualStyleBackColor = true;
            buttonOpen_TAV.Click += buttonOpen_TAV_Click;
            // 
            // panelDo_TAV
            // 
            panelDo_TAV.Controls.Add(groupBoxCondition_TAV);
            panelDo_TAV.Dock = DockStyle.Top;
            panelDo_TAV.Location = new Point(0, 79);
            panelDo_TAV.Name = "panelDo_TAV";
            panelDo_TAV.Size = new Size(800, 76);
            panelDo_TAV.TabIndex = 1;
            // 
            // groupBoxCondition_TAV
            // 
            groupBoxCondition_TAV.Controls.Add(textBoxCondition_TAV);
            groupBoxCondition_TAV.Location = new Point(3, 6);
            groupBoxCondition_TAV.Name = "groupBoxCondition_TAV";
            groupBoxCondition_TAV.Size = new Size(785, 60);
            groupBoxCondition_TAV.TabIndex = 0;
            groupBoxCondition_TAV.TabStop = false;
            groupBoxCondition_TAV.Text = "Условие";
            // 
            // textBoxCondition_TAV
            // 
            textBoxCondition_TAV.BackColor = SystemColors.Menu;
            textBoxCondition_TAV.BorderStyle = BorderStyle.None;
            textBoxCondition_TAV.Location = new Point(9, 17);
            textBoxCondition_TAV.Multiline = true;
            textBoxCondition_TAV.Name = "textBoxCondition_TAV";
            textBoxCondition_TAV.ReadOnly = true;
            textBoxCondition_TAV.Size = new Size(770, 37);
            textBoxCondition_TAV.TabIndex = 0;
            textBoxCondition_TAV.Text = resources.GetString("textBoxCondition_TAV.Text");
            // 
            // panelInput_TAV
            // 
            panelInput_TAV.Controls.Add(groupBoxInPut_TAV);
            panelInput_TAV.Dock = DockStyle.Left;
            panelInput_TAV.Location = new Point(0, 155);
            panelInput_TAV.Name = "panelInput_TAV";
            panelInput_TAV.Size = new Size(273, 295);
            panelInput_TAV.TabIndex = 2;
            // 
            // groupBoxInPut_TAV
            // 
            groupBoxInPut_TAV.Controls.Add(textBoxInput_TAV);
            groupBoxInPut_TAV.Dock = DockStyle.Fill;
            groupBoxInPut_TAV.Location = new Point(0, 0);
            groupBoxInPut_TAV.Name = "groupBoxInPut_TAV";
            groupBoxInPut_TAV.Size = new Size(273, 295);
            groupBoxInPut_TAV.TabIndex = 0;
            groupBoxInPut_TAV.TabStop = false;
            groupBoxInPut_TAV.Text = "Ввод:";
            // 
            // textBoxInput_TAV
            // 
            textBoxInput_TAV.BackColor = SystemColors.Menu;
            textBoxInput_TAV.BorderStyle = BorderStyle.None;
            textBoxInput_TAV.Dock = DockStyle.Fill;
            textBoxInput_TAV.Location = new Point(3, 19);
            textBoxInput_TAV.Multiline = true;
            textBoxInput_TAV.Name = "textBoxInput_TAV";
            textBoxInput_TAV.ReadOnly = true;
            textBoxInput_TAV.ScrollBars = ScrollBars.Vertical;
            textBoxInput_TAV.Size = new Size(267, 273);
            textBoxInput_TAV.TabIndex = 0;
            // 
            // panelOutPut_TAV
            // 
            panelOutPut_TAV.Controls.Add(groupBoxOutPut_TAV);
            panelOutPut_TAV.Dock = DockStyle.Fill;
            panelOutPut_TAV.Location = new Point(273, 155);
            panelOutPut_TAV.Name = "panelOutPut_TAV";
            panelOutPut_TAV.Size = new Size(527, 295);
            panelOutPut_TAV.TabIndex = 3;
            // 
            // groupBoxOutPut_TAV
            // 
            groupBoxOutPut_TAV.Controls.Add(textBoxOut_Put_TAV);
            groupBoxOutPut_TAV.Dock = DockStyle.Fill;
            groupBoxOutPut_TAV.Location = new Point(0, 0);
            groupBoxOutPut_TAV.Name = "groupBoxOutPut_TAV";
            groupBoxOutPut_TAV.Size = new Size(527, 295);
            groupBoxOutPut_TAV.TabIndex = 0;
            groupBoxOutPut_TAV.TabStop = false;
            groupBoxOutPut_TAV.Text = "Вывод";
            // 
            // textBoxOut_Put_TAV
            // 
            textBoxOut_Put_TAV.BackColor = SystemColors.Menu;
            textBoxOut_Put_TAV.BorderStyle = BorderStyle.None;
            textBoxOut_Put_TAV.Dock = DockStyle.Fill;
            textBoxOut_Put_TAV.Location = new Point(3, 19);
            textBoxOut_Put_TAV.Multiline = true;
            textBoxOut_Put_TAV.Name = "textBoxOut_Put_TAV";
            textBoxOut_Put_TAV.ScrollBars = ScrollBars.Vertical;
            textBoxOut_Put_TAV.Size = new Size(521, 273);
            textBoxOut_Put_TAV.TabIndex = 0;
            // 
            // openFileDialogTask_TAV
            // 
            openFileDialogTask_TAV.FileName = "openFileDialog1";
            // 
            // toolTip_TAV
            // 
            toolTip_TAV.ToolTipIcon = ToolTipIcon.Info;
            toolTip_TAV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelOutPut_TAV);
            Controls.Add(panelInput_TAV);
            Controls.Add(panelDo_TAV);
            Controls.Add(panelMain_TAV);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 17 | Талалаева А.В.";
            panelMain_TAV.ResumeLayout(false);
            panelDo_TAV.ResumeLayout(false);
            groupBoxCondition_TAV.ResumeLayout(false);
            groupBoxCondition_TAV.PerformLayout();
            panelInput_TAV.ResumeLayout(false);
            groupBoxInPut_TAV.ResumeLayout(false);
            groupBoxInPut_TAV.PerformLayout();
            panelOutPut_TAV.ResumeLayout(false);
            groupBoxOutPut_TAV.ResumeLayout(false);
            groupBoxOutPut_TAV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain_TAV;
        private Panel panelDo_TAV;
        private GroupBox groupBoxCondition_TAV;
        private TextBox textBoxCondition_TAV;
        private Panel panelInput_TAV;
        private Panel panelOutPut_TAV;
        private GroupBox groupBoxInPut_TAV;
        private TextBox textBoxInput_TAV;
        private Button buttonOpen_TAV;
        private GroupBox groupBoxOutPut_TAV;
        private TextBox textBoxOut_Put_TAV;
        private Button buttonDone_TAV;
        private Button buttonData_TAV;
        private OpenFileDialog openFileDialogTask_TAV;
        private ToolTip toolTip_TAV;
    }
}
