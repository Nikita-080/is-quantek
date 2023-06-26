using InformSystem.dataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformSystem.Forms
{
    public partial class PeripheryHWForm : Form
    {
        private dataBase.Hardware Per;
        private dataBase.Place place;
        private dataBase.Access access;
        private dataBase.StatusDict status;
        int building = 0;
        int floor = 0;
        int office = 0;

        private void LoadService(int id)
        {
            try
            {
                using (PnppkContext context = new PnppkContext())
                {
                    var repair = from rep in context.Repairs
                                 where rep.HardwareR == id
                                 select new
                                 {
                                     dateIn = rep.DateIn,
                                     dateOut = rep.DateOut,
                                     reason = rep.Reason,
                                     verd = rep.Verdict
                                 };
                    foreach (var r in repair)
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void FillComboBox()
        {
            using (PnppkContext context = new PnppkContext())
            {
                var type = from t in context.HardwareTypes
                           where t.IdHt != 1 && t.IdHt != 4
                           select t;
                HTypeTextBox.DataSource = type.ToList();
                HTypeTextBox.DisplayMember = "NameT";
                HTypeTextBox.ValueMember = "IdHt";

                var depart = from t in context.DepartmentDicts
                             select t;
                departmenTextBox.DataSource = depart.ToList();
                departmenTextBox.DisplayMember = "NameD";
                departmenTextBox.ValueMember = "IdDd";

                var status = from t in context.StatusDicts
                             where t.IdS != 4
                             select t;
                StatusTextBox.DataSource = status.ToList();
                StatusTextBox.DisplayMember = "NameS";
                StatusTextBox.ValueMember = "IdS";
            }
        }

        private void ActiveElementsChange()
        {
            IdTextBox.Enabled = true;
            HTypeTextBox.Enabled = true;
            PlaceTextBox.Enabled = true;
            PersonTextBox.Enabled = true;
            departmenTextBox.Enabled = true;
            DiagFormatTextBox.Enabled = true;
            StatusTextBox.Enabled = true;
        }

        private void LoadInfo(int id)
        {
            try
            {
                PnppkContext context = new PnppkContext();
                Per = context.Hardwares.Select(per => per).Where(per => per.IdH == id).First();
                place = context.Places.Select(p => p).Where(p => p.HardwareP == id).FirstOrDefault();
                access = context.Accesses.Select(pers => pers).Where(pers => pers.HardwareA == id).FirstOrDefault();
                status = context.StatusDicts.Select(s => s).Where(s => s.IdS == Per.Status).FirstOrDefault();
                dataBase.HardwareType type = context.HardwareTypes.Select(d => d).Where(d => d.IdHt == Per.TypeH).FirstOrDefault();
                dataBase.HardwareValue value = context.HardwareValues.Select(v => v).Where(v => v.HardwareV == Per.IdH).FirstOrDefault();
                IdTextBox.Text = Per.IdH.ToString();
                HTypeTextBox.Text = type.NameT;
                StatusTextBox.Text = status.NameS.ToString();
                if (value != null) DiagFormatTextBox.Text = value.Value.ToString();
                if (place != null)
                {
                    PlaceTextBox.Text = "Здание " + place.Building + ", " + "этаж " + place.Floor + ", " + "офис " + place.Office;
                    building = place.Building;
                    floor = place.Floor;
                    office = place.Office;
                    int idD = place.DepartmentId;
                    dataBase.DepartmentDict department = context.DepartmentDicts.Select(d => d).Where(d => d.IdDd == place.DepartmentId).FirstOrDefault();
                    departmenTextBox.Text = department.NameD;
                }
                else departmenTextBox.SelectedIndex = -1;
                if (access != null)
                {
                    PersonTextBox.Text = access.Person.ToString();
                }
                switch (type.IdHt)
                {
                    case 2:
                        DiagAndFormatLabel.Text = "Формат";
                        break;
                    case 3:
                        DiagAndFormatLabel.Text = "Диагональ";
                        break;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public PeripheryHWForm()
        {
            InitializeComponent();
            ActiveElementsChange();
            FillComboBox();
            saveButton.Text = "Добавить";
        }

        public PeripheryHWForm(int id)
        {
            InitializeComponent();
            FillComboBox();
            LoadInfo(id);
            LoadService(id);
            bool repair = status.IdS != 4;
            IdTextBox.Enabled = repair;
            PlaceTextBox.Enabled = repair;
            PersonTextBox.Enabled = repair;
            departmenTextBox.Enabled = repair;
            StatusTextBox.Enabled = repair;
            editPlaceButton.Enabled = repair;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void changePlaceButton_Click(object sender, EventArgs e)
        {
            ChangePlaceForm placeC = new ChangePlaceForm();
            placeC.ShowDialog();
            if (placeC.Save) //if click save button
            {
                PlaceTextBox.Text = "Здание " + placeC.Building + ", " + "этаж " + placeC.Floor + ", " + "офис " + placeC.Office;
            }
        }

        private void HTypeTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (HTypeTextBox.SelectedValue)
            {
                case 2:
                    DiagAndFormatLabel.Text = "Формат";
                    break;
                case 3:
                    DiagAndFormatLabel.Text = "Диагональ";
                    break;
            }
        }

        private void editPlaceButton_Click(object sender, EventArgs e)
        {
            ChangePlaceForm placeC = new ChangePlaceForm(place);
            placeC.ShowDialog();
            if (placeC.Save) //if click save button
            {
                building = Convert.ToInt32(placeC.Building);
                floor = Convert.ToInt32(placeC.Floor);
                office = Convert.ToInt32(placeC.Office);
                PlaceTextBox.Text = "Здание " + placeC.Building + ", " + "этаж " + placeC.Floor + ", " + "офис " + placeC.Office;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveButton.Text == "Добавить") AddHardware();
            else SaveHardware();
            this.Close();
        }

        bool AddHardware()
        {
            PnppkContext context = new PnppkContext();
            //Добавление оборудования
            dataBase.Hardware h = new dataBase.Hardware
            {
                IdH = Convert.ToInt32(IdTextBox.Text),
                TypeH = Convert.ToInt32(HTypeTextBox.SelectedValue),
                Status = Convert.ToInt32(StatusTextBox.SelectedValue)
            };
            context.Hardwares.Add(h);
            //Добавление места и отдела оборудования
            var dQuery = context.Database.SqlQuery<DateTime>(FormattableStringFactory.Create("SELECT CURDATE()"));
            DateTime dbDate = dQuery.AsEnumerable().First();
            dataBase.Place p = new dataBase.Place()
            {

                HardwareP = h.IdH,
                DepartmentId = Convert.ToInt32(departmenTextBox.SelectedValue),
                Building = building,
                Floor = floor,
                Office = office,
                Data = dbDate
            };
            context.Places.Add(p);
            //Добавление Пользователя к оборудованию
            if (PersonTextBox.Text != "")
            {
                dataBase.Access a = new dataBase.Access()
                {
                    HardwareA = h.IdH,
                    Person = Convert.ToInt32(PersonTextBox.Text)
                };
                context.Accesses.Add(a);

            }

            //Добавление характеристик оборудования
            int i_type = context.HardwareProperties.Select(p => p).Where(p => p.TypeP == h.TypeH).First().IdHp;//10 or 11
            dataBase.HardwareValue v = new HardwareValue()
            {
                HardwareV = h.IdH,
                Property = i_type,
                Value = DiagFormatTextBox.Text
            };
            context.HardwareValues.Add(v);
            context.SaveChanges();
            return true;
        }
        bool SaveHardware()
        {
            PnppkContext context = new PnppkContext();
            //Настройка пользователя
            if (PersonTextBox.Text != "")
            {
                dataBase.Access a = context.Accesses.Where(a => a.HardwareA == Per.IdH && a.Person == Convert.ToInt32(PersonTextBox.Text)).FirstOrDefault();
                if (a != null)
                {
                    a.Person = Convert.ToInt32(PersonTextBox.Text);
                }
                else
                {
                    a = new dataBase.Access()
                    {
                        HardwareA = Per.IdH,
                        Person = Convert.ToInt32(PersonTextBox.Text)
                    };
                    context.Accesses.Add(a);
                }
            }
            else
            {

                if (access != null)
                {
                    dataBase.Access remA = context.Accesses.Where(a => a.HardwareA == Per.IdH && a.Person == access.Person).FirstOrDefault();
                    context.Accesses.Remove(remA);
                }
            }
            //Настройка местоположения
            if (PlaceTextBox.Text != "")
            {
                dataBase.Place p = context.Places.Where(p => p.HardwareP == Per.IdH).FirstOrDefault();
                var dQuery = context.Database.SqlQuery<DateTime>(FormattableStringFactory.Create("SELECT CURDATE()"));
                DateTime dbDate = dQuery.AsEnumerable().First();
                if (p != null)
                {
                    p.Building = building;
                    p.Floor = floor;
                    p.Office = office;
                    p.Data = dbDate;
                    p.DepartmentId = Convert.ToInt32(departmenTextBox.SelectedValue);
                }
                else
                {
                    dataBase.Place pc = new dataBase.Place()
                    {
                        HardwareP = Per.IdH,
                        Building = building,
                        Floor = floor,
                        Office = office,
                        Data = dbDate,
                        DepartmentId = Convert.ToInt32(departmenTextBox.SelectedValue)
                    };
                    context.Places.Add(pc);
                }
            }
            else
            {

                if (place != null)
                {
                    dataBase.Place remP = context.Places.Where(a => a.HardwareP == Per.IdH).FirstOrDefault();
                    context.Places.Remove(remP);
                }
            }

            context.SaveChanges();
            return true;
        }
    }
}
