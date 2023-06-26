namespace InformSystem.Forms
{
    partial class RepareMainWindow
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
            this.components = new System.ComponentModel.Container();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.databaseTable = new System.Windows.Forms.DataGridView();
            this.idRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hardwareRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.closeRepairButton = new System.Windows.Forms.Button();
            this.updateTableButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).BeginInit();
            this.toolsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel
            // 
            this.tablePanel.Controls.Add(this.databaseTable);
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Location = new System.Drawing.Point(0, 65);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(1045, 411);
            this.tablePanel.TabIndex = 3;
            // 
            // databaseTable
            // 
            this.databaseTable.AllowUserToAddRows = false;
            this.databaseTable.AllowUserToDeleteRows = false;
            this.databaseTable.AutoGenerateColumns = false;
            this.databaseTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.databaseTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.databaseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databaseTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRDataGridViewTextBoxColumn,
            this.hardwareRDataGridViewTextBoxColumn,
            this.dateInDataGridViewTextBoxColumn,
            this.documentInDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn});
            this.databaseTable.DataSource = this.repairBindingSource;
            this.databaseTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseTable.Location = new System.Drawing.Point(0, 0);
            this.databaseTable.Name = "databaseTable";
            this.databaseTable.ReadOnly = true;
            this.databaseTable.RowHeadersWidth = 51;
            this.databaseTable.RowTemplate.Height = 29;
            this.databaseTable.Size = new System.Drawing.Size(1045, 411);
            this.databaseTable.TabIndex = 0;
            // 
            // idRDataGridViewTextBoxColumn
            // 
            this.idRDataGridViewTextBoxColumn.DataPropertyName = "IdR";
            this.idRDataGridViewTextBoxColumn.HeaderText = "Номер ремонта";
            this.idRDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idRDataGridViewTextBoxColumn.Name = "idRDataGridViewTextBoxColumn";
            this.idRDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRDataGridViewTextBoxColumn.Width = 125;
            // 
            // hardwareRDataGridViewTextBoxColumn
            // 
            this.hardwareRDataGridViewTextBoxColumn.DataPropertyName = "HardwareR";
            this.hardwareRDataGridViewTextBoxColumn.HeaderText = "Номер оборудования";
            this.hardwareRDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hardwareRDataGridViewTextBoxColumn.Name = "hardwareRDataGridViewTextBoxColumn";
            this.hardwareRDataGridViewTextBoxColumn.ReadOnly = true;
            this.hardwareRDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateInDataGridViewTextBoxColumn
            // 
            this.dateInDataGridViewTextBoxColumn.DataPropertyName = "DateIn";
            this.dateInDataGridViewTextBoxColumn.HeaderText = "Дата получения";
            this.dateInDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateInDataGridViewTextBoxColumn.Name = "dateInDataGridViewTextBoxColumn";
            this.dateInDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateInDataGridViewTextBoxColumn.Width = 125;
            // 
            // documentInDataGridViewTextBoxColumn
            // 
            this.documentInDataGridViewTextBoxColumn.DataPropertyName = "DocumentIn";
            this.documentInDataGridViewTextBoxColumn.HeaderText = "Номер документа получения";
            this.documentInDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentInDataGridViewTextBoxColumn.Name = "documentInDataGridViewTextBoxColumn";
            this.documentInDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentInDataGridViewTextBoxColumn.Width = 125;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Причина";
            this.reasonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.reasonDataGridViewTextBoxColumn.Width = 125;
            // 
            // repairBindingSource
            // 
            this.repairBindingSource.DataSource = typeof(InformSystem.dataBase.Repair);
            // 
            // toolsPanel
            // 
            this.toolsPanel.Controls.Add(this.closeRepairButton);
            this.toolsPanel.Controls.Add(this.updateTableButton);
            this.toolsPanel.Controls.Add(this.addButton);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolsPanel.Location = new System.Drawing.Point(0, 0);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(1045, 65);
            this.toolsPanel.TabIndex = 2;
            // 
            // closeRepairButton
            // 
            this.closeRepairButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.closeRepairButton.FlatAppearance.BorderSize = 0;
            this.closeRepairButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeRepairButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeRepairButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeRepairButton.Location = new System.Drawing.Point(214, 12);
            this.closeRepairButton.Name = "closeRepairButton";
            this.closeRepairButton.Size = new System.Drawing.Size(195, 33);
            this.closeRepairButton.TabIndex = 3;
            this.closeRepairButton.Text = "Завершить ремонт";
            this.closeRepairButton.UseVisualStyleBackColor = false;
            this.closeRepairButton.Click += new System.EventHandler(this.closeRepairButton_Click);
            // 
            // updateTableButton
            // 
            this.updateTableButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.updateTableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.updateTableButton.FlatAppearance.BorderSize = 0;
            this.updateTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateTableButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateTableButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.updateTableButton.Location = new System.Drawing.Point(835, 15);
            this.updateTableButton.Name = "updateTableButton";
            this.updateTableButton.Size = new System.Drawing.Size(195, 33);
            this.updateTableButton.TabIndex = 1;
            this.updateTableButton.Text = "Загрузить данные";
            this.updateTableButton.UseVisualStyleBackColor = false;
            this.updateTableButton.Click += new System.EventHandler(this.updateTableButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.Location = new System.Drawing.Point(11, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(195, 33);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить ремонт";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // RepareMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 476);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.toolsPanel);
            this.Name = "RepareMainWindow";
            this.Text = "Ремонт";
            this.tablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.databaseTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).EndInit();
            this.toolsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel tablePanel;
        private DataGridView databaseTable;
        private Panel toolsPanel;
        private Button addButton;
        private BindingSource repairBindingSource;
        private Button updateTableButton;
        private Button closeRepairButton;
        private DataGridViewTextBoxColumn idRDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hardwareRDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn documentInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
    }
}