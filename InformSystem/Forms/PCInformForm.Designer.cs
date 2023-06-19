namespace InformSystem.Forms
{
    partial class PCInformForm
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCommonInfo = new System.Windows.Forms.Panel();
            this.departmenTextBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.editPersonButton = new System.Windows.Forms.Button();
            this.editPlaceButton = new System.Windows.Forms.Button();
            this.PersonTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PlaceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HTypeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PCHardInfoPanel = new System.Windows.Forms.Panel();
            this.dataGridViewPcInfo = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServisHistoryPanel = new System.Windows.Forms.Panel();
            this.dataGridViewServisHistory = new System.Windows.Forms.DataGridView();
            this.ConnectedHWPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridViewConnectedHW = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveButton = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.panelCommonInfo.SuspendLayout();
            this.PCHardInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPcInfo)).BeginInit();
            this.ServisHistoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServisHistory)).BeginInit();
            this.ConnectedHWPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnectedHW)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = System.Windows.Forms.DockStyle.Top;
            label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(0, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(298, 23);
            label5.TabIndex = 1;
            label5.Text = "Системные характеристики";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = System.Windows.Forms.DockStyle.Top;
            label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(0, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(191, 23);
            label6.TabIndex = 1;
            label6.Text = "История Сервиса";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = System.Windows.Forms.DockStyle.Top;
            label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(0, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(295, 23);
            label7.TabIndex = 1;
            label7.Text = "Привязанное оборудование";
            // 
            // panelCommonInfo
            // 
            this.panelCommonInfo.Controls.Add(this.departmenTextBox);
            this.panelCommonInfo.Controls.Add(this.label8);
            this.panelCommonInfo.Controls.Add(this.editPersonButton);
            this.panelCommonInfo.Controls.Add(this.editPlaceButton);
            this.panelCommonInfo.Controls.Add(this.PersonTextBox);
            this.panelCommonInfo.Controls.Add(this.label4);
            this.panelCommonInfo.Controls.Add(this.PlaceTextBox);
            this.panelCommonInfo.Controls.Add(this.label3);
            this.panelCommonInfo.Controls.Add(this.HTypeTextBox);
            this.panelCommonInfo.Controls.Add(this.label2);
            this.panelCommonInfo.Controls.Add(this.IdTextBox);
            this.panelCommonInfo.Controls.Add(this.label1);
            this.panelCommonInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCommonInfo.Location = new System.Drawing.Point(0, 0);
            this.panelCommonInfo.Name = "panelCommonInfo";
            this.panelCommonInfo.Size = new System.Drawing.Size(802, 189);
            this.panelCommonInfo.TabIndex = 0;
            // 
            // departmenTextBox
            // 
            this.departmenTextBox.Enabled = false;
            this.departmenTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmenTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departmenTextBox.FormattingEnabled = true;
            this.departmenTextBox.Location = new System.Drawing.Point(201, 148);
            this.departmenTextBox.Name = "departmenTextBox";
            this.departmenTextBox.Size = new System.Drawing.Size(287, 31);
            this.departmenTextBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(7, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Отдел";
            // 
            // editPersonButton
            // 
            this.editPersonButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.editPersonButton.FlatAppearance.BorderSize = 0;
            this.editPersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPersonButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editPersonButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editPersonButton.Image = global::InformSystem.Properties.Resources.edit48481;
            this.editPersonButton.Location = new System.Drawing.Point(496, 111);
            this.editPersonButton.Name = "editPersonButton";
            this.editPersonButton.Size = new System.Drawing.Size(37, 29);
            this.editPersonButton.TabIndex = 12;
            this.editPersonButton.UseVisualStyleBackColor = false;
            this.editPersonButton.Click += new System.EventHandler(this.editPersonButton_Click);
            // 
            // editPlaceButton
            // 
            this.editPlaceButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.editPlaceButton.FlatAppearance.BorderSize = 0;
            this.editPlaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPlaceButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editPlaceButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editPlaceButton.Image = global::InformSystem.Properties.Resources.edit48481;
            this.editPlaceButton.Location = new System.Drawing.Point(496, 75);
            this.editPlaceButton.Name = "editPlaceButton";
            this.editPlaceButton.Size = new System.Drawing.Size(37, 29);
            this.editPlaceButton.TabIndex = 11;
            this.editPlaceButton.UseVisualStyleBackColor = false;
            this.editPlaceButton.Click += new System.EventHandler(this.editPlaceButton_Click);
            // 
            // PersonTextBox
            // 
            this.PersonTextBox.Enabled = false;
            this.PersonTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PersonTextBox.Location = new System.Drawing.Point(201, 111);
            this.PersonTextBox.Name = "PersonTextBox";
            this.PersonTextBox.Size = new System.Drawing.Size(287, 32);
            this.PersonTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ответственный";
            // 
            // PlaceTextBox
            // 
            this.PlaceTextBox.Enabled = false;
            this.PlaceTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlaceTextBox.Location = new System.Drawing.Point(201, 75);
            this.PlaceTextBox.Name = "PlaceTextBox";
            this.PlaceTextBox.Size = new System.Drawing.Size(287, 32);
            this.PlaceTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Местоположение";
            // 
            // HTypeTextBox
            // 
            this.HTypeTextBox.Enabled = false;
            this.HTypeTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HTypeTextBox.Location = new System.Drawing.Point(201, 41);
            this.HTypeTextBox.Name = "HTypeTextBox";
            this.HTypeTextBox.Size = new System.Drawing.Size(287, 32);
            this.HTypeTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вид";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdTextBox.Location = new System.Drawing.Point(201, 7);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(287, 32);
            this.IdTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // PCHardInfoPanel
            // 
            this.PCHardInfoPanel.Controls.Add(this.dataGridViewPcInfo);
            this.PCHardInfoPanel.Controls.Add(label5);
            this.PCHardInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PCHardInfoPanel.Location = new System.Drawing.Point(0, 189);
            this.PCHardInfoPanel.Name = "PCHardInfoPanel";
            this.PCHardInfoPanel.Size = new System.Drawing.Size(802, 293);
            this.PCHardInfoPanel.TabIndex = 1;
            // 
            // dataGridViewPcInfo
            // 
            this.dataGridViewPcInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPcInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPcInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPcInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPcInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPcInfo.ColumnHeadersVisible = false;
            this.dataGridViewPcInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.value});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPcInfo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPcInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPcInfo.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewPcInfo.Location = new System.Drawing.Point(0, 23);
            this.dataGridViewPcInfo.Name = "dataGridViewPcInfo";
            this.dataGridViewPcInfo.RowHeadersVisible = false;
            this.dataGridViewPcInfo.RowHeadersWidth = 51;
            this.dataGridViewPcInfo.RowTemplate.Height = 29;
            this.dataGridViewPcInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPcInfo.Size = new System.Drawing.Size(802, 270);
            this.dataGridViewPcInfo.TabIndex = 2;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // value
            // 
            this.value.HeaderText = "value";
            this.value.MinimumWidth = 6;
            this.value.Name = "value";
            // 
            // ServisHistoryPanel
            // 
            this.ServisHistoryPanel.Controls.Add(this.dataGridViewServisHistory);
            this.ServisHistoryPanel.Controls.Add(label6);
            this.ServisHistoryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServisHistoryPanel.Location = new System.Drawing.Point(0, 482);
            this.ServisHistoryPanel.Name = "ServisHistoryPanel";
            this.ServisHistoryPanel.Size = new System.Drawing.Size(802, 220);
            this.ServisHistoryPanel.TabIndex = 2;
            // 
            // dataGridViewServisHistory
            // 
            this.dataGridViewServisHistory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewServisHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewServisHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServisHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewServisHistory.Location = new System.Drawing.Point(0, 23);
            this.dataGridViewServisHistory.Name = "dataGridViewServisHistory";
            this.dataGridViewServisHistory.RowHeadersWidth = 51;
            this.dataGridViewServisHistory.RowTemplate.Height = 29;
            this.dataGridViewServisHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServisHistory.Size = new System.Drawing.Size(802, 188);
            this.dataGridViewServisHistory.TabIndex = 2;
            // 
            // ConnectedHWPanel
            // 
            this.ConnectedHWPanel.Controls.Add(this.deleteButton);
            this.ConnectedHWPanel.Controls.Add(this.addButton);
            this.ConnectedHWPanel.Controls.Add(this.dataGridViewConnectedHW);
            this.ConnectedHWPanel.Controls.Add(label7);
            this.ConnectedHWPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConnectedHWPanel.Location = new System.Drawing.Point(0, 702);
            this.ConnectedHWPanel.Name = "ConnectedHWPanel";
            this.ConnectedHWPanel.Size = new System.Drawing.Size(802, 247);
            this.ConnectedHWPanel.TabIndex = 3;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteButton.Location = new System.Drawing.Point(697, 217);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(101, 27);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Отвязать";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.Location = new System.Drawing.Point(591, 217);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(101, 27);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridViewConnectedHW
            // 
            this.dataGridViewConnectedHW.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewConnectedHW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewConnectedHW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewConnectedHW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConnectedHW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Type});
            this.dataGridViewConnectedHW.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewConnectedHW.Location = new System.Drawing.Point(0, 23);
            this.dataGridViewConnectedHW.Name = "dataGridViewConnectedHW";
            this.dataGridViewConnectedHW.RowHeadersVisible = false;
            this.dataGridViewConnectedHW.RowHeadersWidth = 51;
            this.dataGridViewConnectedHW.RowTemplate.Height = 29;
            this.dataGridViewConnectedHW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConnectedHW.Size = new System.Drawing.Size(802, 188);
            this.dataGridViewConnectedHW.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "Номер";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 175;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 175;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.Location = new System.Drawing.Point(591, 952);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(207, 35);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // PCInformForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(802, 989);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ConnectedHWPanel);
            this.Controls.Add(this.ServisHistoryPanel);
            this.Controls.Add(this.PCHardInfoPanel);
            this.Controls.Add(this.panelCommonInfo);
            this.Name = "PCInformForm";
            this.Text = "PCInformForm";
            this.panelCommonInfo.ResumeLayout(false);
            this.panelCommonInfo.PerformLayout();
            this.PCHardInfoPanel.ResumeLayout(false);
            this.PCHardInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPcInfo)).EndInit();
            this.ServisHistoryPanel.ResumeLayout(false);
            this.ServisHistoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServisHistory)).EndInit();
            this.ConnectedHWPanel.ResumeLayout(false);
            this.ConnectedHWPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnectedHW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelCommonInfo;
        private TextBox IdTextBox;
        private Label label1;
        private TextBox HTypeTextBox;
        private Label label2;
        private Label label4;
        private TextBox PlaceTextBox;
        private Label label3;
        private TextBox PersonTextBox;
        private Panel PCHardInfoPanel;
        private DataGridView dataGridViewPcInfo;
        private Panel ServisHistoryPanel;
        private DataGridView dataGridViewServisHistory;
        private Panel ConnectedHWPanel;
        private DataGridView dataGridViewConnectedHW;
        private Button deleteButton;
        private Button addButton;
        private Button saveButton;
        private Button editPersonButton;
        private Button editPlaceButton;
        private Label label8;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn value;
        private ComboBox departmenTextBox;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Type;
    }
}