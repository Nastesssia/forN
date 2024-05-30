namespace RepairRequestsProject
{
    partial class HelpFormForMaster
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
            this.richTextBoxHelp = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHelpSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxHelp
            // 
            this.richTextBoxHelp.Location = new System.Drawing.Point(37, 91);
            this.richTextBoxHelp.Name = "richTextBoxHelp";
            this.richTextBoxHelp.Size = new System.Drawing.Size(321, 256);
            this.richTextBoxHelp.TabIndex = 0;
            this.richTextBoxHelp.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Причина просьбы помощи";
            // 
            // buttonHelpSend
            // 
            this.buttonHelpSend.Location = new System.Drawing.Point(462, 324);
            this.buttonHelpSend.Name = "buttonHelpSend";
            this.buttonHelpSend.Size = new System.Drawing.Size(75, 23);
            this.buttonHelpSend.TabIndex = 2;
            this.buttonHelpSend.Text = "Отправить";
            this.buttonHelpSend.UseVisualStyleBackColor = true;
            this.buttonHelpSend.Click += new System.EventHandler(this.buttonHelpSend_Click_1);
            // 
            // HelpFormForMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelpSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxHelp);
            this.Name = "HelpFormForMaster";
            this.Text = "HelpFormForMaster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHelpSend;
    }
}