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
    public partial class PeripheryHWForm : Form
    {
        private dataBase.Hardware Per;

        private void LoadInfo(int id)
        {
            PnppkContext context = new PnppkContext();
            Per = context.Hardwares.Select(p => p).Where(p => p.IdH == id).Single();
            IdTextBox.Text = Per.IdH.ToString();
        }

        public PeripheryHWForm()
        {
            InitializeComponent();
        }

        public PeripheryHWForm(int id)
        {
            InitializeComponent();
            LoadInfo(id);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void changePlaceButton_Click(object sender, EventArgs e)
        {

        }
    }
}
