namespace Lab5
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGen = new System.Windows.Forms.Button();
            this.richTextBoxOut = new System.Windows.Forms.RichTextBox();
            this.comboBoxBounds = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxEW = new System.Windows.Forms.RichTextBox();
            this.comboBoxErrCount = new System.Windows.Forms.ComboBox();
            this.textBoxErrList = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.textBoxErrStr = new System.Windows.Forms.TextBox();
            this.richTextBoxIncome = new System.Windows.Forms.RichTextBox();
            this.textBoxOk = new System.Windows.Forms.TextBox();
            this.textBoxErr = new System.Windows.Forms.TextBox();
            this.textBoxNo = new System.Windows.Forms.TextBox();
            this.textBoxCh = new System.Windows.Forms.TextBox();
            this.textBoxChNew = new System.Windows.Forms.TextBox();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(65, 12);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(215, 22);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            this.textBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Word";
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(432, 13);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(97, 30);
            this.buttonGen.TabIndex = 3;
            this.buttonGen.Text = "Gen";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // richTextBoxOut
            // 
            this.richTextBoxOut.Location = new System.Drawing.Point(16, 49);
            this.richTextBoxOut.Name = "richTextBoxOut";
            this.richTextBoxOut.Size = new System.Drawing.Size(264, 182);
            this.richTextBoxOut.TabIndex = 4;
            this.richTextBoxOut.Text = "";
            // 
            // comboBoxBounds
            // 
            this.comboBoxBounds.FormattingEnabled = true;
            this.comboBoxBounds.Location = new System.Drawing.Point(303, 13);
            this.comboBoxBounds.Name = "comboBoxBounds";
            this.comboBoxBounds.Size = new System.Drawing.Size(105, 24);
            this.comboBoxBounds.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "ExtendedWord";
            // 
            // richTextBoxEW
            // 
            this.richTextBoxEW.Location = new System.Drawing.Point(303, 69);
            this.richTextBoxEW.Name = "richTextBoxEW";
            this.richTextBoxEW.Size = new System.Drawing.Size(294, 25);
            this.richTextBoxEW.TabIndex = 8;
            this.richTextBoxEW.Text = "";
            // 
            // comboBoxErrCount
            // 
            this.comboBoxErrCount.FormattingEnabled = true;
            this.comboBoxErrCount.Location = new System.Drawing.Point(299, 110);
            this.comboBoxErrCount.Name = "comboBoxErrCount";
            this.comboBoxErrCount.Size = new System.Drawing.Size(105, 24);
            this.comboBoxErrCount.TabIndex = 9;
            // 
            // textBoxErrList
            // 
            this.textBoxErrList.Location = new System.Drawing.Point(299, 153);
            this.textBoxErrList.Name = "textBoxErrList";
            this.textBoxErrList.Size = new System.Drawing.Size(298, 22);
            this.textBoxErrList.TabIndex = 10;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(502, 110);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 11;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(583, 111);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 12;
            this.buttonLast.Text = "Last";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(421, 110);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 13;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // textBoxErrStr
            // 
            this.textBoxErrStr.Location = new System.Drawing.Point(299, 181);
            this.textBoxErrStr.Name = "textBoxErrStr";
            this.textBoxErrStr.Size = new System.Drawing.Size(298, 22);
            this.textBoxErrStr.TabIndex = 14;
            // 
            // richTextBoxIncome
            // 
            this.richTextBoxIncome.Location = new System.Drawing.Point(16, 256);
            this.richTextBoxIncome.Name = "richTextBoxIncome";
            this.richTextBoxIncome.Size = new System.Drawing.Size(264, 182);
            this.richTextBoxIncome.TabIndex = 15;
            this.richTextBoxIncome.Text = "";
            // 
            // textBoxOk
            // 
            this.textBoxOk.Location = new System.Drawing.Point(665, 256);
            this.textBoxOk.Name = "textBoxOk";
            this.textBoxOk.Size = new System.Drawing.Size(100, 22);
            this.textBoxOk.TabIndex = 16;
            // 
            // textBoxErr
            // 
            this.textBoxErr.Location = new System.Drawing.Point(665, 295);
            this.textBoxErr.Name = "textBoxErr";
            this.textBoxErr.Size = new System.Drawing.Size(100, 22);
            this.textBoxErr.TabIndex = 17;
            // 
            // textBoxNo
            // 
            this.textBoxNo.Location = new System.Drawing.Point(665, 338);
            this.textBoxNo.Name = "textBoxNo";
            this.textBoxNo.Size = new System.Drawing.Size(100, 22);
            this.textBoxNo.TabIndex = 18;
            // 
            // textBoxCh
            // 
            this.textBoxCh.Location = new System.Drawing.Point(325, 255);
            this.textBoxCh.Name = "textBoxCh";
            this.textBoxCh.Size = new System.Drawing.Size(171, 22);
            this.textBoxCh.TabIndex = 19;
            // 
            // textBoxChNew
            // 
            this.textBoxChNew.Location = new System.Drawing.Point(325, 295);
            this.textBoxChNew.Name = "textBoxChNew";
            this.textBoxChNew.Size = new System.Drawing.Size(171, 22);
            this.textBoxChNew.TabIndex = 20;
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(325, 338);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(171, 22);
            this.textBoxS.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxS);
            this.Controls.Add(this.textBoxChNew);
            this.Controls.Add(this.textBoxCh);
            this.Controls.Add(this.textBoxNo);
            this.Controls.Add(this.textBoxErr);
            this.Controls.Add(this.textBoxOk);
            this.Controls.Add(this.richTextBoxIncome);
            this.Controls.Add(this.textBoxErrStr);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textBoxErrList);
            this.Controls.Add(this.comboBoxErrCount);
            this.Controls.Add(this.richTextBoxEW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxBounds);
            this.Controls.Add(this.richTextBoxOut);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.RichTextBox richTextBoxOut;
        private System.Windows.Forms.ComboBox comboBoxBounds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxEW;
        private System.Windows.Forms.ComboBox comboBoxErrCount;
        private System.Windows.Forms.TextBox textBoxErrList;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textBoxErrStr;
        private System.Windows.Forms.RichTextBox richTextBoxIncome;
        private System.Windows.Forms.TextBox textBoxOk;
        private System.Windows.Forms.TextBox textBoxErr;
        private System.Windows.Forms.TextBox textBoxNo;
        private System.Windows.Forms.TextBox textBoxCh;
        private System.Windows.Forms.TextBox textBoxChNew;
        private System.Windows.Forms.TextBox textBoxS;
    }
}

