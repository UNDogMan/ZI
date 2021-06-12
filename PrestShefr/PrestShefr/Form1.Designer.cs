namespace PrestShefr
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CaesarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trisemusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphabetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.buttonCode = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.buttonOpenText = new System.Windows.Forms.Button();
            this.buttonOpenCodeText = new System.Windows.Forms.Button();
            this.buttonSaveText = new System.Windows.Forms.Button();
            this.buttonSaveCodeText = new System.Windows.Forms.Button();
            this.kNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.buttonStatR = new System.Windows.Forms.Button();
            this.buttonStatL = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeToolStripMenuItem,
            this.alphabetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CaesarToolStripMenuItem,
            this.trisemusToolStripMenuItem});
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.codeToolStripMenuItem.Text = "Code";
            // 
            // CaesarToolStripMenuItem
            // 
            this.CaesarToolStripMenuItem.Checked = true;
            this.CaesarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CaesarToolStripMenuItem.Name = "CaesarToolStripMenuItem";
            this.CaesarToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.CaesarToolStripMenuItem.Text = "Caesar";
            this.CaesarToolStripMenuItem.Click += new System.EventHandler(this.yxkModNToolStripMenuItem_Click);
            // 
            // trisemusToolStripMenuItem
            // 
            this.trisemusToolStripMenuItem.Name = "trisemusToolStripMenuItem";
            this.trisemusToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.trisemusToolStripMenuItem.Text = "Trisemus";
            this.trisemusToolStripMenuItem.Click += new System.EventHandler(this.trisemusToolStripMenuItem_Click);
            // 
            // alphabetToolStripMenuItem
            // 
            this.alphabetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.alphabetToolStripMenuItem.Name = "alphabetToolStripMenuItem";
            this.alphabetToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.alphabetToolStripMenuItem.Text = "Alphabet";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.editToolStripMenuItem.Text = "Edit...";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 81);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 357);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(452, 81);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(326, 357);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // buttonCode
            // 
            this.buttonCode.Location = new System.Drawing.Point(354, 192);
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Size = new System.Drawing.Size(75, 23);
            this.buttonCode.TabIndex = 3;
            this.buttonCode.Text = ">>";
            this.buttonCode.UseVisualStyleBackColor = true;
            this.buttonCode.Click += new System.EventHandler(this.buttonCode_Click);
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(354, 244);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonDecode.TabIndex = 4;
            this.buttonDecode.Text = "<<";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // buttonOpenText
            // 
            this.buttonOpenText.Location = new System.Drawing.Point(12, 43);
            this.buttonOpenText.Name = "buttonOpenText";
            this.buttonOpenText.Size = new System.Drawing.Size(124, 23);
            this.buttonOpenText.TabIndex = 5;
            this.buttonOpenText.Text = "Open Text";
            this.buttonOpenText.UseVisualStyleBackColor = true;
            this.buttonOpenText.Click += new System.EventHandler(this.buttonOpenText_Click);
            // 
            // buttonOpenCodeText
            // 
            this.buttonOpenCodeText.Location = new System.Drawing.Point(648, 43);
            this.buttonOpenCodeText.Name = "buttonOpenCodeText";
            this.buttonOpenCodeText.Size = new System.Drawing.Size(130, 23);
            this.buttonOpenCodeText.TabIndex = 6;
            this.buttonOpenCodeText.Text = "Open CodeText";
            this.buttonOpenCodeText.UseVisualStyleBackColor = true;
            this.buttonOpenCodeText.Click += new System.EventHandler(this.buttonOpenCodeText_Click);
            // 
            // buttonSaveText
            // 
            this.buttonSaveText.Location = new System.Drawing.Point(181, 43);
            this.buttonSaveText.Name = "buttonSaveText";
            this.buttonSaveText.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveText.TabIndex = 7;
            this.buttonSaveText.Text = "Save";
            this.buttonSaveText.UseVisualStyleBackColor = true;
            this.buttonSaveText.Click += new System.EventHandler(this.buttonSaveText_Click);
            // 
            // buttonSaveCodeText
            // 
            this.buttonSaveCodeText.Location = new System.Drawing.Point(530, 43);
            this.buttonSaveCodeText.Name = "buttonSaveCodeText";
            this.buttonSaveCodeText.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveCodeText.TabIndex = 8;
            this.buttonSaveCodeText.Text = "Save";
            this.buttonSaveCodeText.UseVisualStyleBackColor = true;
            this.buttonSaveCodeText.Click += new System.EventHandler(this.buttonSaveCodeText_Click);
            // 
            // kNumericUpDown
            // 
            this.kNumericUpDown.Location = new System.Drawing.Point(333, 44);
            this.kNumericUpDown.Name = "kNumericUpDown";
            this.kNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.kNumericUpDown.TabIndex = 10;
            this.kNumericUpDown.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // buttonStatR
            // 
            this.buttonStatR.Location = new System.Drawing.Point(354, 358);
            this.buttonStatR.Name = "buttonStatR";
            this.buttonStatR.Size = new System.Drawing.Size(75, 23);
            this.buttonStatR.TabIndex = 25;
            this.buttonStatR.Text = "Stat >>";
            this.buttonStatR.UseVisualStyleBackColor = true;
            this.buttonStatR.Click += new System.EventHandler(this.buttonStatR_Click);
            // 
            // buttonStatL
            // 
            this.buttonStatL.Location = new System.Drawing.Point(354, 329);
            this.buttonStatL.Name = "buttonStatL";
            this.buttonStatL.Size = new System.Drawing.Size(75, 23);
            this.buttonStatL.TabIndex = 24;
            this.buttonStatL.Text = "<< Stat";
            this.buttonStatL.UseVisualStyleBackColor = true;
            this.buttonStatL.Click += new System.EventHandler(this.buttonStatL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStatR);
            this.Controls.Add(this.buttonStatL);
            this.Controls.Add(this.kNumericUpDown);
            this.Controls.Add(this.buttonSaveCodeText);
            this.Controls.Add(this.buttonSaveText);
            this.Controls.Add(this.buttonOpenCodeText);
            this.Controls.Add(this.buttonOpenText);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonCode);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CaesarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trisemusToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button buttonCode;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Button buttonOpenText;
        private System.Windows.Forms.Button buttonOpenCodeText;
        private System.Windows.Forms.Button buttonSaveText;
        private System.Windows.Forms.Button buttonSaveCodeText;
        private System.Windows.Forms.NumericUpDown kNumericUpDown;
        private System.Windows.Forms.ToolStripMenuItem alphabetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button buttonStatR;
        private System.Windows.Forms.Button buttonStatL;
    }
}

