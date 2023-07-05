using InformSystem.dataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformSystem.Forms
{
    public partial class Hardware : Form
    {
        private DataTable dataTable;

        public Hardware()
        {
            InitializeComponent();
            dataTable = CreateDataTable();
            LoadData();
            FillFilterPanel();
            databaseTable.Sort(databaseTable.Columns["Type"], ListSortDirection.Descending);
        }

        private DataTable CreateDataTable()
        {
            DataTable dT = new DataTable();
            for (int i = 0; i < databaseTable.Columns.Count; i++)
            {
                DataColumn dc = new DataColumn(databaseTable.Columns[i].HeaderText);
                databaseTable.Columns[i].DataPropertyName = dc.ColumnName;
                dT.Columns.Add(dc);

            }
            return dT;
        }

        private void LoadData()
        {
            try
            {
                using (PnppkContext context = new PnppkContext())
                {
                    var hw = from hardw in context.Hardwares
                             join person in context.Accesses on hardw.IdH equals person.HardwareA into phw
                             from p in phw.DefaultIfEmpty()
                             join place in context.Places on hardw.IdH equals place.HardwareP into plc
                             from pl in plc.DefaultIfEmpty()
                             join status in context.StatusDicts on hardw.Status equals status.IdS into st
                             from s in st.DefaultIfEmpty()
                             select new
                             {
                                 id = hardw.IdH,
                                 typeId = hardw.TypeH,
                                 type = hardw.TypeHNavigation.NameT,
                                 depart = (pl == null ? String.Empty : Convert.ToString(pl.Department.NameD)),
                                 Status = s.NameS,
                                 pers = (p == null ? String.Empty : Convert.ToString(p.Person)),
                                 placeBuilding = (pl == null ? String.Empty : Convert.ToString(pl.Building)),
                                 placeFloor = (pl == null ? String.Empty : Convert.ToString(pl.Floor)),
                                 placeOffice = (pl == null ? String.Empty : Convert.ToString(pl.Office))
                             };
                    dataTable.Clear();
                    dataTable.DefaultView.RowFilter = "";
                    foreach (var r in hw.ToList())
                    {
                        DataRow dr;
                        dr = dataTable.NewRow();
                        //dr.CreateCells(dataTable);
                        dr[0] = r.id;
                        dr[1] = r.type;
                        dr[2] = r.pers;
                        dr[3] = r.depart;
                        dr[4] = r.placeBuilding;
                        dr[5] = r.placeFloor;
                        dr[6] = r.placeOffice;
                        dr[7] = r.Status;
                        dr[8] = r.typeId;
                        dataTable.Rows.Add(dr);
                    }
                    databaseTable.DataSource = dataTable;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
                int id = Convert.ToInt32(dataGridViewRow.Cells[0].Value);
                int id_type = Convert.ToInt32(dataGridViewRow.Cells[8].Value);
                switch (id_type)
                {
                    case 1:
                        PCInformForm frm = new PCInformForm(id);
                        frm.ShowDialog();
                        break;
                    default:
                        PeripheryHWForm pfrm = new PeripheryHWForm(id);
                        pfrm.ShowDialog();
                        break;
                }
                LoadData();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            PeripheryHWForm frm = new PeripheryHWForm();
            frm.ShowDialog();
            LoadData();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (filterPanel.Visible)
            {
                filterPanel.Visible = false;
            }
            else
            {
                filterPanel.Visible = true;
            }
        }

        private void FillFilterPanel()
        {
            try
            {
                using (PnppkContext context = new PnppkContext())
                {
                    var depart = from t in context.DepartmentDicts
                                 where t.NameD != "склад"
                                 select t;
                    departmenTextBox.DataSource = depart.ToList();
                    departmenTextBox.DisplayMember = "NameD";
                    departmenTextBox.ValueMember = "IdDd";
                    departmenTextBox.SelectedIndex = -1;

                    var type = from t in context.HardwareTypes
                               select t;
                    HTypeTextBox.DataSource = type.ToList();
                    HTypeTextBox.DisplayMember = "NameT";
                    HTypeTextBox.ValueMember = "IdHt";
                    HTypeTextBox.SelectedIndex = -1;

                    var stat = from t in context.StatusDicts
                               select t;
                    HardStatusComboBox.DataSource = stat.ToList();
                    HardStatusComboBox.DisplayMember = "NameS";
                    HardStatusComboBox.ValueMember = "IdS";
                    HardStatusComboBox.SelectedIndex = -1;

                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            LoadData();
            HTypeTextBox.SelectedIndex = -1;
            HardStatusComboBox.SelectedIndex = -1;
            departmenTextBox.SelectedIndex = -1;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void acceptFiltButton_Click(object sender, EventArgs e)
        {
            useFilter();
        }

        private void useFilter()
        {
            try
            {
                dataTable.DefaultView.RowFilter = String.Format("Состояние LIKE '%{0}%' AND Тип LIKE '%{1}%' AND Отдел LIKE '%{2}%'", HardStatusComboBox.Text, HTypeTextBox.Text, departmenTextBox.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchForm sF = new SearchForm(dataTable);
            sF.Show();
        }
    }
}
