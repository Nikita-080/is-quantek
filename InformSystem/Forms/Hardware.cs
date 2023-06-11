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
            using (PnppkContext context = new PnppkContext()) 
            {
                /*var hw = from hardw in context.Hardwares
                         join type in context.HardwareTypes on hardw.TypeH equals type.IdHt
                         join person in context.Accesses on hardw.IdH equals person.HardwareA
                         join place in context.Places on hardw.IdH equals place.HardwareP
                         select new
                         {
                             id = hardw.IdH,
                             typeId = type.IdHt,
                             type = type.NameT,
                             pers = person.Person,
                             placeBuilding = place.Building,
                             placeFloor = place.Floor,
                             placeOffice = place.Office
                         };*/
                var hw = from hardw in context.Hardwares
                         join type in context.HardwareTypes on hardw.TypeH equals type.IdHt
                         select new
                         {
                             id = hardw.IdH,
                             typeId = type.IdHt,
                             type = type.NameT,

                         };
                databaseTable.DataSource = hw.ToList();
                
            }
            
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

        private void addButton_Click(object sender, EventArgs e)
        {
            PeripheryHWForm frm = new PeripheryHWForm();
            frm.ShowDialog();
        }
    }
}
