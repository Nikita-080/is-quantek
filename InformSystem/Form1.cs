namespace InformSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void UpdateDataClick(object sender, EventArgs e)
        {
            if (true) //TODO �������� ���� ������������
            {
                object connection="connection"; //TODO �������� �������������� � ����� ������
                UpdateDataWindow win = new UpdateDataWindow(connection);
                win.ShowDialog();
            }
            else
            {
                MessageBox.Show("������������ ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}