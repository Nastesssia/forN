namespace RepairRequestsProject
{
    partial class MainFormClient
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
            this.textBoxNumberClient = new System.Windows.Forms.TextBox();
            this.textBoxClientFIO = new System.Windows.Forms.TextBox();
            this.textBoxClientPhone = new System.Windows.Forms.TextBox();
            this.buttonSaveInfoClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RequestDataGridViewInfoForClient = new System.Windows.Forms.DataGridView();
            this.buttonAddRequest = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RequestDataGridViewInfoForClient)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNumberClient
            // 
            this.textBoxNumberClient.Location = new System.Drawing.Point(65, 44);
            this.textBoxNumberClient.Name = "textBoxNumberClient";
            this.textBoxNumberClient.ReadOnly = true;
            this.textBoxNumberClient.Size = new System.Drawing.Size(61, 20);
            this.textBoxNumberClient.TabIndex = 0;
            // 
            // textBoxClientFIO
            // 
            this.textBoxClientFIO.Location = new System.Drawing.Point(14, 103);
            this.textBoxClientFIO.Name = "textBoxClientFIO";
            this.textBoxClientFIO.Size = new System.Drawing.Size(233, 20);
            this.textBoxClientFIO.TabIndex = 1;
            // 
            // textBoxClientPhone
            // 
            this.textBoxClientPhone.Location = new System.Drawing.Point(14, 171);
            this.textBoxClientPhone.Name = "textBoxClientPhone";
            this.textBoxClientPhone.Size = new System.Drawing.Size(233, 20);
            this.textBoxClientPhone.TabIndex = 2;
            // 
            // buttonSaveInfoClient
            // 
            this.buttonSaveInfoClient.Location = new System.Drawing.Point(65, 262);
            this.buttonSaveInfoClient.Name = "buttonSaveInfoClient";
            this.buttonSaveInfoClient.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveInfoClient.TabIndex = 3;
            this.buttonSaveInfoClient.Text = "Сохранить";
            this.buttonSaveInfoClient.UseVisualStyleBackColor = true;
            this.buttonSaveInfoClient.Click += new System.EventHandler(this.buttonSaveInfoClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Телефон";
            // 
            // RequestDataGridViewInfoForClient
            // 
            this.RequestDataGridViewInfoForClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequestDataGridViewInfoForClient.Location = new System.Drawing.Point(277, 41);
            this.RequestDataGridViewInfoForClient.Name = "RequestDataGridViewInfoForClient";
            this.RequestDataGridViewInfoForClient.Size = new System.Drawing.Size(746, 150);
            this.RequestDataGridViewInfoForClient.TabIndex = 7;
            this.RequestDataGridViewInfoForClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RequestDataGridViewInfoForClient_CellClick);
            // 
            // buttonAddRequest
            // 
            this.buttonAddRequest.Location = new System.Drawing.Point(446, 262);
            this.buttonAddRequest.Name = "buttonAddRequest";
            this.buttonAddRequest.Size = new System.Drawing.Size(123, 23);
            this.buttonAddRequest.TabIndex = 8;
            this.buttonAddRequest.Text = "Добавить заявку";
            this.buttonAddRequest.UseVisualStyleBackColor = true;
            this.buttonAddRequest.Click += new System.EventHandler(this.buttonAddRequest_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(287, 218);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(666, 20);
            this.textBoxFind.TabIndex = 9;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Поиск";
            // 
            // MainFormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 317);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.buttonAddRequest);
            this.Controls.Add(this.RequestDataGridViewInfoForClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveInfoClient);
            this.Controls.Add(this.textBoxClientPhone);
            this.Controls.Add(this.textBoxClientFIO);
            this.Controls.Add(this.textBoxNumberClient);
            this.Name = "MainFormClient";
            this.Text = "MainFormClient";
            ((System.ComponentModel.ISupportInitialize)(this.RequestDataGridViewInfoForClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumberClient;
        private System.Windows.Forms.TextBox textBoxClientFIO;
        private System.Windows.Forms.TextBox textBoxClientPhone;
        private System.Windows.Forms.Button buttonSaveInfoClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView RequestDataGridViewInfoForClient;
        private System.Windows.Forms.Button buttonAddRequest;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label label4;
    }
}
