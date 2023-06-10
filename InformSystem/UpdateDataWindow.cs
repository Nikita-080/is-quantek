using System.Text;
using System.Text.Json;

namespace InformSystem
{
    //created by Nikita
    public partial class UpdateDataWindow : Form
    {
        string path = "";
        string mode = "";
        List<string> filenames=new List<string>();
        int numfiles=0;
        int numsurcess = 0;
        int numerrors = 0;
        List<Computer> computers=new List<Computer>();
        public UpdateDataWindow(object connection)
        {
            InitializeComponent();
            textBox_path.Text = GetPath();
            mode = "find";
            richTextBox1.Text += "нажмите \"Найти\" для поиска файлов о компьютерах\n";
            button_path.Click += new System.EventHandler(this.ChoseFolder);
            button_ok.Click += new System.EventHandler(this.OK);
            button_cancel.Click += new System.EventHandler(this.CANCEL);
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
            this.Close();
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

                    button_ok.Text = "Записать";
                    mode = "change";
                    numfiles = root.GetArrayLength();
                    richTextBox1.Text += $"обнаружено файлов: {numfiles}\n";
                    richTextBox1.Text += "нажмите \"Записать\" для обновленя базы данных\n";
                }
                else
                {
                    richTextBox1.Text += "файл metadata.json не найден\n";
                }
            }
            else if (mode == "change")
            {
                richTextBox1.Text += "обработка...\n";
                for (int i = 0; i < numfiles; i++)
                {
                    try
                    {
                        string datajson = File.ReadAllText(path + "/" + filenames[i]);
                        JsonDocument doc = JsonDocument.Parse(datajson);
                        JsonElement root = doc.RootElement;
                        Computer comp = new Computer();

                        bool ok = root.GetProperty("ID").TryGetInt32(out comp.ID);
                        if (!ok) throw new Exception("ID is not valid");

                        comp.gpucreator = root.GetProperty("gpucreator").ToString();
                        comp.gpumemory = root.GetProperty("gpumemory").ToString();
                        comp.gpuname = root.GetProperty("gpuname").ToString();
                        comp.isInternalGPU = root.GetProperty("isInternalGPU").ToString();
                        comp.proccreator = root.GetProperty("proccreator").ToString();
                        comp.procfreq = root.GetProperty("procfreq").ToString();
                        comp.procmodel = root.GetProperty("procmodel").ToString();
                        comp.rammode = root.GetProperty("rammode").ToString();
                        comp.ramsize = root.GetProperty("ramsize").ToString();

                        int numdisks = root.GetProperty("disks").GetArrayLength();
                        for (int j = 0; j < numdisks; j++)
                        {
                            Disk disk = new Disk();
                            disk.creator = root.GetProperty("disks")[j].GetProperty("creator").ToString();
                            disk.model = root.GetProperty("disks")[j].GetProperty("model").ToString();
                            disk.size = root.GetProperty("disks")[j].GetProperty("size").ToString();
                            disk.type = root.GetProperty("disks")[j].GetProperty("type").ToString();
                            comp.disks.Add(disk);
                        }
                        UpdateDB(comp);
                        numsurcess++;
                    }
                    catch (Exception error)
                    {
                        richTextBox1.Text += $"{filenames[i]}\tошибка {error.Message}\n";
                        numerrors++;
                    }
                }
                richTextBox1.Text += "Завершено\n";
                richTextBox1.Text += $"Записано файлов\t: {numsurcess}/{numfiles}\n";
                richTextBox1.Text += $"Не записано\t: {numerrors}/{numfiles}\n";
                richTextBox1.Text += "нажмите \"Готово\" для завершения\n";
                button_ok.Text = "Готово";
                mode = "final";
            }
            else if (mode == "final")
            {
                this.Close();
            }
        }
        private void UpdateDB(Computer comp)
        {
            //TODO запись в базу данных
            //объекты - computers
            //подключение - connection
        }

        private void UpdateDataWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
