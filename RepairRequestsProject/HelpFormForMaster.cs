using System;
using System.Linq;
using System.Windows.Forms;

namespace RepairRequestsProject
{
    public partial class HelpFormForMaster : Form
    {
        private int masterID;
        private int requestID;

        public HelpFormForMaster(int masterId, int requestId)
        {
            InitializeComponent();
            this.masterID = masterId;
            this.requestID = requestId;
        }

        private void buttonHelpSend_Click_1(object sender, EventArgs e)
        {
            using (var context = new Model1())
            {
                var manager = context.Managers.FirstOrDefault(); // Выбираем первого менеджера (либо измените логику выбора менеджера)
                if (manager != null)
                {
                    var helpRequest = new MasterQualityManager
                    {
                        masterID = masterID,
                        managerID = manager.managerID,
                        requestID = requestID,
                        appealReason = richTextBoxHelp.Text,
                        appealDate = DateTime.Now
                    };


                    try
                    {
                        context.SaveChanges();
                        MessageBox.Show("Запрос помощи успешно отправлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при отправке запроса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Менеджер не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
