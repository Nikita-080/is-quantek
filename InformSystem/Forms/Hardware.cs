using InformSystem.dataBase;
using Microsoft.EntityFrameworkCore;
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
    public partial class Hardware : Form
    {
        

        public Hardware()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            PnppkContext context = new PnppkContext();
            databaseTable.DataSource = context.Hardwares.ToList();
        }

        private void Hardware_Load(object sender, EventArgs e)
        {
            
        }

        private void databaseTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(databaseTable.SelectedCells.Count > 0)
            {
                int index = databaseTable.SelectedCells[0].RowIndex;
                DataGridViewRow dataGridViewRow = databaseTable.Rows[index];
                int id = Convert.ToInt32(dataGridViewRow.Cells[1].Value);
                if (id == 1)
                {
                    PCInformForm frm = new PCInformForm(id);
                    frm.ShowDialog();
                }
            }
        }
    }
}
