namespace RepairRequestsProject
{
    partial class RequestForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxNumberRequest = new System.Windows.Forms.TextBox();
            this.textBoxHomeTechType = new System.Windows.Forms.TextBox();
            this.textBoxHomeTechModel = new System.Windows.Forms.TextBox();
            this.richTextBoxProblemDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxNubmerClient = new System.Windows.Forms.TextBox();
            this.buttonRequestSave = new System.Windows.Forms.Button();
            this.buttonDeleteRequest = new System.Windows.Forms.Button();
            this.labelNumberRequest = new System.Windows.Forms.Label();
            this.labelHomeTechType = new System.Windows.Forms.Label();
            this.labelHomeTechModel = new System.Windows.Forms.Label();
            this.labelProblemDescription = new System.Windows.Forms.Label();
            this.labelNumberClient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNumberRequest
            // 
            this.textBoxNumberRequest.Location = new System.Drawing.Point(12, 28);
            this.textBoxNumberRequest.Name = "textBoxNumberRequest";
            this.textBoxNumberRequest.ReadOnly = true;
            this.textBoxNumberRequest.Size = new System.Drawing.Size(260, 20);
            this.textBoxNumberRequest.TabIndex = 0;
            // 
            // textBoxHomeTechType
            // 
            this.textBoxHomeTechType.Location = new System.Drawing.Point(12, 67);
            this.textBoxHomeTechType.Name = "textBoxHomeTechType";
            this.textBoxHomeTechType.Size = new System.Drawing.Size(260, 20);
            this.textBoxHomeTechType.TabIndex = 1;
            // 
            // textBoxHomeTechModel
            // 
            this.textBoxHomeTechModel.Location = new System.Drawing.Point(12, 106);
            this.textBoxHomeTechModel.Name = "textBoxHomeTechModel";
            this.textBoxHomeTechModel.Size = new System.Drawing.Size(260, 20);
            this.textBoxHomeTechModel.TabIndex = 2;
            // 
            // richTextBoxProblemDescription
            // 
            this.richTextBoxProblemDescription.Location = new System.Drawing.Point(12, 145);
            this.richTextBoxProblemDescription.Name = "richTextBoxProblemDescription";
            this.richTextBoxProblemDescription.Size = new System.Drawing.Size(260, 96);
            this.richTextBoxProblemDescription.TabIndex = 3;
            this.richTextBoxProblemDescription.Text = "";
            // 
            // textBoxNubmerClient
            // 
            this.textBoxNubmerClient.Location = new System.Drawing.Point(12, 267);
            this.textBoxNubmerClient.Name = "textBoxNubmerClient";
            this.textBoxNubmerClient.ReadOnly = true;
            this.textBoxNubmerClient.Size = new System.Drawing.Size(260, 20);
            this.textBoxNubmerClient.TabIndex = 4;
            // 
            // buttonRequestSave
            // 
            this.buttonRequestSave.Location = new System.Drawing.Point(12, 293);
            this.buttonRequestSave.Name = "buttonRequestSave";
            this.buttonRequestSave.Size = new System.Drawing.Size(125, 23);
            this.buttonRequestSave.TabIndex = 5;
            this.buttonRequestSave.Text = "Сохранить";
            this.buttonRequestSave.UseVisualStyleBackColor = true;
            this.buttonRequestSave.Click += new System.EventHandler(this.buttonRequestSave_Click);
            // 
            // buttonDeleteRequest
            // 
            this.buttonDeleteRequest.Location = new System.Drawing.Point(147, 293);
            this.buttonDeleteRequest.Name = "buttonDeleteRequest";
            this.buttonDeleteRequest.Size = new System.Drawing.Size(125, 23);
            this.buttonDeleteRequest.TabIndex = 6;
            this.buttonDeleteRequest.Text = " Удалить";
            this.buttonDeleteRequest.UseVisualStyleBackColor = true;
            this.buttonDeleteRequest.Click += new System.EventHandler(this.buttonDeleteRequest_Click);
            // 
            // labelNumberRequest
            // 
            this.labelNumberRequest.AutoSize = true;
            this.labelNumberRequest.Location = new System.Drawing.Point(12, 12);
            this.labelNumberRequest.Name = "labelNumberRequest";
            this.labelNumberRequest.Size = new System.Drawing.Size(83, 13);
            this.labelNumberRequest.TabIndex = 7;
            this.labelNumberRequest.Text = "Номер заявки:";
            // 
            // labelHomeTechType
            // 
            this.labelHomeTechType.AutoSize = true;
            this.labelHomeTechType.Location = new System.Drawing.Point(12, 51);
            this.labelHomeTechType.Name = "labelHomeTechType";
            this.labelHomeTechType.Size = new System.Drawing.Size(72, 13);
            this.labelHomeTechType.TabIndex = 8;
            this.labelHomeTechType.Text = "Тип техники:";
            // 
            // labelHomeTechModel
            // 
            this.labelHomeTechModel.AutoSize = true;
            this.labelHomeTechModel.Location = new System.Drawing.Point(12, 90);
            this.labelHomeTechModel.Name = "labelHomeTechModel";
            this.labelHomeTechModel.Size = new System.Drawing.Size(92, 13);
            this.labelHomeTechModel.TabIndex = 9;
            this.labelHomeTechModel.Text = "Модель техники:";
            // 
            // labelProblemDescription
            // 
            this.labelProblemDescription.AutoSize = true;
            this.labelProblemDescription.Location = new System.Drawing.Point(12, 129);
            this.labelProblemDescription.Name = "labelProblemDescription";
            this.labelProblemDescription.Size = new System.Drawing.Size(115, 13);
            this.labelProblemDescription.TabIndex = 10;
            this.labelProblemDescription.Text = "Описание проблемы:";
            // 
            // labelNumberClient
            // 
            this.labelNumberClient.AutoSize = true;
            this.labelNumberClient.Location = new System.Drawing.Point(12, 251);
            this.labelNumberClient.Name = "labelNumberClient";
            this.labelNumberClient.Size = new System.Drawing.Size(88, 13);
            this.labelNumberClient.TabIndex = 11;
            this.labelNumberClient.Text = "Номер клиента:";
            // 
            // RequestForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 328);
            this.Controls.Add(this.labelNumberClient);
            this.Controls.Add(this.labelProblemDescription);
            this.Controls.Add(this.labelHomeTechModel);
            this.Controls.Add(this.labelHomeTechType);
            this.Controls.Add(this.labelNumberRequest);
            this.Controls.Add(this.buttonDeleteRequest);
            this.Controls.Add(this.buttonRequestSave);
            this.Controls.Add(this.textBoxNubmerClient);
            this.Controls.Add(this.richTextBoxProblemDescription);
            this.Controls.Add(this.textBoxHomeTechModel);
            this.Controls.Add(this.textBoxHomeTechType);
            this.Controls.Add(this.textBoxNumberRequest);
            this.Name = "RequestForm";
            this.Text = "Информация о заявке";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxNumberRequest;
        private System.Windows.Forms.TextBox textBoxHomeTechType;
        private System.Windows.Forms.TextBox textBoxHomeTechModel;
        private System.Windows.Forms.RichTextBox richTextBoxProblemDescription;
        private System.Windows.Forms.TextBox textBoxNubmerClient;
        private System.Windows.Forms.Button buttonRequestSave;
        private System.Windows.Forms.Button buttonDeleteRequest; // Добавлено
        private System.Windows.Forms.Label labelNumberRequest;
        private System.Windows.Forms.Label labelHomeTechType;
        private System.Windows.Forms.Label labelHomeTechModel;
        private System.Windows.Forms.Label labelProblemDescription;
        private System.Windows.Forms.Label labelNumberClient;
    }
}
