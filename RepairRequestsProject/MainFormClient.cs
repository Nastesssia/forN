using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace RepairRequestsProject
{
    public partial class MainFormClient : Form
    {
        private int clientId;
        private int userId;

        public MainFormClient(int clientId)
        {
            InitializeComponent();
            this.clientId = clientId;
            LoadClientData();
            LoadClientRequests();
        }

        private void MainFormClient_Load(object sender, EventArgs e)
        {
            textBoxNumberClient.ReadOnly = true;
            textBoxFind.TextChanged += textBoxFind_TextChanged;
        }

        private void LoadClientData()
        {
            using (var context = new Model1())
            {
                var client = context.Clients
                    .Include("Users")
                    .FirstOrDefault(c => c.clientID == clientId);

                if (client != null)
                {
                    textBoxNumberClient.Text = client.clientID.ToString();
                    textBoxClientFIO.Text = client.clientName;
                    textBoxClientPhone.Text = client.clientPhone;
                    userId = client.userID;
                }
                else
                {
                    MessageBox.Show("Клиент не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        public void LoadClientRequests(string searchTerm = "")
        {
            using (var context = new Model1())
            {
                var requests = context.Requests
                    .Where(r => r.clientID == clientId)
                    .Where(r =>
                        r.requestID.ToString().Contains(searchTerm) ||
                        r.startDate.ToString().Contains(searchTerm) ||
                        r.homeTechType.Contains(searchTerm) ||
                        r.homeTechModel.Contains(searchTerm) ||
                        r.problemDescription.Contains(searchTerm) ||
                        r.requestStatus.Contains(searchTerm) ||
                        (r.completionDate != null && r.completionDate.ToString().Contains(searchTerm)))
                    .Select(r => new
                    {
                        r.requestID,
                        r.startDate,
                        r.homeTechType,
                        r.homeTechModel,
                        r.problemDescription,
                        r.requestStatus,
                        r.completionDate
                    }).ToList();

                RequestDataGridViewInfoForClient.DataSource = requests;
            }
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            LoadClientRequests(textBoxFind.Text);
        }

        private void buttonSaveInfoClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxClientFIO.Text) || string.IsNullOrWhiteSpace(textBoxClientPhone.Text))
            {
                MessageBox.Show("Поля ФИО и телефон не должны быть пустыми.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new Model1())
            {
                var client = context.Clients.FirstOrDefault(c => c.clientID == clientId);
                var user = context.Users.FirstOrDefault(u => u.userID == userId);

                if (client != null && user != null)
                {
                    client.clientName = textBoxClientFIO.Text;
                    client.clientPhone = textBoxClientPhone.Text;

                    user.fio = textBoxClientFIO.Text;
                    user.phone = textBoxClientPhone.Text;

                    try
                    {
                        context.SaveChanges();
                        MessageBox.Show("Информация успешно сохранена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Клиент не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RequestDataGridViewInfoForClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var requestId = (int)RequestDataGridViewInfoForClient.Rows[e.RowIndex].Cells["requestID"].Value;
                var requestForm = new RequestForm(requestId, clientId);
                requestForm.Show();
            }
        }

        private void buttonAddRequest_Click(object sender, EventArgs e)
        {
            var requestForm = new RequestForm(null, clientId); // Пустые поля и текущий clientId
            requestForm.Show();
        }

        private void AddRequest_Click(object sender, EventArgs e)
        {
            // Пустой метод, можно добавить логику по необходимости
        }

        private void textBoxFind_TextChanged_1(object sender, EventArgs e)
        {
            LoadClientRequests(textBoxFind.Text);
        }
    }
}
