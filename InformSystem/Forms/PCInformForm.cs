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
    public partial class PCInformForm : Form
    {
        int id_PC;
        int building;
        int floor;
        int office;
        private dataBase.Hardware PC;
        private dataBase.Place place;
        private dataBase.Access access;

        private void LoadService()
        {
            try
            {
                using(PnppkContext context = new PnppkContext())
                {
                    var repair = from rep in context.Repairs
                                 where rep.HardwareR == id_PC
                                 select new
                                 {
                                     dateIn = rep.DateIn,
                                     dateOut = rep.DateOut,
                                     reason = rep.Reason,
                                     verd = rep.Verdict
                                 };
                    foreach(var r in repair)
                    {
                        DataGridViewRow dr = new DataGridViewRow();
                        dr.CreateCells(dataGridViewServisHistory);
                        dr.Cells[0].Value = r.dateIn;
                        dr.Cells[1].Value = r.dateOut;
                        dr.Cells[2].Value = r.reason;
                        dr.Cells[3].Value = r.verd;
                        dataGridViewServisHistory.Rows.Add(dr);
                    }

                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void LoadConnectedHW()
        {
            try
            {
                dataGridViewConnectedHW.Rows.Clear();
                using(PnppkContext context = new PnppkContext())
                {
                    var connectedHW = from c in context.Hardwares
                                      where c.Parent == id_PC
                                      join t in context.HardwareTypes on c.TypeH equals t.IdHt into ct
                                      from tc in ct.DefaultIfEmpty()
                                      select new
                                      {
                                          id = c.IdH,
                                          type = tc.NameT
                                      };
                    if(connectedHW != null)
                    {
                        foreach (var c in connectedHW.ToList())
                        {
                            DataGridViewRow dr = new DataGridViewRow();
                            dr.CreateCells(dataGridViewConnectedHW);
                            dr.Cells[0].Value = c.id;
                            dr.Cells[1].Value = c.type;
                            dataGridViewConnectedHW.Rows.Add(dr);
                        }
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void FillComboBox()
        {
            using (PnppkContext context = new PnppkContext())
            {
                var depart = from t in context.DepartmentDicts
                             select t;
                departmenTextBox.DataSource = depart.ToList();
                departmenTextBox.DisplayMember = "NameD";
                departmenTextBox.ValueMember = "IdDd";
            }
        }

        private void LoadPCInfo(int id)
        {
            id_PC = id;
            try
            {
                PnppkContext context = new PnppkContext();
                PC = context.Hardwares.Select(pc => pc).Where(pc => pc.IdH == id).First();
                place = context.Places.Select(p => p).Where(p => p.HardwareP == id).FirstOrDefault();
                access = context.Accesses.Select(pers => pers).Where(pers => pers.HardwareA == id).FirstOrDefault();
                IdTextBox.Text = PC.IdH.ToString();
                HTypeTextBox.Text = "Компьютер";
                if (place != null)
                {
                    PlaceTextBox.Text = "Здание " + place.Building + ", " + "этаж " + place.Floor + ", " + "офис " + place.Office;
                    int idD = place.DepartmentId;
                    dataBase.DepartmentDict department = context.DepartmentDicts.Select(d => d).Where(d => d.IdDd == idD).FirstOrDefault();
                    departmenTextBox.Text = department.NameD;
                }
                if (access != null)
                {
                    PersonTextBox.Text = access.Person.ToString();
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public PCInformForm(int idPC)
        {
            InitializeComponent();
            ActiveElementsChange();
            FillComboBox();
            LoadPCInfo(idPC);
            LoadConnectedHW();
            LoadService();
            ConfigLoad(idPC);


        }
        private void ActiveElementsChange()
        {
            HTypeTextBox.Enabled = false;
            PlaceTextBox.Enabled = true;
            PersonTextBox.Enabled = true;
            departmenTextBox.Enabled = true;
        }
        private void ConfigLoad(int id)
        {
            try
            {
                using (PnppkContext context = new PnppkContext())
                {
                    var config = from hardw in context.HardwareValues
                                 join prop in context.HardwareProperties on hardw.Property equals prop.IdHp
                                 where hardw.HardwareV == id
                                 orderby hardw.Property
                                 select new
                                 {
                                     name = prop.NameP,
                                     value = hardw.Value
                                 };
                    var disk = from d in context.Disks
                               where d.HardwareD == id
                               select new
                               {
                                   name = "Диск",
                                   value = d.Size + "GB " + d.Creator + " " + d.Model + " (" + d.Type + ")"
                               };
                    //dataGridViewPcInfo.DataSource = config.ToList();
                    foreach (var c in config.ToList())
                    {
                        DataGridViewRow dr = new DataGridViewRow();
                        dr.CreateCells(dataGridViewPcInfo);
                        dr.Cells[0].Value = c.name;
                        dr.Cells[1].Value = c.value;
                        dataGridViewPcInfo.Rows.Add(dr);
                    }
                    foreach (var d in disk.ToList())
                    {
                        DataGridViewRow dr = new DataGridViewRow();
                        dr.CreateCells(dataGridViewPcInfo);
                        dr.Cells[0].Value = d.name;
                        dr.Cells[1].Value = d.value;
                        dataGridViewPcInfo.Rows.Add(dr);
                    }



                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PCInformForm_Load(object sender, EventArgs e)
        {

        }

        private void editPlaceButton_Click(object sender, EventArgs e)
        {
            ChangePlaceForm placeC = new ChangePlaceForm();
            placeC.ShowDialog();
            if (placeC.Save) //if click save button
            {
                building = Convert.ToInt32(placeC.Building);
                floor = Convert.ToInt32(placeC.Floor);
                office = Convert.ToInt32(placeC.Office);
                PlaceTextBox.Text = "Здание " + placeC.Building + ", " + "этаж " + placeC.Floor + ", " + "офис " + placeC.Office;
            }
        }

        private void editPersonButton_Click(object sender, EventArgs e)
        {
            //ChangePersonForm person = new ChangePersonForm();
            //person.ShowDialog();
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            //TODO Сохранение данных системного блока оборудования
            PnppkContext context = new PnppkContext();
            place = context.Places.Select(h => h).Where(h => h.HardwareP == id_PC).First();
            place.Building = building;
            place.Floor = floor;
            place.Office = office;
            access = context.Accesses.Where(a => a.HardwareA == id_PC).First();
            access.Person = Convert.ToInt32(PersonTextBox.Text);
            context.SaveChanges();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddPeripheryForm periphery = new AddPeripheryForm(PC.IdH);
            if (periphery.ShowDialog() == DialogResult.Cancel)
            {
                LoadConnectedHW();
                this.Refresh();
            }

        }
        





        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Отвязать выбранное оборудование?", "Отвязка", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (PnppkContext context = new PnppkContext())
                    {
                        if (dataGridViewConnectedHW.SelectedRows.Count > 0)
                        {
                            var r = this.dataGridViewConnectedHW.SelectedRows;
                            for (int i = 0; i < r.Count; i++)
                            {
                                if (r[i].Cells[0].Value != null)
                                {
                                    int id = Convert.ToInt32(r[i].Cells[0].Value);
                                    dataBase.Hardware hw = context.Hardwares.Select(hw => hw).Where(hw => hw.IdH == id).First();
                                    hw.Parent = null;
                                }
                            }
                        }
                        context.SaveChanges();

                    }
                    LoadConnectedHW();
                    this.Refresh();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
