namespace InformSystem.Forms
{
    partial class AddPeripheryForm
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
            addButton = new Button();
            IdTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(0, 42, 87);
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.ForeColor = SystemColors.ButtonFace;
            addButton.Location = new Point(346, 38);
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(88, 26);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IdTextBox.Location = new Point(182, 7);
            IdTextBox.Margin = new Padding(3, 2, 3, 2);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(252, 27);
            IdTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(27, 21);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // AddPeripheryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 80);
            Controls.Add(IdTextBox);
            Controls.Add(label1);
            Controls.Add(addButton);
            Name = "AddPeripheryForm";
            Text = "ChangePeripheryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private TextBox IdTextBox;
        private Label label1;
    }
}