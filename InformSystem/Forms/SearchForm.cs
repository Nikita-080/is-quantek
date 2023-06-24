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
    public partial class SearchForm : Form
    {
        DataTable dataTable;

        public SearchForm(DataTable datTable)
        {
            InitializeComponent();
            dataTable = datTable;
        }

        private void SearchButtonIdH_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                bool ok = int.TryParse(IdH.Text, out id);
                if (ok)
                {
                    dataTable.DefaultView.RowFilter = String.Format("Номер = {0}", id);
                    if (dataTable.Rows.Count > 0)
                    {
                        MessageBox.Show(String.Format("Найдено {0}", dataTable.DefaultView.Count), "Результат поиска", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Введен неверный номер оборудования!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HTypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButtonIdP_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                bool ok = int.TryParse(IdP.Text, out id);
                if (ok)
                {
                    dataTable.DefaultView.RowFilter = String.Format("Пользователь = '{0}'", id);
                    if (dataTable.Rows.Count > 0)
                    {
                        MessageBox.Show(String.Format("Найдено {0}", dataTable.DefaultView.Count), "Результат поиска", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Введен неверный номер пользователя!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
