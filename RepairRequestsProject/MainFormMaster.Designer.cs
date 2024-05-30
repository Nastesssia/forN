namespace RepairRequestsProject
{
    partial class MainFormMaster
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
            this.buttonSaveMessage = new System.Windows.Forms.Button();
            this.richTextBoxMaster = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonHelpText = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Комментарий";
            // 
            // buttonSaveMessage
            // 
            this.buttonSaveMessage.Location = new System.Drawing.Point(22, 187);
            this.buttonSaveMessage.Name = "buttonSaveMessage";
            this.buttonSaveMessage.Size = new System.Drawing.Size(150, 30);
            this.buttonSaveMessage.TabIndex = 2;
            this.buttonSaveMessage.Text = "Сохранить комментарий";
            this.buttonSaveMessage.UseVisualStyleBackColor = true;
            this.buttonSaveMessage.Click += new System.EventHandler(this.buttonSaveMessage_Click);
            // 
            // richTextBoxMaster
            // 
            this.richTextBoxMaster.Location = new System.Drawing.Point(12, 53);
            this.richTextBoxMaster.Name = "richTextBoxMaster";
            this.richTextBoxMaster.Size = new System.Drawing.Size(171, 100);
            this.richTextBoxMaster.TabIndex = 1;
            this.richTextBoxMaster.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Заявки";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 412);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Запросить запчасть";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Заказать запчасть";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonHelpText
            // 
            this.buttonHelpText.Location = new System.Drawing.Point(438, 254);
            this.buttonHelpText.Name = "buttonHelpText";
            this.buttonHelpText.Size = new System.Drawing.Size(209, 23);
            this.buttonHelpText.TabIndex = 12;
            this.buttonHelpText.Text = "Попросить помощи";
            this.buttonHelpText.UseVisualStyleBackColor = true;
            this.buttonHelpText.Click += new System.EventHandler(this.buttonHelpText_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(265, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(511, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRequestMaster_CellClick);
            // 
            // MainFormMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonHelpText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxMaster);
            this.Controls.Add(this.buttonSaveMessage);
            this.Controls.Add(this.label1);
            this.Name = "MainFormMaster";
            this.Text = "MainFormMaster";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveMessage;
        private System.Windows.Forms.RichTextBox richTextBoxMaster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonHelpText;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}