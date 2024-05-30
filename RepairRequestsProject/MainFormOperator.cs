using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace RepairRequestsProject
{
    public partial class MainFormOperator : Form
    {
        private Model1 dbContext;
        private int selectedRequestId;
        private int selectedMasterId;

        public MainFormOperator()
        {
            InitializeComponent();
            dbContext = new Model1();
            LoadAllRequests();
        }

        private void LoadAllRequests()
        {
            var requests = dbContext.Requests
                .Select(r => new
                {
                    r.requestID,
                    r.startDate,
                    r.homeTechType,
                    r.homeTechModel,
                    r.problemDescription,
                    r.requestStatus,
                    r.completionDate,
                    ClientName = r.Clients.clientName,
                    r.masterID,
                    r.repairParts // Добавляем запчасти
                }).ToList();

            dataGridViewRequestOperator.DataSource = requests;

            // Настраиваем отображение столбцов
            dataGridViewRequestOperator.Columns["requestID"].HeaderText = "ID заявки";
            dataGridViewRequestOperator.Columns["startDate"].HeaderText = "Дата начала";
            dataGridViewRequestOperator.Columns["homeTechType"].HeaderText = "Тип техники";
            dataGridViewRequestOperator.Columns["homeTechModel"].HeaderText = "Модель техники";
            dataGridViewRequestOperator.Columns["problemDescription"].HeaderText = "Описание проблемы";
            dataGridViewRequestOperator.Columns["requestStatus"].HeaderText = "Статус заявки";
            dataGridViewRequestOperator.Columns["completionDate"].HeaderText = "Дата завершения";
            dataGridViewRequestOperator.Columns["ClientName"].HeaderText = "Имя клиента";
            dataGridViewRequestOperator.Columns["masterID"].HeaderText = "ID мастера";
            dataGridViewRequestOperator.Columns["repairParts"].HeaderText = "Запчасти"; // Отображаем запчасти
        }

        private void dataGridViewRequestOperator_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRequestId = (int)dataGridViewRequestOperator.Rows[e.RowIndex].Cells["requestID"].Value;
                selectedMasterId = dataGridViewRequestOperator.Rows[e.RowIndex].Cells["masterID"].Value != null ? (int)dataGridViewRequestOperator.Rows[e.RowIndex].Cells["masterID"].Value : 0;

                var selectedStatus = dataGridViewRequestOperator.Rows[e.RowIndex].Cells["requestStatus"].Value.ToString();
                comboBoxStatus.SelectedItem = selectedStatus;

                var selectedMaster = dataGridViewRequestOperator.Rows[e.RowIndex].Cells["masterID"].Value;
                comboBoxMaster.SelectedItem = selectedMaster?.ToString();
            }
        }

        private void buttonOpenRequestForm_Click(object sender, EventArgs e)
        {
            if (selectedRequestId > 0)
            {
                var requestForm = new RequestForm(selectedRequestId, selectedMasterId);
                requestForm.Show();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заявку из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainFormOperator_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Освобождение ресурсов контекста базы данных при закрытии формы
            dbContext.Dispose();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedRequestId > 0)
            {
                var request = dbContext.Requests.Find(selectedRequestId);
                if (request != null)
                {
                    request.requestStatus = comboBoxStatus.SelectedItem.ToString();
                }
            }
        }

        private void comboBoxMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedRequestId > 0)
            {
                var request = dbContext.Requests.Find(selectedRequestId);
                if (request != null)
                {
                    if (string.IsNullOrEmpty(comboBoxMaster.SelectedItem?.ToString()))
                    {
                        request.masterID = null; // Устанавливаем значение null для masterID
                    }
                    else
                    {
                        request.masterID = int.Parse(comboBoxMaster.SelectedItem.ToString());
                    }
                }
            }
        }

        private void buttonSaveMasterOrStatus_Click(object sender, EventArgs e)
        {
            if (selectedRequestId > 0)
            {
                var request = dbContext.Requests.Find(selectedRequestId);
                if (request != null)
                {
                    request.requestStatus = comboBoxStatus.SelectedItem?.ToString();
                    request.masterID = string.IsNullOrEmpty(comboBoxMaster.SelectedItem?.ToString()) ? (int?)null : int.Parse(comboBoxMaster.SelectedItem.ToString());

                    try
                    {
                        dbContext.SaveChanges();
                        MessageBox.Show("Данные успешно сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllRequests(); // Перезагрузка данных
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заявку из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonParts_Click(object sender, EventArgs e)
        {
            if (selectedRequestId > 0)
            {
                var partsOrdersForm = new PartsOrdersForm(selectedRequestId);
                partsOrdersForm.Show();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заявку из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
