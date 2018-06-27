namespace CreateBatch
{
    partial class Form1
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
            this.tbListContent2 = new System.Windows.Forms.RichTextBox();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.tbBeforeValue = new System.Windows.Forms.TextBox();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEndValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbListContent1 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBrowserV2 = new System.Windows.Forms.Button();
            this.btnBrowserV1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbListContent2
            // 
            this.tbListContent2.Location = new System.Drawing.Point(18, 361);
            this.tbListContent2.Name = "tbListContent2";
            this.tbListContent2.Size = new System.Drawing.Size(257, 172);
            this.tbListContent2.TabIndex = 0;
            this.tbListContent2.Text = "";
            // 
            // tbStart
            // 
            this.tbStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbStart.Location = new System.Drawing.Point(340, 69);
            this.tbStart.Multiline = true;
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(472, 268);
            this.tbStart.TabIndex = 1;
            this.tbStart.Text = "robocopy &Value1 &Value2 /E /Copy:DAT /R:0 /W:0";
            // 
            // tbBeforeValue
            // 
            this.tbBeforeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbBeforeValue.Location = new System.Drawing.Point(579, 591);
            this.tbBeforeValue.Multiline = true;
            this.tbBeforeValue.Name = "tbBeforeValue";
            this.tbBeforeValue.Size = new System.Drawing.Size(43, 41);
            this.tbBeforeValue.TabIndex = 2;
            // 
            // tbEnd
            // 
            this.tbEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbEnd.Location = new System.Drawing.Point(783, 591);
            this.tbEnd.Multiline = true;
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(41, 38);
            this.tbEnd.TabIndex = 3;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(350, 409);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 52);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbCount
            // 
            this.tbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCount.Location = new System.Drawing.Point(606, 356);
            this.tbCount.Multiline = true;
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(49, 33);
            this.tbCount.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Script";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(747, 609);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "End";
            // 
            // tbEndValue
            // 
            this.tbEndValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbEndValue.Location = new System.Drawing.Point(690, 591);
            this.tbEndValue.Multiline = true;
            this.tbEndValue.Name = "tbEndValue";
            this.tbEndValue.Size = new System.Drawing.Size(51, 41);
            this.tbEndValue.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 609);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Before Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 609);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "End Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 532);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 65);
            this.label5.TabIndex = 11;
            this.label5.Text = "Start\r\n\r\nBefore Value + tb.text + End Value\r\n\r\nEnd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Count:";
            // 
            // tbListContent1
            // 
            this.tbListContent1.Location = new System.Drawing.Point(21, 69);
            this.tbListContent1.Name = "tbListContent1";
            this.tbListContent1.Size = new System.Drawing.Size(283, 247);
            this.tbListContent1.TabIndex = 13;
            this.tbListContent1.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Value2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Value1";
            // 
            // btnBrowserV2
            // 
            this.btnBrowserV2.Location = new System.Drawing.Point(79, 322);
            this.btnBrowserV2.Name = "btnBrowserV2";
            this.btnBrowserV2.Size = new System.Drawing.Size(138, 34);
            this.btnBrowserV2.TabIndex = 16;
            this.btnBrowserV2.Text = "Browser Value2";
            this.btnBrowserV2.UseVisualStyleBackColor = true;
            this.btnBrowserV2.Click += new System.EventHandler(this.btnBrowserV2_Click);
            // 
            // btnBrowserV1
            // 
            this.btnBrowserV1.Location = new System.Drawing.Point(85, 29);
            this.btnBrowserV1.Name = "btnBrowserV1";
            this.btnBrowserV1.Size = new System.Drawing.Size(101, 34);
            this.btnBrowserV1.TabIndex = 17;
            this.btnBrowserV1.Text = "Browser Value1";
            this.btnBrowserV1.UseVisualStyleBackColor = true;
            this.btnBrowserV1.Click += new System.EventHandler(this.btnBrowserV1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "FileName:";
            // 
            // tbFileName
            // 
            this.tbFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbFileName.Location = new System.Drawing.Point(340, 356);
            this.tbFileName.Multiline = true;
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(212, 33);
            this.tbFileName.TabIndex = 18;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 23);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbListContent1);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.tbFileName);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.tbStart);
            this.splitContainer1.Panel1.Controls.Add(this.btnBrowserV2);
            this.splitContainer1.Panel1.Controls.Add(this.btnBrowserV1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tbListContent2);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.tbCount);
            this.splitContainer1.Panel1.Controls.Add(this.btnGenerate);
            this.splitContainer1.Size = new System.Drawing.Size(823, 695);
            this.splitContainer1.SplitterDistance = 573;
            this.splitContainer1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 730);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEndValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.tbBeforeValue);
            this.Name = "Form1";
            this.Text = "Create Batch";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbListContent2;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.TextBox tbBeforeValue;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEndValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox tbListContent1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBrowserV2;
        private System.Windows.Forms.Button btnBrowserV1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

