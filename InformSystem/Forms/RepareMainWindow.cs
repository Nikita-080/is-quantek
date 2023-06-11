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
            databaseTable.DataSource = context.Repairs.ToList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            NewRepare newRepare = new NewRepare();
            newRepare.Show();
        }

        private void updateTableButton_Click(object sender, EventArgs e)
        {
            if(HwIdTextBox.Text != "Номер оборудования")
            {
                try
                {
                    databaseTable.DataSource = context.Repairs.Where(repair => repair.HardwareR == Convert.ToInt32(HwIdTextBox.Text)).ToList();
                    MessageBox.Show("Данные успешно обновлены");
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"Ошибка {ex.Message}");
                }
            }
            else
            {
                databaseTable.DataSource = context.Repairs.ToList();
                MessageBox.Show("Данные успешно обновлены");
            }
                
        }

        private void HwIdTextBox_Enter(object sender, EventArgs e)
        {
            if (HwIdTextBox.Text == "Номер оборудования")
            {
                HwIdTextBox.Text = "";
            }
        }

        private void HwIdTextBox_Leave(object sender, EventArgs e)
        {
            if (HwIdTextBox.Text == "")
            {
                HwIdTextBox.Text = "Номер оборудования";

            }
        }
    }
}
