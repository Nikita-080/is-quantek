namespace InformSystem.Forms
{
    partial class CloseRepair
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.verdictTextBox = new System.Windows.Forms.TextBox();
            this.docNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.dateClsoePicker = new System.Windows.Forms.DateTimePicker();
            this.repairNumComboBox = new System.Windows.Forms.ComboBox();
            this.verdictLabel = new System.Windows.Forms.Label();
            this.documentNumberLabel = new System.Windows.Forms.Label();
            this.closeRepairDateLabel = new System.Windows.Forms.Label();
            this.repairIdLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(533, 88);
            this.headerPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(143, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Завершить ремонт";
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.checkBox1);
            this.infoPanel.Controls.Add(this.sendButton);
            this.infoPanel.Controls.Add(this.verdictTextBox);
            this.infoPanel.Controls.Add(this.docNumUpDown);
            this.infoPanel.Controls.Add(this.dateClsoePicker);
            this.infoPanel.Controls.Add(this.repairNumComboBox);
            this.infoPanel.Controls.Add(this.verdictLabel);
            this.infoPanel.Controls.Add(this.documentNumberLabel);
            this.infoPanel.Controls.Add(this.closeRepairDateLabel);
            this.infoPanel.Controls.Add(this.repairIdLabel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(0, 88);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(533, 545);
            this.infoPanel.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(427, 127);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Списание";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sendButton.Location = new System.Drawing.Point(14, 453);
            this.sendButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(503, 76);
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // verdictTextBox
            // 
            this.verdictTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verdictTextBox.Location = new System.Drawing.Point(14, 160);
            this.verdictTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.verdictTextBox.MaxLength = 50;
            this.verdictTextBox.Multiline = true;
            this.verdictTextBox.Name = "verdictTextBox";
            this.verdictTextBox.Size = new System.Drawing.Size(502, 271);
            this.verdictTextBox.TabIndex = 7;
            // 
            // docNumUpDown
            // 
            this.docNumUpDown.Location = new System.Drawing.Point(315, 88);
            this.docNumUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.docNumUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.docNumUpDown.Name = "docNumUpDown";
            this.docNumUpDown.Size = new System.Drawing.Size(201, 27);
            this.docNumUpDown.TabIndex = 6;
            // 
            // dateClsoePicker
            // 
            this.dateClsoePicker.Location = new System.Drawing.Point(315, 47);
            this.dateClsoePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateClsoePicker.Name = "dateClsoePicker";
            this.dateClsoePicker.Size = new System.Drawing.Size(201, 27);
            this.dateClsoePicker.TabIndex = 5;
            // 
            // repairNumComboBox
            // 
            this.repairNumComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.repairNumComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.repairNumComboBox.FormattingEnabled = true;
            this.repairNumComboBox.Location = new System.Drawing.Point(315, 8);
            this.repairNumComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.repairNumComboBox.Name = "repairNumComboBox";
            this.repairNumComboBox.Size = new System.Drawing.Size(201, 28);
            this.repairNumComboBox.TabIndex = 4;
            // 
            // verdictLabel
            // 
            this.verdictLabel.AutoSize = true;
            this.verdictLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verdictLabel.Location = new System.Drawing.Point(14, 127);
            this.verdictLabel.Name = "verdictLabel";
            this.verdictLabel.Size = new System.Drawing.Size(70, 20);
            this.verdictLabel.TabIndex = 3;
            this.verdictLabel.Text = "Вердикт";
            // 
            // documentNumberLabel
            // 
            this.documentNumberLabel.AutoSize = true;
            this.documentNumberLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.documentNumberLabel.Location = new System.Drawing.Point(14, 91);
            this.documentNumberLabel.Name = "documentNumberLabel";
            this.documentNumberLabel.Size = new System.Drawing.Size(333, 20);
            this.documentNumberLabel.TabIndex = 2;
            this.documentNumberLabel.Text = "Номер документа о завершении ремонта";
            // 
            // closeRepairDateLabel
            // 
            this.closeRepairDateLabel.AutoSize = true;
            this.closeRepairDateLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeRepairDateLabel.Location = new System.Drawing.Point(14, 51);
            this.closeRepairDateLabel.Name = "closeRepairDateLabel";
            this.closeRepairDateLabel.Size = new System.Drawing.Size(214, 20);
            this.closeRepairDateLabel.TabIndex = 1;
            this.closeRepairDateLabel.Text = "Дата завершения ремонта";
            // 
            // repairIdLabel
            // 
            this.repairIdLabel.AutoSize = true;
            this.repairIdLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.repairIdLabel.Location = new System.Drawing.Point(14, 16);
            this.repairIdLabel.Name = "repairIdLabel";
            this.repairIdLabel.Size = new System.Drawing.Size(134, 20);
            this.repairIdLabel.TabIndex = 0;
            this.repairIdLabel.Text = "Номер ремонта";
            // 
            // CloseRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 633);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.headerPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CloseRepair";
            this.Text = "CloseRepair";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docNumUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel headerPanel;
        private Panel infoPanel;
        private Label documentNumberLabel;
        private Label closeRepairDateLabel;
        private Label repairIdLabel;
        private Label verdictLabel;
        private ComboBox repairNumComboBox;
        private Button sendButton;
        private TextBox verdictTextBox;
        private NumericUpDown docNumUpDown;
        private DateTimePicker dateClsoePicker;
        private Label label1;
        private CheckBox checkBox1;
    }
}