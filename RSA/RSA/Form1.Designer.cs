
namespace RSA
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
            this.richTextBoxCoded = new System.Windows.Forms.RichTextBox();
            this.richTextBoxEncoded = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCode = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.buttonGen = new System.Windows.Forms.Button();
            this.buttonCode = new System.Windows.Forms.Button();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxCoded
            // 
            this.richTextBoxCoded.Location = new System.Drawing.Point(605, 53);
            this.richTextBoxCoded.Name = "richTextBoxCoded";
            this.richTextBoxCoded.Size = new System.Drawing.Size(219, 385);
            this.richTextBoxCoded.TabIndex = 0;
            this.richTextBoxCoded.Text = "";
            // 
            // richTextBoxEncoded
            // 
            this.richTextBoxEncoded.Location = new System.Drawing.Point(893, 53);
            this.richTextBoxEncoded.Name = "richTextBoxEncoded";
            this.richTextBoxEncoded.Size = new System.Drawing.Size(219, 385);
            this.richTextBoxEncoded.TabIndex = 1;
            this.richTextBoxEncoded.Text = "";
            // 
            // richTextBoxCode
            // 
            this.richTextBoxCode.Location = new System.Drawing.Point(301, 53);
            this.richTextBoxCode.Name = "richTextBoxCode";
            this.richTextBoxCode.Size = new System.Drawing.Size(219, 385);
            this.richTextBoxCode.TabIndex = 2;
            this.richTextBoxCode.Text = "";
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Location = new System.Drawing.Point(12, 53);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(219, 385);
            this.richTextBoxInfo.TabIndex = 3;
            this.richTextBoxInfo.Text = "";
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(12, 12);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(89, 23);
            this.buttonGen.TabIndex = 4;
            this.buttonGen.Text = "Generate";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // buttonCode
            // 
            this.buttonCode.Location = new System.Drawing.Point(526, 239);
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Size = new System.Drawing.Size(58, 23);
            this.buttonCode.TabIndex = 5;
            this.buttonCode.Text = ">>";
            this.buttonCode.UseVisualStyleBackColor = true;
            this.buttonCode.Click += new System.EventHandler(this.buttonCode_Click);
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(829, 239);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(58, 23);
            this.buttonEncode.TabIndex = 6;
            this.buttonEncode.Text = ">>";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 450);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.buttonCode);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.richTextBoxCode);
            this.Controls.Add(this.richTextBoxEncoded);
            this.Controls.Add(this.richTextBoxCoded);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxCoded;
        private System.Windows.Forms.RichTextBox richTextBoxEncoded;
        private System.Windows.Forms.RichTextBox richTextBoxCode;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.Button buttonCode;
        private System.Windows.Forms.Button buttonEncode;
    }
}

