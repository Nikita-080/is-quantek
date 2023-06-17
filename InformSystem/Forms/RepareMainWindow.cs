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
                databaseTable.DataSource = context.Repairs.Where(repair => repair.DateOut == DateTime.MinValue || repair.DateOut == null).ToList();
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
    }
}
