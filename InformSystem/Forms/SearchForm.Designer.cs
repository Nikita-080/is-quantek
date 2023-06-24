namespace InformSystem.Forms
{
    partial class SearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchButtonIdH = new System.Windows.Forms.Button();
            this.IdP = new System.Windows.Forms.TextBox();
            this.IdH = new System.Windows.Forms.TextBox();
            this.SearchButtonIdP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер оборудования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Номер пользователя";
            // 
            // SearchButtonIdH
            // 
            this.SearchButtonIdH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButtonIdH.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SearchButtonIdH.FlatAppearance.BorderSize = 0;
            this.SearchButtonIdH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButtonIdH.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchButtonIdH.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SearchButtonIdH.Image = global::InformSystem.Properties.Resources.search;
            this.SearchButtonIdH.Location = new System.Drawing.Point(443, 9);
            this.SearchButtonIdH.Name = "SearchButtonIdH";
            this.SearchButtonIdH.Size = new System.Drawing.Size(49, 37);
            this.SearchButtonIdH.TabIndex = 7;
            this.SearchButtonIdH.UseVisualStyleBackColor = false;
            this.SearchButtonIdH.Click += new System.EventHandler(this.SearchButtonIdH_Click);
            // 
            // IdP
            // 
            this.IdP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdP.Location = new System.Drawing.Point(227, 59);
            this.IdP.Name = "IdP";
            this.IdP.Size = new System.Drawing.Size(210, 30);
            this.IdP.TabIndex = 9;
            this.IdP.TextChanged += new System.EventHandler(this.HTypeTextBox_TextChanged);
            // 
            // IdH
            // 
            this.IdH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdH.Location = new System.Drawing.Point(227, 9);
            this.IdH.Name = "IdH";
            this.IdH.Size = new System.Drawing.Size(210, 30);
            this.IdH.TabIndex = 8;
            // 
            // SearchButtonIdP
            // 
            this.SearchButtonIdP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButtonIdP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SearchButtonIdP.FlatAppearance.BorderSize = 0;
            this.SearchButtonIdP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButtonIdP.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchButtonIdP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SearchButtonIdP.Image = global::InformSystem.Properties.Resources.search;
            this.SearchButtonIdP.Location = new System.Drawing.Point(443, 52);
            this.SearchButtonIdP.Name = "SearchButtonIdP";
            this.SearchButtonIdP.Size = new System.Drawing.Size(49, 37);
            this.SearchButtonIdP.TabIndex = 10;
            this.SearchButtonIdP.UseVisualStyleBackColor = false;
            this.SearchButtonIdP.Click += new System.EventHandler(this.SearchButtonIdP_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 111);
            this.Controls.Add(this.SearchButtonIdP);
            this.Controls.Add(this.IdP);
            this.Controls.Add(this.IdH);
            this.Controls.Add(this.SearchButtonIdH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button SearchButtonIdH;
        private TextBox IdP;
        private TextBox IdH;
        private Button SearchButtonIdP;
    }
}