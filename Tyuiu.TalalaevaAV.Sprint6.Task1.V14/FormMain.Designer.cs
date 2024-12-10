namespace Tyuiu.TalalaevaAV.Sprint6.Task1.V14
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
            groupBoxCondition_TAV = new GroupBox();
            textBoxCondition_TAV = new TextBox();
            groupBoxDataInput_TAV = new GroupBox();
            textBoxStopStep_TAV = new TextBox();
            textBoxStartStep_TAV = new TextBox();
            textBoxVarStopStep_TAV = new TextBox();
            textBoxVarStartStep_TAV = new TextBox();
            buttonData_TAV = new Button();
            buttonResult_TAV = new Button();
            groupBoxDataOutput_TAV = new GroupBox();
            textBoxText = new TextBox();
            textBoxResult_TAV = new TextBox();
            groupBoxCondition_TAV.SuspendLayout();
            groupBoxDataInput_TAV.SuspendLayout();
            groupBoxDataOutput_TAV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_TAV
            // 
            groupBoxCondition_TAV.Controls.Add(textBoxCondition_TAV);
            groupBoxCondition_TAV.Location = new Point(11, 11);
            groupBoxCondition_TAV.Name = "groupBoxCondition_TAV";
            groupBoxCondition_TAV.Size = new Size(405, 198);
            groupBoxCondition_TAV.TabIndex = 0;
            groupBoxCondition_TAV.TabStop = false;
            groupBoxCondition_TAV.Text = "Условие";
            // 
            // textBoxCondition_TAV
            // 
            textBoxCondition_TAV.BackColor = SystemColors.Menu;
            textBoxCondition_TAV.BorderStyle = BorderStyle.None;
            textBoxCondition_TAV.Location = new Point(6, 22);
            textBoxCondition_TAV.Multiline = true;
            textBoxCondition_TAV.Name = "textBoxCondition_TAV";
            textBoxCondition_TAV.ReadOnly = true;
            textBoxCondition_TAV.Size = new Size(393, 170);
            textBoxCondition_TAV.TabIndex = 0;
            textBoxCondition_TAV.Text = "Протабулировать функцию в заданном диапозоне.\r\nРезультат вывести в таблице.\r\n";
            // 
            // groupBoxDataInput_TAV
            // 
            groupBoxDataInput_TAV.Controls.Add(textBoxStopStep_TAV);
            groupBoxDataInput_TAV.Controls.Add(textBoxStartStep_TAV);
            groupBoxDataInput_TAV.Controls.Add(textBoxVarStopStep_TAV);
            groupBoxDataInput_TAV.Controls.Add(textBoxVarStartStep_TAV);
            groupBoxDataInput_TAV.Location = new Point(13, 224);
            groupBoxDataInput_TAV.Name = "groupBoxDataInput_TAV";
            groupBoxDataInput_TAV.Size = new Size(278, 126);
            groupBoxDataInput_TAV.TabIndex = 1;
            groupBoxDataInput_TAV.TabStop = false;
            groupBoxDataInput_TAV.Text = "Ввод данных";
            // 
            // textBoxStopStep_TAV
            // 
            textBoxStopStep_TAV.Location = new Point(151, 65);
            textBoxStopStep_TAV.Name = "textBoxStopStep_TAV";
            textBoxStopStep_TAV.Size = new Size(106, 23);
            textBoxStopStep_TAV.TabIndex = 3;
            textBoxStopStep_TAV.KeyPress += textBoxStopStep_TAV_KeyPress;
            // 
            // textBoxStartStep_TAV
            // 
            textBoxStartStep_TAV.Location = new Point(6, 65);
            textBoxStartStep_TAV.Name = "textBoxStartStep_TAV";
            textBoxStartStep_TAV.Size = new Size(119, 23);
            textBoxStartStep_TAV.TabIndex = 2;
            textBoxStartStep_TAV.TextChanged += textBoxStartStep_TAV_TextChanged;
            textBoxStartStep_TAV.KeyPress += textBoxStartStep_TAV_KeyPress;
            // 
            // textBoxVarStopStep_TAV
            // 
            textBoxVarStopStep_TAV.BackColor = SystemColors.Menu;
            textBoxVarStopStep_TAV.BorderStyle = BorderStyle.None;
            textBoxVarStopStep_TAV.Location = new Point(151, 43);
            textBoxVarStopStep_TAV.Name = "textBoxVarStopStep_TAV";
            textBoxVarStopStep_TAV.Size = new Size(99, 16);
            textBoxVarStopStep_TAV.TabIndex = 1;
            textBoxVarStopStep_TAV.Text = "Конец шага";
            textBoxVarStopStep_TAV.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxVarStartStep_TAV
            // 
            textBoxVarStartStep_TAV.BackColor = SystemColors.Menu;
            textBoxVarStartStep_TAV.BorderStyle = BorderStyle.None;
            textBoxVarStartStep_TAV.Location = new Point(4, 43);
            textBoxVarStartStep_TAV.Name = "textBoxVarStartStep_TAV";
            textBoxVarStartStep_TAV.Size = new Size(121, 16);
            textBoxVarStartStep_TAV.TabIndex = 0;
            textBoxVarStartStep_TAV.Text = "Старт шага";
            textBoxVarStartStep_TAV.TextAlign = HorizontalAlignment.Center;
            textBoxVarStartStep_TAV.TextChanged += textBoxVarStartStep_TAV_TextChanged;
            // 
            // buttonData_TAV
            // 
            buttonData_TAV.BackColor = Color.Cyan;
            buttonData_TAV.FlatStyle = FlatStyle.Flat;
            buttonData_TAV.Location = new Point(297, 246);
            buttonData_TAV.Name = "buttonData_TAV";
            buttonData_TAV.Size = new Size(124, 37);
            buttonData_TAV.TabIndex = 2;
            buttonData_TAV.Text = "Справка";
            buttonData_TAV.UseVisualStyleBackColor = false;
            buttonData_TAV.Click += buttonData_TAV_Click;
            // 
            // buttonResult_TAV
            // 
            buttonResult_TAV.BackColor = Color.Lime;
            buttonResult_TAV.Location = new Point(297, 289);
            buttonResult_TAV.Name = "buttonResult_TAV";
            buttonResult_TAV.Size = new Size(124, 51);
            buttonResult_TAV.TabIndex = 3;
            buttonResult_TAV.Text = "Выполнить";
            buttonResult_TAV.UseVisualStyleBackColor = false;
            buttonResult_TAV.Click += buttonResult_TAV_Click;
            // 
            // groupBoxDataOutput_TAV
            // 
            groupBoxDataOutput_TAV.Controls.Add(textBoxText);
            groupBoxDataOutput_TAV.Controls.Add(textBoxResult_TAV);
            groupBoxDataOutput_TAV.Location = new Point(433, 12);
            groupBoxDataOutput_TAV.Name = "groupBoxDataOutput_TAV";
            groupBoxDataOutput_TAV.Size = new Size(263, 349);
            groupBoxDataOutput_TAV.TabIndex = 4;
            groupBoxDataOutput_TAV.TabStop = false;
            groupBoxDataOutput_TAV.Text = "Вывод данных";
            // 
            // textBoxText
            // 
            textBoxText.BackColor = SystemColors.Menu;
            textBoxText.BorderStyle = BorderStyle.None;
            textBoxText.Location = new Point(11, 20);
            textBoxText.Name = "textBoxText";
            textBoxText.Size = new Size(221, 16);
            textBoxText.TabIndex = 1;
            textBoxText.Text = "Результат";
            // 
            // textBoxResult_TAV
            // 
            textBoxResult_TAV.BackColor = SystemColors.Menu;
            textBoxResult_TAV.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_TAV.Location = new Point(11, 38);
            textBoxResult_TAV.Multiline = true;
            textBoxResult_TAV.Name = "textBoxResult_TAV";
            textBoxResult_TAV.ReadOnly = true;
            textBoxResult_TAV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_TAV.Size = new Size(246, 300);
            textBoxResult_TAV.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 386);
            Controls.Add(groupBoxDataOutput_TAV);
            Controls.Add(buttonResult_TAV);
            Controls.Add(buttonData_TAV);
            Controls.Add(groupBoxDataInput_TAV);
            Controls.Add(groupBoxCondition_TAV);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 14 | Талалаева А.В.";
            groupBoxCondition_TAV.ResumeLayout(false);
            groupBoxCondition_TAV.PerformLayout();
            groupBoxDataInput_TAV.ResumeLayout(false);
            groupBoxDataInput_TAV.PerformLayout();
            groupBoxDataOutput_TAV.ResumeLayout(false);
            groupBoxDataOutput_TAV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_TAV;
        private TextBox textBoxCondition_TAV;
        private GroupBox groupBoxDataInput_TAV;
        private TextBox textBoxStartStep_TAV;
        private TextBox textBoxVarStopStep_TAV;
        private TextBox textBoxVarStartStep_TAV;
        private TextBox textBoxStopStep_TAV;
        private Button buttonData_TAV;
        private Button buttonResult_TAV;
        private GroupBox groupBoxDataOutput_TAV;
        private TextBox textBoxResult_TAV;
        private TextBox textBoxText;
    }
}
