using InformSystem.dataBase;
using InformSystem.Forms;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Diagnostics.Eventing.Reader;

namespace InformSystem
{
    public partial class Main : Form
    {
        private Form activeForm;
        string key_buf = "pppppppppppppppppppp";
        Random rnd;
        public Main()
        {
            InitializeComponent();
            OpenChildForm(new InformSystem.Forms.Hardware());

            KeyPreview = true;
            KeyPress += KeyHandler;
            rnd = new Random(DateTime.Now.Millisecond);

        }

        private void UpdateDataClick(object sender, EventArgs e)
        {
            if (true) //TODO проверка прав пользователя
            {
                object connection = "connection"; //TODO средство взаимодействия с базой данных
                UpdateDataWindow win = new UpdateDataWindow(connection);
                OpenChildForm(win);
                //win.ShowDialog();
            }
            else
            {
                MessageBox.Show("Недостаточно прав", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
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
            OpenChildForm(new InformSystem.Forms.Hardware());
        }

        private void RepairButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RepareMainWindow());
        }

        private void ChildFormLabel_Click(object sender, EventArgs e)
        {

        }
        private void KeyHandler(object sender, KeyPressEventArgs e)
        {
            key_buf = key_buf.Substring(1) + e.KeyChar;
            if (key_buf.EndsWith("rootwindow"))
            {
                var r=MessageBox.Show("Заполнить базу случайными данными?\nмониторы\nпринтеры\nместа\nназначения\nсвязи\nремонты", "ROOT",MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    PnppkContext context = new PnppkContext();
                    int num = 20;
                    /*
                    for (int i = 0; i < num; i++)
                    {
                        var printer = new InformSystem.dataBase.Hardware();
                        printer.IdH = 10000 + i;
                        printer.TypeH = 2;
                        printer.Parent = 100000 + rnd.Next(0, 29);
                        context.Hardwares.Add(printer);

                        var monitor = new InformSystem.dataBase.Hardware();
                        monitor.IdH = 12000 + i;
                        monitor.TypeH = 3;
                        monitor.Parent = 100000 + rnd.Next(0, 29);
                        context.Hardwares.Add(monitor);

                        var pv = new HardwareValue();
                        pv.HardwareV = 10000 + i;
                        pv.Property = 11;
                        pv.Value = "A" + rnd.Next(1, 5).ToString();

                        var mv = new HardwareValue();
                        mv.HardwareV = 12000 + i;
                        mv.Property = 10;
                        mv.Value = rnd.Next(21, 32).ToString();

                        context.HardwareValues.Add(pv);
                        context.HardwareValues.Add(mv);
                    }
                    for (int i = 0; i < 30; i++)
                    {
                        var p = new Place();
                        p.HardwareP = 100000 + i;
                        p.DepartmentId = rnd.Next(1, 16);
                        p.Building = rnd.Next(1, 20);
                        p.Floor = rnd.Next(1, 4);
                        p.Office = rnd.Next(100, 499);
                        p.Data = DateTime.Now;

                        var a = new Access();
                        a.HardwareA = 100000 + i;
                        a.Person = rnd.Next(1000, 9999);

                        context.Places.Add(p);
                        context.Accesses.Add(a);
                    }
                    */
                    for (int i = 0; i < 10; i++)
                    {
                        var reasons = new List<string> { "тормозит","упал","не включается","зависает"};
                        var verdicts = new List<string> { "замена комплектующих", "перезагрузка", "лечение ативирусом", "переустановка системы" };

                        var repair = new Repair();
                        int x = rnd.Next(1, 3);

                        if (x == 1) repair.HardwareR = 100000+rnd.Next(0, 29);
                        else if (x==2) repair.HardwareR = 10000 + rnd.Next(0, 19);
                        else repair.HardwareR = 12000 + rnd.Next(0, 19);

                        repair.Reason = reasons[rnd.Next(0, 3)];
                        repair.Verdict = verdicts[rnd.Next(0, 3)];
                        repair.DocumentIn = rnd.Next(100000, 999999);
                        repair.DocumentOut = rnd.Next(100000, 999999);
                        int month = rnd.Next(1, 4);
                        int day = rnd.Next(1, 27);
                        repair.DateIn = new DateTime(2023, month, day);
                        repair.DateOut = new DateTime(2023, rnd.Next(month, 5), rnd.Next(day, 28));

                        context.Repairs.Add(repair);
                    }
                    context.SaveChanges();
                    MessageBox.Show("SURCESSFULLY", "INFO");
                }
            }
        }
    }
}