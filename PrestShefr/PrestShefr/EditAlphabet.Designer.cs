namespace PrestShefr
{
    partial class EditAlphabet
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
            this.richTextBoxAlphabet = new System.Windows.Forms.RichTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxAlphabet
            // 
            this.richTextBoxAlphabet.Location = new System.Drawing.Point(13, 13);
            this.richTextBoxAlphabet.Name = "richTextBoxAlphabet";
            this.richTextBoxAlphabet.Size = new System.Drawing.Size(448, 121);
            this.richTextBoxAlphabet.TabIndex = 0;
            this.richTextBoxAlphabet.Text = "";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(57, 141);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(337, 140);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // EditAlphabet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 175);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.richTextBoxAlphabet);
            this.Name = "EditAlphabet";
            this.Text = "EditAlphabet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxAlphabet;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
    }
}