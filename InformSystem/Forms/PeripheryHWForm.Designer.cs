namespace InformSystem.Forms
{
    partial class PeripheryHWForm
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
            System.Windows.Forms.Label label6;
            this.panelCommonInfo = new System.Windows.Forms.Panel();
            this.editTypeButton = new System.Windows.Forms.Button();
            this.HTypeTextBox = new System.Windows.Forms.ComboBox();
            this.editDepartmenButton = new System.Windows.Forms.Button();
            this.departmenTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.editPersonButton = new System.Windows.Forms.Button();
            this.editPlaceButton = new System.Windows.Forms.Button();
            this.DiagFormatTextBox = new System.Windows.Forms.TextBox();
            this.DiagAndFormatLabel = new System.Windows.Forms.Label();
            this.PersonTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PlaceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ServisHistoryPanel = new System.Windows.Forms.Panel();
            this.dataGridViewServisHistory = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            this.panelCommonInfo.SuspendLayout();
            this.ServisHistoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServisHistory)).BeginInit();
            this.SuspendLayout();
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
            // panelCommonInfo
            // 
            this.panelCommonInfo.Controls.Add(this.editTypeButton);
            this.panelCommonInfo.Controls.Add(this.HTypeTextBox);
            this.panelCommonInfo.Controls.Add(this.editDepartmenButton);
            this.panelCommonInfo.Controls.Add(this.departmenTextBox);
            this.panelCommonInfo.Controls.Add(this.label8);
            this.panelCommonInfo.Controls.Add(this.editPersonButton);
            this.panelCommonInfo.Controls.Add(this.editPlaceButton);
            this.panelCommonInfo.Controls.Add(this.DiagFormatTextBox);
            this.panelCommonInfo.Controls.Add(this.DiagAndFormatLabel);
            this.panelCommonInfo.Controls.Add(this.PersonTextBox);
            this.panelCommonInfo.Controls.Add(this.label4);
            this.panelCommonInfo.Controls.Add(this.PlaceTextBox);
            this.panelCommonInfo.Controls.Add(this.label3);
            this.panelCommonInfo.Controls.Add(this.label2);
            this.panelCommonInfo.Controls.Add(this.IdTextBox);
            this.panelCommonInfo.Controls.Add(this.label1);
            this.panelCommonInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCommonInfo.Location = new System.Drawing.Point(0, 0);
            this.panelCommonInfo.Name = "panelCommonInfo";
            this.panelCommonInfo.Size = new System.Drawing.Size(800, 245);
            this.panelCommonInfo.TabIndex = 1;
            // 
            // editTypeButton
            // 
            this.editTypeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.editTypeButton.FlatAppearance.BorderSize = 0;
            this.editTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTypeButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editTypeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editTypeButton.Image = global::InformSystem.Properties.Resources.edit48481;
            this.editTypeButton.Location = new System.Drawing.Point(495, 39);
            this.editTypeButton.Name = "editTypeButton";
            this.editTypeButton.Size = new System.Drawing.Size(36, 29);
            this.editTypeButton.TabIndex = 20;
            this.editTypeButton.Text = "Р";
            this.editTypeButton.UseVisualStyleBackColor = false;
            // 
            // HTypeTextBox
            // 
            this.HTypeTextBox.Enabled = false;
            this.HTypeTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HTypeTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HTypeTextBox.FormattingEnabled = true;
            this.HTypeTextBox.Location = new System.Drawing.Point(201, 41);
            this.HTypeTextBox.Name = "HTypeTextBox";
            this.HTypeTextBox.Size = new System.Drawing.Size(288, 31);
            this.HTypeTextBox.TabIndex = 19;
            this.HTypeTextBox.SelectedIndexChanged += new System.EventHandler(this.HTypeTextBox_SelectedIndexChanged);
            // 
            // editDepartmenButton
            // 
            this.editDepartmenButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.editDepartmenButton.FlatAppearance.BorderSize = 0;
            this.editDepartmenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editDepartmenButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editDepartmenButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editDepartmenButton.Image = global::InformSystem.Properties.Resources.edit48481;
            this.editDepartmenButton.Location = new System.Drawing.Point(495, 151);
            this.editDepartmenButton.Name = "editDepartmenButton";
            this.editDepartmenButton.Size = new System.Drawing.Size(36, 29);
            this.editDepartmenButton.TabIndex = 18;
            this.editDepartmenButton.UseVisualStyleBackColor = false;
            // 
            // departmenTextBox
            // 
            this.departmenTextBox.Enabled = false;
            this.departmenTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departmenTextBox.Location = new System.Drawing.Point(201, 155);
            this.departmenTextBox.Name = "departmenTextBox";
            this.departmenTextBox.Size = new System.Drawing.Size(288, 32);
            this.departmenTextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(7, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 23);
            this.label8.TabIndex = 16;
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
            this.editPersonButton.Location = new System.Drawing.Point(495, 109);
            this.editPersonButton.Name = "editPersonButton";
            this.editPersonButton.Size = new System.Drawing.Size(36, 29);
            this.editPersonButton.TabIndex = 11;
            this.editPersonButton.Text = "Р";
            this.editPersonButton.UseVisualStyleBackColor = false;
            // 
            // editPlaceButton
            // 
            this.editPlaceButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.editPlaceButton.FlatAppearance.BorderSize = 0;
            this.editPlaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPlaceButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editPlaceButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editPlaceButton.Image = global::InformSystem.Properties.Resources.edit48481;
            this.editPlaceButton.Location = new System.Drawing.Point(495, 71);
            this.editPlaceButton.Name = "editPlaceButton";
            this.editPlaceButton.Size = new System.Drawing.Size(36, 29);
            this.editPlaceButton.TabIndex = 10;
            this.editPlaceButton.Text = "Р";
            this.editPlaceButton.UseVisualStyleBackColor = false;
            this.editPlaceButton.Click += new System.EventHandler(this.changePlaceButton_Click);
            // 
            // DiagFormatTextBox
            // 
            this.DiagFormatTextBox.Enabled = false;
            this.DiagFormatTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiagFormatTextBox.Location = new System.Drawing.Point(201, 198);
            this.DiagFormatTextBox.Name = "DiagFormatTextBox";
            this.DiagFormatTextBox.Size = new System.Drawing.Size(288, 32);
            this.DiagFormatTextBox.TabIndex = 9;
            this.DiagFormatTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DiagAndFormatLabel
            // 
            this.DiagAndFormatLabel.AutoSize = true;
            this.DiagAndFormatLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiagAndFormatLabel.Location = new System.Drawing.Point(7, 197);
            this.DiagAndFormatLabel.Name = "DiagAndFormatLabel";
            this.DiagAndFormatLabel.Size = new System.Drawing.Size(117, 23);
            this.DiagAndFormatLabel.TabIndex = 8;
            this.DiagAndFormatLabel.Text = "Диагональ";
            // 
            // PersonTextBox
            // 
            this.PersonTextBox.Enabled = false;
            this.PersonTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PersonTextBox.Location = new System.Drawing.Point(201, 111);
            this.PersonTextBox.Name = "PersonTextBox";
            this.PersonTextBox.Size = new System.Drawing.Size(288, 32);
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
            this.PlaceTextBox.Size = new System.Drawing.Size(288, 32);
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
            this.IdTextBox.Size = new System.Drawing.Size(288, 32);
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
            // ServisHistoryPanel
            // 
            this.ServisHistoryPanel.Controls.Add(this.dataGridViewServisHistory);
            this.ServisHistoryPanel.Controls.Add(label6);
            this.ServisHistoryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServisHistoryPanel.Location = new System.Drawing.Point(0, 245);
            this.ServisHistoryPanel.Name = "ServisHistoryPanel";
            this.ServisHistoryPanel.Size = new System.Drawing.Size(800, 212);
            this.ServisHistoryPanel.TabIndex = 3;
            // 
            // dataGridViewServisHistory
            // 
            this.dataGridViewServisHistory.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewServisHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewServisHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServisHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewServisHistory.Location = new System.Drawing.Point(0, 23);
            this.dataGridViewServisHistory.Name = "dataGridViewServisHistory";
            this.dataGridViewServisHistory.RowHeadersWidth = 51;
            this.dataGridViewServisHistory.RowTemplate.Height = 29;
            this.dataGridViewServisHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServisHistory.Size = new System.Drawing.Size(800, 188);
            this.dataGridViewServisHistory.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.Location = new System.Drawing.Point(681, 463);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(119, 29);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // PeripheryHWForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ServisHistoryPanel);
            this.Controls.Add(this.panelCommonInfo);
            this.Name = "PeripheryHWForm";
            this.Text = "PeripheryHWForm";
            this.panelCommonInfo.ResumeLayout(false);
            this.panelCommonInfo.PerformLayout();
            this.ServisHistoryPanel.ResumeLayout(false);
            this.ServisHistoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServisHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelCommonInfo;
        private TextBox PersonTextBox;
        private Label label4;
        private TextBox PlaceTextBox;
        private Label label3;
        private Label label2;
        private TextBox IdTextBox;
        private Label label1;
        private TextBox DiagFormatTextBox;
        private Label DiagAndFormatLabel;
        private Panel ServisHistoryPanel;
        private DataGridView dataGridViewServisHistory;
        private Button saveButton;
        private Button editPlaceButton;
        private Button editPersonButton;
        private Button editDepartmenButton;
        private TextBox departmenTextBox;
        private Label label8;
        private ComboBox HTypeTextBox;
        private Button editTypeButton;
    }
}