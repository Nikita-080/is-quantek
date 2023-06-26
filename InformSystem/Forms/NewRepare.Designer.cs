namespace InformSystem.Forms
{
    partial class NewRepare
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.reasonTextBox = new System.Windows.Forms.TextBox();
            this.HW_IDNumberLabel = new System.Windows.Forms.Label();
            this.HwIdComboBox = new System.Windows.Forms.ComboBox();
            this.dateInPicker = new System.Windows.Forms.DateTimePicker();
            this.docInUpDown = new System.Windows.Forms.NumericUpDown();
            this.DateInLabel = new System.Windows.Forms.Label();
            this.DocInLabel = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docInUpDown)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.reasonLabel);
            this.panel1.Controls.Add(this.sendButton);
            this.panel1.Controls.Add(this.reasonTextBox);
            this.panel1.Controls.Add(this.HW_IDNumberLabel);
            this.panel1.Controls.Add(this.HwIdComboBox);
            this.panel1.Controls.Add(this.dateInPicker);
            this.panel1.Controls.Add(this.docInUpDown);
            this.panel1.Controls.Add(this.DateInLabel);
            this.panel1.Controls.Add(this.DocInLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 500);
            this.panel1.TabIndex = 13;
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reasonLabel.Location = new System.Drawing.Point(8, 171);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(194, 21);
            this.reasonLabel.TabIndex = 8;
            this.reasonLabel.Text = "Причина поступления";
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sendButton.Location = new System.Drawing.Point(14, 381);
            this.sendButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(486, 103);
            this.sendButton.TabIndex = 12;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reasonTextBox.Location = new System.Drawing.Point(11, 207);
            this.reasonTextBox.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.reasonTextBox.MaxLength = 50;
            this.reasonTextBox.Multiline = true;
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(487, 156);
            this.reasonTextBox.TabIndex = 12;
            // 
            // HW_IDNumberLabel
            // 
            this.HW_IDNumberLabel.AutoSize = true;
            this.HW_IDNumberLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HW_IDNumberLabel.Location = new System.Drawing.Point(3, 12);
            this.HW_IDNumberLabel.Name = "HW_IDNumberLabel";
            this.HW_IDNumberLabel.Size = new System.Drawing.Size(198, 21);
            this.HW_IDNumberLabel.TabIndex = 1;
            this.HW_IDNumberLabel.Text = "Номер оборудования";
            // 
            // HwIdComboBox
            // 
            this.HwIdComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.HwIdComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.HwIdComboBox.FormattingEnabled = true;
            this.HwIdComboBox.Location = new System.Drawing.Point(186, 9);
            this.HwIdComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HwIdComboBox.Name = "HwIdComboBox";
            this.HwIdComboBox.Size = new System.Drawing.Size(149, 28);
            this.HwIdComboBox.TabIndex = 0;
            // 
            // dateInPicker
            // 
            this.dateInPicker.Location = new System.Drawing.Point(186, 55);
            this.dateInPicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateInPicker.Name = "dateInPicker";
            this.dateInPicker.Size = new System.Drawing.Size(149, 27);
            this.dateInPicker.TabIndex = 2;
            // 
            // docInUpDown
            // 
            this.docInUpDown.Location = new System.Drawing.Point(186, 107);
            this.docInUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.docInUpDown.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.docInUpDown.Name = "docInUpDown";
            this.docInUpDown.Size = new System.Drawing.Size(150, 27);
            this.docInUpDown.TabIndex = 10;
            // 
            // DateInLabel
            // 
            this.DateInLabel.AutoSize = true;
            this.DateInLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateInLabel.Location = new System.Drawing.Point(3, 61);
            this.DateInLabel.Name = "DateInLabel";
            this.DateInLabel.Size = new System.Drawing.Size(144, 21);
            this.DateInLabel.TabIndex = 3;
            this.DateInLabel.Text = "Дата получения";
            // 
            // DocInLabel
            // 
            this.DocInLabel.AutoSize = true;
            this.DocInLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DocInLabel.Location = new System.Drawing.Point(3, 108);
            this.DocInLabel.Name = "DocInLabel";
            this.DocInLabel.Size = new System.Drawing.Size(174, 21);
            this.DocInLabel.TabIndex = 6;
            this.DocInLabel.Text = "Докумет получения";
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPanel.Controls.Add(this.panel1);
            this.infoPanel.Location = new System.Drawing.Point(0, 85);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(514, 500);
            this.infoPanel.TabIndex = 2;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(514, 85);
            this.headerPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(138, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добавить ремонт";
            // 
            // NewRepare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 585);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.infoPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewRepare";
            this.Text = "NewRepare";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docInUpDown)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button sendButton;
        private Label HW_IDNumberLabel;
        private ComboBox HwIdComboBox;
        private DateTimePicker dateInPicker;
        private NumericUpDown docInUpDown;
        private Label DateInLabel;
        private Label DocInLabel;
        private Label reasonLabel;
        private TextBox reasonTextBox;
        private Panel infoPanel;
        private Panel headerPanel;
        private Label label1;
    }
}