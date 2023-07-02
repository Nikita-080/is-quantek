namespace InformSystem.Forms
{
    partial class RepairFilter
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
            label1 = new Label();
            label2 = new Label();
            loadAllCheckBox = new CheckBox();
            dateFromPicker = new DateTimePicker();
            dateToPicker = new DateTimePicker();
            applyChangesButton = new Button();
            useFromCheckBox = new CheckBox();
            useToCheckBox = new CheckBox();
            useToEndCheckBox = new CheckBox();
            useFromEndCheckBox = new CheckBox();
            dateEndPickerTo = new DateTimePicker();
            dateEndPickerFrom = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 12);
            label1.Name = "label1";
            label1.Size = new Size(106, 17);
            label1.TabIndex = 0;
            label1.Text = "От(Получение):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 48);
            label2.Name = "label2";
            label2.Size = new Size(109, 17);
            label2.TabIndex = 1;
            label2.Text = "До(Получение):";
            // 
            // loadAllCheckBox
            // 
            loadAllCheckBox.AutoSize = true;
            loadAllCheckBox.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            loadAllCheckBox.Location = new Point(12, 143);
            loadAllCheckBox.Name = "loadAllCheckBox";
            loadAllCheckBox.Size = new Size(115, 21);
            loadAllCheckBox.TabIndex = 2;
            loadAllCheckBox.Text = "Загрузить все";
            loadAllCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateFromPicker
            // 
            dateFromPicker.Location = new Point(139, 12);
            dateFromPicker.Name = "dateFromPicker";
            dateFromPicker.Size = new Size(200, 23);
            dateFromPicker.TabIndex = 3;
            // 
            // dateToPicker
            // 
            dateToPicker.Location = new Point(139, 46);
            dateToPicker.Name = "dateToPicker";
            dateToPicker.Size = new Size(200, 23);
            dateToPicker.TabIndex = 4;
            // 
            // applyChangesButton
            // 
            applyChangesButton.BackColor = Color.FromArgb(0, 42, 87);
            applyChangesButton.FlatAppearance.BorderSize = 0;
            applyChangesButton.FlatStyle = FlatStyle.Flat;
            applyChangesButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            applyChangesButton.ForeColor = SystemColors.ButtonFace;
            applyChangesButton.Location = new Point(9, 169);
            applyChangesButton.Margin = new Padding(3, 2, 3, 2);
            applyChangesButton.Name = "applyChangesButton";
            applyChangesButton.Size = new Size(171, 25);
            applyChangesButton.TabIndex = 5;
            applyChangesButton.Text = "Применить";
            applyChangesButton.UseVisualStyleBackColor = false;
            applyChangesButton.Click += applyChangesButton_Click;
            // 
            // useFromCheckBox
            // 
            useFromCheckBox.AutoSize = true;
            useFromCheckBox.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            useFromCheckBox.Location = new Point(345, 17);
            useFromCheckBox.Name = "useFromCheckBox";
            useFromCheckBox.Size = new Size(116, 21);
            useFromCheckBox.TabIndex = 6;
            useFromCheckBox.Text = "Использовать";
            useFromCheckBox.UseVisualStyleBackColor = true;
            // 
            // useToCheckBox
            // 
            useToCheckBox.AutoSize = true;
            useToCheckBox.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            useToCheckBox.Location = new Point(345, 49);
            useToCheckBox.Name = "useToCheckBox";
            useToCheckBox.Size = new Size(116, 21);
            useToCheckBox.TabIndex = 7;
            useToCheckBox.Text = "Использовать";
            useToCheckBox.UseVisualStyleBackColor = true;
            // 
            // useToEndCheckBox
            // 
            useToEndCheckBox.AutoSize = true;
            useToEndCheckBox.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            useToEndCheckBox.Location = new Point(345, 118);
            useToEndCheckBox.Name = "useToEndCheckBox";
            useToEndCheckBox.Size = new Size(116, 21);
            useToEndCheckBox.TabIndex = 13;
            useToEndCheckBox.Text = "Использовать";
            useToEndCheckBox.UseVisualStyleBackColor = true;
            // 
            // useFromEndCheckBox
            // 
            useFromEndCheckBox.AutoSize = true;
            useFromEndCheckBox.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            useFromEndCheckBox.Location = new Point(345, 86);
            useFromEndCheckBox.Name = "useFromEndCheckBox";
            useFromEndCheckBox.Size = new Size(116, 21);
            useFromEndCheckBox.TabIndex = 12;
            useFromEndCheckBox.Text = "Использовать";
            useFromEndCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateEndPickerTo
            // 
            dateEndPickerTo.Location = new Point(139, 115);
            dateEndPickerTo.Name = "dateEndPickerTo";
            dateEndPickerTo.Size = new Size(200, 23);
            dateEndPickerTo.TabIndex = 11;
            // 
            // dateEndPickerFrom
            // 
            dateEndPickerFrom.Location = new Point(139, 81);
            dateEndPickerFrom.Name = "dateEndPickerFrom";
            dateEndPickerFrom.Size = new Size(200, 23);
            dateEndPickerFrom.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 117);
            label3.Name = "label3";
            label3.Size = new Size(124, 17);
            label3.TabIndex = 9;
            label3.Text = "До(Завершение):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 83);
            label4.Name = "label4";
            label4.Size = new Size(121, 17);
            label4.TabIndex = 8;
            label4.Text = "От(Завершение):";
            // 
            // RepairFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 203);
            Controls.Add(useToEndCheckBox);
            Controls.Add(useFromEndCheckBox);
            Controls.Add(dateEndPickerTo);
            Controls.Add(dateEndPickerFrom);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(useToCheckBox);
            Controls.Add(useFromCheckBox);
            Controls.Add(applyChangesButton);
            Controls.Add(dateToPicker);
            Controls.Add(dateFromPicker);
            Controls.Add(loadAllCheckBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RepairFilter";
            Text = "RepairFilter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox loadAllCheckBox;
        private DateTimePicker dateFromPicker;
        private DateTimePicker dateToPicker;
        private Button applyChangesButton;
        private CheckBox useFromCheckBox;
        private CheckBox useToCheckBox;
        private CheckBox useToEndCheckBox;
        private CheckBox useFromEndCheckBox;
        private DateTimePicker dateEndPickerTo;
        private DateTimePicker dateEndPickerFrom;
        private Label label3;
        private Label label4;
    }
}