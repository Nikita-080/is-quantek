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
            headerPanel = new Panel();
            infoPanel = new Panel();
            sendButton = new Button();
            verdictTextBox = new TextBox();
            docNumUpDown = new NumericUpDown();
            dateClsoePicker = new DateTimePicker();
            repairNumComboBox = new ComboBox();
            verdictLabel = new Label();
            documentNumberLabel = new Label();
            closeRepairDateLabel = new Label();
            repairIdLabel = new Label();
            infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)docNumUpDown).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(0, 42, 87);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(466, 66);
            headerPanel.TabIndex = 0;
            // 
            // infoPanel
            // 
            infoPanel.Controls.Add(sendButton);
            infoPanel.Controls.Add(verdictTextBox);
            infoPanel.Controls.Add(docNumUpDown);
            infoPanel.Controls.Add(dateClsoePicker);
            infoPanel.Controls.Add(repairNumComboBox);
            infoPanel.Controls.Add(verdictLabel);
            infoPanel.Controls.Add(documentNumberLabel);
            infoPanel.Controls.Add(closeRepairDateLabel);
            infoPanel.Controls.Add(repairIdLabel);
            infoPanel.Dock = DockStyle.Fill;
            infoPanel.Location = new Point(0, 66);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(466, 409);
            infoPanel.TabIndex = 1;
            // 
            // sendButton
            // 
            sendButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sendButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            sendButton.Location = new Point(12, 340);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(440, 57);
            sendButton.TabIndex = 8;
            sendButton.Text = "Отпарвить";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // verdictTextBox
            // 
            verdictTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            verdictTextBox.Location = new Point(12, 115);
            verdictTextBox.MaxLength = 50;
            verdictTextBox.Multiline = true;
            verdictTextBox.Name = "verdictTextBox";
            verdictTextBox.Size = new Size(440, 209);
            verdictTextBox.TabIndex = 7;
            // 
            // docNumUpDown
            // 
            docNumUpDown.Location = new Point(276, 66);
            docNumUpDown.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            docNumUpDown.Name = "docNumUpDown";
            docNumUpDown.Size = new Size(176, 23);
            docNumUpDown.TabIndex = 6;
            // 
            // dateClsoePicker
            // 
            dateClsoePicker.Location = new Point(276, 35);
            dateClsoePicker.Name = "dateClsoePicker";
            dateClsoePicker.Size = new Size(176, 23);
            dateClsoePicker.TabIndex = 5;
            // 
            // repairNumComboBox
            // 
            repairNumComboBox.FormattingEnabled = true;
            repairNumComboBox.Location = new Point(276, 6);
            repairNumComboBox.Name = "repairNumComboBox";
            repairNumComboBox.Size = new Size(176, 23);
            repairNumComboBox.TabIndex = 4;
            // 
            // verdictLabel
            // 
            verdictLabel.AutoSize = true;
            verdictLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            verdictLabel.Location = new Point(12, 97);
            verdictLabel.Name = "verdictLabel";
            verdictLabel.Size = new Size(56, 17);
            verdictLabel.TabIndex = 3;
            verdictLabel.Text = "Вердикт";
            // 
            // documentNumberLabel
            // 
            documentNumberLabel.AutoSize = true;
            documentNumberLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            documentNumberLabel.Location = new Point(12, 68);
            documentNumberLabel.Name = "documentNumberLabel";
            documentNumberLabel.Size = new Size(267, 17);
            documentNumberLabel.TabIndex = 2;
            documentNumberLabel.Text = "Номер документа о завершении ремонта";
            // 
            // closeRepairDateLabel
            // 
            closeRepairDateLabel.AutoSize = true;
            closeRepairDateLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            closeRepairDateLabel.Location = new Point(12, 38);
            closeRepairDateLabel.Name = "closeRepairDateLabel";
            closeRepairDateLabel.Size = new Size(173, 17);
            closeRepairDateLabel.TabIndex = 1;
            closeRepairDateLabel.Text = "Дата завершения ремонта";
            // 
            // repairIdLabel
            // 
            repairIdLabel.AutoSize = true;
            repairIdLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            repairIdLabel.Location = new Point(12, 12);
            repairIdLabel.Name = "repairIdLabel";
            repairIdLabel.Size = new Size(109, 17);
            repairIdLabel.TabIndex = 0;
            repairIdLabel.Text = "Номер ремонта";
            // 
            // CloseRepair
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 475);
            Controls.Add(infoPanel);
            Controls.Add(headerPanel);
            Name = "CloseRepair";
            Text = "CloseRepair";
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)docNumUpDown).EndInit();
            ResumeLayout(false);
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
    }
}