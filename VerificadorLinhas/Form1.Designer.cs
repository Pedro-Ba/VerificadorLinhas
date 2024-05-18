namespace VerificadorLinhas
{
    partial class Form1
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
            btnFirstFile = new Button();
            btnSecondFile = new Button();
            labelFirstFile = new Label();
            labelSecondFile = new Label();
            listBox1 = new ListBox();
            btnCheckLines = new Button();
            lblLinesFirstFile = new Label();
            lblLinesSecondFile = new Label();
            SuspendLayout();
            // 
            // btnFirstFile
            // 
            btnFirstFile.Location = new Point(12, 12);
            btnFirstFile.Name = "btnFirstFile";
            btnFirstFile.Size = new Size(94, 29);
            btnFirstFile.TabIndex = 0;
            btnFirstFile.Text = "First File";
            btnFirstFile.UseVisualStyleBackColor = true;
            btnFirstFile.Click += btnFirstFile_Click;
            // 
            // btnSecondFile
            // 
            btnSecondFile.Location = new Point(409, 12);
            btnSecondFile.Name = "btnSecondFile";
            btnSecondFile.Size = new Size(94, 29);
            btnSecondFile.TabIndex = 1;
            btnSecondFile.Text = "Second File";
            btnSecondFile.UseVisualStyleBackColor = true;
            btnSecondFile.Click += btnSecondFile_Click;
            // 
            // labelFirstFile
            // 
            labelFirstFile.AutoSize = true;
            labelFirstFile.Location = new Point(12, 44);
            labelFirstFile.Name = "labelFirstFile";
            labelFirstFile.Size = new Size(107, 20);
            labelFirstFile.TabIndex = 2;
            labelFirstFile.Text = "First File Name";
            // 
            // labelSecondFile
            // 
            labelSecondFile.AutoSize = true;
            labelSecondFile.Location = new Point(409, 44);
            labelSecondFile.Name = "labelSecondFile";
            labelSecondFile.Size = new Size(129, 20);
            labelSecondFile.TabIndex = 3;
            labelSecondFile.Text = "Second File Name";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(106, 154);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(312, 284);
            listBox1.TabIndex = 4;
            // 
            // btnCheckLines
            // 
            btnCheckLines.Location = new Point(210, 119);
            btnCheckLines.Name = "btnCheckLines";
            btnCheckLines.Size = new Size(94, 29);
            btnCheckLines.TabIndex = 5;
            btnCheckLines.Text = "Check Lines";
            btnCheckLines.UseVisualStyleBackColor = true;
            btnCheckLines.Click += btnCheckLines_Click;
            // 
            // lblLinesFirstFile
            // 
            lblLinesFirstFile.AutoSize = true;
            lblLinesFirstFile.Location = new Point(12, 64);
            lblLinesFirstFile.Name = "lblLinesFirstFile";
            lblLinesFirstFile.Size = new Size(0, 20);
            lblLinesFirstFile.TabIndex = 6;
            // 
            // lblLinesSecondFile
            // 
            lblLinesSecondFile.AutoSize = true;
            lblLinesSecondFile.Location = new Point(409, 64);
            lblLinesSecondFile.Name = "lblLinesSecondFile";
            lblLinesSecondFile.Size = new Size(0, 20);
            lblLinesSecondFile.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLinesSecondFile);
            Controls.Add(lblLinesFirstFile);
            Controls.Add(btnCheckLines);
            Controls.Add(listBox1);
            Controls.Add(labelSecondFile);
            Controls.Add(labelFirstFile);
            Controls.Add(btnSecondFile);
            Controls.Add(btnFirstFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFirstFile;
        private Button btnSecondFile;
        private Label labelFirstFile;
        private Label labelSecondFile;
        private ListBox listBox1;
        private Button btnCheckLines;
        private Label lblLinesFirstFile;
        private Label lblLinesSecondFile;
    }
}
