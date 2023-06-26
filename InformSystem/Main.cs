using InformSystem.Forms;

namespace InformSystem
{
    public partial class Main : Form
    {
        private Form activeForm;
        public Main()
        {
            InitializeComponent();
            OpenChildForm(new Hardware());

        }

        private void UpdateDataClick(object sender, EventArgs e)
        {
            if (true) //TODO �������� ���� ������������
            {
                object connection="connection"; //TODO �������� �������������� � ����� ������
                UpdateDataWindow win = new UpdateDataWindow(connection);
                OpenChildForm(win);
                //win.ShowDialog();
            }
            else
            {
                MessageBox.Show("������������ ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void OpenChildForm(Form childForm)
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
            OpenChildForm(new Hardware());
        }

        private void RepairButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RepareMainWindow());
        }
    }
}