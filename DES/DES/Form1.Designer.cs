
namespace DES
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
            this.textBoxKey1 = new System.Windows.Forms.TextBox();
            this.richTextBoxBase = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCoded = new System.Windows.Forms.RichTextBox();
            this.buttonCrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textBoxKey2 = new System.Windows.Forms.TextBox();
            this.buttonGenKey1 = new System.Windows.Forms.Button();
            this.buttonGenKey2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelKey2 = new System.Windows.Forms.Label();
            this.labelKey1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxKey1
            // 
            this.textBoxKey1.Location = new System.Drawing.Point(115, 12);
            this.textBoxKey1.MaxLength = 7;
            this.textBoxKey1.Name = "textBoxKey1";
            this.textBoxKey1.Size = new System.Drawing.Size(100, 22);
            this.textBoxKey1.TabIndex = 0;
            // 
            // richTextBoxBase
            // 
            this.richTextBoxBase.Location = new System.Drawing.Point(13, 136);
            this.richTextBoxBase.Name = "richTextBoxBase";
            this.richTextBoxBase.Size = new System.Drawing.Size(331, 302);
            this.richTextBoxBase.TabIndex = 1;
            this.richTextBoxBase.Text = "";
            // 
            // richTextBoxCoded
            // 
            this.richTextBoxCoded.Location = new System.Drawing.Point(431, 136);
            this.richTextBoxCoded.Name = "richTextBoxCoded";
            this.richTextBoxCoded.Size = new System.Drawing.Size(357, 302);
            this.richTextBoxCoded.TabIndex = 2;
            this.richTextBoxCoded.Text = "";
            // 
            // buttonCrypt
            // 
            this.buttonCrypt.Location = new System.Drawing.Point(350, 228);
            this.buttonCrypt.Name = "buttonCrypt";
            this.buttonCrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonCrypt.TabIndex = 3;
            this.buttonCrypt.Text = ">>";
            this.buttonCrypt.UseVisualStyleBackColor = true;
            this.buttonCrypt.Click += new System.EventHandler(this.buttonCrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(350, 296);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonDecrypt.TabIndex = 4;
            this.buttonDecrypt.Text = "<<";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // textBoxKey2
            // 
            this.textBoxKey2.Location = new System.Drawing.Point(115, 40);
            this.textBoxKey2.MaxLength = 7;
            this.textBoxKey2.Name = "textBoxKey2";
            this.textBoxKey2.Size = new System.Drawing.Size(100, 22);
            this.textBoxKey2.TabIndex = 5;
            // 
            // buttonGenKey1
            // 
            this.buttonGenKey1.Location = new System.Drawing.Point(221, 12);
            this.buttonGenKey1.Name = "buttonGenKey1";
            this.buttonGenKey1.Size = new System.Drawing.Size(75, 23);
            this.buttonGenKey1.TabIndex = 6;
            this.buttonGenKey1.Text = "Gen";
            this.buttonGenKey1.UseVisualStyleBackColor = true;
            this.buttonGenKey1.Click += new System.EventHandler(this.buttonGenKey1_Click);
            // 
            // buttonGenKey2
            // 
            this.buttonGenKey2.Location = new System.Drawing.Point(221, 40);
            this.buttonGenKey2.Name = "buttonGenKey2";
            this.buttonGenKey2.Size = new System.Drawing.Size(75, 23);
            this.buttonGenKey2.TabIndex = 7;
            this.buttonGenKey2.Text = "Gen";
            this.buttonGenKey2.UseVisualStyleBackColor = true;
            this.buttonGenKey2.Click += new System.EventHandler(this.buttonGenKey2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Key1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Key2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Coded";
            // 
            // labelKey2
            // 
            this.labelKey2.AutoSize = true;
            this.labelKey2.Location = new System.Drawing.Point(347, 42);
            this.labelKey2.Name = "labelKey2";
            this.labelKey2.Size = new System.Drawing.Size(40, 17);
            this.labelKey2.TabIndex = 13;
            this.labelKey2.Text = "Key2";
            // 
            // labelKey1
            // 
            this.labelKey1.AutoSize = true;
            this.labelKey1.Location = new System.Drawing.Point(347, 17);
            this.labelKey1.Name = "labelKey1";
            this.labelKey1.Size = new System.Drawing.Size(40, 17);
            this.labelKey1.TabIndex = 12;
            this.labelKey1.Text = "Key1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelKey2);
            this.Controls.Add(this.labelKey1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGenKey2);
            this.Controls.Add(this.buttonGenKey1);
            this.Controls.Add(this.textBoxKey2);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonCrypt);
            this.Controls.Add(this.richTextBoxCoded);
            this.Controls.Add(this.richTextBoxBase);
            this.Controls.Add(this.textBoxKey1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKey1;
        private System.Windows.Forms.RichTextBox richTextBoxBase;
        private System.Windows.Forms.RichTextBox richTextBoxCoded;
        private System.Windows.Forms.Button buttonCrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxKey2;
        private System.Windows.Forms.Button buttonGenKey1;
        private System.Windows.Forms.Button buttonGenKey2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelKey2;
        private System.Windows.Forms.Label labelKey1;
    }
}

