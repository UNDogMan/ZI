namespace Lab7
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
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBlockSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxByBlock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMsgCoded = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxColumnCount = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxErrBlockSize = new System.Windows.Forms.ComboBox();
            this.richTextBoxShiffMatrix = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxShuffed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBoxErrStr = new System.Windows.Forms.RichTextBox();
            this.richTextBoxShuffleMatrixOut = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxDesheffed = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxDecoded = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxIncome = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxOk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(76, 12);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(498, 22);
            this.textBoxMessage.TabIndex = 0;
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBoxMessage_TextChanged);
            this.textBoxMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMessage_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message";
            // 
            // comboBoxBlockSize
            // 
            this.comboBoxBlockSize.FormattingEnabled = true;
            this.comboBoxBlockSize.Location = new System.Drawing.Point(690, 8);
            this.comboBoxBlockSize.Name = "comboBoxBlockSize";
            this.comboBoxBlockSize.Size = new System.Drawing.Size(98, 24);
            this.comboBoxBlockSize.TabIndex = 2;
            this.comboBoxBlockSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxBlockSize_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Block Size";
            // 
            // textBoxByBlock
            // 
            this.textBoxByBlock.Location = new System.Drawing.Point(76, 41);
            this.textBoxByBlock.Name = "textBoxByBlock";
            this.textBoxByBlock.Size = new System.Drawing.Size(498, 22);
            this.textBoxByBlock.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "By blocks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Coded";
            // 
            // textBoxMsgCoded
            // 
            this.textBoxMsgCoded.Location = new System.Drawing.Point(76, 69);
            this.textBoxMsgCoded.Name = "textBoxMsgCoded";
            this.textBoxMsgCoded.Size = new System.Drawing.Size(498, 22);
            this.textBoxMsgCoded.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Column Count";
            // 
            // comboBoxColumnCount
            // 
            this.comboBoxColumnCount.FormattingEnabled = true;
            this.comboBoxColumnCount.Location = new System.Drawing.Point(690, 39);
            this.comboBoxColumnCount.Name = "comboBoxColumnCount";
            this.comboBoxColumnCount.Size = new System.Drawing.Size(98, 24);
            this.comboBoxColumnCount.TabIndex = 8;
            this.comboBoxColumnCount.SelectedIndexChanged += new System.EventHandler(this.comboBoxColumnCount_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(588, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Err Block Size";
            // 
            // comboBoxErrBlockSize
            // 
            this.comboBoxErrBlockSize.FormattingEnabled = true;
            this.comboBoxErrBlockSize.Location = new System.Drawing.Point(690, 69);
            this.comboBoxErrBlockSize.Name = "comboBoxErrBlockSize";
            this.comboBoxErrBlockSize.Size = new System.Drawing.Size(98, 24);
            this.comboBoxErrBlockSize.TabIndex = 10;
            this.comboBoxErrBlockSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxErrBlockSize_SelectedIndexChanged);
            // 
            // richTextBoxShiffMatrix
            // 
            this.richTextBoxShiffMatrix.Location = new System.Drawing.Point(14, 160);
            this.richTextBoxShiffMatrix.Name = "richTextBoxShiffMatrix";
            this.richTextBoxShiffMatrix.Size = new System.Drawing.Size(98, 259);
            this.richTextBoxShiffMatrix.TabIndex = 12;
            this.richTextBoxShiffMatrix.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Shiffile Matrix";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(641, 241);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Shuffed";
            // 
            // textBoxShuffed
            // 
            this.textBoxShuffed.Location = new System.Drawing.Point(300, 101);
            this.textBoxShuffed.Name = "textBoxShuffed";
            this.textBoxShuffed.Size = new System.Drawing.Size(488, 22);
            this.textBoxShuffed.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "With Error";
            // 
            // richTextBoxErrStr
            // 
            this.richTextBoxErrStr.Location = new System.Drawing.Point(300, 135);
            this.richTextBoxErrStr.Name = "richTextBoxErrStr";
            this.richTextBoxErrStr.Size = new System.Drawing.Size(488, 30);
            this.richTextBoxErrStr.TabIndex = 18;
            this.richTextBoxErrStr.Text = "";
            // 
            // richTextBoxShuffleMatrixOut
            // 
            this.richTextBoxShuffleMatrixOut.Location = new System.Drawing.Point(118, 160);
            this.richTextBoxShuffleMatrixOut.Name = "richTextBoxShuffleMatrixOut";
            this.richTextBoxShuffleMatrixOut.Size = new System.Drawing.Size(98, 259);
            this.richTextBoxShuffleMatrixOut.TabIndex = 19;
            this.richTextBoxShuffleMatrixOut.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "In";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Out";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(222, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "DeShuffed";
            // 
            // textBoxDesheffed
            // 
            this.textBoxDesheffed.Location = new System.Drawing.Point(300, 181);
            this.textBoxDesheffed.Name = "textBoxDesheffed";
            this.textBoxDesheffed.Size = new System.Drawing.Size(488, 22);
            this.textBoxDesheffed.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(222, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Decoded";
            // 
            // textBoxDecoded
            // 
            this.textBoxDecoded.Location = new System.Drawing.Point(300, 213);
            this.textBoxDecoded.Name = "textBoxDecoded";
            this.textBoxDecoded.Size = new System.Drawing.Size(488, 22);
            this.textBoxDecoded.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(222, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Income";
            // 
            // textBoxIncome
            // 
            this.textBoxIncome.Location = new System.Drawing.Point(300, 251);
            this.textBoxIncome.Name = "textBoxIncome";
            this.textBoxIncome.Size = new System.Drawing.Size(488, 22);
            this.textBoxIncome.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(222, 282);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 17);
            this.label15.TabIndex = 29;
            this.label15.Text = "Ok";
            // 
            // textBoxOk
            // 
            this.textBoxOk.Location = new System.Drawing.Point(300, 279);
            this.textBoxOk.Name = "textBoxOk";
            this.textBoxOk.Size = new System.Drawing.Size(488, 22);
            this.textBoxOk.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxOk);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxIncome);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxDecoded);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxDesheffed);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.richTextBoxShuffleMatrixOut);
            this.Controls.Add(this.richTextBoxErrStr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxShuffed);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBoxShiffMatrix);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxErrBlockSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxColumnCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMsgCoded);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxByBlock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxBlockSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBlockSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxByBlock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMsgCoded;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxColumnCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxErrBlockSize;
        private System.Windows.Forms.RichTextBox richTextBoxShiffMatrix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxShuffed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBoxErrStr;
        private System.Windows.Forms.RichTextBox richTextBoxShuffleMatrixOut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxDesheffed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxDecoded;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxIncome;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxOk;
    }
}

