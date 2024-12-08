namespace Tyuiu.TalalaevaAV.Sprint6.Task0.V23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonDoneResult_TAV = new Button();
            groupBoxCondition_TAV = new GroupBox();
            pictureBoxCondition_TAV = new PictureBox();
            textBoxCondition_TAV = new TextBox();
            groupBoxDataEntry_TAV = new GroupBox();
            textBoxVarX_TAV = new TextBox();
            textBoxInputX_TAV = new TextBox();
            groupBoxDataOutput_TAV = new GroupBox();
            groupBoxResult_TAV = new GroupBox();
            textBoxResult_TAV = new TextBox();
            buttonData_TAV = new Button();
            groupBoxCondition_TAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition_TAV).BeginInit();
            groupBoxDataEntry_TAV.SuspendLayout();
            groupBoxDataOutput_TAV.SuspendLayout();
            groupBoxResult_TAV.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDoneResult_TAV
            // 
            buttonDoneResult_TAV.Location = new Point(502, 270);
            buttonDoneResult_TAV.Name = "buttonDoneResult_TAV";
            buttonDoneResult_TAV.Size = new Size(103, 38);
            buttonDoneResult_TAV.TabIndex = 0;
            buttonDoneResult_TAV.Text = "Выполнить";
            buttonDoneResult_TAV.UseVisualStyleBackColor = true;
            buttonDoneResult_TAV.Click += buttonDoneResult_TAV_Click;
            // 
            // groupBoxCondition_TAV
            // 
            groupBoxCondition_TAV.Controls.Add(pictureBoxCondition_TAV);
            groupBoxCondition_TAV.Controls.Add(textBoxCondition_TAV);
            groupBoxCondition_TAV.Location = new Point(13, 12);
            groupBoxCondition_TAV.Name = "groupBoxCondition_TAV";
            groupBoxCondition_TAV.Size = new Size(592, 124);
            groupBoxCondition_TAV.TabIndex = 1;
            groupBoxCondition_TAV.TabStop = false;
            groupBoxCondition_TAV.Text = "Условие";
            // 
            // pictureBoxCondition_TAV
            // 
            pictureBoxCondition_TAV.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxCondition_TAV.Image = (Image)resources.GetObject("pictureBoxCondition_TAV.Image");
            pictureBoxCondition_TAV.Location = new Point(435, 22);
            pictureBoxCondition_TAV.Name = "pictureBoxCondition_TAV";
            pictureBoxCondition_TAV.Size = new Size(139, 61);
            pictureBoxCondition_TAV.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCondition_TAV.TabIndex = 3;
            pictureBoxCondition_TAV.TabStop = false;
            // 
            // textBoxCondition_TAV
            // 
            textBoxCondition_TAV.BackColor = SystemColors.Menu;
            textBoxCondition_TAV.BorderStyle = BorderStyle.None;
            textBoxCondition_TAV.Location = new Point(6, 22);
            textBoxCondition_TAV.Multiline = true;
            textBoxCondition_TAV.Name = "textBoxCondition_TAV";
            textBoxCondition_TAV.Size = new Size(266, 23);
            textBoxCondition_TAV.TabIndex = 2;
            textBoxCondition_TAV.Text = "Вычислить значение выражения по формуле";
            // 
            // groupBoxDataEntry_TAV
            // 
            groupBoxDataEntry_TAV.Controls.Add(textBoxVarX_TAV);
            groupBoxDataEntry_TAV.Controls.Add(textBoxInputX_TAV);
            groupBoxDataEntry_TAV.Location = new Point(12, 152);
            groupBoxDataEntry_TAV.Name = "groupBoxDataEntry_TAV";
            groupBoxDataEntry_TAV.Size = new Size(359, 112);
            groupBoxDataEntry_TAV.TabIndex = 2;
            groupBoxDataEntry_TAV.TabStop = false;
            groupBoxDataEntry_TAV.Text = "Ввод данных";
            // 
            // textBoxVarX_TAV
            // 
            textBoxVarX_TAV.Location = new Point(141, 56);
            textBoxVarX_TAV.Name = "textBoxVarX_TAV";
            textBoxVarX_TAV.Size = new Size(132, 23);
            textBoxVarX_TAV.TabIndex = 1;
            textBoxVarX_TAV.TextChanged += textBoxVarX_TAV_TextChanged;
            textBoxVarX_TAV.KeyPress += textBoxVarX_TAV_KeyPress;
            // 
            // textBoxInputX_TAV
            // 
            textBoxInputX_TAV.BackColor = SystemColors.Menu;
            textBoxInputX_TAV.BorderStyle = BorderStyle.None;
            textBoxInputX_TAV.ForeColor = SystemColors.WindowText;
            textBoxInputX_TAV.Location = new Point(1, 59);
            textBoxInputX_TAV.Multiline = true;
            textBoxInputX_TAV.Name = "textBoxInputX_TAV";
            textBoxInputX_TAV.Size = new Size(127, 20);
            textBoxInputX_TAV.TabIndex = 0;
            textBoxInputX_TAV.Text = "Переменная X:";
            textBoxInputX_TAV.TextAlign = HorizontalAlignment.Center;
            textBoxInputX_TAV.TextChanged += textBoxInputX_TAV_TextChanged;
            // 
            // groupBoxDataOutput_TAV
            // 
            groupBoxDataOutput_TAV.Controls.Add(groupBoxResult_TAV);
            groupBoxDataOutput_TAV.Location = new Point(377, 152);
            groupBoxDataOutput_TAV.Name = "groupBoxDataOutput_TAV";
            groupBoxDataOutput_TAV.Size = new Size(228, 112);
            groupBoxDataOutput_TAV.TabIndex = 3;
            groupBoxDataOutput_TAV.TabStop = false;
            groupBoxDataOutput_TAV.Text = "Вывод данных";
            groupBoxDataOutput_TAV.Enter += groupBoxDataOutput_TAV_Enter;
            // 
            // groupBoxResult_TAV
            // 
            groupBoxResult_TAV.Controls.Add(textBoxResult_TAV);
            groupBoxResult_TAV.Location = new Point(7, 22);
            groupBoxResult_TAV.Name = "groupBoxResult_TAV";
            groupBoxResult_TAV.Size = new Size(216, 84);
            groupBoxResult_TAV.TabIndex = 0;
            groupBoxResult_TAV.TabStop = false;
            groupBoxResult_TAV.Text = "Результат";
            // 
            // textBoxResult_TAV
            // 
            textBoxResult_TAV.BackColor = SystemColors.MenuBar;
            textBoxResult_TAV.Location = new Point(10, 34);
            textBoxResult_TAV.Name = "textBoxResult_TAV";
            textBoxResult_TAV.ReadOnly = true;
            textBoxResult_TAV.Size = new Size(200, 23);
            textBoxResult_TAV.TabIndex = 0;
            textBoxResult_TAV.ReadOnlyChanged += textBoxResult_TAV_ReadOnlyChanged;
            textBoxResult_TAV.TextChanged += textBoxResult_TAV_TextChanged;
            // 
            // buttonData_TAV
            // 
            buttonData_TAV.BackColor = SystemColors.Menu;
            buttonData_TAV.FlatStyle = FlatStyle.Flat;
            buttonData_TAV.Location = new Point(448, 272);
            buttonData_TAV.Name = "buttonData_TAV";
            buttonData_TAV.Size = new Size(38, 36);
            buttonData_TAV.TabIndex = 4;
            buttonData_TAV.Text = "?";
            buttonData_TAV.UseVisualStyleBackColor = false;
            buttonData_TAV.Click += buttonData_TAV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(614, 320);
            Controls.Add(buttonData_TAV);
            Controls.Add(groupBoxDataOutput_TAV);
            Controls.Add(groupBoxDataEntry_TAV);
            Controls.Add(groupBoxCondition_TAV);
            Controls.Add(buttonDoneResult_TAV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 23 | Талалаева А.В.";
            groupBoxCondition_TAV.ResumeLayout(false);
            groupBoxCondition_TAV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition_TAV).EndInit();
            groupBoxDataEntry_TAV.ResumeLayout(false);
            groupBoxDataEntry_TAV.PerformLayout();
            groupBoxDataOutput_TAV.ResumeLayout(false);
            groupBoxResult_TAV.ResumeLayout(false);
            groupBoxResult_TAV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDoneResult_TAV;
        private GroupBox groupBoxCondition_TAV;
        private TextBox textBoxCondition_TAV;
        private PictureBox pictureBoxCondition_TAV;
        private GroupBox groupBoxDataEntry_TAV;
        private GroupBox groupBoxDataOutput_TAV;
        private TextBox textBoxInputX_TAV;
        private TextBox textBoxVarX_TAV;
        private GroupBox groupBoxResult_TAV;
        private TextBox textBoxResult_TAV;
        private Button buttonData_TAV;
    }
}
