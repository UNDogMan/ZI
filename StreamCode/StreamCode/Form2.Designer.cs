
namespace StreamCode
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.buttonGen = new System.Windows.Forms.Button();
            this.labelGen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKey.Location = new System.Drawing.Point(52, 23);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(720, 22);
            this.textBoxKey.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(321, 283);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(449, 51);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(323, 283);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(350, 182);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonEncode.TabIndex = 4;
            this.buttonEncode.Text = ">>";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(352, 224);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonDecode.TabIndex = 5;
            this.buttonDecode.Text = "<<";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(339, 64);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(102, 23);
            this.buttonGen.TabIndex = 6;
            this.buttonGen.Text = "Generate";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // labelGen
            // 
            this.labelGen.AutoSize = true;
            this.labelGen.Location = new System.Drawing.Point(374, 90);
            this.labelGen.Name = "labelGen";
            this.labelGen.Size = new System.Drawing.Size(26, 17);
            this.labelGen.TabIndex = 7;
            this.labelGen.Text = "No";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 346);
            this.Controls.Add(this.labelGen);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "RC4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.Label labelGen;
    }
}