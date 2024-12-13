namespace Tyuiu.TalalaevaAV.Sprint6.Task7.V24
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxMe_TAV = new PictureBox();
            textBox1 = new TextBox();
            buttonOK_TAV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMe_TAV).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMe_TAV
            // 
            pictureBoxMe_TAV.Image = (Image)resources.GetObject("pictureBoxMe_TAV.Image");
            pictureBoxMe_TAV.Location = new Point(25, 12);
            pictureBoxMe_TAV.Name = "pictureBoxMe_TAV";
            pictureBoxMe_TAV.Size = new Size(115, 153);
            pictureBoxMe_TAV.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMe_TAV.TabIndex = 2;
            pictureBoxMe_TAV.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(159, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(321, 130);
            textBox1.TabIndex = 3;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // buttonOK_TAV
            // 
            buttonOK_TAV.Location = new Point(384, 149);
            buttonOK_TAV.Name = "buttonOK_TAV";
            buttonOK_TAV.Size = new Size(79, 24);
            buttonOK_TAV.TabIndex = 4;
            buttonOK_TAV.Text = "OK";
            buttonOK_TAV.UseVisualStyleBackColor = true;
            buttonOK_TAV.Click += buttonOK_TAV_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 185);
            Controls.Add(buttonOK_TAV);
            Controls.Add(textBox1);
            Controls.Add(pictureBoxMe_TAV);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMe_TAV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxMe_TAV;
        private TextBox textBox1;
        private Button buttonOK_TAV;
    }
}