namespace SimpleNum
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
            this.textBoxGCDNums = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGCDCalc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.buttonSCalc = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textBoxGCDans = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxGCDNums
            // 
            this.textBoxGCDNums.Location = new System.Drawing.Point(69, 12);
            this.textBoxGCDNums.Name = "textBoxGCDNums";
            this.textBoxGCDNums.Size = new System.Drawing.Size(400, 22);
            this.textBoxGCDNums.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "GCD";
            // 
            // buttonGCDCalc
            // 
            this.buttonGCDCalc.Location = new System.Drawing.Point(491, 12);
            this.buttonGCDCalc.Name = "buttonGCDCalc";
            this.buttonGCDCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonGCDCalc.TabIndex = 2;
            this.buttonGCDCalc.Text = "Calc";
            this.buttonGCDCalc.UseVisualStyleBackColor = true;
            this.buttonGCDCalc.Click += new System.EventHandler(this.buttonGCDCalc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "m";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(52, 55);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 22);
            this.textBoxN.TabIndex = 5;
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(52, 87);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(100, 22);
            this.textBoxM.TabIndex = 6;
            // 
            // buttonSCalc
            // 
            this.buttonSCalc.Location = new System.Drawing.Point(201, 66);
            this.buttonSCalc.Name = "buttonSCalc";
            this.buttonSCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonSCalc.TabIndex = 7;
            this.buttonSCalc.Text = "Calc";
            this.buttonSCalc.UseVisualStyleBackColor = true;
            this.buttonSCalc.Click += new System.EventHandler(this.buttonSCalc_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(18, 127);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(258, 311);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(328, 127);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(238, 311);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // textBoxGCDans
            // 
            this.textBoxGCDans.Location = new System.Drawing.Point(466, 41);
            this.textBoxGCDans.Name = "textBoxGCDans";
            this.textBoxGCDans.ReadOnly = true;
            this.textBoxGCDans.Size = new System.Drawing.Size(100, 22);
            this.textBoxGCDans.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.textBoxGCDans);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonSCalc);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGCDCalc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGCDNums);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGCDNums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGCDCalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Button buttonSCalc;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBoxGCDans;
    }
}

