namespace Example_Kursach
{
    partial class Staff
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
            this.Gap = new System.Windows.Forms.Panel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.SGuardButton = new System.Windows.Forms.Button();
            this.SUnitButton = new System.Windows.Forms.Button();
            this.DStaffButton = new System.Windows.Forms.Button();
            this.MainPageButton = new System.Windows.Forms.Button();
            this.DepButton = new System.Windows.Forms.Button();
            this.Gap.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gap
            // 
            this.Gap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gap.Controls.Add(this.NameLabel);
            this.Gap.Controls.Add(this.LoginPanel);
            this.Gap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gap.Location = new System.Drawing.Point(0, 0);
            this.Gap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Gap.Name = "Gap";
            this.Gap.Size = new System.Drawing.Size(2184, 1590);
            this.Gap.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.NameLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NameLabel.Location = new System.Drawing.Point(806, 33);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(284, 34);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "armorguardian";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.SGuardButton);
            this.LoginPanel.Controls.Add(this.SUnitButton);
            this.LoginPanel.Controls.Add(this.DStaffButton);
            this.LoginPanel.Controls.Add(this.MainPageButton);
            this.LoginPanel.Controls.Add(this.DepButton);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginPanel.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanel.Location = new System.Drawing.Point(0, 102);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(2184, 1488);
            this.LoginPanel.TabIndex = 2;
            // 
            // SGuardButton
            // 
            this.SGuardButton.AutoSize = true;
            this.SGuardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SGuardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.SGuardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SGuardButton.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SGuardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.SGuardButton.Location = new System.Drawing.Point(1166, 1283);
            this.SGuardButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SGuardButton.Name = "SGuardButton";
            this.SGuardButton.Size = new System.Drawing.Size(972, 135);
            this.SGuardButton.TabIndex = 7;
            this.SGuardButton.Text = "security guards";
            this.SGuardButton.UseVisualStyleBackColor = true;
            this.SGuardButton.Click += new System.EventHandler(this.SGuardButton_Click);
            this.SGuardButton.MouseEnter += new System.EventHandler(this.SGuardButton_MouseEnter);
            this.SGuardButton.MouseLeave += new System.EventHandler(this.SGuardButton_MouseLeave);
            // 
            // SUnitButton
            // 
            this.SUnitButton.AutoSize = true;
            this.SUnitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SUnitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.SUnitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SUnitButton.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUnitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.SUnitButton.Location = new System.Drawing.Point(74, 1065);
            this.SUnitButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SUnitButton.Name = "SUnitButton";
            this.SUnitButton.Size = new System.Drawing.Size(820, 135);
            this.SUnitButton.TabIndex = 5;
            this.SUnitButton.Text = "Security Units";
            this.SUnitButton.UseVisualStyleBackColor = true;
            this.SUnitButton.Click += new System.EventHandler(this.SUnitButton_Click);
            this.SUnitButton.MouseEnter += new System.EventHandler(this.SUnitButton_MouseEnter);
            this.SUnitButton.MouseLeave += new System.EventHandler(this.SUnitButton_MouseLeave);
            // 
            // DStaffButton
            // 
            this.DStaffButton.AutoSize = true;
            this.DStaffButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DStaffButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.DStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DStaffButton.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DStaffButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.DStaffButton.Location = new System.Drawing.Point(1078, 723);
            this.DStaffButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DStaffButton.Name = "DStaffButton";
            this.DStaffButton.Size = new System.Drawing.Size(1060, 135);
            this.DStaffButton.TabIndex = 4;
            this.DStaffButton.Text = "Departments\' staff";
            this.DStaffButton.UseMnemonic = false;
            this.DStaffButton.UseVisualStyleBackColor = true;
            this.DStaffButton.Click += new System.EventHandler(this.DStaffButton_Click);
            this.DStaffButton.MouseEnter += new System.EventHandler(this.DStaffButton_MouseEnter);
            this.DStaffButton.MouseLeave += new System.EventHandler(this.DStaffButton_MouseLeave);
            // 
            // MainPageButton
            // 
            this.MainPageButton.AutoSize = true;
            this.MainPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainPageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.MainPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainPageButton.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.MainPageButton.Location = new System.Drawing.Point(610, 75);
            this.MainPageButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MainPageButton.Name = "MainPageButton";
            this.MainPageButton.Size = new System.Drawing.Size(962, 135);
            this.MainPageButton.TabIndex = 3;
            this.MainPageButton.Text = "Main Page";
            this.MainPageButton.UseVisualStyleBackColor = true;
            this.MainPageButton.Click += new System.EventHandler(this.MainPageButton_Click);
            this.MainPageButton.MouseEnter += new System.EventHandler(this.MainPageButton_MouseEnter);
            this.MainPageButton.MouseLeave += new System.EventHandler(this.MainPageButton_MouseLeave);
            // 
            // DepButton
            // 
            this.DepButton.AutoSize = true;
            this.DepButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DepButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.DepButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepButton.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.DepButton.Location = new System.Drawing.Point(74, 529);
            this.DepButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DepButton.Name = "DepButton";
            this.DepButton.Size = new System.Drawing.Size(736, 135);
            this.DepButton.TabIndex = 0;
            this.DepButton.Text = "Departments";
            this.DepButton.UseVisualStyleBackColor = true;
            this.DepButton.Click += new System.EventHandler(this.DepButton_Click);
            this.DepButton.MouseEnter += new System.EventHandler(this.DepButton_MouseEnter);
            this.DepButton.MouseLeave += new System.EventHandler(this.DepButton_MouseLeave);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2184, 1590);
            this.Controls.Add(this.Gap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Gap.ResumeLayout(false);
            this.Gap.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Gap;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button SGuardButton;
        private System.Windows.Forms.Button SUnitButton;
        private System.Windows.Forms.Button DStaffButton;
        private System.Windows.Forms.Button MainPageButton;
        private System.Windows.Forms.Button DepButton;
    }
}