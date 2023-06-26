namespace InformSystem.Forms
{
    partial class ChangePlaceForm
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
            OfficeNumeric = new NumericUpDown();
            FloorNumeric = new NumericUpDown();
            BuildingNumeric = new NumericUpDown();
            saveButton = new Button();
            label8 = new Label();
            label4 = new Label();
            BuildingLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OfficeNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FloorNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BuildingNumeric).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(OfficeNumeric);
            panel1.Controls.Add(FloorNumeric);
            panel1.Controls.Add(BuildingNumeric);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(BuildingLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 142);
            panel1.TabIndex = 0;
            // 
            // OfficeNumeric
            // 
            OfficeNumeric.BorderStyle = BorderStyle.None;
            OfficeNumeric.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OfficeNumeric.Location = new Point(103, 63);
            OfficeNumeric.Margin = new Padding(3, 2, 3, 2);
            OfficeNumeric.Name = "OfficeNumeric";
            OfficeNumeric.Size = new Size(252, 23);
            OfficeNumeric.TabIndex = 27;
            // 
            // FloorNumeric
            // 
            FloorNumeric.BorderStyle = BorderStyle.None;
            FloorNumeric.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FloorNumeric.Location = new Point(103, 34);
            FloorNumeric.Margin = new Padding(3, 2, 3, 2);
            FloorNumeric.Name = "FloorNumeric";
            FloorNumeric.Size = new Size(252, 23);
            FloorNumeric.TabIndex = 26;
            // 
            // BuildingNumeric
            // 
            BuildingNumeric.BorderStyle = BorderStyle.None;
            BuildingNumeric.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BuildingNumeric.Location = new Point(103, 7);
            BuildingNumeric.Margin = new Padding(3, 2, 3, 2);
            BuildingNumeric.Name = "BuildingNumeric";
            BuildingNumeric.Size = new Size(252, 23);
            BuildingNumeric.TabIndex = 25;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(0, 42, 87);
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.ForeColor = SystemColors.ButtonFace;
            saveButton.Location = new Point(251, 104);
            saveButton.Margin = new Padding(3, 2, 3, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(104, 27);
            saveButton.TabIndex = 24;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(10, 67);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 22;
            label8.Text = "Офис";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 34);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 20;
            label4.Text = "Этаж";
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BuildingLabel.Location = new Point(10, 7);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(69, 21);
            BuildingLabel.TabIndex = 18;
            BuildingLabel.Text = "Здание";
            // 
            // ChangePlaceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 142);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ChangePlaceForm";
            Text = "ChangePlaceForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OfficeNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)FloorNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)BuildingNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label8;
        private Label label4;
        private Label BuildingLabel;
        private Button saveButton;
        private NumericUpDown OfficeNumeric;
        private NumericUpDown FloorNumeric;
        private NumericUpDown BuildingNumeric;
    }
}