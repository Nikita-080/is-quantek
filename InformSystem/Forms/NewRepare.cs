﻿using InformSystem.dataBase;
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
            try
            {
                foreach (var item in context.Hardwares.Where(item => item.Status == 1 || item.Status == 3).Select(id => id.IdH))
                    HwIdComboBox.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка \"{ex.Message}\"");
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            Repair repair = new Repair();
            try
            {
                dataBase.Hardware hardware = context.Hardwares.First(id => id.IdH == Convert.ToInt32(HwIdComboBox.Text));
                if (hardware.Status == 4)
                    throw new Exception("Already in repair");
                hardware.Status = 4;
                repair.HardwareR = Convert.ToInt32(HwIdComboBox.Text);
                repair.DateIn = dateInPicker.Value;
                repair.DocumentIn = (int)docInUpDown.Value;
                repair.Reason = reasonTextBox.Text;
                context.Repairs.Add(repair);
                context.SaveChanges();
                MessageBox.Show("Запись успешно добавлена");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка \"{ex.Message}\"");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
