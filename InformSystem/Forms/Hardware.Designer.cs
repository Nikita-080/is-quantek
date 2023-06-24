namespace InformSystem.Forms
{
    partial class Hardware
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
            toolsPanel = new Panel();
            refreshButton = new Button();
            SearchButton = new Button();
            filterButton = new Button();
            addButton = new Button();
            tablePanel = new Panel();
            databaseTable = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Person = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            Building = new DataGridViewTextBoxColumn();
            Floor = new DataGridViewTextBoxColumn();
            Office = new DataGridViewTextBoxColumn();
            isWork = new DataGridViewTextBoxColumn();
            typeID = new DataGridViewTextBoxColumn();
            filterPanel = new Panel();
            clearButton = new Button();
            acceptFiltButton = new Button();
            HardStatusComboBox = new ComboBox();
            label1 = new Label();
            HTypeTextBox = new ComboBox();
            departmenTextBox = new ComboBox();
            label8 = new Label();
            label2 = new Label();
            toolsPanel.SuspendLayout();
            tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)databaseTable).BeginInit();
            filterPanel.SuspendLayout();
            SuspendLayout();
            // 
            // toolsPanel
            // 
            toolsPanel.Controls.Add(refreshButton);
            toolsPanel.Controls.Add(SearchButton);
            toolsPanel.Controls.Add(filterButton);
            toolsPanel.Controls.Add(addButton);
            toolsPanel.Dock = DockStyle.Top;
            toolsPanel.Location = new Point(0, 0);
            toolsPanel.Margin = new Padding(3, 2, 3, 2);
            toolsPanel.Name = "toolsPanel";
            toolsPanel.Size = new Size(1004, 44);
            toolsPanel.TabIndex = 0;
            // 
            // refreshButton
            // 
            refreshButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refreshButton.BackColor = Color.FromArgb(0, 42, 87);
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            refreshButton.ForeColor = SystemColors.ButtonFace;
            refreshButton.Location = new Point(737, 9);
            refreshButton.Margin = new Padding(3, 2, 3, 2);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(141, 26);
            refreshButton.TabIndex = 3;
            refreshButton.Text = "Обновить";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchButton.BackColor = Color.FromArgb(0, 42, 87);
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SearchButton.ForeColor = SystemColors.ButtonFace;
            SearchButton.Image = Properties.Resources.search;
            SearchButton.ImageAlign = ContentAlignment.MiddleRight;
            SearchButton.Location = new Point(883, 9);
            SearchButton.Margin = new Padding(3, 2, 3, 2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(118, 26);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Найти";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // filterButton
            // 
            filterButton.BackColor = Color.FromArgb(0, 42, 87);
            filterButton.FlatAppearance.BorderSize = 0;
            filterButton.FlatStyle = FlatStyle.Flat;
            filterButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            filterButton.ForeColor = SystemColors.ButtonFace;
            filterButton.Location = new Point(103, 9);
            filterButton.Margin = new Padding(3, 2, 3, 2);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(141, 26);
            filterButton.TabIndex = 1;
            filterButton.Text = "Фильтры";
            filterButton.UseVisualStyleBackColor = false;
            filterButton.Click += filterButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(0, 42, 87);
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.ForeColor = SystemColors.ButtonFace;
            addButton.Location = new Point(10, 9);
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(88, 26);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // tablePanel
            // 
            tablePanel.Controls.Add(databaseTable);
            tablePanel.Dock = DockStyle.Fill;
            tablePanel.Location = new Point(0, 121);
            tablePanel.Margin = new Padding(3, 2, 3, 2);
            tablePanel.Name = "tablePanel";
            tablePanel.Size = new Size(1004, 239);
            tablePanel.TabIndex = 1;
            // 
            // databaseTable
            // 
            databaseTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            databaseTable.BackgroundColor = SystemColors.ControlLight;
            databaseTable.BorderStyle = BorderStyle.None;
            databaseTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            databaseTable.Columns.AddRange(new DataGridViewColumn[] { Id, Type, Person, Department, Building, Floor, Office, isWork, typeID });
            databaseTable.Dock = DockStyle.Fill;
            databaseTable.Location = new Point(0, 0);
            databaseTable.Margin = new Padding(3, 2, 3, 2);
            databaseTable.Name = "databaseTable";
            databaseTable.ReadOnly = true;
            databaseTable.RowHeadersVisible = false;
            databaseTable.RowHeadersWidth = 51;
            databaseTable.RowTemplate.Height = 29;
            databaseTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            databaseTable.Size = new Size(1004, 239);
            databaseTable.TabIndex = 0;
            databaseTable.CellDoubleClick += databaseTable_CellDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "Номер";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Type
            // 
            Type.HeaderText = "Тип";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // Person
            // 
            Person.HeaderText = "Пользователь";
            Person.MinimumWidth = 6;
            Person.Name = "Person";
            Person.ReadOnly = true;
            // 
            // Department
            // 
            Department.HeaderText = "Отдел";
            Department.MinimumWidth = 6;
            Department.Name = "Department";
            Department.ReadOnly = true;
            // 
            // Building
            // 
            Building.HeaderText = "Здание";
            Building.MinimumWidth = 6;
            Building.Name = "Building";
            Building.ReadOnly = true;
            // 
            // Floor
            // 
            Floor.HeaderText = "Этаж";
            Floor.MinimumWidth = 6;
            Floor.Name = "Floor";
            Floor.ReadOnly = true;
            // 
            // Office
            // 
            Office.HeaderText = "Офис";
            Office.MinimumWidth = 6;
            Office.Name = "Office";
            Office.ReadOnly = true;
            // 
            // isWork
            // 
            isWork.HeaderText = "Состояние";
            isWork.MinimumWidth = 6;
            isWork.Name = "isWork";
            isWork.ReadOnly = true;
            // 
            // typeID
            // 
            typeID.HeaderText = "typeID";
            typeID.MinimumWidth = 6;
            typeID.Name = "typeID";
            typeID.ReadOnly = true;
            typeID.Visible = false;
            // 
            // filterPanel
            // 
            filterPanel.Controls.Add(clearButton);
            filterPanel.Controls.Add(acceptFiltButton);
            filterPanel.Controls.Add(HardStatusComboBox);
            filterPanel.Controls.Add(label1);
            filterPanel.Controls.Add(HTypeTextBox);
            filterPanel.Controls.Add(departmenTextBox);
            filterPanel.Controls.Add(label8);
            filterPanel.Controls.Add(label2);
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(0, 44);
            filterPanel.Margin = new Padding(3, 2, 3, 2);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(1004, 77);
            filterPanel.TabIndex = 2;
            filterPanel.Visible = false;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Right;
            clearButton.BackColor = Color.FromArgb(0, 42, 87);
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.ForeColor = SystemColors.ButtonFace;
            clearButton.Location = new Point(852, 37);
            clearButton.Margin = new Padding(3, 2, 3, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(141, 26);
            clearButton.TabIndex = 29;
            clearButton.Text = "Сбросить";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // acceptFiltButton
            // 
            acceptFiltButton.Anchor = AnchorStyles.Right;
            acceptFiltButton.BackColor = Color.FromArgb(0, 42, 87);
            acceptFiltButton.FlatAppearance.BorderSize = 0;
            acceptFiltButton.FlatStyle = FlatStyle.Flat;
            acceptFiltButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            acceptFiltButton.ForeColor = SystemColors.ButtonFace;
            acceptFiltButton.Location = new Point(852, 3);
            acceptFiltButton.Margin = new Padding(3, 2, 3, 2);
            acceptFiltButton.Name = "acceptFiltButton";
            acceptFiltButton.Size = new Size(141, 26);
            acceptFiltButton.TabIndex = 28;
            acceptFiltButton.Text = "Применить";
            acceptFiltButton.UseVisualStyleBackColor = false;
            acceptFiltButton.Click += acceptFiltButton_Click;
            // 
            // HardStatusComboBox
            // 
            HardStatusComboBox.Anchor = AnchorStyles.Left;
            HardStatusComboBox.FlatStyle = FlatStyle.Flat;
            HardStatusComboBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HardStatusComboBox.FormattingEnabled = true;
            HardStatusComboBox.Location = new Point(452, 6);
            HardStatusComboBox.Margin = new Padding(3, 2, 3, 2);
            HardStatusComboBox.Name = "HardStatusComboBox";
            HardStatusComboBox.Size = new Size(252, 28);
            HardStatusComboBox.TabIndex = 27;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(347, 8);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 26;
            label1.Text = "Состояние";
            // 
            // HTypeTextBox
            // 
            HTypeTextBox.Anchor = AnchorStyles.Left;
            HTypeTextBox.FlatStyle = FlatStyle.Flat;
            HTypeTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HTypeTextBox.FormattingEnabled = true;
            HTypeTextBox.Location = new Point(80, 6);
            HTypeTextBox.Margin = new Padding(3, 2, 3, 2);
            HTypeTextBox.Name = "HTypeTextBox";
            HTypeTextBox.Size = new Size(252, 28);
            HTypeTextBox.TabIndex = 25;
            // 
            // departmenTextBox
            // 
            departmenTextBox.Anchor = AnchorStyles.Left;
            departmenTextBox.FlatStyle = FlatStyle.Flat;
            departmenTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            departmenTextBox.FormattingEnabled = true;
            departmenTextBox.Location = new Point(80, 34);
            departmenTextBox.Margin = new Padding(3, 2, 3, 2);
            departmenTextBox.Name = "departmenTextBox";
            departmenTextBox.Size = new Size(252, 28);
            departmenTextBox.TabIndex = 24;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(10, 40);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 23;
            label8.Text = "Отдел";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 6);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 21;
            label2.Text = "Тип";
            // 
            // Hardware
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 360);
            Controls.Add(tablePanel);
            Controls.Add(filterPanel);
            Controls.Add(toolsPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Hardware";
            Text = "Hardware";
            toolsPanel.ResumeLayout(false);
            tablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)databaseTable).EndInit();
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel toolsPanel;
        private Button addButton;
        private Panel tablePanel;
        private DataGridView databaseTable;
        private Button filterButton;
        private Panel filterPanel;
        private Button SearchButton;
        private ComboBox HardStatusComboBox;
        private Label label1;
        private ComboBox HTypeTextBox;
        private ComboBox departmenTextBox;
        private Label label8;
        private Label label2;
        private Button clearButton;
        private Button acceptFiltButton;
        private Button refreshButton;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Person;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn Building;
        private DataGridViewTextBoxColumn Floor;
        private DataGridViewTextBoxColumn Office;
        private DataGridViewTextBoxColumn isWork;
        private DataGridViewTextBoxColumn typeID;
    }
}