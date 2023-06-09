namespace InformSystem
{
    partial class UpdateDataWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_path = new TextBox();
            label_path = new Label();
            button_path = new Button();
            button_ok = new Button();
            button_cancel = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // textBox_path
            // 
            textBox_path.Location = new Point(23, 52);
            textBox_path.Name = "textBox_path";
            textBox_path.Size = new Size(432, 31);
            textBox_path.TabIndex = 0;
            // 
            // label_path
            // 
            label_path.AutoSize = true;
            label_path.Location = new Point(23, 9);
            label_path.Name = "label_path";
            label_path.Size = new Size(116, 25);
            label_path.TabIndex = 1;
            label_path.Text = "Путь к папке";
            // 
            // button_path
            // 
            button_path.Location = new Point(466, 52);
            button_path.Name = "button_path";
            button_path.Size = new Size(112, 34);
            button_path.TabIndex = 2;
            button_path.Text = "...";
            button_path.UseVisualStyleBackColor = true;
            // 
            // button_ok
            // 
            button_ok.Location = new Point(343, 358);
            button_ok.Name = "button_ok";
            button_ok.Size = new Size(112, 34);
            button_ok.TabIndex = 3;
            button_ok.Text = "Найти";
            button_ok.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(461, 358);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(112, 34);
            button_cancel.TabIndex = 4;
            button_cancel.Text = "Отмена";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(24, 108);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(554, 233);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // UpdateDataWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 408);
            Controls.Add(richTextBox1);
            Controls.Add(button_cancel);
            Controls.Add(button_ok);
            Controls.Add(button_path);
            Controls.Add(label_path);
            Controls.Add(textBox_path);
            Name = "UpdateDataWindow";
            Text = "UpdateDataWindow";
            Load += UpdateDataWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_path;
        private Label label_path;
        private Button button_path;
        private Button button_ok;
        private Button button_cancel;
        private RichTextBox richTextBox1;
    }
}