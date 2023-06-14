using InformSystem.dataBase;
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

        private void FillComboBox()
        {
            using (PnppkContext context = new PnppkContext())
            {
                var type = from t in context.HardwareTypes
                           select t;
                HTypeTextBox.DataSource = type.ToList();
                HTypeTextBox.DisplayMember = "NameT";
                HTypeTextBox.ValueMember = "IdHt";
            }
        }

        private void ActiveElementsChange()
        {
            HTypeTextBox.Enabled = true;
            PlaceTextBox.Enabled = true;
            PersonTextBox.Enabled = true;
            departmenTextBox.Enabled = true;
            DiagFormatTextBox.Enabled = true;
        }

        private void LoadInfo(int id)
        {
            try
            {
                PnppkContext context = new PnppkContext();
                Per = context.Hardwares.Select(per => per).Where(per => per.IdH == id).First();
                place = context.Places.Select(p => p).Where(p => p.HardwareP == id).FirstOrDefault();
                access = context.Accesses.Select(pers => pers).Where(pers => pers.HardwareA == id).FirstOrDefault();
                dataBase.HardwareType type = context.HardwareTypes.Select(d => d).Where(d => d.IdHt == Per.TypeH).FirstOrDefault();
                IdTextBox.Text = Per.IdH.ToString();
                HTypeTextBox.Text = type.NameT;
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
        }

        public PeripheryHWForm(int id)
        {
            InitializeComponent();
            FillComboBox();
            LoadInfo(id);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void changePlaceButton_Click(object sender, EventArgs e)
        {

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
    }
}
