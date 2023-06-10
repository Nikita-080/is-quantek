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
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.label_path = new System.Windows.Forms.Label();
            this.button_path = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.textPanel = new System.Windows.Forms.Panel();
            this.toolsPanel.SuspendLayout();
            this.textPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_path
            // 
            this.textBox_path.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_path.Location = new System.Drawing.Point(2, 35);
            this.textBox_path.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(346, 27);
            this.textBox_path.TabIndex = 0;
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_path.Location = new System.Drawing.Point(2, 9);
            this.label_path.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(116, 21);
            this.label_path.TabIndex = 1;
            this.label_path.Text = "Путь к папке";
            // 
            // button_path
            // 
            this.button_path.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_path.Location = new System.Drawing.Point(357, 35);
            this.button_path.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_path.Name = "button_path";
            this.button_path.Size = new System.Drawing.Size(90, 27);
            this.button_path.TabIndex = 2;
            this.button_path.Text = "...";
            this.button_path.UseVisualStyleBackColor = false;
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.button_ok.FlatAppearance.BorderSize = 0;
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ok.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ok.ForeColor = System.Drawing.Color.White;
            this.button_ok.Location = new System.Drawing.Point(451, 35);
            this.button_ok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(90, 27);
            this.button_ok.TabIndex = 3;
            this.button_ok.Text = "Найти";
            this.button_ok.UseVisualStyleBackColor = false;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.Location = new System.Drawing.Point(545, 35);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(90, 27);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1044, 241);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // toolsPanel
            // 
            this.toolsPanel.Controls.Add(this.label_path);
            this.toolsPanel.Controls.Add(this.textBox_path);
            this.toolsPanel.Controls.Add(this.button_cancel);
            this.toolsPanel.Controls.Add(this.button_path);
            this.toolsPanel.Controls.Add(this.button_ok);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolsPanel.Location = new System.Drawing.Point(0, 0);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(1044, 74);
            this.toolsPanel.TabIndex = 6;
            this.toolsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textPanel
            // 
            this.textPanel.Controls.Add(this.richTextBox1);
            this.textPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.textPanel.Location = new System.Drawing.Point(0, 74);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(1044, 241);
            this.textPanel.TabIndex = 7;
            // 
            // UpdateDataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 476);
            this.Controls.Add(this.textPanel);
            this.Controls.Add(this.toolsPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UpdateDataWindow";
            this.Text = "UpdateDataWindow";
            this.toolsPanel.ResumeLayout(false);
            this.toolsPanel.PerformLayout();
            this.textPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBox_path;
        private Label label_path;
        private Button button_path;
        private Button button_ok;
        private Button button_cancel;
        private RichTextBox richTextBox1;
        private Panel toolsPanel;
        private Panel textPanel;
    }
}