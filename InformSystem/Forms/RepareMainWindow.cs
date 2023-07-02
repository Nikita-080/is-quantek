using InformSystem.dataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformSystem.Forms
{
    public partial class RepareMainWindow : Form
    {
        PnppkContext context = new PnppkContext();
        public RepareMainWindow()
        {
            InitializeComponent();
            try
            {
                databaseTable.DataSource = context.Repairs.Where(repair => repair.DateOut == DateTime.MinValue || repair.DateOut == null).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка \"{ex.Message}\"");
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            NewRepare newRepare = new NewRepare();
            newRepare.Show();
        }

        private void updateTableButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Repair> repairList = new List<Repair>();
                if (RepairFilter.loadAll)
                    repairList = context.Repairs.ToList();
                else
                    repairList = context.Repairs.Where(repair => repair.DateOut == DateTime.MinValue || repair.DateOut == null).ToList();
                if (RepairFilter.useDateFrom)
                    repairList = repairList.Where(repair => repair.DateIn >= RepairFilter.dateFrom).ToList();
                if (RepairFilter.useDateTo)
                    repairList = repairList.Where(repair => repair.DateIn <= RepairFilter.dateTo).ToList();
                if (RepairFilter.useDateFromEnd)
                    repairList = repairList.Where(repair => repair.DateOut >= RepairFilter.dateFromEnd).ToList();
                if (RepairFilter.useDateToEnd)
                    repairList = repairList.Where(repair => repair.DateOut <= RepairFilter.dateToEnd).ToList();
                databaseTable.DataSource = repairList;
                MessageBox.Show("Данные успешно обновлены");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка \"{ex.Message}\"");
            }
        }

        private void closeRepairButton_Click(object sender, EventArgs e)
        {
            CloseRepair closeRepair = new CloseRepair();
            closeRepair.Show();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            RepairFilter filter = new RepairFilter();
            filter.Show();
        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            RepairFilter.loadAll = false;
            RepairFilter.useDateFrom = false;
            RepairFilter.useDateTo = false;
            RepairFilter.useDateFromEnd = false;
            RepairFilter.useDateToEnd = false;
        }
    }
}
