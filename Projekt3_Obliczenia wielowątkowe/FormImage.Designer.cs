namespace Projekt3_Obliczenia_wielowątkowe
{
    partial class FormImage
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
            button1 = new Button();
            buttonLoadFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBoxOrginal = new PictureBox();
            buttonFillter = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOrginal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial Black", 8.2F, FontStyle.Bold);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(47, 47);
            button1.TabIndex = 1;
            button1.Tag = "buttonReturn";
            button1.Text = "<--";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonLoadFile
            // 
            buttonLoadFile.Location = new Point(75, 550);
            buttonLoadFile.Name = "buttonLoadFile";
            buttonLoadFile.Size = new Size(184, 53);
            buttonLoadFile.TabIndex = 3;
            buttonLoadFile.Text = "Wczytaj obraz";
            buttonLoadFile.UseVisualStyleBackColor = true;
            buttonLoadFile.Click += buttonLoadFile_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "(*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = "d:\\\\";
            // 
            // pictureBoxOrginal
            // 
            pictureBoxOrginal.Location = new Point(75, 118);
            pictureBoxOrginal.Name = "pictureBoxOrginal";
            pictureBoxOrginal.Size = new Size(400, 400);
            pictureBoxOrginal.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOrginal.TabIndex = 4;
            pictureBoxOrginal.TabStop = false;
            // 
            // buttonFillter
            // 
            buttonFillter.Location = new Point(291, 550);
            buttonFillter.Name = "buttonFillter";
            buttonFillter.Size = new Size(184, 53);
            buttonFillter.TabIndex = 5;
            buttonFillter.Text = "Zastosuj filtry ";
            buttonFillter.UseVisualStyleBackColor = true;
            buttonFillter.Click += buttonFillter_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(553, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(852, 74);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(238, 216);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(553, 344);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(238, 216);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(852, 344);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(238, 216);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // FormImage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 763);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonFillter);
            Controls.Add(pictureBoxOrginal);
            Controls.Add(buttonLoadFile);
            Controls.Add(button1);
            Name = "FormImage";
            Text = "Image";
            ((System.ComponentModel.ISupportInitialize)pictureBoxOrginal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button buttonLoadFile;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBoxOrginal;
        private Button buttonFillter;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}