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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BuildingLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.BuildingNumeric = new System.Windows.Forms.NumericUpDown();
            this.FloorNumeric = new System.Windows.Forms.NumericUpDown();
            this.OfficeNumeric = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuildingNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloorNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OfficeNumeric);
            this.panel1.Controls.Add(this.FloorNumeric);
            this.panel1.Controls.Add(this.BuildingNumeric);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BuildingLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 190);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Офис";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Этаж";
            // 
            // BuildingLabel
            // 
            this.BuildingLabel.AutoSize = true;
            this.BuildingLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BuildingLabel.Location = new System.Drawing.Point(12, 9);
            this.BuildingLabel.Name = "BuildingLabel";
            this.BuildingLabel.Size = new System.Drawing.Size(85, 23);
            this.BuildingLabel.TabIndex = 18;
            this.BuildingLabel.Text = "Здание";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.Location = new System.Drawing.Point(287, 139);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(119, 29);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // BuildingNumeric
            // 
            this.BuildingNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BuildingNumeric.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BuildingNumeric.Location = new System.Drawing.Point(118, 9);
            this.BuildingNumeric.Name = "BuildingNumeric";
            this.BuildingNumeric.Size = new System.Drawing.Size(288, 28);
            this.BuildingNumeric.TabIndex = 25;
            // 
            // FloorNumeric
            // 
            this.FloorNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FloorNumeric.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FloorNumeric.Location = new System.Drawing.Point(118, 45);
            this.FloorNumeric.Name = "FloorNumeric";
            this.FloorNumeric.Size = new System.Drawing.Size(288, 28);
            this.FloorNumeric.TabIndex = 26;
            // 
            // OfficeNumeric
            // 
            this.OfficeNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OfficeNumeric.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OfficeNumeric.Location = new System.Drawing.Point(118, 84);
            this.OfficeNumeric.Name = "OfficeNumeric";
            this.OfficeNumeric.Size = new System.Drawing.Size(288, 28);
            this.OfficeNumeric.TabIndex = 27;
            // 
            // ChangePlaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 190);
            this.Controls.Add(this.panel1);
            this.Name = "ChangePlaceForm";
            this.Text = "ChangePlaceForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuildingNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloorNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeNumeric)).EndInit();
            this.ResumeLayout(false);

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