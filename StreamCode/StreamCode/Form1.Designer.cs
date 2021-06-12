
namespace StreamCode
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
            this.richTextBoxStream = new System.Windows.Forms.RichTextBox();
            this.buttonGen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCreateLong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxBBS = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownBitSize = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownBitsToGen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownP = new System.Windows.Forms.NumericUpDown();
            this.buttonGenStream = new System.Windows.Forms.Button();
            this.labelExTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rC4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitsToGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxStream
            // 
            this.richTextBoxStream.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxStream.Location = new System.Drawing.Point(12, 288);
            this.richTextBoxStream.Name = "richTextBoxStream";
            this.richTextBoxStream.Size = new System.Drawing.Size(774, 161);
            this.richTextBoxStream.TabIndex = 0;
            this.richTextBoxStream.Text = "";
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(571, 80);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(94, 23);
            this.buttonGen.TabIndex = 1;
            this.buttonGen.Text = "Generate";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "LongData";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "P";
            // 
            // buttonCreateLong
            // 
            this.buttonCreateLong.Location = new System.Drawing.Point(163, 80);
            this.buttonCreateLong.Name = "buttonCreateLong";
            this.buttonCreateLong.Size = new System.Drawing.Size(94, 23);
            this.buttonCreateLong.TabIndex = 7;
            this.buttonCreateLong.Text = "Create";
            this.buttonCreateLong.UseVisualStyleBackColor = true;
            this.buttonCreateLong.Click += new System.EventHandler(this.buttonCreateLong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Auto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "N";
            // 
            // richTextBoxBBS
            // 
            this.richTextBoxBBS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxBBS.Location = new System.Drawing.Point(53, 118);
            this.richTextBoxBBS.Name = "richTextBoxBBS";
            this.richTextBoxBBS.Size = new System.Drawing.Size(733, 105);
            this.richTextBoxBBS.TabIndex = 11;
            this.richTextBoxBBS.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "BBS";
            // 
            // numericUpDownBitSize
            // 
            this.numericUpDownBitSize.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownBitSize.Location = new System.Drawing.Point(560, 52);
            this.numericUpDownBitSize.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDownBitSize.Name = "numericUpDownBitSize";
            this.numericUpDownBitSize.Size = new System.Drawing.Size(133, 22);
            this.numericUpDownBitSize.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bits to Generate";
            // 
            // numericUpDownBitsToGen
            // 
            this.numericUpDownBitsToGen.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownBitsToGen.Location = new System.Drawing.Point(186, 242);
            this.numericUpDownBitsToGen.Maximum = new decimal(new int[] {
            -1454759936,
            465,
            0,
            0});
            this.numericUpDownBitsToGen.Name = "numericUpDownBitsToGen";
            this.numericUpDownBitsToGen.Size = new System.Drawing.Size(133, 22);
            this.numericUpDownBitsToGen.TabIndex = 15;
            // 
            // numericUpDownQ
            // 
            this.numericUpDownQ.Location = new System.Drawing.Point(47, 50);
            this.numericUpDownQ.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDownQ.Name = "numericUpDownQ";
            this.numericUpDownQ.Size = new System.Drawing.Size(133, 22);
            this.numericUpDownQ.TabIndex = 16;
            // 
            // numericUpDownP
            // 
            this.numericUpDownP.Location = new System.Drawing.Point(248, 52);
            this.numericUpDownP.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDownP.Name = "numericUpDownP";
            this.numericUpDownP.Size = new System.Drawing.Size(133, 22);
            this.numericUpDownP.TabIndex = 17;
            // 
            // buttonGenStream
            // 
            this.buttonGenStream.Location = new System.Drawing.Point(341, 241);
            this.buttonGenStream.Name = "buttonGenStream";
            this.buttonGenStream.Size = new System.Drawing.Size(94, 23);
            this.buttonGenStream.TabIndex = 18;
            this.buttonGenStream.Text = "Generate";
            this.buttonGenStream.UseVisualStyleBackColor = true;
            this.buttonGenStream.Click += new System.EventHandler(this.buttonGenStream_Click);
            // 
            // labelExTime
            // 
            this.labelExTime.AutoSize = true;
            this.labelExTime.Location = new System.Drawing.Point(482, 241);
            this.labelExTime.Name = "labelExTime";
            this.labelExTime.Size = new System.Drawing.Size(0, 17);
            this.labelExTime.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rC4ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rC4ToolStripMenuItem
            // 
            this.rC4ToolStripMenuItem.Name = "rC4ToolStripMenuItem";
            this.rC4ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.rC4ToolStripMenuItem.Text = "RC4";
            this.rC4ToolStripMenuItem.Click += new System.EventHandler(this.rC4ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 461);
            this.Controls.Add(this.labelExTime);
            this.Controls.Add(this.buttonGenStream);
            this.Controls.Add(this.numericUpDownP);
            this.Controls.Add(this.numericUpDownQ);
            this.Controls.Add(this.numericUpDownBitsToGen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownBitSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBoxBBS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCreateLong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.richTextBoxStream);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "BBS";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitsToGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxStream;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCreateLong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxBBS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownBitSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownBitsToGen;
        private System.Windows.Forms.NumericUpDown numericUpDownQ;
        private System.Windows.Forms.NumericUpDown numericUpDownP;
        private System.Windows.Forms.Button buttonGenStream;
        private System.Windows.Forms.Label labelExTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rC4ToolStripMenuItem;
    }
}

