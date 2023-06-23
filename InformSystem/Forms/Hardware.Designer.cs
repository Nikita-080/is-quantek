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
            sortButton = new Button();
            addButton = new Button();
            tablePanel = new Panel();
            databaseTable = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Person = new DataGridViewTextBoxColumn();
            Building = new DataGridViewTextBoxColumn();
            Floor = new DataGridViewTextBoxColumn();
            Office = new DataGridViewTextBoxColumn();
            isWork = new DataGridViewTextBoxColumn();
            typeID = new DataGridViewTextBoxColumn();
            toolsPanel.SuspendLayout();
            tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)databaseTable).BeginInit();
            SuspendLayout();
            // 
            // toolsPanel
            // 
            toolsPanel.Controls.Add(sortButton);
            toolsPanel.Controls.Add(addButton);
            toolsPanel.Dock = DockStyle.Top;
            toolsPanel.Location = new Point(0, 0);
            toolsPanel.Margin = new Padding(3, 2, 3, 2);
            toolsPanel.Name = "toolsPanel";
            toolsPanel.Size = new Size(1006, 49);
            toolsPanel.TabIndex = 0;
            // 
            // sortButton
            // 
            sortButton.BackColor = Color.FromArgb(0, 42, 87);
            sortButton.FlatAppearance.BorderSize = 0;
            sortButton.FlatStyle = FlatStyle.Flat;
            sortButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            sortButton.ForeColor = SystemColors.ButtonFace;
            sortButton.Location = new Point(103, 9);
            sortButton.Margin = new Padding(3, 2, 3, 2);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(141, 26);
            sortButton.TabIndex = 1;
            sortButton.Text = "Отсортировать";
            sortButton.UseVisualStyleBackColor = false;
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
            tablePanel.Location = new Point(0, 49);
            tablePanel.Margin = new Padding(3, 2, 3, 2);
            tablePanel.Name = "tablePanel";
            tablePanel.Size = new Size(1006, 311);
            tablePanel.TabIndex = 1;
            // 
            // databaseTable
            // 
            databaseTable.BackgroundColor = SystemColors.ControlLight;
            databaseTable.BorderStyle = BorderStyle.None;
            databaseTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            databaseTable.Columns.AddRange(new DataGridViewColumn[] { Id, Type, Person, Building, Floor, Office, isWork, typeID });
            databaseTable.Dock = DockStyle.Fill;
            databaseTable.Location = new Point(0, 0);
            databaseTable.Margin = new Padding(3, 2, 3, 2);
            databaseTable.Name = "databaseTable";
            databaseTable.ReadOnly = true;
            databaseTable.RowHeadersWidth = 51;
            databaseTable.RowTemplate.Height = 29;
            databaseTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            databaseTable.Size = new Size(1006, 311);
            databaseTable.TabIndex = 0;
            databaseTable.CellDoubleClick += databaseTable_CellDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "Номер";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 150;
            // 
            // Type
            // 
            Type.HeaderText = "Тип";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Width = 150;
            // 
            // Person
            // 
            Person.HeaderText = "Ответственный";
            Person.MinimumWidth = 6;
            Person.Name = "Person";
            Person.ReadOnly = true;
            Person.Width = 150;
            // 
            // Building
            // 
            Building.HeaderText = "Здание";
            Building.MinimumWidth = 6;
            Building.Name = "Building";
            Building.ReadOnly = true;
            Building.Width = 125;
            // 
            // Floor
            // 
            Floor.HeaderText = "Этаж";
            Floor.MinimumWidth = 6;
            Floor.Name = "Floor";
            Floor.ReadOnly = true;
            Floor.Width = 125;
            // 
            // Office
            // 
            Office.HeaderText = "Офис";
            Office.MinimumWidth = 6;
            Office.Name = "Office";
            Office.ReadOnly = true;
            Office.Width = 125;
            // 
            // isWork
            // 
            isWork.HeaderText = "Состояние";
            isWork.MinimumWidth = 6;
            isWork.Name = "isWork";
            isWork.ReadOnly = true;
            isWork.Width = 125;
            // 
            // typeID
            // 
            typeID.HeaderText = "typeID";
            typeID.MinimumWidth = 6;
            typeID.Name = "typeID";
            typeID.ReadOnly = true;
            typeID.Visible = false;
            typeID.Width = 125;
            // 
            // Hardware
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 360);
            Controls.Add(tablePanel);
            Controls.Add(toolsPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Hardware";
            Text = "Hardware";
            Load += Hardware_Load;
            toolsPanel.ResumeLayout(false);
            tablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)databaseTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel toolsPanel;
        private Button addButton;
        private Panel tablePanel;
        private DataGridView databaseTable;
        private Button sortButton;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Person;
        private DataGridViewTextBoxColumn Building;
        private DataGridViewTextBoxColumn Floor;
        private DataGridViewTextBoxColumn Office;
        private DataGridViewTextBoxColumn isWork;
        private DataGridViewTextBoxColumn typeID;
    }
}