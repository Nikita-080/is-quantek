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

        private void LoadPCInfo(int id)
        {
            PnppkContext context = new PnppkContext();
            PC = context.Hardwares.Select(pc => pc).Where(pc => pc.IdH == id).Single();
            IdTextBox.Text = PC.IdH.ToString();
        }

        public PCInformForm(int idPC)
        {
            InitializeComponent();
            LoadPCInfo(idPC);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PCInformForm_Load(object sender, EventArgs e)
        {

        }
    }
}
