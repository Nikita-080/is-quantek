namespace InformSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LeftPanel = new Panel();
            BuyButton = new Button();
            RepairButton = new Button();
            HardwareButton = new Button();
            LogoPanel = new Panel();
            pictureBox1 = new PictureBox();
            TittlePanel = new Panel();
            FormPanel = new Panel();
            UpdateDataButton = new Button();
            LeftPanel.SuspendLayout();
            LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.FromArgb(0, 42, 87);
            LeftPanel.Controls.Add(UpdateDataButton);
            LeftPanel.Controls.Add(BuyButton);
            LeftPanel.Controls.Add(RepairButton);
            LeftPanel.Controls.Add(HardwareButton);
            LeftPanel.Controls.Add(LogoPanel);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Margin = new Padding(4);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(275, 754);
            LeftPanel.TabIndex = 0;
            // 
            // BuyButton
            // 
            BuyButton.Dock = DockStyle.Top;
            BuyButton.FlatAppearance.BorderSize = 0;
            BuyButton.FlatStyle = FlatStyle.Flat;
            BuyButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BuyButton.ForeColor = SystemColors.ActiveBorder;
            BuyButton.ImageAlign = ContentAlignment.MiddleLeft;
            BuyButton.Location = new Point(0, 250);
            BuyButton.Margin = new Padding(4);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(275, 75);
            BuyButton.TabIndex = 3;
            BuyButton.Text = "Закупка";
            BuyButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            BuyButton.UseVisualStyleBackColor = true;
            // 
            // RepairButton
            // 
            RepairButton.Dock = DockStyle.Top;
            RepairButton.FlatAppearance.BorderSize = 0;
            RepairButton.FlatStyle = FlatStyle.Flat;
            RepairButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RepairButton.ForeColor = SystemColors.ActiveBorder;
            RepairButton.ImageAlign = ContentAlignment.MiddleLeft;
            RepairButton.Location = new Point(0, 175);
            RepairButton.Margin = new Padding(4);
            RepairButton.Name = "RepairButton";
            RepairButton.Size = new Size(275, 75);
            RepairButton.TabIndex = 2;
            RepairButton.Text = "Техническое обслуживание";
            RepairButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            RepairButton.UseVisualStyleBackColor = true;
            // 
            // HardwareButton
            // 
            HardwareButton.Dock = DockStyle.Top;
            HardwareButton.FlatAppearance.BorderSize = 0;
            HardwareButton.FlatStyle = FlatStyle.Flat;
            HardwareButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HardwareButton.ForeColor = SystemColors.ActiveBorder;
            HardwareButton.ImageAlign = ContentAlignment.MiddleLeft;
            HardwareButton.Location = new Point(0, 100);
            HardwareButton.Margin = new Padding(4);
            HardwareButton.Name = "HardwareButton";
            HardwareButton.Size = new Size(275, 75);
            HardwareButton.TabIndex = 1;
            HardwareButton.Text = "Оборудование";
            HardwareButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            HardwareButton.UseVisualStyleBackColor = true;
            // 
            // LogoPanel
            // 
            LogoPanel.BackColor = SystemColors.Control;
            LogoPanel.Controls.Add(pictureBox1);
            LogoPanel.Dock = DockStyle.Top;
            LogoPanel.Location = new Point(0, 0);
            LogoPanel.Margin = new Padding(4);
            LogoPanel.Name = "LogoPanel";
            LogoPanel.Size = new Size(275, 100);
            LogoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Image = Properties.Resources.pnppk;
            pictureBox1.Location = new Point(54, 15);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TittlePanel
            // 
            TittlePanel.Dock = DockStyle.Top;
            TittlePanel.Location = new Point(275, 0);
            TittlePanel.Margin = new Padding(4);
            TittlePanel.Name = "TittlePanel";
            TittlePanel.Size = new Size(1327, 100);
            TittlePanel.TabIndex = 1;
            // 
            // FormPanel
            // 
            FormPanel.BackColor = SystemColors.ControlDark;
            FormPanel.Dock = DockStyle.Fill;
            FormPanel.Location = new Point(275, 100);
            FormPanel.Margin = new Padding(4);
            FormPanel.Name = "FormPanel";
            FormPanel.Size = new Size(1327, 654);
            FormPanel.TabIndex = 2;
            // 
            // UpdateDataButton
            // 
            UpdateDataButton.Dock = DockStyle.Top;
            UpdateDataButton.FlatAppearance.BorderSize = 0;
            UpdateDataButton.FlatStyle = FlatStyle.Flat;
            UpdateDataButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateDataButton.ForeColor = SystemColors.ActiveBorder;
            UpdateDataButton.ImageAlign = ContentAlignment.MiddleLeft;
            UpdateDataButton.Location = new Point(0, 325);
            UpdateDataButton.Margin = new Padding(4);
            UpdateDataButton.Name = "UpdateDataButton";
            UpdateDataButton.Size = new Size(275, 75);
            UpdateDataButton.TabIndex = 4;
            UpdateDataButton.Text = "Обновление данных";
            UpdateDataButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            UpdateDataButton.UseVisualStyleBackColor = true;
            UpdateDataButton.Click += UpdateDataClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1602, 754);
            Controls.Add(FormPanel);
            Controls.Add(TittlePanel);
            Controls.Add(LeftPanel);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            LeftPanel.ResumeLayout(false);
            LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftPanel;
        private Panel LogoPanel;
        private PictureBox pictureBox1;
        private Panel TittlePanel;
        private Panel FormPanel;
        private Button BuyButton;
        private Button RepairButton;
        private Button HardwareButton;
        private Button UpdateDataButton;
    }
}