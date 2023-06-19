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
            Label label6;
            panelCommonInfo = new Panel();
            departmenTextBox = new ComboBox();
            HTypeTextBox = new ComboBox();
            label8 = new Label();
            editPersonButton = new Button();
            editPlaceButton = new Button();
            DiagFormatTextBox = new TextBox();
            DiagAndFormatLabel = new Label();
            PersonTextBox = new TextBox();
            label4 = new Label();
            PlaceTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            IdTextBox = new TextBox();
            label1 = new Label();
            ServisHistoryPanel = new Panel();
            saveButton = new Button();
            dataGridViewServisHistory = new DataGridView();
            label6 = new Label();
            panelCommonInfo.SuspendLayout();
            ServisHistoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServisHistory).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(152, 21);
            label6.TabIndex = 1;
            label6.Text = "История Сервиса";
            // 
            // panelCommonInfo
            // 
            panelCommonInfo.Controls.Add(departmenTextBox);
            panelCommonInfo.Controls.Add(HTypeTextBox);
            panelCommonInfo.Controls.Add(label8);
            panelCommonInfo.Controls.Add(editPersonButton);
            panelCommonInfo.Controls.Add(editPlaceButton);
            panelCommonInfo.Controls.Add(DiagFormatTextBox);
            panelCommonInfo.Controls.Add(DiagAndFormatLabel);
            panelCommonInfo.Controls.Add(PersonTextBox);
            panelCommonInfo.Controls.Add(label4);
            panelCommonInfo.Controls.Add(PlaceTextBox);
            panelCommonInfo.Controls.Add(label3);
            panelCommonInfo.Controls.Add(label2);
            panelCommonInfo.Controls.Add(IdTextBox);
            panelCommonInfo.Controls.Add(label1);
            panelCommonInfo.Dock = DockStyle.Top;
            panelCommonInfo.Location = new Point(0, 0);
            panelCommonInfo.Margin = new Padding(3, 2, 3, 2);
            panelCommonInfo.Name = "panelCommonInfo";
            panelCommonInfo.Size = new Size(702, 201);
            panelCommonInfo.TabIndex = 1;
            // 
            // departmenTextBox
            // 
            departmenTextBox.Enabled = false;
            departmenTextBox.FlatStyle = FlatStyle.Flat;
            departmenTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            departmenTextBox.FormattingEnabled = true;
            departmenTextBox.Location = new Point(176, 131);
            departmenTextBox.Margin = new Padding(3, 2, 3, 2);
            departmenTextBox.Name = "departmenTextBox";
            departmenTextBox.Size = new Size(252, 29);
            departmenTextBox.TabIndex = 21;
            // 
            // HTypeTextBox
            // 
            HTypeTextBox.Enabled = false;
            HTypeTextBox.FlatStyle = FlatStyle.Flat;
            HTypeTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HTypeTextBox.FormattingEnabled = true;
            HTypeTextBox.Location = new Point(176, 36);
            HTypeTextBox.Margin = new Padding(3, 2, 3, 2);
            HTypeTextBox.Name = "HTypeTextBox";
            HTypeTextBox.Size = new Size(252, 29);
            HTypeTextBox.TabIndex = 19;
            HTypeTextBox.SelectedIndexChanged += HTypeTextBox_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 132);
            label8.Name = "label8";
            label8.Size = new Size(58, 21);
            label8.TabIndex = 16;
            label8.Text = "Отдел";
            // 
            // editPersonButton
            // 
            editPersonButton.BackColor = SystemColors.ButtonFace;
            editPersonButton.FlatAppearance.BorderSize = 0;
            editPersonButton.FlatStyle = FlatStyle.Flat;
            editPersonButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            editPersonButton.ForeColor = SystemColors.ButtonFace;
            editPersonButton.Image = Properties.Resources.edit48481;
            editPersonButton.Location = new Point(434, 101);
            editPersonButton.Margin = new Padding(3, 2, 3, 2);
            editPersonButton.Name = "editPersonButton";
            editPersonButton.Size = new Size(32, 22);
            editPersonButton.TabIndex = 11;
            editPersonButton.Text = "Р";
            editPersonButton.UseVisualStyleBackColor = false;
            editPersonButton.Click += editPersonButton_Click;
            // 
            // editPlaceButton
            // 
            editPlaceButton.BackColor = SystemColors.ButtonFace;
            editPlaceButton.FlatAppearance.BorderSize = 0;
            editPlaceButton.FlatStyle = FlatStyle.Flat;
            editPlaceButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            editPlaceButton.ForeColor = SystemColors.ButtonFace;
            editPlaceButton.Image = Properties.Resources.edit48481;
            editPlaceButton.Location = new Point(434, 68);
            editPlaceButton.Margin = new Padding(3, 2, 3, 2);
            editPlaceButton.Name = "editPlaceButton";
            editPlaceButton.Size = new Size(32, 22);
            editPlaceButton.TabIndex = 10;
            editPlaceButton.Text = "Р";
            editPlaceButton.UseVisualStyleBackColor = false;
            editPlaceButton.Click += changePlaceButton_Click;
            // 
            // DiagFormatTextBox
            // 
            DiagFormatTextBox.Enabled = false;
            DiagFormatTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DiagFormatTextBox.Location = new Point(176, 164);
            DiagFormatTextBox.Margin = new Padding(3, 2, 3, 2);
            DiagFormatTextBox.Name = "DiagFormatTextBox";
            DiagFormatTextBox.Size = new Size(252, 27);
            DiagFormatTextBox.TabIndex = 9;
            DiagFormatTextBox.TextChanged += textBox1_TextChanged;
            // 
            // DiagAndFormatLabel
            // 
            DiagAndFormatLabel.AutoSize = true;
            DiagAndFormatLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DiagAndFormatLabel.Location = new Point(6, 164);
            DiagAndFormatLabel.Name = "DiagAndFormatLabel";
            DiagAndFormatLabel.Size = new Size(97, 21);
            DiagAndFormatLabel.TabIndex = 8;
            DiagAndFormatLabel.Text = "Диагональ";
            // 
            // PersonTextBox
            // 
            PersonTextBox.Enabled = false;
            PersonTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PersonTextBox.Location = new Point(176, 99);
            PersonTextBox.Margin = new Padding(3, 2, 3, 2);
            PersonTextBox.Name = "PersonTextBox";
            PersonTextBox.Size = new Size(252, 27);
            PersonTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 99);
            label4.Name = "label4";
            label4.Size = new Size(127, 21);
            label4.TabIndex = 6;
            label4.Text = "Ответственный";
            // 
            // PlaceTextBox
            // 
            PlaceTextBox.Enabled = false;
            PlaceTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PlaceTextBox.Location = new Point(176, 68);
            PlaceTextBox.Margin = new Padding(3, 2, 3, 2);
            PlaceTextBox.Name = "PlaceTextBox";
            PlaceTextBox.Size = new Size(252, 27);
            PlaceTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 68);
            label3.Name = "label3";
            label3.Size = new Size(151, 21);
            label3.TabIndex = 4;
            label3.Text = "Местоположение";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 36);
            label2.Name = "label2";
            label2.Size = new Size(38, 21);
            label2.TabIndex = 2;
            label2.Text = "Вид";
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IdTextBox.Location = new Point(176, 5);
            IdTextBox.Margin = new Padding(3, 2, 3, 2);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(252, 27);
            IdTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 7);
            label1.Name = "label1";
            label1.Size = new Size(27, 21);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // ServisHistoryPanel
            // 
            ServisHistoryPanel.Controls.Add(saveButton);
            ServisHistoryPanel.Controls.Add(dataGridViewServisHistory);
            ServisHistoryPanel.Controls.Add(label6);
            ServisHistoryPanel.Dock = DockStyle.Top;
            ServisHistoryPanel.Location = new Point(0, 201);
            ServisHistoryPanel.Margin = new Padding(3, 2, 3, 2);
            ServisHistoryPanel.Name = "ServisHistoryPanel";
            ServisHistoryPanel.Size = new Size(702, 179);
            ServisHistoryPanel.TabIndex = 3;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(0, 42, 87);
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.ForeColor = SystemColors.ButtonFace;
            saveButton.Location = new Point(595, 146);
            saveButton.Margin = new Padding(3, 2, 3, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(104, 27);
            saveButton.TabIndex = 4;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // dataGridViewServisHistory
            // 
            dataGridViewServisHistory.BackgroundColor = SystemColors.ControlLight;
            dataGridViewServisHistory.BorderStyle = BorderStyle.None;
            dataGridViewServisHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServisHistory.Dock = DockStyle.Top;
            dataGridViewServisHistory.Location = new Point(0, 21);
            dataGridViewServisHistory.Margin = new Padding(3, 2, 3, 2);
            dataGridViewServisHistory.Name = "dataGridViewServisHistory";
            dataGridViewServisHistory.RowHeadersWidth = 51;
            dataGridViewServisHistory.RowTemplate.Height = 29;
            dataGridViewServisHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewServisHistory.Size = new Size(702, 121);
            dataGridViewServisHistory.TabIndex = 2;
            // 
            // PeripheryHWForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 377);
            Controls.Add(ServisHistoryPanel);
            Controls.Add(panelCommonInfo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PeripheryHWForm";
            Text = "PeripheryHWForm";
            panelCommonInfo.ResumeLayout(false);
            panelCommonInfo.PerformLayout();
            ServisHistoryPanel.ResumeLayout(false);
            ServisHistoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServisHistory).EndInit();
            ResumeLayout(false);
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
        private Label label8;
        private ComboBox HTypeTextBox;
        private ComboBox departmenTextBox;
    }
}