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
                var hw = from hardw in context.Hardwares
                         join person in context.Accesses on hardw.IdH equals person.HardwareA into phw
                         from p in phw.DefaultIfEmpty()
                         join place in context.Places on p.HardwareA equals place.HardwareP into plc
                         from pl in plc.DefaultIfEmpty()      
                         select new
                         {
                             id = hardw.IdH,
                             typeId = hardw.TypeH,
                             type = hardw.TypeHNavigation.NameT,
                             iswork = hardw.Iswork,
                             pers = (p == null ? String.Empty : Convert.ToString(p.Person)),
                             placeBuilding = (pl == null ? String.Empty : Convert.ToString(pl.Building)),
                             placeFloor = (pl == null ? String.Empty : Convert.ToString(pl.Floor)),
                             placeOffice = (pl == null ? String.Empty : Convert.ToString(pl.Office))
                         };
                foreach(var r in hw.ToList())
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    dr.CreateCells(databaseTable);
                    dr.Cells[0].Value = r.id;
                    dr.Cells[1].Value = r.type;
                    dr.Cells[2].Value = r.pers;
                    dr.Cells[3].Value = r.placeBuilding;
                    dr.Cells[4].Value = r.placeFloor;
                    dr.Cells[5].Value = r.placeOffice;
                    dr.Cells[6].Value = r.iswork;
                    dr.Cells[7].Value = r.typeId;
                    databaseTable.Rows.Add(dr);
                }
                
            }
            
        }

        private void Hardware_Load(object sender, EventArgs e)
        {
            
        }

        private void databaseTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (databaseTable.SelectedCells.Count > 0)
            {
                int index = databaseTable.SelectedCells[0].RowIndex;
                DataGridViewRow dataGridViewRow = databaseTable.Rows[index];
                int id = Convert.ToInt32(dataGridViewRow.Cells[7].Value);
                if (id == 1)
                {
                    PCInformForm frm = new PCInformForm(id);
                    frm.ShowDialog();
                }
                else if (id == 2 || id == 3)
                {
                    PeripheryHWForm frm = new PeripheryHWForm(id);
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
