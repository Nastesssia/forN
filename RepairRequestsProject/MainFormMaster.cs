using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace RepairRequestsProject
{
    public partial class MainFormMaster : Form
    {
        private Model1 dbContext;
        private int selectedRequestId;
        private int selectedMasterId;

        public MainFormMaster(int masterId)
        {
            InitializeComponent();
            dbContext = new Model1();
            selectedMasterId = masterId;
            LoadAllRequests();
        }

        private void MainFormMaster_Load(object sender, EventArgs e)
        {
            // Настройка обработчика события для ячеек DataGridView
            dataGridView1.CellClick += dataGridViewRequestMaster_CellClick;
            buttonSaveMessage.Click += buttonSaveMessage_Click;
        }

        private void LoadAllRequests()
        {
            try
            {
                var masterExists = dbContext.Masters.Any(m => m.masterID == selectedMasterId);
                if (!masterExists)
                {
                    MessageBox.Show("Мастер с данным ID не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var requests = dbContext.Requests
                    .Where(r => r.masterID == selectedMasterId)
                    .Select(r => new
                    {
                        r.requestID,
                        r.masterID,
                        r.homeTechType,
                        r.homeTechModel,
                        r.problemDescription,
                        Comment = r.MasterComments.FirstOrDefault(mc => mc.masterID == selectedMasterId).message
                    }).ToList();

                dataGridView1.DataSource = requests;

                if (requests.Count == 0)
                {
                    MessageBox.Show("Нет заявок для данного мастера.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Настраиваем отображение столбцов
                    dataGridView1.Columns["requestID"].HeaderText = "ID заявки";
                    dataGridView1.Columns["masterID"].HeaderText = "ID мастера";
                    dataGridView1.Columns["homeTechType"].HeaderText = "Тип техники";
                    dataGridView1.Columns["homeTechModel"].HeaderText = "Модель техники";
                    dataGridView1.Columns["problemDescription"].HeaderText = "Описание проблемы";
                    dataGridView1.Columns["Comment"].HeaderText = "Комментарий мастера";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке заявок: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewRequestMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    selectedRequestId = (int)dataGridView1.Rows[e.RowIndex].Cells["requestID"].Value;
                    var comment = dataGridView1.Rows[e.RowIndex].Cells["Comment"].Value?.ToString();
                    richTextBoxMaster.Text = comment;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при выборе заявки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSaveMessage_Click(object sender, EventArgs e)
        {
            if (selectedRequestId > 0)
            {
                try
                {
                    var masterComment = dbContext.MasterComments
                        .FirstOrDefault(mc => mc.requestID == selectedRequestId && mc.masterID == selectedMasterId);

                    if (masterComment == null)
                    {
                        masterComment = new MasterComments
                        {
                            requestID = selectedRequestId,
                            masterID = selectedMasterId,
                            message = richTextBoxMaster.Text
                        };
                        dbContext.MasterComments.Add(masterComment);
                    }
                    else
                    {
                        masterComment.message = richTextBoxMaster.Text;
                    }

                    dbContext.SaveChanges();
                    MessageBox.Show("Комментарий успешно сохранен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllRequests(); // Перезагрузка данных
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            MessageBox.Show($"Свойство: {validationError.PropertyName} Ошибка: {validationError.ErrorMessage}", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении комментария: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заявку из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelpText_Click(object sender, EventArgs e)
        {
            if (selectedRequestId > 0)
            {
                var helpForm = new HelpFormForMaster(selectedMasterId, selectedRequestId);
                helpForm.Show();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заявку из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
