using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.TalalaevaAV.Sprint6.Task6.V17
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormAbout));
            buttonOK_TAV = new Button();
            pictureBoxMe_TAV = new PictureBox();
            textBox1 = new TextBox();
            ((ISupportInitialize)pictureBoxMe_TAV).BeginInit();
            SuspendLayout();
            // 
            // buttonOK_TAV
            // 
            buttonOK_TAV.Location = new Point(394, 156);
            buttonOK_TAV.Name = "buttonOK_TAV";
            buttonOK_TAV.Size = new Size(73, 27);
            buttonOK_TAV.TabIndex = 0;
            buttonOK_TAV.Text = "ОК";
            buttonOK_TAV.UseVisualStyleBackColor = true;
            buttonOK_TAV.Click += buttonOK_TAV_Click;
            // 
            // pictureBoxMe_TAV
            // 
            pictureBoxMe_TAV.Image = (Image)resources.GetObject("pictureBoxMe_TAV.Image");
            pictureBoxMe_TAV.Location = new Point(7, 20);
            pictureBoxMe_TAV.Name = "pictureBoxMe_TAV";
            pictureBoxMe_TAV.Size = new Size(115, 153);
            pictureBoxMe_TAV.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMe_TAV.TabIndex = 1;
            pictureBoxMe_TAV.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(128, 20);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(359, 130);
            textBox1.TabIndex = 2;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormAbout
            // 
            ClientSize = new Size(494, 201);
            Controls.Add(textBox1);
            Controls.Add(pictureBoxMe_TAV);
            Controls.Add(buttonOK_TAV);
            MaximizeBox = false;
            MaximumSize = new Size(510, 240);
            MinimizeBox = false;
            MinimumSize = new Size(510, 240);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((ISupportInitialize)pictureBoxMe_TAV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBoxMe_TAV;
        private TextBox textBox1;
        private Button buttonOK_TAV;

        private void buttonOK_TAV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
