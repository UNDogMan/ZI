namespace PrestShefr
{
    partial class Form2
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
            this.buttonSaveCodeText = new System.Windows.Forms.Button();
            this.buttonSaveText = new System.Windows.Forms.Button();
            this.buttonOpenCodeText = new System.Windows.Forms.Button();
            this.buttonOpenText = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.buttonCode = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.alphabetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxPairs = new System.Windows.Forms.ComboBox();
            this.buttonStatL = new System.Windows.Forms.Button();
            this.buttonStatR = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.TabIndex = 11;
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
            this.CaesarToolStripMenuItem.Name = "CaesarToolStripMenuItem";
            this.CaesarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.CaesarToolStripMenuItem.Text = "Caesar";
            this.CaesarToolStripMenuItem.Click += new System.EventHandler(this.CaesarToolStripMenuItem_Click);
            // 
            // trisemusToolStripMenuItem
            // 
            this.trisemusToolStripMenuItem.Checked = true;
            this.trisemusToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trisemusToolStripMenuItem.Name = "trisemusToolStripMenuItem";
            this.trisemusToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.trisemusToolStripMenuItem.Text = "Trisemus";
            // 
            // buttonSaveCodeText
            // 
            this.buttonSaveCodeText.Location = new System.Drawing.Point(530, 49);
            this.buttonSaveCodeText.Name = "buttonSaveCodeText";
            this.buttonSaveCodeText.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveCodeText.TabIndex = 19;
            this.buttonSaveCodeText.Text = "Save";
            this.buttonSaveCodeText.UseVisualStyleBackColor = true;
            this.buttonSaveCodeText.Click += new System.EventHandler(this.buttonSaveCodeText_Click);
            // 
            // buttonSaveText
            // 
            this.buttonSaveText.Location = new System.Drawing.Point(181, 49);
            this.buttonSaveText.Name = "buttonSaveText";
            this.buttonSaveText.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveText.TabIndex = 18;
            this.buttonSaveText.Text = "Save";
            this.buttonSaveText.UseVisualStyleBackColor = true;
            this.buttonSaveText.Click += new System.EventHandler(this.buttonSaveText_Click);
            // 
            // buttonOpenCodeText
            // 
            this.buttonOpenCodeText.Location = new System.Drawing.Point(648, 49);
            this.buttonOpenCodeText.Name = "buttonOpenCodeText";
            this.buttonOpenCodeText.Size = new System.Drawing.Size(130, 23);
            this.buttonOpenCodeText.TabIndex = 17;
            this.buttonOpenCodeText.Text = "Open CodeText";
            this.buttonOpenCodeText.UseVisualStyleBackColor = true;
            this.buttonOpenCodeText.Click += new System.EventHandler(this.buttonOpenCodeText_Click);
            // 
            // buttonOpenText
            // 
            this.buttonOpenText.Location = new System.Drawing.Point(12, 49);
            this.buttonOpenText.Name = "buttonOpenText";
            this.buttonOpenText.Size = new System.Drawing.Size(124, 23);
            this.buttonOpenText.TabIndex = 16;
            this.buttonOpenText.Text = "Open Text";
            this.buttonOpenText.UseVisualStyleBackColor = true;
            this.buttonOpenText.Click += new System.EventHandler(this.buttonOpenText_Click);
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(354, 250);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonDecode.TabIndex = 15;
            this.buttonDecode.Text = "<<";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // buttonCode
            // 
            this.buttonCode.Location = new System.Drawing.Point(354, 198);
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Size = new System.Drawing.Size(75, 23);
            this.buttonCode.TabIndex = 14;
            this.buttonCode.Text = ">>";
            this.buttonCode.UseVisualStyleBackColor = true;
            this.buttonCode.Click += new System.EventHandler(this.buttonCode_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(452, 87);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(326, 357);
            this.richTextBox2.TabIndex = 13;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 87);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 357);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(296, 50);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(200, 22);
            this.textBoxK.TabIndex = 20;
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
            this.editToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editToolStripMenuItem.Text = "Edit...";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // comboBoxPairs
            // 
            this.comboBoxPairs.FormattingEnabled = true;
            this.comboBoxPairs.Location = new System.Drawing.Point(342, 87);
            this.comboBoxPairs.Name = "comboBoxPairs";
            this.comboBoxPairs.Size = new System.Drawing.Size(104, 24);
            this.comboBoxPairs.TabIndex = 21;
            // 
            // buttonStatL
            // 
            this.buttonStatL.Location = new System.Drawing.Point(354, 328);
            this.buttonStatL.Name = "buttonStatL";
            this.buttonStatL.Size = new System.Drawing.Size(75, 23);
            this.buttonStatL.TabIndex = 22;
            this.buttonStatL.Text = "<< Stat";
            this.buttonStatL.UseVisualStyleBackColor = true;
            this.buttonStatL.Click += new System.EventHandler(this.buttonStatL_Click);
            // 
            // buttonStatR
            // 
            this.buttonStatR.Location = new System.Drawing.Point(354, 357);
            this.buttonStatR.Name = "buttonStatR";
            this.buttonStatR.Size = new System.Drawing.Size(75, 23);
            this.buttonStatR.TabIndex = 23;
            this.buttonStatR.Text = "Stat >>";
            this.buttonStatR.UseVisualStyleBackColor = true;
            this.buttonStatR.Click += new System.EventHandler(this.buttonStatR_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStatR);
            this.Controls.Add(this.buttonStatL);
            this.Controls.Add(this.comboBoxPairs);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonSaveCodeText);
            this.Controls.Add(this.buttonSaveText);
            this.Controls.Add(this.buttonOpenCodeText);
            this.Controls.Add(this.buttonOpenText);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonCode);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CaesarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trisemusToolStripMenuItem;
        private System.Windows.Forms.Button buttonSaveCodeText;
        private System.Windows.Forms.Button buttonSaveText;
        private System.Windows.Forms.Button buttonOpenCodeText;
        private System.Windows.Forms.Button buttonOpenText;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Button buttonCode;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.ToolStripMenuItem alphabetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxPairs;
        private System.Windows.Forms.Button buttonStatL;
        private System.Windows.Forms.Button buttonStatR;
    }
}