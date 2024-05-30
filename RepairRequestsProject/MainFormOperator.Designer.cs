namespace RepairRequestsProject
{
    partial class MainFormOperator
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
            this.dataGridViewRequestOperator = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxMaster = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonParts = new System.Windows.Forms.Button();
            this.buttonOpenRequestForm = new System.Windows.Forms.Button();
            this.buttonSaveMasterOrStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestOperator)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRequestOperator
            // 
            this.dataGridViewRequestOperator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequestOperator.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewRequestOperator.Name = "dataGridViewRequestOperator";
            this.dataGridViewRequestOperator.Size = new System.Drawing.Size(776, 197);
            this.dataGridViewRequestOperator.TabIndex = 9;
            this.dataGridViewRequestOperator.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRequestOperator_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заявки";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Новая заявка",
            "В процессе ремонта",
            "Готова к выдаче"});
            this.comboBoxStatus.Location = new System.Drawing.Point(12, 399);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(389, 21);
            this.comboBoxStatus.TabIndex = 2;
            // 
            // comboBoxMaster
            // 
            this.comboBoxMaster.FormattingEnabled = true;
            this.comboBoxMaster.Items.AddRange(new object[] {
            "",
            "2",
            "3",
            "6",
            "10"});
            this.comboBoxMaster.Location = new System.Drawing.Point(12, 360);
            this.comboBoxMaster.Name = "comboBoxMaster";
            this.comboBoxMaster.Size = new System.Drawing.Size(389, 21);
            this.comboBoxMaster.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Статус";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Мастер";
            // 
            // buttonParts
            // 
            this.buttonParts.Location = new System.Drawing.Point(489, 331);
            this.buttonParts.Name = "buttonParts";
            this.buttonParts.Size = new System.Drawing.Size(275, 23);
            this.buttonParts.TabIndex = 8;
            this.buttonParts.Text = "Заказать Запчасть";
            this.buttonParts.UseVisualStyleBackColor = true;
            this.buttonParts.Click += new System.EventHandler(this.buttonParts_Click);
            // 
            // buttonOpenRequestForm
            // 
            this.buttonOpenRequestForm.Location = new System.Drawing.Point(15, 279);
            this.buttonOpenRequestForm.Name = "buttonOpenRequestForm";
            this.buttonOpenRequestForm.Size = new System.Drawing.Size(150, 30);
            this.buttonOpenRequestForm.TabIndex = 1;
            this.buttonOpenRequestForm.Text = "Open Request Form";
            this.buttonOpenRequestForm.UseVisualStyleBackColor = true;
            this.buttonOpenRequestForm.Click += new System.EventHandler(this.buttonOpenRequestForm_Click);
            // 
            // buttonSaveMasterOrStatus
            // 
            this.buttonSaveMasterOrStatus.Location = new System.Drawing.Point(326, 331);
            this.buttonSaveMasterOrStatus.Name = "buttonSaveMasterOrStatus";
            this.buttonSaveMasterOrStatus.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveMasterOrStatus.TabIndex = 10;
            this.buttonSaveMasterOrStatus.Text = "Сохранить";
            this.buttonSaveMasterOrStatus.UseVisualStyleBackColor = true;
            this.buttonSaveMasterOrStatus.Click += new System.EventHandler(this.buttonSaveMasterOrStatus_Click);
            // 
            // MainFormOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaveMasterOrStatus);
            this.Controls.Add(this.buttonOpenRequestForm);
            this.Controls.Add(this.buttonParts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMaster);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewRequestOperator);
            this.Name = "MainFormOperator";
            this.Text = "MainFormOperator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestOperator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRequestOperator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxMaster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonParts;
        private System.Windows.Forms.Button buttonOpenRequestForm;
        private System.Windows.Forms.Button buttonSaveMasterOrStatus;
    }

}