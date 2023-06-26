namespace InformSystem
{
    partial class Main
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.UpdateDataButton = new System.Windows.Forms.Button();
            this.RepairButton = new System.Windows.Forms.Button();
            this.HardwareButton = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TittlePanel = new System.Windows.Forms.Panel();
            this.ChildFormLabel = new System.Windows.Forms.Label();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.LeftPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TittlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.LeftPanel.Controls.Add(this.UpdateDataButton);
            this.LeftPanel.Controls.Add(this.RepairButton);
            this.LeftPanel.Controls.Add(this.HardwareButton);
            this.LeftPanel.Controls.Add(this.LogoPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(220, 603);
            this.LeftPanel.TabIndex = 0;
            // 
            // UpdateDataButton
            // 
            this.UpdateDataButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateDataButton.FlatAppearance.BorderSize = 0;
            this.UpdateDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateDataButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateDataButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.UpdateDataButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateDataButton.Location = new System.Drawing.Point(0, 200);
            this.UpdateDataButton.Name = "UpdateDataButton";
            this.UpdateDataButton.Size = new System.Drawing.Size(220, 60);
            this.UpdateDataButton.TabIndex = 4;
            this.UpdateDataButton.Text = "Обновление данных";
            this.UpdateDataButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateDataButton.UseVisualStyleBackColor = true;
            this.UpdateDataButton.Click += new System.EventHandler(this.UpdateDataClick);
            // 
            // RepairButton
            // 
            this.RepairButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RepairButton.FlatAppearance.BorderSize = 0;
            this.RepairButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepairButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RepairButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.RepairButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RepairButton.Location = new System.Drawing.Point(0, 140);
            this.RepairButton.Name = "RepairButton";
            this.RepairButton.Size = new System.Drawing.Size(220, 60);
            this.RepairButton.TabIndex = 2;
            this.RepairButton.Text = "Техническое обслуживание";
            this.RepairButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RepairButton.UseVisualStyleBackColor = true;
            this.RepairButton.Click += new System.EventHandler(this.RepairButton_Click);
            // 
            // HardwareButton
            // 
            this.HardwareButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HardwareButton.FlatAppearance.BorderSize = 0;
            this.HardwareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HardwareButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HardwareButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.HardwareButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HardwareButton.Location = new System.Drawing.Point(0, 80);
            this.HardwareButton.Name = "HardwareButton";
            this.HardwareButton.Size = new System.Drawing.Size(220, 60);
            this.HardwareButton.TabIndex = 1;
            this.HardwareButton.Text = "Оборудование";
            this.HardwareButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HardwareButton.UseVisualStyleBackColor = true;
            this.HardwareButton.Click += new System.EventHandler(this.HardwareButton_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.SystemColors.Control;
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(220, 80);
            this.LogoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::InformSystem.Properties.Resources.pnppk;
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TittlePanel
            // 
            this.TittlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.TittlePanel.Controls.Add(this.ChildFormLabel);
            this.TittlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TittlePanel.Location = new System.Drawing.Point(220, 0);
            this.TittlePanel.Name = "TittlePanel";
            this.TittlePanel.Size = new System.Drawing.Size(1062, 80);
            this.TittlePanel.TabIndex = 1;
            this.TittlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TittlePanel_Paint);
            // 
            // ChildFormLabel
            // 
            this.ChildFormLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChildFormLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ChildFormLabel.Location = new System.Drawing.Point(0, 0);
            this.ChildFormLabel.Name = "ChildFormLabel";
            this.ChildFormLabel.Size = new System.Drawing.Size(1062, 80);
            this.ChildFormLabel.TabIndex = 0;
            this.ChildFormLabel.Text = "Домашняя страница";
            this.ChildFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPanel
            // 
            this.FormPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(220, 80);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(1062, 523);
            this.FormPanel.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 603);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.TittlePanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "Main";
            this.Text = "Form1";
            this.LeftPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TittlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel LeftPanel;
        private Panel LogoPanel;
        private PictureBox pictureBox1;
        private Panel TittlePanel;
        private Panel FormPanel;
        private Button RepairButton;
        private Button HardwareButton;
        private Button UpdateDataButton;
        private Label ChildFormLabel;
    }
}