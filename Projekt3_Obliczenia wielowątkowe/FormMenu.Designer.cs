namespace Projekt3_Obliczenia_wielowątkowe
{
    partial class FormMenu
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
            Matrix = new Button();
            Image = new Button();
            SuspendLayout();
            // 
            // Matrix
            // 
            Matrix.Font = new Font("Arial Black", 22.2F, FontStyle.Bold);
            Matrix.Location = new Point(136, 99);
            Matrix.Name = "Matrix";
            Matrix.Size = new Size(217, 217);
            Matrix.TabIndex = 0;
            Matrix.Tag = "buttonMatrix";
            Matrix.Text = "Matrix";
            Matrix.TextImageRelation = TextImageRelation.TextBeforeImage;
            Matrix.UseVisualStyleBackColor = true;
            Matrix.Click += Matrix_Click;
            // 
            // Image
            // 
            Image.Font = new Font("Arial Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Image.Location = new Point(452, 99);
            Image.Name = "Image";
            Image.Size = new Size(217, 217);
            Image.TabIndex = 1;
            Image.Tag = "buttonImage";
            Image.Text = "Image";
            Image.TextImageRelation = TextImageRelation.TextBeforeImage;
            Image.UseVisualStyleBackColor = true;
            Image.Click += Image_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Image);
            Controls.Add(Matrix);
            Name = "FormMenu";
            Text = "Menu";
            Load += FormMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Matrix;
        private Button Image;
    }
}
