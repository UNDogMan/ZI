namespace Enigma
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textToEncypt = new System.Windows.Forms.RichTextBox();
            this.encryptedText = new System.Windows.Forms.RichTextBox();
            this.rRotList = new System.Windows.Forms.ComboBox();
            this.mRotList = new System.Windows.Forms.ComboBox();
            this.lRotList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button27 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textToEncypt
            // 
            this.textToEncypt.Location = new System.Drawing.Point(12, 106);
            this.textToEncypt.Name = "textToEncypt";
            this.textToEncypt.Size = new System.Drawing.Size(320, 174);
            this.textToEncypt.TabIndex = 0;
            this.textToEncypt.Text = "";
            this.textToEncypt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textToEncypt_KeyPress);
            // 
            // encryptedText
            // 
            this.encryptedText.Location = new System.Drawing.Point(338, 107);
            this.encryptedText.Name = "encryptedText";
            this.encryptedText.ReadOnly = true;
            this.encryptedText.Size = new System.Drawing.Size(335, 173);
            this.encryptedText.TabIndex = 1;
            this.encryptedText.Text = "";
            // 
            // rRotList
            // 
            this.rRotList.DropDownWidth = 10;
            this.rRotList.FormattingEnabled = true;
            this.rRotList.Location = new System.Drawing.Point(232, 30);
            this.rRotList.Name = "rRotList";
            this.rRotList.Size = new System.Drawing.Size(45, 24);
            this.rRotList.TabIndex = 3;
            // 
            // mRotList
            // 
            this.mRotList.DropDownWidth = 10;
            this.mRotList.FormattingEnabled = true;
            this.mRotList.Location = new System.Drawing.Point(152, 30);
            this.mRotList.Name = "mRotList";
            this.mRotList.Size = new System.Drawing.Size(48, 24);
            this.mRotList.TabIndex = 4;
            // 
            // lRotList
            // 
            this.lRotList.DropDownWidth = 10;
            this.lRotList.FormattingEnabled = true;
            this.lRotList.Location = new System.Drawing.Point(69, 30);
            this.lRotList.Name = "lRotList";
            this.lRotList.Size = new System.Drawing.Size(44, 24);
            this.lRotList.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "L";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Output Text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Input Text";
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(552, 22);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(121, 38);
            this.button27.TabIndex = 37;
            this.button27.Text = "Clear";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 292);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lRotList);
            this.Controls.Add(this.mRotList);
            this.Controls.Add(this.rRotList);
            this.Controls.Add(this.encryptedText);
            this.Controls.Add(this.textToEncypt);
            this.Name = "Form1";
            this.Text = "Enigma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textToEncypt;
        private System.Windows.Forms.RichTextBox encryptedText;
        private System.Windows.Forms.ComboBox rRotList;
        private System.Windows.Forms.ComboBox mRotList;
        private System.Windows.Forms.ComboBox lRotList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button27;
    }
}

