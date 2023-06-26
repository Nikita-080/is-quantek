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
            Label label5;
            Label label6;
            Label label7;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelCommonInfo = new Panel();
            StatusTextBox = new ComboBox();
            label9 = new Label();
            departmenTextBox = new ComboBox();
            label8 = new Label();
            editPlaceButton = new Button();
            PersonTextBox = new TextBox();
            label4 = new Label();
            PlaceTextBox = new TextBox();
            label3 = new Label();
            HTypeTextBox = new TextBox();
            label2 = new Label();
            IdTextBox = new TextBox();
            label1 = new Label();
            PCHardInfoPanel = new Panel();
            dataGridViewPcInfo = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            value = new DataGridViewTextBoxColumn();
            ServisHistoryPanel = new Panel();
            dataGridViewServisHistory = new DataGridView();
            DateIn = new DataGridViewTextBoxColumn();
            DateOut = new DataGridViewTextBoxColumn();
            Reason = new DataGridViewTextBoxColumn();
            Verdict = new DataGridViewTextBoxColumn();
            ConnectedHWPanel = new Panel();
            deleteButton = new Button();
            addButton = new Button();
            dataGridViewConnectedHW = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            saveButton = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panelCommonInfo.SuspendLayout();
            PCHardInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPcInfo).BeginInit();
            ServisHistoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServisHistory).BeginInit();
            ConnectedHWPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConnectedHW).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(220, 20);
            label5.TabIndex = 1;
            label5.Text = "Системные характеристики";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(141, 20);
            label6.TabIndex = 1;
            label6.Text = "История Сервиса";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(222, 20);
            label7.TabIndex = 1;
            label7.Text = "Привязанное оборудование";
            // 
            // panelCommonInfo
            // 
            panelCommonInfo.Controls.Add(StatusTextBox);
            panelCommonInfo.Controls.Add(label9);
            panelCommonInfo.Controls.Add(departmenTextBox);
            panelCommonInfo.Controls.Add(label8);
            panelCommonInfo.Controls.Add(editPlaceButton);
            panelCommonInfo.Controls.Add(PersonTextBox);
            panelCommonInfo.Controls.Add(label4);
            panelCommonInfo.Controls.Add(PlaceTextBox);
            panelCommonInfo.Controls.Add(label3);
            panelCommonInfo.Controls.Add(HTypeTextBox);
            panelCommonInfo.Controls.Add(label2);
            panelCommonInfo.Controls.Add(IdTextBox);
            panelCommonInfo.Controls.Add(label1);
            panelCommonInfo.Dock = DockStyle.Top;
            panelCommonInfo.Location = new Point(0, 0);
            panelCommonInfo.Margin = new Padding(3, 2, 3, 2);
            panelCommonInfo.Name = "panelCommonInfo";
            panelCommonInfo.Size = new Size(702, 184);
            panelCommonInfo.TabIndex = 0;
            // 
            // StatusTextBox
            // 
            StatusTextBox.Enabled = false;
            StatusTextBox.FlatStyle = FlatStyle.Flat;
            StatusTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StatusTextBox.FormattingEnabled = true;
            StatusTextBox.Location = new Point(176, 143);
            StatusTextBox.Margin = new Padding(3, 2, 3, 2);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.Size = new Size(252, 28);
            StatusTextBox.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(6, 146);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 24;
            label9.Text = "Состояние";
            // 
            // departmenTextBox
            // 
            departmenTextBox.Enabled = false;
            departmenTextBox.FlatStyle = FlatStyle.Flat;
            departmenTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            departmenTextBox.FormattingEnabled = true;
            departmenTextBox.Location = new Point(176, 111);
            departmenTextBox.Margin = new Padding(3, 2, 3, 2);
            departmenTextBox.Name = "departmenTextBox";
            departmenTextBox.Size = new Size(252, 28);
            departmenTextBox.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 113);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 13;
            label8.Text = "Отдел";
            // 
            // editPlaceButton
            // 
            editPlaceButton.BackColor = SystemColors.ButtonFace;
            editPlaceButton.FlatAppearance.BorderSize = 0;
            editPlaceButton.FlatStyle = FlatStyle.Flat;
            editPlaceButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            editPlaceButton.ForeColor = SystemColors.ButtonFace;
            editPlaceButton.Image = Properties.Resources.edit48481;
            editPlaceButton.Location = new Point(434, 56);
            editPlaceButton.Margin = new Padding(3, 2, 3, 2);
            editPlaceButton.Name = "editPlaceButton";
            editPlaceButton.Size = new Size(32, 22);
            editPlaceButton.TabIndex = 11;
            editPlaceButton.UseVisualStyleBackColor = false;
            editPlaceButton.Click += editPlaceButton_Click;
            // 
            // PersonTextBox
            // 
            PersonTextBox.Enabled = false;
            PersonTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PersonTextBox.Location = new Point(176, 83);
            PersonTextBox.Margin = new Padding(3, 2, 3, 2);
            PersonTextBox.Name = "PersonTextBox";
            PersonTextBox.Size = new Size(252, 26);
            PersonTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 83);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 6;
            label4.Text = "Пользователь";
            // 
            // PlaceTextBox
            // 
            PlaceTextBox.Enabled = false;
            PlaceTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PlaceTextBox.Location = new Point(176, 56);
            PlaceTextBox.Margin = new Padding(3, 2, 3, 2);
            PlaceTextBox.Name = "PlaceTextBox";
            PlaceTextBox.Size = new Size(252, 26);
            PlaceTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 56);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 4;
            label3.Text = "Местоположение";
            // 
            // HTypeTextBox
            // 
            HTypeTextBox.Enabled = false;
            HTypeTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HTypeTextBox.Location = new Point(176, 31);
            HTypeTextBox.Margin = new Padding(3, 2, 3, 2);
            HTypeTextBox.Name = "HTypeTextBox";
            HTypeTextBox.Size = new Size(252, 26);
            HTypeTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 31);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 2;
            label2.Text = "Вид";
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IdTextBox.Location = new Point(176, 5);
            IdTextBox.Margin = new Padding(3, 2, 3, 2);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(252, 26);
            IdTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 7);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // PCHardInfoPanel
            // 
            PCHardInfoPanel.Controls.Add(dataGridViewPcInfo);
            PCHardInfoPanel.Controls.Add(label5);
            PCHardInfoPanel.Dock = DockStyle.Top;
            PCHardInfoPanel.Location = new Point(0, 184);
            PCHardInfoPanel.Margin = new Padding(3, 2, 3, 2);
            PCHardInfoPanel.Name = "PCHardInfoPanel";
            PCHardInfoPanel.Size = new Size(702, 175);
            PCHardInfoPanel.TabIndex = 1;
            // 
            // dataGridViewPcInfo
            // 
            dataGridViewPcInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPcInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPcInfo.BackgroundColor = SystemColors.Control;
            dataGridViewPcInfo.BorderStyle = BorderStyle.None;
            dataGridViewPcInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPcInfo.ColumnHeadersVisible = false;
            dataGridViewPcInfo.Columns.AddRange(new DataGridViewColumn[] { name, value });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewPcInfo.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPcInfo.Dock = DockStyle.Fill;
            dataGridViewPcInfo.GridColor = SystemColors.ButtonFace;
            dataGridViewPcInfo.Location = new Point(0, 20);
            dataGridViewPcInfo.Margin = new Padding(3, 2, 3, 2);
            dataGridViewPcInfo.Name = "dataGridViewPcInfo";
            dataGridViewPcInfo.RowHeadersVisible = false;
            dataGridViewPcInfo.RowHeadersWidth = 51;
            dataGridViewPcInfo.RowTemplate.Height = 29;
            dataGridViewPcInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPcInfo.Size = new Size(702, 155);
            dataGridViewPcInfo.TabIndex = 2;
            // 
            // name
            // 
            name.HeaderText = "name";
            name.MinimumWidth = 6;
            name.Name = "name";
            // 
            // value
            // 
            value.HeaderText = "value";
            value.MinimumWidth = 6;
            value.Name = "value";
            // 
            // ServisHistoryPanel
            // 
            ServisHistoryPanel.Controls.Add(dataGridViewServisHistory);
            ServisHistoryPanel.Controls.Add(label6);
            ServisHistoryPanel.Dock = DockStyle.Top;
            ServisHistoryPanel.Location = new Point(0, 359);
            ServisHistoryPanel.Margin = new Padding(3, 2, 3, 2);
            ServisHistoryPanel.Name = "ServisHistoryPanel";
            ServisHistoryPanel.Size = new Size(702, 165);
            ServisHistoryPanel.TabIndex = 2;
            // 
            // dataGridViewServisHistory
            // 
            dataGridViewServisHistory.BackgroundColor = SystemColors.Control;
            dataGridViewServisHistory.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewServisHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewServisHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServisHistory.Columns.AddRange(new DataGridViewColumn[] { DateIn, DateOut, Reason, Verdict });
            dataGridViewServisHistory.Dock = DockStyle.Top;
            dataGridViewServisHistory.Location = new Point(0, 20);
            dataGridViewServisHistory.Margin = new Padding(3, 2, 3, 2);
            dataGridViewServisHistory.Name = "dataGridViewServisHistory";
            dataGridViewServisHistory.RowHeadersVisible = false;
            dataGridViewServisHistory.RowHeadersWidth = 51;
            dataGridViewServisHistory.RowTemplate.Height = 29;
            dataGridViewServisHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewServisHistory.Size = new Size(702, 141);
            dataGridViewServisHistory.TabIndex = 2;
            // 
            // DateIn
            // 
            DateIn.HeaderText = "Дата получения";
            DateIn.MinimumWidth = 6;
            DateIn.Name = "DateIn";
            DateIn.Width = 125;
            // 
            // DateOut
            // 
            DateOut.HeaderText = "Дата возврата";
            DateOut.MinimumWidth = 6;
            DateOut.Name = "DateOut";
            DateOut.Width = 125;
            // 
            // Reason
            // 
            Reason.HeaderText = "Причина";
            Reason.MinimumWidth = 6;
            Reason.Name = "Reason";
            Reason.Width = 125;
            // 
            // Verdict
            // 
            Verdict.HeaderText = "Вердикт";
            Verdict.MinimumWidth = 6;
            Verdict.Name = "Verdict";
            Verdict.Width = 125;
            // 
            // ConnectedHWPanel
            // 
            ConnectedHWPanel.Controls.Add(deleteButton);
            ConnectedHWPanel.Controls.Add(addButton);
            ConnectedHWPanel.Controls.Add(dataGridViewConnectedHW);
            ConnectedHWPanel.Controls.Add(label7);
            ConnectedHWPanel.Dock = DockStyle.Top;
            ConnectedHWPanel.Location = new Point(0, 524);
            ConnectedHWPanel.Margin = new Padding(3, 2, 3, 2);
            ConnectedHWPanel.Name = "ConnectedHWPanel";
            ConnectedHWPanel.Size = new Size(702, 186);
            ConnectedHWPanel.TabIndex = 3;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(0, 42, 87);
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.ForeColor = SystemColors.ButtonFace;
            deleteButton.Location = new Point(610, 153);
            deleteButton.Margin = new Padding(3, 2, 3, 2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(88, 30);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Отвязать";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(0, 42, 87);
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.ForeColor = SystemColors.ButtonFace;
            addButton.Location = new Point(517, 153);
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(88, 30);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // dataGridViewConnectedHW
            // 
            dataGridViewConnectedHW.BackgroundColor = SystemColors.Control;
            dataGridViewConnectedHW.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewConnectedHW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewConnectedHW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConnectedHW.Columns.AddRange(new DataGridViewColumn[] { Id, Type });
            dataGridViewConnectedHW.Dock = DockStyle.Top;
            dataGridViewConnectedHW.Location = new Point(0, 20);
            dataGridViewConnectedHW.Margin = new Padding(3, 2, 3, 2);
            dataGridViewConnectedHW.Name = "dataGridViewConnectedHW";
            dataGridViewConnectedHW.RowHeadersVisible = false;
            dataGridViewConnectedHW.RowHeadersWidth = 51;
            dataGridViewConnectedHW.RowTemplate.Height = 29;
            dataGridViewConnectedHW.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewConnectedHW.Size = new Size(702, 129);
            dataGridViewConnectedHW.TabIndex = 2;
            // 
            // Id
            // 
            Id.HeaderText = "Номер";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 175;
            // 
            // Type
            // 
            Type.HeaderText = "Тип";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.Width = 175;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(0, 42, 87);
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.ForeColor = SystemColors.ButtonFace;
            saveButton.Location = new Point(517, 714);
            saveButton.Margin = new Padding(3, 2, 3, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(181, 26);
            saveButton.TabIndex = 5;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // PCInformForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(702, 747);
            Controls.Add(saveButton);
            Controls.Add(ConnectedHWPanel);
            Controls.Add(ServisHistoryPanel);
            Controls.Add(PCHardInfoPanel);
            Controls.Add(panelCommonInfo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PCInformForm";
            Text = "PCInformForm";
            panelCommonInfo.ResumeLayout(false);
            panelCommonInfo.PerformLayout();
            PCHardInfoPanel.ResumeLayout(false);
            PCHardInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPcInfo).EndInit();
            ServisHistoryPanel.ResumeLayout(false);
            ServisHistoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServisHistory).EndInit();
            ConnectedHWPanel.ResumeLayout(false);
            ConnectedHWPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConnectedHW).EndInit();
            ResumeLayout(false);
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
        private Panel ConnectedHWPanel;
        private DataGridView dataGridViewConnectedHW;
        private Button deleteButton;
        private Button addButton;
        private Button saveButton;
        private Button editPlaceButton;
        private Label label8;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn value;
        private ComboBox departmenTextBox;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Type;
        private DataGridView dataGridViewServisHistory;
        private DataGridViewTextBoxColumn DateIn;
        private DataGridViewTextBoxColumn DateOut;
        private DataGridViewTextBoxColumn Reason;
        private DataGridViewTextBoxColumn Verdict;
        private ComboBox StatusTextBox;
        private Label label9;
    }
}