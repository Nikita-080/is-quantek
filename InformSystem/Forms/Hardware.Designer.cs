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
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.databaseTable = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Office = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.acceptFiltButton = new System.Windows.Forms.Button();
            this.HardStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HTypeTextBox = new System.Windows.Forms.ComboBox();
            this.departmenTextBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolsPanel.SuspendLayout();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTable)).BeginInit();
            this.filterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolsPanel
            // 
            this.toolsPanel.Controls.Add(this.refreshButton);
            this.toolsPanel.Controls.Add(this.SearchButton);
            this.toolsPanel.Controls.Add(this.filterButton);
            this.toolsPanel.Controls.Add(this.addButton);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolsPanel.Location = new System.Drawing.Point(0, 0);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(1147, 59);
            this.toolsPanel.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.refreshButton.Location = new System.Drawing.Point(842, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(161, 35);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SearchButton.Image = global::InformSystem.Properties.Resources.search;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchButton.Location = new System.Drawing.Point(1009, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(135, 35);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.filterButton.FlatAppearance.BorderSize = 0;
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.filterButton.Location = new System.Drawing.Point(118, 12);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(161, 35);
            this.filterButton.TabIndex = 1;
            this.filterButton.Text = "Фильтры";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.Location = new System.Drawing.Point(11, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(101, 35);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tablePanel
            // 
            this.tablePanel.Controls.Add(this.databaseTable);
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Location = new System.Drawing.Point(0, 162);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(1147, 318);
            this.tablePanel.TabIndex = 1;
            // 
            // databaseTable
            // 
            this.databaseTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.databaseTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.databaseTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.databaseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databaseTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Type,
            this.Person,
            this.Department,
            this.Building,
            this.Floor,
            this.Office,
            this.isWork,
            this.typeID});
            this.databaseTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseTable.Location = new System.Drawing.Point(0, 0);
            this.databaseTable.Name = "databaseTable";
            this.databaseTable.ReadOnly = true;
            this.databaseTable.RowHeadersVisible = false;
            this.databaseTable.RowHeadersWidth = 51;
            this.databaseTable.RowTemplate.Height = 29;
            this.databaseTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.databaseTable.Size = new System.Drawing.Size(1147, 318);
            this.databaseTable.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Номер";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Person
            // 
            this.Person.HeaderText = "Пользователь";
            this.Person.MinimumWidth = 6;
            this.Person.Name = "Person";
            this.Person.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.HeaderText = "Отдел";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // Building
            // 
            this.Building.HeaderText = "Здание";
            this.Building.MinimumWidth = 6;
            this.Building.Name = "Building";
            this.Building.ReadOnly = true;
            // 
            // Floor
            // 
            this.Floor.HeaderText = "Этаж";
            this.Floor.MinimumWidth = 6;
            this.Floor.Name = "Floor";
            this.Floor.ReadOnly = true;
            // 
            // Office
            // 
            this.Office.HeaderText = "Офис";
            this.Office.MinimumWidth = 6;
            this.Office.Name = "Office";
            this.Office.ReadOnly = true;
            // 
            // isWork
            // 
            this.isWork.HeaderText = "Состояние";
            this.isWork.MinimumWidth = 6;
            this.isWork.Name = "isWork";
            this.isWork.ReadOnly = true;
            // 
            // typeID
            // 
            this.typeID.HeaderText = "typeID";
            this.typeID.MinimumWidth = 6;
            this.typeID.Name = "typeID";
            this.typeID.ReadOnly = true;
            this.typeID.Visible = false;
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.clearButton);
            this.filterPanel.Controls.Add(this.acceptFiltButton);
            this.filterPanel.Controls.Add(this.HardStatusComboBox);
            this.filterPanel.Controls.Add(this.label1);
            this.filterPanel.Controls.Add(this.HTypeTextBox);
            this.filterPanel.Controls.Add(this.departmenTextBox);
            this.filterPanel.Controls.Add(this.label8);
            this.filterPanel.Controls.Add(this.label2);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 59);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(1147, 103);
            this.filterPanel.TabIndex = 2;
            this.filterPanel.Visible = false;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearButton.Location = new System.Drawing.Point(974, 49);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(161, 35);
            this.clearButton.TabIndex = 29;
            this.clearButton.Text = "Сбросить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // acceptFiltButton
            // 
            this.acceptFiltButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.acceptFiltButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.acceptFiltButton.FlatAppearance.BorderSize = 0;
            this.acceptFiltButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptFiltButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acceptFiltButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.acceptFiltButton.Location = new System.Drawing.Point(974, 4);
            this.acceptFiltButton.Name = "acceptFiltButton";
            this.acceptFiltButton.Size = new System.Drawing.Size(161, 35);
            this.acceptFiltButton.TabIndex = 28;
            this.acceptFiltButton.Text = "Применить";
            this.acceptFiltButton.UseVisualStyleBackColor = false;
            this.acceptFiltButton.Click += new System.EventHandler(this.acceptFiltButton_Click);
            // 
            // HardStatusComboBox
            // 
            this.HardStatusComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HardStatusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HardStatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HardStatusComboBox.FormattingEnabled = true;
            this.HardStatusComboBox.Location = new System.Drawing.Point(517, 8);
            this.HardStatusComboBox.Name = "HardStatusComboBox";
            this.HardStatusComboBox.Size = new System.Drawing.Size(287, 33);
            this.HardStatusComboBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(397, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Состояние";
            // 
            // HTypeTextBox
            // 
            this.HTypeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HTypeTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HTypeTextBox.FormattingEnabled = true;
            this.HTypeTextBox.Location = new System.Drawing.Point(91, 8);
            this.HTypeTextBox.Name = "HTypeTextBox";
            this.HTypeTextBox.Size = new System.Drawing.Size(287, 33);
            this.HTypeTextBox.TabIndex = 25;
            // 
            // departmenTextBox
            // 
            this.departmenTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.departmenTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departmenTextBox.FormattingEnabled = true;
            this.departmenTextBox.Location = new System.Drawing.Point(91, 45);
            this.departmenTextBox.Name = "departmenTextBox";
            this.departmenTextBox.Size = new System.Drawing.Size(287, 33);
            this.departmenTextBox.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(11, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Отдел";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Тип";
            // 
            // Hardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 480);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.toolsPanel);
            this.Name = "Hardware";
            this.Text = "Оборудование";
            this.toolsPanel.ResumeLayout(false);
            this.tablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.databaseTable)).EndInit();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.ResumeLayout(false);

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