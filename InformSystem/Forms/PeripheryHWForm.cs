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
                IdTextBox.Text = Per.IdH.ToString();
                HTypeTextBox.Text = type.NameT;
                StatusTextBox.Text = status.NameS.ToString();
                if (place != null)
                {
                    PlaceTextBox.Text = "Здание " + place.Building + ", " + "этаж " + place.Floor + ", " + "офис " + place.Office;
                    int idD = place.DepartmentId;
                    dataBase.DepartmentDict department = context.DepartmentDicts.Select(d => d).FirstOrDefault();
                    departmenTextBox.Text = department.NameD;
                }
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
            IdTextBox.Enabled = true;
            PlaceTextBox.Enabled = true;
            PersonTextBox.Enabled = true;
            departmenTextBox.Enabled = true;
            StatusTextBox.Enabled = true;
            LoadInfo(id);
            LoadService(id);
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


        private void editPersonButton_Click(object sender, EventArgs e)
        {
            //ChangePersonForm person = new ChangePersonForm();
            //person.ShowDialog();
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
            PnppkContext context = new PnppkContext();
            //Добавление оборудования
            dataBase.Hardware h = new dataBase.Hardware
            {
                IdH = Convert.ToInt32(IdTextBox.Text),
                TypeH = Convert.ToInt32(HTypeTextBox.SelectedValue),
                Status = Convert.ToInt32(StatusTextBox.Text)
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
                this.Close();
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
        }

    }
}
