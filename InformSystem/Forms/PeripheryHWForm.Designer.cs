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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCommonInfo = new System.Windows.Forms.Panel();
            this.StatusTextBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.departmenTextBox = new System.Windows.Forms.ComboBox();
            this.HTypeTextBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.DateIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verdict = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(0, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(173, 25);
            label6.TabIndex = 1;
            label6.Text = "История Сервиса";
            // 
            // panelCommonInfo
            // 
            this.panelCommonInfo.Controls.Add(this.StatusTextBox);
            this.panelCommonInfo.Controls.Add(this.label5);
            this.panelCommonInfo.Controls.Add(this.departmenTextBox);
            this.panelCommonInfo.Controls.Add(this.HTypeTextBox);
            this.panelCommonInfo.Controls.Add(this.label8);
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
            this.panelCommonInfo.Size = new System.Drawing.Size(593, 319);
            this.panelCommonInfo.TabIndex = 1;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Enabled = false;
            this.StatusTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusTextBox.FormattingEnabled = true;
            this.StatusTextBox.Location = new System.Drawing.Point(201, 259);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(287, 33);
            this.StatusTextBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Состояние";
            // 
            // departmenTextBox
            // 
            this.departmenTextBox.Enabled = false;
            this.departmenTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departmenTextBox.FormattingEnabled = true;
            this.departmenTextBox.Location = new System.Drawing.Point(201, 175);
            this.departmenTextBox.Name = "departmenTextBox";
            this.departmenTextBox.Size = new System.Drawing.Size(287, 33);
            this.departmenTextBox.TabIndex = 21;
            // 
            // HTypeTextBox
            // 
            this.HTypeTextBox.Enabled = false;
            this.HTypeTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HTypeTextBox.FormattingEnabled = true;
            this.HTypeTextBox.Location = new System.Drawing.Point(201, 48);
            this.HTypeTextBox.Name = "HTypeTextBox";
            this.HTypeTextBox.Size = new System.Drawing.Size(287, 33);
            this.HTypeTextBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Отдел";
            // 
            // editPlaceButton
            // 
            this.editPlaceButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.editPlaceButton.FlatAppearance.BorderSize = 0;
            this.editPlaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPlaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editPlaceButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editPlaceButton.Image = global::InformSystem.Properties.Resources.edit48481;
            this.editPlaceButton.Location = new System.Drawing.Point(496, 91);
            this.editPlaceButton.Name = "editPlaceButton";
            this.editPlaceButton.Size = new System.Drawing.Size(37, 29);
            this.editPlaceButton.TabIndex = 10;
            this.editPlaceButton.UseVisualStyleBackColor = false;
            this.editPlaceButton.Click += new System.EventHandler(this.editPlaceButton_Click);
            // 
            // DiagFormatTextBox
            // 
            this.DiagFormatTextBox.Enabled = false;
            this.DiagFormatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiagFormatTextBox.Location = new System.Drawing.Point(201, 219);
            this.DiagFormatTextBox.Name = "DiagFormatTextBox";
            this.DiagFormatTextBox.Size = new System.Drawing.Size(287, 30);
            this.DiagFormatTextBox.TabIndex = 9;
            // 
            // DiagAndFormatLabel
            // 
            this.DiagAndFormatLabel.AutoSize = true;
            this.DiagAndFormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiagAndFormatLabel.Location = new System.Drawing.Point(3, 223);
            this.DiagAndFormatLabel.Name = "DiagAndFormatLabel";
            this.DiagAndFormatLabel.Size = new System.Drawing.Size(92, 25);
            this.DiagAndFormatLabel.TabIndex = 8;
            this.DiagAndFormatLabel.Text = "Формат";
            // 
            // PersonTextBox
            // 
            this.PersonTextBox.Enabled = false;
            this.PersonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PersonTextBox.Location = new System.Drawing.Point(201, 132);
            this.PersonTextBox.Name = "PersonTextBox";
            this.PersonTextBox.Size = new System.Drawing.Size(287, 30);
            this.PersonTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пользователь";
            // 
            // PlaceTextBox
            // 
            this.PlaceTextBox.Enabled = false;
            this.PlaceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlaceTextBox.Location = new System.Drawing.Point(201, 91);
            this.PlaceTextBox.Name = "PlaceTextBox";
            this.PlaceTextBox.Size = new System.Drawing.Size(287, 30);
            this.PlaceTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Местоположение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вид";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdTextBox.Location = new System.Drawing.Point(201, 7);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(287, 30);
            this.IdTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // ServisHistoryPanel
            // 
            this.ServisHistoryPanel.Controls.Add(this.dataGridViewServisHistory);
            this.ServisHistoryPanel.Controls.Add(label6);
            this.ServisHistoryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServisHistoryPanel.Location = new System.Drawing.Point(0, 319);
            this.ServisHistoryPanel.Name = "ServisHistoryPanel";
            this.ServisHistoryPanel.Size = new System.Drawing.Size(593, 228);
            this.ServisHistoryPanel.TabIndex = 3;
            // 
            // dataGridViewServisHistory
            // 
            this.dataGridViewServisHistory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewServisHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServisHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewServisHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServisHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateIn,
            this.DateOut,
            this.Reason,
            this.Verdict});
            this.dataGridViewServisHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewServisHistory.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewServisHistory.Name = "dataGridViewServisHistory";
            this.dataGridViewServisHistory.RowHeadersVisible = false;
            this.dataGridViewServisHistory.RowHeadersWidth = 51;
            this.dataGridViewServisHistory.RowTemplate.Height = 29;
            this.dataGridViewServisHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServisHistory.Size = new System.Drawing.Size(593, 188);
            this.dataGridViewServisHistory.TabIndex = 5;
            // 
            // DateIn
            // 
            this.DateIn.HeaderText = "Дата получения";
            this.DateIn.MinimumWidth = 6;
            this.DateIn.Name = "DateIn";
            this.DateIn.Width = 125;
            // 
            // DateOut
            // 
            this.DateOut.HeaderText = "Дата возврата";
            this.DateOut.MinimumWidth = 6;
            this.DateOut.Name = "DateOut";
            this.DateOut.Width = 125;
            // 
            // Reason
            // 
            this.Reason.HeaderText = "Причина";
            this.Reason.MinimumWidth = 6;
            this.Reason.Name = "Reason";
            this.Reason.Width = 125;
            // 
            // Verdict
            // 
            this.Verdict.HeaderText = "Вердикт";
            this.Verdict.MinimumWidth = 6;
            this.Verdict.Name = "Verdict";
            this.Verdict.Width = 125;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.Location = new System.Drawing.Point(461, 555);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(119, 35);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // PeripheryHWForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 604);
            this.Controls.Add(this.ServisHistoryPanel);
            this.Controls.Add(this.saveButton);
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
        private Button saveButton;
        private Button editPlaceButton;
        private Label label8;
        private ComboBox HTypeTextBox;
        private ComboBox departmenTextBox;
        private DataGridView dataGridViewServisHistory;
        private DataGridViewTextBoxColumn DateIn;
        private DataGridViewTextBoxColumn DateOut;
        private DataGridViewTextBoxColumn Reason;
        private DataGridViewTextBoxColumn Verdict;
        private Label label5;
        private ComboBox StatusTextBox;
    }
}