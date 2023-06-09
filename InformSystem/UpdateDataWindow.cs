using InformSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace InformSystem
{
    public partial class UpdateDataWindow : Form
    {
        string path = "";
        string mode = "";
        List<string> filenames;
        public UpdateDataWindow(object connection)
        {
            InitializeComponent();
            //TODO сохранять и загружать путь
            /*
            using (FileStream fstream = new FileStream(, FileMode.OpenOrCreate))
            {
                // операции с fstream
            }
            */
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

                    for (int i=0;i<root.GetArrayLength();i++)
                    {
                        filenames.Add(root[i].ToString() + ".json");
                    }

                    button_ok.Text = "Внести данные";
                    mode = "change";
                    int length = root.GetArrayLength();
                    richTextBox1.Text += $"обнаружено файлов: {length}\n";
                    richTextBox1.Text += "нажмите \"Внести данные\" для обновленя базы данных\n";
                }
                else
                {
                    richTextBox1.Text += "файл metadata.json не найден\n";
                }
            }
            else
            {

            }
        }

        private void UpdateDataWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
