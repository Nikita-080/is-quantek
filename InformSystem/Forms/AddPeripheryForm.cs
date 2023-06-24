﻿using InformSystem.dataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InformSystem.Forms
{
    public partial class AddPeripheryForm : Form
    {
        PnppkContext context = new PnppkContext();
        dataBase.Hardware hardware;
        int id;
        public AddPeripheryForm(int idPC)
        {
            InitializeComponent();
            IdTextBox.Enabled = true;
            id = idPC;
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                int Pc = context.Hardwares.Where(p => p.IdH == Convert.ToInt32(IdTextBox.Text)).First().TypeH;
                if (Pc != 1)
                {
                    hardware = context.Hardwares.Select(pc => pc).Where(pc => pc.IdH == Convert.ToInt32(IdTextBox.Text)).First();
                    hardware.Parent = id;
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Оборудование привязано", "Привязка", MessageBoxButtons.OK);
                    }
                }
                else MessageBox.Show("Вы не можете привязать системный блок", "Привязка", MessageBoxButtons.OK);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }
    }
}
