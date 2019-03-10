namespace WindowsFormsApplication1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lend = new System.Windows.Forms.Label();
            this.N1TXT = new System.Windows.Forms.TextBox();
            this.N2TXT = new System.Windows.Forms.TextBox();
            this.loopBTN = new System.Windows.Forms.Button();
            this.N3TXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.N4TXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 155);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number 1";
            // 
            // lend
            // 
            this.lend.AutoSize = true;
            this.lend.Location = new System.Drawing.Point(9, 41);
            this.lend.Name = "lend";
            this.lend.Size = new System.Drawing.Size(53, 13);
            this.lend.TabIndex = 2;
            this.lend.Text = "Number 2";
            // 
            // N1TXT
            // 
            this.N1TXT.Location = new System.Drawing.Point(69, 12);
            this.N1TXT.Name = "N1TXT";
            this.N1TXT.Size = new System.Drawing.Size(100, 20);
            this.N1TXT.TabIndex = 3;
            this.N1TXT.TextChanged += new System.EventHandler(this.LstartTXT_TextChanged);
            // 
            // N2TXT
            // 
            this.N2TXT.Location = new System.Drawing.Point(69, 38);
            this.N2TXT.Name = "N2TXT";
            this.N2TXT.Size = new System.Drawing.Size(100, 20);
            this.N2TXT.TabIndex = 4;
            // 
            // loopBTN
            // 
            this.loopBTN.Location = new System.Drawing.Point(197, 47);
            this.loopBTN.Name = "loopBTN";
            this.loopBTN.Size = new System.Drawing.Size(75, 23);
            this.loopBTN.TabIndex = 5;
            this.loopBTN.Text = "Decipher";
            this.loopBTN.UseVisualStyleBackColor = true;
            this.loopBTN.Click += new System.EventHandler(this.loopBTN_Click);
            // 
            // N3TXT
            // 
            this.N3TXT.Location = new System.Drawing.Point(69, 64);
            this.N3TXT.Name = "N3TXT";
            this.N3TXT.Size = new System.Drawing.Size(100, 20);
            this.N3TXT.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number 3";
            // 
            // N4TXT
            // 
            this.N4TXT.Location = new System.Drawing.Point(69, 91);
            this.N4TXT.Name = "N4TXT";
            this.N4TXT.Size = new System.Drawing.Size(100, 20);
            this.N4TXT.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.N4TXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.N3TXT);
            this.Controls.Add(this.loopBTN);
            this.Controls.Add(this.N2TXT);
            this.Controls.Add(this.N1TXT);
            this.Controls.Add(this.lend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lend;
        private System.Windows.Forms.TextBox N1TXT;
        private System.Windows.Forms.TextBox N2TXT;
        private System.Windows.Forms.Button loopBTN;
        private System.Windows.Forms.TextBox N3TXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox N4TXT;
        private System.Windows.Forms.Label label3;
    }
}

