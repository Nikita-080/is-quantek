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
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 375);
            panel1.TabIndex = 13;
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            reasonLabel.Location = new Point(7, 128);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new Size(150, 17);
            reasonLabel.TabIndex = 8;
            reasonLabel.Text = "Причина поступления";
            // 
            // sendButton
            // 
            sendButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sendButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            sendButton.Location = new Point(12, 286);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(425, 77);
            sendButton.TabIndex = 12;
            sendButton.Text = "Отправить";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // reasonTextBox
            // 
            reasonTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reasonTextBox.Location = new Point(10, 155);
            reasonTextBox.Margin = new Padding(10);
            reasonTextBox.MaxLength = 50;
            reasonTextBox.Multiline = true;
            reasonTextBox.Name = "reasonTextBox";
            reasonTextBox.Size = new Size(427, 118);
            reasonTextBox.TabIndex = 12;
            // 
            // HW_IDNumberLabel
            // 
            HW_IDNumberLabel.AutoSize = true;
            HW_IDNumberLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            HW_IDNumberLabel.Location = new Point(3, 9);
            HW_IDNumberLabel.Name = "HW_IDNumberLabel";
            HW_IDNumberLabel.Size = new Size(154, 17);
            HW_IDNumberLabel.TabIndex = 1;
            HW_IDNumberLabel.Text = "Номер оборудования";
            // 
            // HwIdComboBox
            // 
            HwIdComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            HwIdComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            HwIdComboBox.FormattingEnabled = true;
            HwIdComboBox.Location = new Point(163, 7);
            HwIdComboBox.Name = "HwIdComboBox";
            HwIdComboBox.Size = new Size(131, 23);
            HwIdComboBox.TabIndex = 0;
            // 
            // dateInPicker
            // 
            dateInPicker.Location = new Point(163, 41);
            dateInPicker.Name = "dateInPicker";
            dateInPicker.Size = new Size(131, 23);
            dateInPicker.TabIndex = 2;
            // 
            // docInUpDown
            // 
            docInUpDown.Location = new Point(163, 80);
            docInUpDown.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            docInUpDown.Name = "docInUpDown";
            docInUpDown.Size = new Size(131, 23);
            docInUpDown.TabIndex = 10;
            // 
            // DateInLabel
            // 
            DateInLabel.AutoSize = true;
            DateInLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DateInLabel.Location = new Point(3, 46);
            DateInLabel.Name = "DateInLabel";
            DateInLabel.Size = new Size(111, 17);
            DateInLabel.TabIndex = 3;
            DateInLabel.Text = "Дата получения";
            // 
            // DocInLabel
            // 
            DocInLabel.AutoSize = true;
            DocInLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DocInLabel.Location = new Point(3, 81);
            DocInLabel.Name = "DocInLabel";
            DocInLabel.Size = new Size(134, 17);
            DocInLabel.TabIndex = 6;
            DocInLabel.Text = "Докумет получения";
            // 
            // infoPanel
            // 
            infoPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            infoPanel.Controls.Add(panel1);
            infoPanel.Location = new Point(0, 64);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(450, 375);
            infoPanel.TabIndex = 2;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(0, 42, 87);
            headerPanel.Controls.Add(label1);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(450, 64);
            headerPanel.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(121, 19);
            label1.Name = "label1";
            label1.Size = new Size(211, 26);
            label1.TabIndex = 4;
            label1.Text = "Добавить ремонт";
            // 
            // NewRepare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 439);
            Controls.Add(headerPanel);
            Controls.Add(infoPanel);
            Name = "NewRepare";
            Text = "NewRepare";
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