
namespace Backpack
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
            this.textBoxI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGen = new System.Windows.Forms.Button();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.richTextBoxRaw = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCode = new System.Windows.Forms.RichTextBox();
            this.buttonCode = new System.Windows.Forms.Button();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.richTextBoxDecode = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxI
            // 
            this.textBoxI.Location = new System.Drawing.Point(29, 12);
            this.textBoxI.Name = "textBoxI";
            this.textBoxI.Size = new System.Drawing.Size(100, 22);
            this.textBoxI.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "I";
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(29, 54);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(100, 23);
            this.buttonGen.TabIndex = 2;
            this.buttonGen.Text = "Generate";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxInfo.Location = new System.Drawing.Point(4, 83);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(212, 355);
            this.richTextBoxInfo.TabIndex = 3;
            this.richTextBoxInfo.Text = "";
            // 
            // richTextBoxRaw
            // 
            this.richTextBoxRaw.Location = new System.Drawing.Point(260, 15);
            this.richTextBoxRaw.Name = "richTextBoxRaw";
            this.richTextBoxRaw.Size = new System.Drawing.Size(528, 109);
            this.richTextBoxRaw.TabIndex = 4;
            this.richTextBoxRaw.Text = "";
            // 
            // richTextBoxCode
            // 
            this.richTextBoxCode.Location = new System.Drawing.Point(260, 162);
            this.richTextBoxCode.Name = "richTextBoxCode";
            this.richTextBoxCode.Size = new System.Drawing.Size(528, 121);
            this.richTextBoxCode.TabIndex = 5;
            this.richTextBoxCode.Text = "";
            // 
            // buttonCode
            // 
            this.buttonCode.Location = new System.Drawing.Point(404, 131);
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Size = new System.Drawing.Size(75, 23);
            this.buttonCode.TabIndex = 6;
            this.buttonCode.Text = "Code";
            this.buttonCode.UseVisualStyleBackColor = true;
            this.buttonCode.Click += new System.EventHandler(this.buttonCode_Click);
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(404, 289);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonEncode.TabIndex = 7;
            this.buttonEncode.Text = "Encode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // richTextBoxDecode
            // 
            this.richTextBoxDecode.Location = new System.Drawing.Point(260, 317);
            this.richTextBoxDecode.Name = "richTextBoxDecode";
            this.richTextBoxDecode.Size = new System.Drawing.Size(528, 121);
            this.richTextBoxDecode.TabIndex = 8;
            this.richTextBoxDecode.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxDecode);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.buttonCode);
            this.Controls.Add(this.richTextBoxCode);
            this.Controls.Add(this.richTextBoxRaw);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.RichTextBox richTextBoxRaw;
        private System.Windows.Forms.RichTextBox richTextBoxCode;
        private System.Windows.Forms.Button buttonCode;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.RichTextBox richTextBoxDecode;
    }
}

