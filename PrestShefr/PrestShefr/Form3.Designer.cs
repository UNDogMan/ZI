namespace PrestShefr
{
    partial class Form3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonStatR = new System.Windows.Forms.Button();
            this.buttonStatL = new System.Windows.Forms.Button();
            this.kNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.buttonSaveCodeText = new System.Windows.Forms.Button();
            this.buttonSaveText = new System.Windows.Forms.Button();
            this.buttonOpenCodeText = new System.Windows.Forms.Button();
            this.buttonOpenText = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.buttonCode = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxKey2MP = new System.Windows.Forms.TextBox();
            this.textBoxKey1MP = new System.Windows.Forms.TextBox();
            this.buttonCTextMPStat = new System.Windows.Forms.Button();
            this.buttonTextMPStat = new System.Windows.Forms.Button();
            this.buttonSaveCTextMP = new System.Windows.Forms.Button();
            this.buttonSaveTextMP = new System.Windows.Forms.Button();
            this.buttonOpenCTextMP = new System.Windows.Forms.Button();
            this.buttonOpenTextMP = new System.Windows.Forms.Button();
            this.buttonDecodeMP = new System.Windows.Forms.Button();
            this.buttonCodeMP = new System.Windows.Forms.Button();
            this.richTextBoxCMP = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMP = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kNumericUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(895, 493);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonStatR);
            this.tabPage1.Controls.Add(this.buttonStatL);
            this.tabPage1.Controls.Add(this.kNumericUpDown);
            this.tabPage1.Controls.Add(this.buttonSaveCodeText);
            this.tabPage1.Controls.Add(this.buttonSaveText);
            this.tabPage1.Controls.Add(this.buttonOpenCodeText);
            this.tabPage1.Controls.Add(this.buttonOpenText);
            this.tabPage1.Controls.Add(this.buttonDecode);
            this.tabPage1.Controls.Add(this.buttonCode);
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(887, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Snake";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonStatR
            // 
            this.buttonStatR.Location = new System.Drawing.Point(402, 350);
            this.buttonStatR.Name = "buttonStatR";
            this.buttonStatR.Size = new System.Drawing.Size(75, 23);
            this.buttonStatR.TabIndex = 36;
            this.buttonStatR.Text = "Stat >>";
            this.buttonStatR.UseVisualStyleBackColor = true;
            this.buttonStatR.Click += new System.EventHandler(this.buttonStatR_Click);
            // 
            // buttonStatL
            // 
            this.buttonStatL.Location = new System.Drawing.Point(402, 321);
            this.buttonStatL.Name = "buttonStatL";
            this.buttonStatL.Size = new System.Drawing.Size(75, 23);
            this.buttonStatL.TabIndex = 35;
            this.buttonStatL.Text = "<< Stat";
            this.buttonStatL.UseVisualStyleBackColor = true;
            this.buttonStatL.Click += new System.EventHandler(this.buttonStatL_Click);
            // 
            // kNumericUpDown
            // 
            this.kNumericUpDown.Location = new System.Drawing.Point(381, 36);
            this.kNumericUpDown.Name = "kNumericUpDown";
            this.kNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.kNumericUpDown.TabIndex = 34;
            this.kNumericUpDown.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // buttonSaveCodeText
            // 
            this.buttonSaveCodeText.Location = new System.Drawing.Point(578, 35);
            this.buttonSaveCodeText.Name = "buttonSaveCodeText";
            this.buttonSaveCodeText.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveCodeText.TabIndex = 33;
            this.buttonSaveCodeText.Text = "Save";
            this.buttonSaveCodeText.UseVisualStyleBackColor = true;
            this.buttonSaveCodeText.Click += new System.EventHandler(this.buttonSaveCodeText_Click);
            // 
            // buttonSaveText
            // 
            this.buttonSaveText.Location = new System.Drawing.Point(229, 35);
            this.buttonSaveText.Name = "buttonSaveText";
            this.buttonSaveText.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveText.TabIndex = 32;
            this.buttonSaveText.Text = "Save";
            this.buttonSaveText.UseVisualStyleBackColor = true;
            this.buttonSaveText.Click += new System.EventHandler(this.buttonSaveText_Click);
            // 
            // buttonOpenCodeText
            // 
            this.buttonOpenCodeText.Location = new System.Drawing.Point(696, 35);
            this.buttonOpenCodeText.Name = "buttonOpenCodeText";
            this.buttonOpenCodeText.Size = new System.Drawing.Size(130, 23);
            this.buttonOpenCodeText.TabIndex = 31;
            this.buttonOpenCodeText.Text = "Open CodeText";
            this.buttonOpenCodeText.UseVisualStyleBackColor = true;
            this.buttonOpenCodeText.Click += new System.EventHandler(this.buttonOpenCodeText_Click);
            // 
            // buttonOpenText
            // 
            this.buttonOpenText.Location = new System.Drawing.Point(60, 35);
            this.buttonOpenText.Name = "buttonOpenText";
            this.buttonOpenText.Size = new System.Drawing.Size(124, 23);
            this.buttonOpenText.TabIndex = 30;
            this.buttonOpenText.Text = "Open Text";
            this.buttonOpenText.UseVisualStyleBackColor = true;
            this.buttonOpenText.Click += new System.EventHandler(this.buttonOpenText_Click);
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(402, 236);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonDecode.TabIndex = 29;
            this.buttonDecode.Text = "<<";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // buttonCode
            // 
            this.buttonCode.Location = new System.Drawing.Point(402, 184);
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Size = new System.Drawing.Size(75, 23);
            this.buttonCode.TabIndex = 28;
            this.buttonCode.Text = ">>";
            this.buttonCode.UseVisualStyleBackColor = true;
            this.buttonCode.Click += new System.EventHandler(this.buttonCode_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(500, 73);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(326, 357);
            this.richTextBox2.TabIndex = 27;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(61, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 357);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxKey2MP);
            this.tabPage2.Controls.Add(this.textBoxKey1MP);
            this.tabPage2.Controls.Add(this.buttonCTextMPStat);
            this.tabPage2.Controls.Add(this.buttonTextMPStat);
            this.tabPage2.Controls.Add(this.buttonSaveCTextMP);
            this.tabPage2.Controls.Add(this.buttonSaveTextMP);
            this.tabPage2.Controls.Add(this.buttonOpenCTextMP);
            this.tabPage2.Controls.Add(this.buttonOpenTextMP);
            this.tabPage2.Controls.Add(this.buttonDecodeMP);
            this.tabPage2.Controls.Add(this.buttonCodeMP);
            this.tabPage2.Controls.Add(this.richTextBoxCMP);
            this.tabPage2.Controls.Add(this.richTextBoxMP);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(887, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MultiPerm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxKey2MP
            // 
            this.textBoxKey2MP.Location = new System.Drawing.Point(331, 36);
            this.textBoxKey2MP.Name = "textBoxKey2MP";
            this.textBoxKey2MP.Size = new System.Drawing.Size(213, 22);
            this.textBoxKey2MP.TabIndex = 48;
            // 
            // textBoxKey1MP
            // 
            this.textBoxKey1MP.Location = new System.Drawing.Point(331, 6);
            this.textBoxKey1MP.Name = "textBoxKey1MP";
            this.textBoxKey1MP.Size = new System.Drawing.Size(213, 22);
            this.textBoxKey1MP.TabIndex = 47;
            // 
            // buttonCTextMPStat
            // 
            this.buttonCTextMPStat.Location = new System.Drawing.Point(402, 350);
            this.buttonCTextMPStat.Name = "buttonCTextMPStat";
            this.buttonCTextMPStat.Size = new System.Drawing.Size(75, 23);
            this.buttonCTextMPStat.TabIndex = 46;
            this.buttonCTextMPStat.Text = "Stat >>";
            this.buttonCTextMPStat.UseVisualStyleBackColor = true;
            this.buttonCTextMPStat.Click += new System.EventHandler(this.buttonCTextMPStat_Click);
            // 
            // buttonTextMPStat
            // 
            this.buttonTextMPStat.Location = new System.Drawing.Point(402, 321);
            this.buttonTextMPStat.Name = "buttonTextMPStat";
            this.buttonTextMPStat.Size = new System.Drawing.Size(75, 23);
            this.buttonTextMPStat.TabIndex = 45;
            this.buttonTextMPStat.Text = "<< Stat";
            this.buttonTextMPStat.UseVisualStyleBackColor = true;
            this.buttonTextMPStat.Click += new System.EventHandler(this.buttonTextMPStat_Click);
            // 
            // buttonSaveCTextMP
            // 
            this.buttonSaveCTextMP.Location = new System.Drawing.Point(578, 35);
            this.buttonSaveCTextMP.Name = "buttonSaveCTextMP";
            this.buttonSaveCTextMP.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveCTextMP.TabIndex = 44;
            this.buttonSaveCTextMP.Text = "Save";
            this.buttonSaveCTextMP.UseVisualStyleBackColor = true;
            this.buttonSaveCTextMP.Click += new System.EventHandler(this.buttonSaveCTextMP_Click);
            // 
            // buttonSaveTextMP
            // 
            this.buttonSaveTextMP.Location = new System.Drawing.Point(229, 35);
            this.buttonSaveTextMP.Name = "buttonSaveTextMP";
            this.buttonSaveTextMP.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveTextMP.TabIndex = 43;
            this.buttonSaveTextMP.Text = "Save";
            this.buttonSaveTextMP.UseVisualStyleBackColor = true;
            this.buttonSaveTextMP.Click += new System.EventHandler(this.buttonSaveTextMP_Click);
            // 
            // buttonOpenCTextMP
            // 
            this.buttonOpenCTextMP.Location = new System.Drawing.Point(696, 35);
            this.buttonOpenCTextMP.Name = "buttonOpenCTextMP";
            this.buttonOpenCTextMP.Size = new System.Drawing.Size(130, 23);
            this.buttonOpenCTextMP.TabIndex = 42;
            this.buttonOpenCTextMP.Text = "Open CodeText";
            this.buttonOpenCTextMP.UseVisualStyleBackColor = true;
            this.buttonOpenCTextMP.Click += new System.EventHandler(this.buttonOpenCTextMP_Click);
            // 
            // buttonOpenTextMP
            // 
            this.buttonOpenTextMP.Location = new System.Drawing.Point(60, 35);
            this.buttonOpenTextMP.Name = "buttonOpenTextMP";
            this.buttonOpenTextMP.Size = new System.Drawing.Size(124, 23);
            this.buttonOpenTextMP.TabIndex = 41;
            this.buttonOpenTextMP.Text = "Open Text";
            this.buttonOpenTextMP.UseVisualStyleBackColor = true;
            this.buttonOpenTextMP.Click += new System.EventHandler(this.buttonOpenTextMP_Click);
            // 
            // buttonDecodeMP
            // 
            this.buttonDecodeMP.Location = new System.Drawing.Point(402, 236);
            this.buttonDecodeMP.Name = "buttonDecodeMP";
            this.buttonDecodeMP.Size = new System.Drawing.Size(75, 23);
            this.buttonDecodeMP.TabIndex = 40;
            this.buttonDecodeMP.Text = "<<";
            this.buttonDecodeMP.UseVisualStyleBackColor = true;
            this.buttonDecodeMP.Click += new System.EventHandler(this.buttonDecodeMP_Click);
            // 
            // buttonCodeMP
            // 
            this.buttonCodeMP.Location = new System.Drawing.Point(402, 184);
            this.buttonCodeMP.Name = "buttonCodeMP";
            this.buttonCodeMP.Size = new System.Drawing.Size(75, 23);
            this.buttonCodeMP.TabIndex = 39;
            this.buttonCodeMP.Text = ">>";
            this.buttonCodeMP.UseVisualStyleBackColor = true;
            this.buttonCodeMP.Click += new System.EventHandler(this.buttonCodeMP_Click);
            // 
            // richTextBoxCMP
            // 
            this.richTextBoxCMP.Location = new System.Drawing.Point(500, 73);
            this.richTextBoxCMP.Name = "richTextBoxCMP";
            this.richTextBoxCMP.Size = new System.Drawing.Size(326, 357);
            this.richTextBoxCMP.TabIndex = 38;
            this.richTextBoxCMP.Text = "";
            // 
            // richTextBoxMP
            // 
            this.richTextBoxMP.Location = new System.Drawing.Point(61, 73);
            this.richTextBoxMP.Name = "richTextBoxMP";
            this.richTextBoxMP.Size = new System.Drawing.Size(322, 357);
            this.richTextBoxMP.TabIndex = 37;
            this.richTextBoxMP.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 489);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kNumericUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonStatR;
        private System.Windows.Forms.Button buttonStatL;
        private System.Windows.Forms.NumericUpDown kNumericUpDown;
        private System.Windows.Forms.Button buttonSaveCodeText;
        private System.Windows.Forms.Button buttonSaveText;
        private System.Windows.Forms.Button buttonOpenCodeText;
        private System.Windows.Forms.Button buttonOpenText;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Button buttonCode;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxKey2MP;
        private System.Windows.Forms.TextBox textBoxKey1MP;
        private System.Windows.Forms.Button buttonCTextMPStat;
        private System.Windows.Forms.Button buttonTextMPStat;
        private System.Windows.Forms.Button buttonSaveCTextMP;
        private System.Windows.Forms.Button buttonSaveTextMP;
        private System.Windows.Forms.Button buttonOpenCTextMP;
        private System.Windows.Forms.Button buttonOpenTextMP;
        private System.Windows.Forms.Button buttonDecodeMP;
        private System.Windows.Forms.Button buttonCodeMP;
        private System.Windows.Forms.RichTextBox richTextBoxCMP;
        private System.Windows.Forms.RichTextBox richTextBoxMP;
    }
}