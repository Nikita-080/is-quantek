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
    public partial class RepareMainWindow : Form
    {
        PnppkContext context = new PnppkContext();
        public RepareMainWindow()
        {
            InitializeComponent();
            databaseTable.DataSource = context.Repairs.ToList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            NewRepare newRepare = new NewRepare();
            newRepare.Show();
        }

        private void updateTableButton_Click(object sender, EventArgs e)
        {
            databaseTable.DataSource = context.Repairs.ToList();
        }
    }
}
