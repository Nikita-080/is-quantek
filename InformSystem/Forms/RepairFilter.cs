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
    public partial class RepairFilter : Form
    {
        public static DateTime dateFrom;
        public static bool useDateFrom;
        public static DateTime dateTo;
        public static bool useDateTo;
        public static DateTime dateFromEnd;
        public static bool useDateFromEnd;
        public static DateTime dateToEnd;
        public static bool useDateToEnd;
        public static bool loadAll;
        public RepairFilter()
        {
            InitializeComponent();
        }

        private void applyChangesButton_Click(object sender, EventArgs e)
        {
            dateFrom = dateFromPicker.Value;
            dateTo = dateToPicker.Value;
            loadAll = loadAllCheckBox.Checked;
            useDateFrom = useFromCheckBox.Checked;
            useDateTo = useToCheckBox.Checked;
            dateFromEnd = dateEndPickerFrom.Value;
            dateToEnd = dateEndPickerTo.Value;
            useDateFromEnd = useFromEndCheckBox.Checked;
            useDateToEnd = useToEndCheckBox.Checked;
            this.Close();
        }
    }
}
