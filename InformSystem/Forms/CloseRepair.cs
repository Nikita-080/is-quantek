using InformSystem.dataBase;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
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
    public partial class CloseRepair : Form
    {
        PnppkContext context = new PnppkContext();
        public CloseRepair()
        {
            InitializeComponent();
            docNumUpDown.Controls[0].Visible = false;
            try
            {
                foreach (var item in context.Repairs.Where(repair => repair.DateOut == DateTime.MinValue || repair.DateOut == null))
                    repairNumComboBox.Items.Add(item.IdR);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка \"{ex.Message}\"");
            }
        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                Repair repair = context.Repairs.First(rep => rep.IdR == Convert.ToInt32(repairNumComboBox.Text));
                dataBase.Hardware hardware = context.Hardwares.First(id => id.IdH == repair.HardwareR);
                Place place;
                if (checkBox1.Checked)
                {
                    hardware.Status = 2;
                    hardware.Parent = null;
                    place = context.Places.First(item => item.HardwareP == repair.HardwareR);
                    place.Data = dateClsoePicker.Value;
                    place.Floor = 0;
                    place.Office = 0;
                    place.Building = 0;
                    place.DepartmentId = 0;
                }
                else hardware.Status = 1;
                repair.Verdict = verdictTextBox.Text;
                repair.DateOut = dateClsoePicker.Value;
                repair.DocumentOut = (int)docNumUpDown.Value;
                context.SaveChanges();
                MessageBox.Show("Запись успешно добавлена");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка \"{ex.Message}\"");
            }
        }
    }
}
