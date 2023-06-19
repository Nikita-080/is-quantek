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
    public partial class ChangePlaceForm : Form
    {
        public bool Save { get; set; }
        public decimal Building { get; set; }
        public decimal Floor { get; set; }
        public decimal Office { get; set; }

        public ChangePlaceForm()
        {
            InitializeComponent();
            Building = 0;
            Floor = 0;
            Office = 0;
            Save = false;
        }

        private void PlaceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Building = BuildingNumeric.Value;
            Floor = FloorNumeric.Value;
            Office = OfficeNumeric.Value;
            Save = true;
            this.Close();
        }
    }
}
