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
            sendButton = new Button();
            HW_IDNumberLabel = new Label();
            HwIdComboBox = new ComboBox();
            docOutUpDown = new NumericUpDown();
            dateInPicker = new DateTimePicker();
            docInUpDown = new NumericUpDown();
            DateInLabel = new Label();
            DateOutLabel = new Label();
            dateOutPicker = new DateTimePicker();
            DocOutLabel = new Label();
            DocInLabel = new Label();
            panel2 = new Panel();
            reasonLabel = new Label();
            reasonTextBox = new TextBox();
            panel3 = new Panel();
            verdictTextBox = new TextBox();
            verdictLabel = new Label();
            infoPanel = new Panel();
            headerPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)docOutUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)docInUpDown).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            infoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(sendButton);
            panel1.Controls.Add(HW_IDNumberLabel);
            panel1.Controls.Add(HwIdComboBox);
            panel1.Controls.Add(docOutUpDown);
            panel1.Controls.Add(dateInPicker);
            panel1.Controls.Add(docInUpDown);
            panel1.Controls.Add(DateInLabel);
            panel1.Controls.Add(DateOutLabel);
            panel1.Controls.Add(dateOutPicker);
            panel1.Controls.Add(DocOutLabel);
            panel1.Controls.Add(DocInLabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 341);
            panel1.TabIndex = 13;
            // 
            // sendButton
            // 
            sendButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            sendButton.Location = new Point(12, 243);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(268, 77);
            sendButton.TabIndex = 12;
            sendButton.Text = "Отправить";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
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
            HwIdComboBox.FormattingEnabled = true;
            HwIdComboBox.Location = new Point(163, 7);
            HwIdComboBox.Name = "HwIdComboBox";
            HwIdComboBox.Size = new Size(131, 23);
            HwIdComboBox.TabIndex = 0;
            // 
            // docOutUpDown
            // 
            docOutUpDown.Location = new Point(163, 166);
            docOutUpDown.Name = "docOutUpDown";
            docOutUpDown.Size = new Size(131, 23);
            docOutUpDown.TabIndex = 11;
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
            docInUpDown.Location = new Point(163, 124);
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
            // DateOutLabel
            // 
            DateOutLabel.AutoSize = true;
            DateOutLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DateOutLabel.Location = new Point(7, 88);
            DateOutLabel.Name = "DateOutLabel";
            DateOutLabel.Size = new Size(104, 17);
            DateOutLabel.TabIndex = 4;
            DateOutLabel.Text = "Дата возврата";
            // 
            // dateOutPicker
            // 
            dateOutPicker.Location = new Point(163, 83);
            dateOutPicker.Name = "dateOutPicker";
            dateOutPicker.Size = new Size(131, 23);
            dateOutPicker.TabIndex = 5;
            // 
            // DocOutLabel
            // 
            DocOutLabel.AutoSize = true;
            DocOutLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DocOutLabel.Location = new Point(7, 167);
            DocOutLabel.Name = "DocOutLabel";
            DocOutLabel.Size = new Size(135, 17);
            DocOutLabel.TabIndex = 7;
            DocOutLabel.Text = "Документ возврата";
            // 
            // DocInLabel
            // 
            DocInLabel.AutoSize = true;
            DocInLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DocInLabel.Location = new Point(7, 125);
            DocInLabel.Name = "DocInLabel";
            DocInLabel.Size = new Size(134, 17);
            DocInLabel.TabIndex = 6;
            DocInLabel.Text = "Докумет получения";
            // 
            // panel2
            // 
            panel2.Controls.Add(reasonLabel);
            panel2.Controls.Add(reasonTextBox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(297, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(470, 168);
            panel2.TabIndex = 14;
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            reasonLabel.Location = new Point(6, 6);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new Size(150, 17);
            reasonLabel.TabIndex = 8;
            reasonLabel.Text = "Причина поступления";
            // 
            // reasonTextBox
            // 
            reasonTextBox.Dock = DockStyle.Bottom;
            reasonTextBox.Location = new Point(0, 33);
            reasonTextBox.Margin = new Padding(10);
            reasonTextBox.MaxLength = 50;
            reasonTextBox.Multiline = true;
            reasonTextBox.Name = "reasonTextBox";
            reasonTextBox.Size = new Size(470, 135);
            reasonTextBox.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.Controls.Add(verdictTextBox);
            panel3.Controls.Add(verdictLabel);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(297, 168);
            panel3.Name = "panel3";
            panel3.Size = new Size(470, 173);
            panel3.TabIndex = 15;
            // 
            // verdictTextBox
            // 
            verdictTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            verdictTextBox.Location = new Point(0, 32);
            verdictTextBox.MaxLength = 50;
            verdictTextBox.Multiline = true;
            verdictTextBox.Name = "verdictTextBox";
            verdictTextBox.Size = new Size(470, 141);
            verdictTextBox.TabIndex = 10;
            // 
            // verdictLabel
            // 
            verdictLabel.AutoSize = true;
            verdictLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            verdictLabel.Location = new Point(6, 4);
            verdictLabel.Name = "verdictLabel";
            verdictLabel.Size = new Size(60, 17);
            verdictLabel.TabIndex = 9;
            verdictLabel.Text = "Вердикт";
            // 
            // infoPanel
            // 
            infoPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            infoPanel.Controls.Add(panel3);
            infoPanel.Controls.Add(panel2);
            infoPanel.Controls.Add(panel1);
            infoPanel.Location = new Point(0, 64);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(767, 341);
            infoPanel.TabIndex = 2;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(0, 42, 87);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(767, 64);
            headerPanel.TabIndex = 3;
            // 
            // NewRepare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 405);
            Controls.Add(headerPanel);
            Controls.Add(infoPanel);
            Name = "NewRepare";
            Text = "NewRepare";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)docOutUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)docInUpDown).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button sendButton;
        private Label HW_IDNumberLabel;
        private ComboBox HwIdComboBox;
        private NumericUpDown docOutUpDown;
        private DateTimePicker dateInPicker;
        private NumericUpDown docInUpDown;
        private Label DateInLabel;
        private Label DateOutLabel;
        private DateTimePicker dateOutPicker;
        private Label DocOutLabel;
        private Label DocInLabel;
        private Panel panel2;
        private Label reasonLabel;
        private TextBox reasonTextBox;
        private Panel panel3;
        private TextBox verdictTextBox;
        private Label verdictLabel;
        private Panel infoPanel;
        private Panel headerPanel;
    }
}