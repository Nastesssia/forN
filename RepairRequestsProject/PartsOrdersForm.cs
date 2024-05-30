using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace RepairRequestsProject
{
    public partial class PartsOrdersForm : Form
    {
        private Model1 dbContext;
        private int requestId;

        public PartsOrdersForm(int requestId)
        {
            InitializeComponent();
            this.requestId = requestId;
            dbContext = new Model1();
            LoadParts();
        }

        private void LoadParts()
        {
            var parts = dbContext.PartsOrders
                .Where(po => po.requestID == requestId)
                .Select(po => new
                {
                    po.Parts.partID,
                    po.Parts.partsName,
                    po.Parts.partsDescription,
                    po.quantity,
                    po.Parts.price
                }).ToList();

            dataGridViewParts.DataSource = parts;

            // Настраиваем отображение столбцов
            dataGridViewParts.Columns["partID"].HeaderText = "ID запчасти";
            dataGridViewParts.Columns["partsName"].HeaderText = "Название запчасти";
            dataGridViewParts.Columns["partsDescription"].HeaderText = "Описание запчасти";
            dataGridViewParts.Columns["quantity"].HeaderText = "Количество";
            dataGridViewParts.Columns["price"].HeaderText = "Цена";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            dbContext.Dispose();
            base.OnFormClosing(e);
        }
    }
}
