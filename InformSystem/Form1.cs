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
            if (true) //TODO проверка прав пользователя
            {
                object connection="connection"; //TODO средство взаимодействия с базой данных
                UpdateDataWindow win = new UpdateDataWindow(connection);
                win.ShowDialog();
            }
            else
            {
                MessageBox.Show("Недостаточно прав", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}