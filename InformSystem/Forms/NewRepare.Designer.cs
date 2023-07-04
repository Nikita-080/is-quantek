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
            panel1 = new Panel();
            reasonLabel = new Label();
            sendButton = new Button();
            reasonTextBox = new TextBox();
            HW_IDNumberLabel = new Label();
            HwIdComboBox = new ComboBox();
            dateInPicker = new DateTimePicker();
            docInUpDown = new NumericUpDown();
            DateInLabel = new Label();
            DocInLabel = new Label();
            infoPanel = new Panel();
            headerPanel = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)docInUpDown).BeginInit();
            infoPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(reasonLabel);
            panel1.Controls.Add(sendButton);
            panel1.Controls.Add(reasonTextBox);
            panel1.Controls.Add(HW_IDNumberLabel);
            panel1.Controls.Add(HwIdComboBox);
            panel1.Controls.Add(dateInPicker);
            panel1.Controls.Add(docInUpDown);
            panel1.Controls.Add(DateInLabel);
            panel1.Controls.Add(DocInLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 625);
            panel1.TabIndex = 13;
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            reasonLabel.Location = new Point(10, 214);
            reasonLabel.Margin = new Padding(4, 0, 4, 0);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new Size(229, 23);
            reasonLabel.TabIndex = 8;
            reasonLabel.Text = "Причина поступления";
            // 
            // sendButton
            // 
            sendButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sendButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            sendButton.Location = new Point(18, 476);
            sendButton.Margin = new Padding(4, 5, 4, 5);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(608, 129);
            sendButton.TabIndex = 12;
            sendButton.Text = "Отправить";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // reasonTextBox
            // 
            reasonTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reasonTextBox.Location = new Point(14, 259);
            reasonTextBox.Margin = new Padding(14, 16, 14, 16);
            reasonTextBox.MaxLength = 50;
            reasonTextBox.Multiline = true;
            reasonTextBox.Name = "reasonTextBox";
            reasonTextBox.Size = new Size(608, 194);
            reasonTextBox.TabIndex = 12;
            // 
            // HW_IDNumberLabel
            // 
            HW_IDNumberLabel.AutoSize = true;
            HW_IDNumberLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            HW_IDNumberLabel.Location = new Point(4, 15);
            HW_IDNumberLabel.Margin = new Padding(4, 0, 4, 0);
            HW_IDNumberLabel.Name = "HW_IDNumberLabel";
            HW_IDNumberLabel.Size = new Size(233, 23);
            HW_IDNumberLabel.TabIndex = 1;
            HW_IDNumberLabel.Text = "Номер оборудования";
            // 
            // HwIdComboBox
            // 
            HwIdComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            HwIdComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            HwIdComboBox.FormattingEnabled = true;
            HwIdComboBox.Location = new Point(232, 11);
            HwIdComboBox.Margin = new Padding(4, 5, 4, 5);
            HwIdComboBox.Name = "HwIdComboBox";
            HwIdComboBox.Size = new Size(185, 33);
            HwIdComboBox.TabIndex = 0;
            // 
            // dateInPicker
            // 
            dateInPicker.Location = new Point(232, 69);
            dateInPicker.Margin = new Padding(4, 5, 4, 5);
            dateInPicker.Name = "dateInPicker";
            dateInPicker.Size = new Size(185, 31);
            dateInPicker.TabIndex = 2;
            // 
            // docInUpDown
            // 
            docInUpDown.Location = new Point(232, 134);
            docInUpDown.Margin = new Padding(4, 5, 4, 5);
            docInUpDown.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            docInUpDown.Name = "docInUpDown";
            docInUpDown.Size = new Size(188, 31);
            docInUpDown.TabIndex = 10;
            // 
            // DateInLabel
            // 
            DateInLabel.AutoSize = true;
            DateInLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DateInLabel.Location = new Point(4, 76);
            DateInLabel.Margin = new Padding(4, 0, 4, 0);
            DateInLabel.Name = "DateInLabel";
            DateInLabel.Size = new Size(169, 23);
            DateInLabel.TabIndex = 3;
            DateInLabel.Text = "Дата получения";
            // 
            // DocInLabel
            // 
            DocInLabel.AutoSize = true;
            DocInLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DocInLabel.Location = new Point(4, 135);
            DocInLabel.Margin = new Padding(4, 0, 4, 0);
            DocInLabel.Name = "DocInLabel";
            DocInLabel.Size = new Size(206, 23);
            DocInLabel.TabIndex = 6;
            DocInLabel.Text = "Докумет получения";
            // 
            // infoPanel
            // 
            infoPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            infoPanel.Controls.Add(panel1);
            infoPanel.Location = new Point(0, 106);
            infoPanel.Margin = new Padding(4, 5, 4, 5);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(642, 625);
            infoPanel.TabIndex = 2;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(0, 42, 87);
            headerPanel.Controls.Add(label1);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(4, 5, 4, 5);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(642, 106);
            headerPanel.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(172, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(317, 39);
            label1.TabIndex = 4;
            label1.Text = "Добавить ремонт";
            label1.Click += label1_Click;
            // 
            // NewRepare
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 731);
            Controls.Add(headerPanel);
            Controls.Add(infoPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "NewRepare";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NewRepair";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)docInUpDown).EndInit();
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
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