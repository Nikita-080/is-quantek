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
            components = new System.ComponentModel.Container();
            tablePanel = new Panel();
            databaseTable = new DataGridView();
            idRDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hardwareRDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            documentInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            documentOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reasonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            verdictDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            repairBindingSource = new BindingSource(components);
            toolsPanel = new Panel();
            updateTableButton = new Button();
            addButton = new Button();
            tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)databaseTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repairBindingSource).BeginInit();
            toolsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tablePanel
            // 
            tablePanel.Controls.Add(databaseTable);
            tablePanel.Dock = DockStyle.Fill;
            tablePanel.Location = new Point(0, 49);
            tablePanel.Margin = new Padding(3, 2, 3, 2);
            tablePanel.Name = "tablePanel";
            tablePanel.Size = new Size(914, 308);
            tablePanel.TabIndex = 3;
            // 
            // databaseTable
            // 
            databaseTable.AllowUserToAddRows = false;
            databaseTable.AllowUserToDeleteRows = false;
            databaseTable.AutoGenerateColumns = false;
            databaseTable.BackgroundColor = SystemColors.ControlLight;
            databaseTable.BorderStyle = BorderStyle.None;
            databaseTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            databaseTable.Columns.AddRange(new DataGridViewColumn[] { idRDataGridViewTextBoxColumn, hardwareRDataGridViewTextBoxColumn, dateInDataGridViewTextBoxColumn, dateOutDataGridViewTextBoxColumn, documentInDataGridViewTextBoxColumn, documentOutDataGridViewTextBoxColumn, reasonDataGridViewTextBoxColumn, verdictDataGridViewTextBoxColumn });
            databaseTable.DataSource = repairBindingSource;
            databaseTable.Dock = DockStyle.Fill;
            databaseTable.Location = new Point(0, 0);
            databaseTable.Margin = new Padding(3, 2, 3, 2);
            databaseTable.Name = "databaseTable";
            databaseTable.ReadOnly = true;
            databaseTable.RowHeadersWidth = 51;
            databaseTable.RowTemplate.Height = 29;
            databaseTable.Size = new Size(914, 308);
            databaseTable.TabIndex = 0;
            // 
            // idRDataGridViewTextBoxColumn
            // 
            idRDataGridViewTextBoxColumn.DataPropertyName = "IdR";
            idRDataGridViewTextBoxColumn.HeaderText = "IdR";
            idRDataGridViewTextBoxColumn.Name = "idRDataGridViewTextBoxColumn";
            idRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hardwareRDataGridViewTextBoxColumn
            // 
            hardwareRDataGridViewTextBoxColumn.DataPropertyName = "HardwareR";
            hardwareRDataGridViewTextBoxColumn.HeaderText = "HardwareR";
            hardwareRDataGridViewTextBoxColumn.Name = "hardwareRDataGridViewTextBoxColumn";
            hardwareRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateInDataGridViewTextBoxColumn
            // 
            dateInDataGridViewTextBoxColumn.DataPropertyName = "DateIn";
            dateInDataGridViewTextBoxColumn.HeaderText = "DateIn";
            dateInDataGridViewTextBoxColumn.Name = "dateInDataGridViewTextBoxColumn";
            dateInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOutDataGridViewTextBoxColumn
            // 
            dateOutDataGridViewTextBoxColumn.DataPropertyName = "DateOut";
            dateOutDataGridViewTextBoxColumn.HeaderText = "DateOut";
            dateOutDataGridViewTextBoxColumn.Name = "dateOutDataGridViewTextBoxColumn";
            dateOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentInDataGridViewTextBoxColumn
            // 
            documentInDataGridViewTextBoxColumn.DataPropertyName = "DocumentIn";
            documentInDataGridViewTextBoxColumn.HeaderText = "DocumentIn";
            documentInDataGridViewTextBoxColumn.Name = "documentInDataGridViewTextBoxColumn";
            documentInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentOutDataGridViewTextBoxColumn
            // 
            documentOutDataGridViewTextBoxColumn.DataPropertyName = "DocumentOut";
            documentOutDataGridViewTextBoxColumn.HeaderText = "DocumentOut";
            documentOutDataGridViewTextBoxColumn.Name = "documentOutDataGridViewTextBoxColumn";
            documentOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            reasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // verdictDataGridViewTextBoxColumn
            // 
            verdictDataGridViewTextBoxColumn.DataPropertyName = "Verdict";
            verdictDataGridViewTextBoxColumn.HeaderText = "Verdict";
            verdictDataGridViewTextBoxColumn.Name = "verdictDataGridViewTextBoxColumn";
            verdictDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // repairBindingSource
            // 
            repairBindingSource.DataSource = typeof(dataBase.Repair);
            // 
            // toolsPanel
            // 
            toolsPanel.Controls.Add(updateTableButton);
            toolsPanel.Controls.Add(addButton);
            toolsPanel.Dock = DockStyle.Top;
            toolsPanel.Location = new Point(0, 0);
            toolsPanel.Margin = new Padding(3, 2, 3, 2);
            toolsPanel.Name = "toolsPanel";
            toolsPanel.Size = new Size(914, 49);
            toolsPanel.TabIndex = 2;
            // 
            // updateTableButton
            // 
            updateTableButton.BackColor = Color.FromArgb(0, 42, 87);
            updateTableButton.FlatAppearance.BorderSize = 0;
            updateTableButton.FlatStyle = FlatStyle.Flat;
            updateTableButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            updateTableButton.ForeColor = SystemColors.ButtonFace;
            updateTableButton.Location = new Point(187, 9);
            updateTableButton.Margin = new Padding(3, 2, 3, 2);
            updateTableButton.Name = "updateTableButton";
            updateTableButton.Size = new Size(171, 25);
            updateTableButton.TabIndex = 1;
            updateTableButton.Text = "Обновить данные";
            updateTableButton.UseVisualStyleBackColor = false;
            updateTableButton.Click += updateTableButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(0, 42, 87);
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.ForeColor = SystemColors.ButtonFace;
            addButton.Location = new Point(10, 9);
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(171, 25);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить ремонт";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // RepareMainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 357);
            Controls.Add(tablePanel);
            Controls.Add(toolsPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RepareMainWindow";
            Text = "RepareMainWindow";
            tablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)databaseTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)repairBindingSource).EndInit();
            toolsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel tablePanel;
        private DataGridView databaseTable;
        private Panel toolsPanel;
        private Button addButton;
        private BindingSource repairBindingSource;
        private Button updateTableButton;
        private DataGridViewTextBoxColumn idRDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hardwareRDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOutDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn documentInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn documentOutDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn verdictDataGridViewTextBoxColumn;
    }
}