using InformSystem.dataBase;
using System.Text;
using System.Text.Json;

namespace InformSystem
{
    //created by Nikita
    public partial class UpdateDataWindow : Form
    {
        const int TYPE_SYSTEM_UNIT = 1;
        const int PROC_MODEL       = 1;
        const int PROC_CREATOR     = 2;
        const int PROC_FREQ        = 3;
        const int RAM_SIZE         = 4;
        const int RAM_MODE         = 5;
        const int IS_INTERNAL_GPU  = 6;
        const int GPU_CREATOR      = 7;
        const int GPU_MEMORY       = 8;
        const int GPU_NAME         = 9;

        string path = "";
        string mode = "";
        List<string> filenames=new List<string>();
        int numfiles=0;
        int numsurcess = 0;
        int numerrors = 0;
        List<Hardware> computers=new List<Hardware>();
        
        public UpdateDataWindow(object connection)
        {
            InitializeComponent();

            mode = "find";

            richTextBox1.Text += "нажмите \"Найти\" для поиска файлов о компьютерах\n";
            path = GetPath();
            textBox_path.Text = path;

            button_path.Click += new System.EventHandler(ChoseFolder);
            button_ok.Click += new System.EventHandler(OK);
            button_cancel.Click += new System.EventHandler(CANCEL);
        }
        void ChoseFolder(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                path = fbd.SelectedPath;
            }
            textBox_path.Text = path;
            SetPath(path);
        }

        string GetPath()
        {
            if (File.Exists("./datapath.txt"))
            {
                return File.ReadAllText("./datapath.txt");
            }
            else return "";
        }
        void SetPath(string s)
        {
            if (!File.Exists("./datapath.txt"))
            {
                FileStream fs=File.Create("./datapath.txt");
                byte[] data = Encoding.UTF8.GetBytes(s);
                fs.Write(data, 0, data.Length);
            }
            else
            {
                File.WriteAllText("./datapath.txt", s);
            }
        }

        void CANCEL(object sender, EventArgs e)
        {
            Close();
        }
        void OK(object sender, EventArgs e)
        {
            if (mode == "find")
            {
                if (File.Exists(path + "/metadata.json"))
                {
                    string metadatajson = File.ReadAllText(path + "/metadata.json");
                    JsonDocument doc = JsonDocument.Parse(metadatajson);
                    JsonElement root = doc.RootElement;

                    for (int i = 0; i < root.GetArrayLength(); i++)
                    {
                        filenames.Add(root[i].ToString() + ".json");
                    }

                    button_ok.Text = "Получить";
                    mode = "get";
                    numfiles = root.GetArrayLength();
                    richTextBox1.Text += $"обнаружено файлов: {numfiles}\n";
                    richTextBox1.Text += "нажмите \"Получить\" для сбора информации\n";
                }
                else
                {
                    richTextBox1.Text += "файл metadata.json не найден\n";
                }
            }
            else if (mode == "get")
            {
                for (int i = 0; i < numfiles; i++)
                {
                    try
                    {
                        string datajson = File.ReadAllText(path + "/" + filenames[i]);
                        JsonDocument doc = JsonDocument.Parse(datajson);
                        JsonElement root = doc.RootElement;

                        Hardware h = new Hardware();

                        h.TypeH = TYPE_SYSTEM_UNIT;

                        int id;
                        bool ok = root.GetProperty("ID").TryGetInt32(out id);
                        if (!ok) throw new Exception("ID is not valid");
                        h.IdH = id;

                        HardwareValue hv1 = new HardwareValue();
                        hv1.Property = GPU_CREATOR;
                        hv1.Value = root.GetProperty("gpucreator").ToString();

                        HardwareValue hv2 = new HardwareValue();
                        hv2.Property = GPU_MEMORY;
                        hv2.Value = root.GetProperty("gpumemory").ToString();

                        HardwareValue hv3 = new HardwareValue();
                        hv3.Property = GPU_NAME;
                        hv3.Value = root.GetProperty("gpuname").ToString();

                        HardwareValue hv4 = new HardwareValue();
                        hv4.Property = IS_INTERNAL_GPU;
                        hv4.Value = root.GetProperty("isInternalGPU").ToString();

                        HardwareValue hv5 = new HardwareValue();
                        hv5.Property = PROC_CREATOR;
                        hv5.Value = root.GetProperty("proccreator").ToString();

                        HardwareValue hv6 = new HardwareValue();
                        hv6.Property = PROC_FREQ;
                        hv6.Value = root.GetProperty("procfreq").ToString();

                        HardwareValue hv7 = new HardwareValue();
                        hv7.Property = PROC_MODEL;
                        hv7.Value = root.GetProperty("procmodel").ToString();

                        HardwareValue hv8 = new HardwareValue();
                        hv8.Property = RAM_MODE;
                        hv8.Value = root.GetProperty("rammode").ToString();

                        HardwareValue hv9 = new HardwareValue();
                        hv9.Property = RAM_SIZE;
                        hv9.Value = root.GetProperty("ramsize").ToString();

                        h.HardwareValues = new List<HardwareValue> { hv1, hv2, hv3, hv4, hv5, hv6, hv7, hv8, hv9 };


                        int numdisks = root.GetProperty("disks").GetArrayLength();
                        for (int j = 0; j < numdisks; j++)
                        {
                            Disk disk = new Disk();
                            disk.Creator = root.GetProperty("disks")[j].GetProperty("creator").ToString();
                            disk.Model = root.GetProperty("disks")[j].GetProperty("model").ToString();
                            disk.Type = root.GetProperty("disks")[j].GetProperty("type").ToString();

                            int ds;
                            ok = root.GetProperty("disks")[j].GetProperty("size").TryGetInt32(out ds);
                            if (!ok) throw new Exception("disk size is not valid");
                            disk.Size = ds;

                            h.Disks.Add(disk);
                        }
                        computers.Add(h);
                        numsurcess++;
                    }
                    catch (Exception error)
                    {
                        richTextBox1.Text += $"{filenames[i]}\tошибка {error.Message}\n";
                        numerrors++;
                    }
                }
                button_ok.Text = "Записать";
                mode = "change";
                richTextBox1.Text += $"Получено файлов\t: {numsurcess}/{numfiles}\n";
                richTextBox1.Text += $"Повреждено файлов\t: {numerrors}/{numfiles}\n";
                richTextBox1.Text += "нажмите \"Записать\" для обновленя базы данных\n";
            }
            else if (mode == "change")
            {
                try
                {
                    PnppkContext context = new PnppkContext();
                    context.Hardwares.AddRange(computers);
                    context.SaveChanges();

                    richTextBox1.Text += "Завершено\n";
                }
                catch (Exception error)
                {
                    richTextBox1.Text += "ОШИБКА\n";
                    richTextBox1.Text += error.Message+"\n";
                }
                richTextBox1.Text += "нажмите \"Готово\" для завершения\n";
                button_ok.Text = "Готово";
                mode = "final";
            }
            else if (mode == "final")
            {
                Close();
            }
        }
        private void UpdateDataWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
