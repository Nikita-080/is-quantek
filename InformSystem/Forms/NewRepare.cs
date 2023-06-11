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
    public partial class NewRepare : Form
    {
        PnppkContext context = new PnppkContext();
        public NewRepare()
        {
            InitializeComponent();
            docInUpDown.Controls[0].Visible = false;
            docOutUpDown.Controls[0].Visible = false;
            foreach (var item in context.Hardwares.Select(id => id.IdH))
                HwIdComboBox.Items.Add(item);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            Repair repair = new Repair();
            try
            {
                repair.HardwareR = Convert.ToInt32(HwIdComboBox.Text);
                repair.DateIn = dateInPicker.Value;
                repair.DateOut = dateOutPicker.Value;
                repair.DocumentIn = (int)docInUpDown.Value;
                repair.DocumentOut = (int)docOutUpDown.Value;
                repair.Reason = reasonTextBox.Text;
                repair.Verdict = verdictTextBox.Text;
                context.Repairs.Add(repair);
                context.SaveChanges();
                MessageBox.Show("Запись успешно добавлена");
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Ошибка {ex.Message}");
            }
            
        }
    }
}
