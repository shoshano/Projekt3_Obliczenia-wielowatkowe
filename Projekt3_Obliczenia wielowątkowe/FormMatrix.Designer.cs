namespace Projekt3_Obliczenia_wielowątkowe
{
    partial class FormMatrix
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
            buttonReturn = new Button();
            buttonStart = new Button();
            textBoxMatA = new TextBox();
            textBoxMatB = new TextBox();
            labelMatA = new Label();
            labelMatB = new Label();
            textBoxMatC = new TextBox();
            labelMatC = new Label();
            numericUpDownARow = new NumericUpDown();
            labelMatA1 = new Label();
            numericUpDownACol = new NumericUpDown();
            numericUpDownBCol = new NumericUpDown();
            labelMatB1 = new Label();
            numericUpDownBRow = new NumericUpDown();
            radioButtonCountAll = new RadioButton();
            radioButtonStaticNumberOfTh = new RadioButton();
            numericUpDownNrTh = new NumericUpDown();
            labelCol = new Label();
            labelRow = new Label();
            checkBoxPararelle = new CheckBox();
            buttonExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownARow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownACol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBCol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBRow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNrTh).BeginInit();
            SuspendLayout();
            // 
            // buttonReturn
            // 
            buttonReturn.Font = new Font("Arial Black", 8.2F, FontStyle.Bold);
            buttonReturn.Location = new Point(7, 8);
            buttonReturn.Margin = new Padding(3, 2, 3, 2);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(41, 35);
            buttonReturn.TabIndex = 0;
            buttonReturn.Tag = "buttonReturn";
            buttonReturn.Text = "<--";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(93, 575);
            buttonStart.Margin = new Padding(3, 2, 3, 2);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(161, 83);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // textBoxMatA
            // 
            textBoxMatA.Location = new Point(502, 72);
            textBoxMatA.Multiline = true;
            textBoxMatA.Name = "textBoxMatA";
            textBoxMatA.Size = new Size(262, 258);
            textBoxMatA.TabIndex = 2;
            // 
            // textBoxMatB
            // 
            textBoxMatB.Location = new Point(839, 72);
            textBoxMatB.Multiline = true;
            textBoxMatB.Name = "textBoxMatB";
            textBoxMatB.Size = new Size(262, 258);
            textBoxMatB.TabIndex = 3;
            // 
            // labelMatA
            // 
            labelMatA.AutoSize = true;
            labelMatA.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelMatA.Location = new Point(572, 40);
            labelMatA.Name = "labelMatA";
            labelMatA.Size = new Size(110, 30);
            labelMatA.TabIndex = 4;
            labelMatA.Text = "Macierz A";
            // 
            // labelMatB
            // 
            labelMatB.AutoSize = true;
            labelMatB.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelMatB.Location = new Point(915, 40);
            labelMatB.Name = "labelMatB";
            labelMatB.Size = new Size(108, 30);
            labelMatB.TabIndex = 5;
            labelMatB.Text = "Macierz B";
            // 
            // textBoxMatC
            // 
            textBoxMatC.Location = new Point(513, 387);
            textBoxMatC.Multiline = true;
            textBoxMatC.Name = "textBoxMatC";
            textBoxMatC.Size = new Size(579, 271);
            textBoxMatC.TabIndex = 6;
            // 
            // labelMatC
            // 
            labelMatC.AutoSize = true;
            labelMatC.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelMatC.Location = new Point(748, 354);
            labelMatC.Name = "labelMatC";
            labelMatC.Size = new Size(108, 30);
            labelMatC.TabIndex = 7;
            labelMatC.Text = "Macierz C";
            // 
            // numericUpDownARow
            // 
            numericUpDownARow.Location = new Point(147, 101);
            numericUpDownARow.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownARow.Name = "numericUpDownARow";
            numericUpDownARow.Size = new Size(56, 23);
            numericUpDownARow.TabIndex = 8;
            numericUpDownARow.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownARow.ValueChanged += numericUpDownARow_ValueChanged;
            // 
            // labelMatA1
            // 
            labelMatA1.AutoSize = true;
            labelMatA1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelMatA1.Location = new Point(130, 60);
            labelMatA1.Name = "labelMatA1";
            labelMatA1.Size = new Size(110, 30);
            labelMatA1.TabIndex = 9;
            labelMatA1.Text = "Macierz A";
            // 
            // numericUpDownACol
            // 
            numericUpDownACol.Location = new Point(147, 130);
            numericUpDownACol.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownACol.Name = "numericUpDownACol";
            numericUpDownACol.Size = new Size(56, 23);
            numericUpDownACol.TabIndex = 10;
            numericUpDownACol.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownACol.ValueChanged += numericUpDownACol_ValueChanged;
            // 
            // numericUpDownBCol
            // 
            numericUpDownBCol.Location = new Point(323, 130);
            numericUpDownBCol.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownBCol.Name = "numericUpDownBCol";
            numericUpDownBCol.Size = new Size(56, 23);
            numericUpDownBCol.TabIndex = 13;
            numericUpDownBCol.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownBCol.ValueChanged += numericUpDownBCol_ValueChanged;
            // 
            // labelMatB1
            // 
            labelMatB1.AutoSize = true;
            labelMatB1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelMatB1.Location = new Point(306, 60);
            labelMatB1.Name = "labelMatB1";
            labelMatB1.Size = new Size(108, 30);
            labelMatB1.TabIndex = 12;
            labelMatB1.Text = "Macierz B";
            // 
            // numericUpDownBRow
            // 
            numericUpDownBRow.Location = new Point(323, 101);
            numericUpDownBRow.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownBRow.Name = "numericUpDownBRow";
            numericUpDownBRow.Size = new Size(56, 23);
            numericUpDownBRow.TabIndex = 11;
            numericUpDownBRow.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownBRow.ValueChanged += numericUpDownBRow_ValueChanged;
            // 
            // radioButtonCountAll
            // 
            radioButtonCountAll.AutoSize = true;
            radioButtonCountAll.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            radioButtonCountAll.Location = new Point(50, 269);
            radioButtonCountAll.Name = "radioButtonCountAll";
            radioButtonCountAll.Size = new Size(204, 25);
            radioButtonCountAll.TabIndex = 15;
            radioButtonCountAll.TabStop = true;
            radioButtonCountAll.Text = "Wszystkie wątki po kolei";
            radioButtonCountAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonStaticNumberOfTh
            // 
            radioButtonStaticNumberOfTh.AutoSize = true;
            radioButtonStaticNumberOfTh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            radioButtonStaticNumberOfTh.Location = new Point(50, 337);
            radioButtonStaticNumberOfTh.Name = "radioButtonStaticNumberOfTh";
            radioButtonStaticNumberOfTh.Size = new Size(169, 25);
            radioButtonStaticNumberOfTh.TabIndex = 16;
            radioButtonStaticNumberOfTh.TabStop = true;
            radioButtonStaticNumberOfTh.Text = "Stała liczba wątków";
            radioButtonStaticNumberOfTh.UseVisualStyleBackColor = true;
            // 
            // numericUpDownNrTh
            // 
            numericUpDownNrTh.Location = new Point(73, 387);
            numericUpDownNrTh.Name = "numericUpDownNrTh";
            numericUpDownNrTh.Size = new Size(56, 23);
            numericUpDownNrTh.TabIndex = 17;
            // 
            // labelCol
            // 
            labelCol.AutoSize = true;
            labelCol.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelCol.Location = new Point(71, 130);
            labelCol.Name = "labelCol";
            labelCol.Size = new Size(70, 20);
            labelCol.TabIndex = 18;
            labelCol.Text = "Kolumny";
            // 
            // labelRow
            // 
            labelRow.AutoSize = true;
            labelRow.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelRow.Location = new Point(71, 104);
            labelRow.Name = "labelRow";
            labelRow.Size = new Size(62, 20);
            labelRow.TabIndex = 19;
            labelRow.Text = "Wiersze";
            // 
            // checkBoxPararelle
            // 
            checkBoxPararelle.AutoSize = true;
            checkBoxPararelle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            checkBoxPararelle.Location = new Point(50, 511);
            checkBoxPararelle.Name = "checkBoxPararelle";
            checkBoxPararelle.Size = new Size(124, 25);
            checkBoxPararelle.TabIndex = 20;
            checkBoxPararelle.Text = "Użyj Parallele";
            checkBoxPararelle.UseVisualStyleBackColor = true;
            // 
            // buttonExcel
            // 
            buttonExcel.Location = new Point(296, 575);
            buttonExcel.Margin = new Padding(3, 2, 3, 2);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(161, 83);
            buttonExcel.TabIndex = 21;
            buttonExcel.Text = "Excel";
            buttonExcel.UseVisualStyleBackColor = true;
            buttonExcel.Click += buttonExcel_Click;
            // 
            // FormMatrix
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 691);
            Controls.Add(buttonExcel);
            Controls.Add(checkBoxPararelle);
            Controls.Add(labelRow);
            Controls.Add(labelCol);
            Controls.Add(numericUpDownNrTh);
            Controls.Add(radioButtonStaticNumberOfTh);
            Controls.Add(radioButtonCountAll);
            Controls.Add(numericUpDownBCol);
            Controls.Add(labelMatB1);
            Controls.Add(numericUpDownBRow);
            Controls.Add(numericUpDownACol);
            Controls.Add(labelMatA1);
            Controls.Add(numericUpDownARow);
            Controls.Add(labelMatC);
            Controls.Add(textBoxMatC);
            Controls.Add(labelMatB);
            Controls.Add(labelMatA);
            Controls.Add(textBoxMatB);
            Controls.Add(textBoxMatA);
            Controls.Add(buttonStart);
            Controls.Add(buttonReturn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMatrix";
            Text = "Matrix";
            ((System.ComponentModel.ISupportInitialize)numericUpDownARow).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownACol).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBCol).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBRow).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNrTh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReturn;
        private Button buttonStart;
        private TextBox textBoxMatA;
        private TextBox textBoxMatB;
        private Label labelMatA;
        private Label labelMatB;
        private TextBox textBoxMatC;
        private Label labelMatC;
        private NumericUpDown numericUpDownARow;
        private Label labelMatA1;
        private NumericUpDown numericUpDownACol;
        private NumericUpDown numericUpDownBCol;
        private Label labelMatB1;
        private NumericUpDown numericUpDownBRow;
        private RadioButton radioButtonCountAll;
        private RadioButton radioButtonStaticNumberOfTh;
        private NumericUpDown numericUpDownNrTh;
        private Label labelCol;
        private Label labelRow;
        private CheckBox checkBoxPararelle;
        private Button buttonExcel;
    }
}