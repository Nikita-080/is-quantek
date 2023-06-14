using InformSystem.Forms;

namespace InformSystem
{
    public partial class Form1 : Form
    {
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();

        }

        private void UpdateDataClick(object sender, EventArgs e)
        {
            if (true) //TODO проверка прав пользователя
            {
                object connection="connection"; //TODO средство взаимодействия с базой данных
                UpdateDataWindow win = new UpdateDataWindow(connection);
                OpenChildForm(win, sender);
                //win.ShowDialog();
            }
            else
            {
                MessageBox.Show("Недостаточно прав", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock=DockStyle.Fill;
            this.FormPanel.Controls.Add(childForm);
            this.FormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            ChildFormLabel.Text = childForm.Text;

        }

        private void TittlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HardwareButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Hardware(), sender);
        }

        private void RepairButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RepareMainWindow(), sender);
        }
    }
}