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
    public partial class PCInformForm : Form
    {
        private dataBase.Hardware PC;
        private dataBase.Place place;
        private dataBase.Access access;

        private void LoadPCInfo(int id)
        {
            try
            {
                PnppkContext context = new PnppkContext();
                PC = context.Hardwares.Select(pc => pc).Where(pc => pc.IdH == id).First();
                place = context.Places.Select(p => p).Where(p => p.HardwareP == id).FirstOrDefault();
                access = context.Accesses.Select(pers => pers).Where(pers => pers.HardwareA == id).FirstOrDefault();
                IdTextBox.Text = PC.IdH.ToString();
                HTypeTextBox.Text = "Компьютер";
                if(place != null)
                {
                    PlaceTextBox.Text = "Здание " + place.Building + ", " + "этаж " + place.Floor + ", " + "офис " + place.Office;
                    int idD = place.DepartmentId;
                    dataBase.DepartmentDict department = context.DepartmentDicts.Select(d => d).Where(d => d.IdDd == idD).FirstOrDefault(); 
                    departmenTextBox.Text = department.NameD;
                }
                if(access != null)
                {
                    PersonTextBox.Text = access.Person.ToString();
                }
                
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public PCInformForm(int idPC)
        {
            InitializeComponent();
            LoadPCInfo(idPC);
            ConfigLoad(idPC);
            
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
                                 select new
                                 {
                                     name = prop.NameP,
                                     value = hardw.Value
                                 };
                    dataGridViewPcInfo.DataSource = config.ToList();
                                 


                }
            }
            catch(Exception e)
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
    }
}
