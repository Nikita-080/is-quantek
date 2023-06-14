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
            this.sortButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.databaseTable = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Office = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolsPanel.SuspendLayout();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTable)).BeginInit();
            this.SuspendLayout();
            // 
            // toolsPanel
            // 
            this.toolsPanel.Controls.Add(this.sortButton);
            this.toolsPanel.Controls.Add(this.addButton);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolsPanel.Location = new System.Drawing.Point(0, 0);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(1044, 65);
            this.toolsPanel.TabIndex = 0;
            // 
            // sortButton
            // 
            this.sortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.sortButton.FlatAppearance.BorderSize = 0;
            this.sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sortButton.Location = new System.Drawing.Point(118, 12);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(161, 29);
            this.sortButton.TabIndex = 1;
            this.sortButton.Text = "Отсортировать";
            this.sortButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.Location = new System.Drawing.Point(12, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 29);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tablePanel
            // 
            this.tablePanel.Controls.Add(this.databaseTable);
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Location = new System.Drawing.Point(0, 65);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(1044, 411);
            this.tablePanel.TabIndex = 1;
            // 
            // databaseTable
            // 
            this.databaseTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.databaseTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.databaseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databaseTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Type,
            this.Person,
            this.Building,
            this.Floor,
            this.Office,
            this.isWork,
            this.typeID});
            this.databaseTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseTable.Location = new System.Drawing.Point(0, 0);
            this.databaseTable.Name = "databaseTable";
            this.databaseTable.ReadOnly = true;
            this.databaseTable.RowHeadersWidth = 51;
            this.databaseTable.RowTemplate.Height = 29;
            this.databaseTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.databaseTable.Size = new System.Drawing.Size(1044, 411);
            this.databaseTable.TabIndex = 0;
            this.databaseTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.databaseTable_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Номер";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 150;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 150;
            // 
            // Person
            // 
            this.Person.HeaderText = "Ответственный";
            this.Person.MinimumWidth = 6;
            this.Person.Name = "Person";
            this.Person.ReadOnly = true;
            this.Person.Width = 150;
            // 
            // Building
            // 
            this.Building.HeaderText = "Здание";
            this.Building.MinimumWidth = 6;
            this.Building.Name = "Building";
            this.Building.ReadOnly = true;
            this.Building.Width = 125;
            // 
            // Floor
            // 
            this.Floor.HeaderText = "Этаж";
            this.Floor.MinimumWidth = 6;
            this.Floor.Name = "Floor";
            this.Floor.ReadOnly = true;
            this.Floor.Width = 125;
            // 
            // Office
            // 
            this.Office.HeaderText = "Офис";
            this.Office.MinimumWidth = 6;
            this.Office.Name = "Office";
            this.Office.ReadOnly = true;
            this.Office.Width = 125;
            // 
            // isWork
            // 
            this.isWork.HeaderText = "Состояние";
            this.isWork.MinimumWidth = 6;
            this.isWork.Name = "isWork";
            this.isWork.ReadOnly = true;
            this.isWork.Width = 125;
            // 
            // typeID
            // 
            this.typeID.HeaderText = "typeID";
            this.typeID.MinimumWidth = 6;
            this.typeID.Name = "typeID";
            this.typeID.ReadOnly = true;
            this.typeID.Visible = false;
            this.typeID.Width = 125;
            // 
            // Hardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 476);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.toolsPanel);
            this.Name = "Hardware";
            this.Text = "Hardware";
            this.Load += new System.EventHandler(this.Hardware_Load);
            this.toolsPanel.ResumeLayout(false);
            this.tablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.databaseTable)).EndInit();
            this.ResumeLayout(false);

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