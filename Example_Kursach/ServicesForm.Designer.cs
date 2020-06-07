namespace Example_Kursach
{
    partial class ServicesForm
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
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.TechButton = new System.Windows.Forms.Button();
            this.BodyGuardButton = new System.Windows.Forms.Button();
            this.MassEventsButton = new System.Windows.Forms.Button();
            this.FacilityButton = new System.Windows.Forms.Button();
            this.CargoButton = new System.Windows.Forms.Button();
            this.AllServiceButton = new System.Windows.Forms.Button();
            this.Gap.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gap
            // 
            this.Gap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gap.Controls.Add(this.NameLabel);
            this.Gap.Controls.Add(this.MinimizeButton);
            this.Gap.Controls.Add(this.CloseButton);
            this.Gap.Controls.Add(this.LoginPanel);
            this.Gap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gap.Location = new System.Drawing.Point(0, 0);
            this.Gap.Name = "Gap";
            this.Gap.Size = new System.Drawing.Size(1095, 826);
            this.Gap.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.NameLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NameLabel.Location = new System.Drawing.Point(398, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(284, 34);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "armorguardian";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Font = new System.Drawing.Font("Perpetua Titling MT", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.MinimizeButton.Location = new System.Drawing.Point(985, 9);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(44, 38);
            this.MinimizeButton.TabIndex = 5;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.MinimizeButton_MouseEnter);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.MinimizeButton_MouseLeave);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.Location = new System.Drawing.Point(1035, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(44, 38);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.TechButton);
            this.LoginPanel.Controls.Add(this.BodyGuardButton);
            this.LoginPanel.Controls.Add(this.MassEventsButton);
            this.LoginPanel.Controls.Add(this.FacilityButton);
            this.LoginPanel.Controls.Add(this.CargoButton);
            this.LoginPanel.Controls.Add(this.AllServiceButton);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginPanel.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanel.Location = new System.Drawing.Point(0, 52);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1095, 774);
            this.LoginPanel.TabIndex = 2;
            this.LoginPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginPanel_MouseDown);
            this.LoginPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginPanel_MouseMove);
            // 
            // TechButton
            // 
            this.TechButton.AutoSize = true;
            this.TechButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TechButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.TechButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TechButton.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.TechButton.Location = new System.Drawing.Point(48, 667);
            this.TechButton.Name = "TechButton";
            this.TechButton.Size = new System.Drawing.Size(531, 70);
            this.TechButton.TabIndex = 5;
            this.TechButton.Text = "Technical Services";
            this.TechButton.UseVisualStyleBackColor = true;
            this.TechButton.Click += new System.EventHandler(this.TechButton_Click);
            this.TechButton.MouseEnter += new System.EventHandler(this.TechButton_MouseEnter);
            this.TechButton.MouseLeave += new System.EventHandler(this.TechButton_MouseLeave);
            // 
            // BodyGuardButton
            // 
            this.BodyGuardButton.AutoSize = true;
            this.BodyGuardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BodyGuardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BodyGuardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BodyGuardButton.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodyGuardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.BodyGuardButton.Location = new System.Drawing.Point(48, 240);
            this.BodyGuardButton.Name = "BodyGuardButton";
            this.BodyGuardButton.Size = new System.Drawing.Size(531, 70);
            this.BodyGuardButton.TabIndex = 4;
            this.BodyGuardButton.Text = "Body-Guard services";
            this.BodyGuardButton.UseVisualStyleBackColor = true;
            this.BodyGuardButton.Click += new System.EventHandler(this.BodyGuardButton_Click);
            this.BodyGuardButton.MouseEnter += new System.EventHandler(this.BodyGuard_MouseEnter);
            this.BodyGuardButton.MouseLeave += new System.EventHandler(this.BodyGuard_MouseLeave);
            // 
            // MassEventsButton
            // 
            this.MassEventsButton.AutoSize = true;
            this.MassEventsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MassEventsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.MassEventsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MassEventsButton.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MassEventsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.MassEventsButton.Location = new System.Drawing.Point(454, 558);
            this.MassEventsButton.Name = "MassEventsButton";
            this.MassEventsButton.Size = new System.Drawing.Size(575, 70);
            this.MassEventsButton.TabIndex = 3;
            this.MassEventsButton.Text = "Mass Events Protection";
            this.MassEventsButton.UseVisualStyleBackColor = true;
            this.MassEventsButton.Click += new System.EventHandler(this.MassEventsButton_Click);
            this.MassEventsButton.MouseEnter += new System.EventHandler(this.MassEventsButton_MouseEnter);
            this.MassEventsButton.MouseLeave += new System.EventHandler(this.MassEventsButton_MouseLeave);
            // 
            // FacilityButton
            // 
            this.FacilityButton.AutoSize = true;
            this.FacilityButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FacilityButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.FacilityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FacilityButton.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.FacilityButton.Location = new System.Drawing.Point(48, 456);
            this.FacilityButton.Name = "FacilityButton";
            this.FacilityButton.Size = new System.Drawing.Size(531, 70);
            this.FacilityButton.TabIndex = 2;
            this.FacilityButton.Text = "Facility Protection";
            this.FacilityButton.UseVisualStyleBackColor = true;
            this.FacilityButton.Click += new System.EventHandler(this.FacilityButton_Click);
            this.FacilityButton.MouseEnter += new System.EventHandler(this.FacilityButton_MouseEnter);
            this.FacilityButton.MouseLeave += new System.EventHandler(this.FacilityButton_MouseLeave);
            // 
            // CargoButton
            // 
            this.CargoButton.AutoSize = true;
            this.CargoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CargoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.CargoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CargoButton.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.CargoButton.Location = new System.Drawing.Point(454, 347);
            this.CargoButton.Name = "CargoButton";
            this.CargoButton.Size = new System.Drawing.Size(575, 70);
            this.CargoButton.TabIndex = 1;
            this.CargoButton.Text = "Cargo Escorting services";
            this.CargoButton.UseVisualStyleBackColor = true;
            this.CargoButton.Click += new System.EventHandler(this.CargoButton_Click);
            this.CargoButton.MouseEnter += new System.EventHandler(this.CargoButton_MouseEnter);
            this.CargoButton.MouseLeave += new System.EventHandler(this.CargoButton_MouseLeave);
            // 
            // AllServiceButton
            // 
            this.AllServiceButton.AutoSize = true;
            this.AllServiceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllServiceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.AllServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllServiceButton.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllServiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.AllServiceButton.Location = new System.Drawing.Point(216, 57);
            this.AllServiceButton.Name = "AllServiceButton";
            this.AllServiceButton.Size = new System.Drawing.Size(651, 70);
            this.AllServiceButton.TabIndex = 0;
            this.AllServiceButton.Text = "All Tariffs";
            this.AllServiceButton.UseVisualStyleBackColor = true;
            this.AllServiceButton.Click += new System.EventHandler(this.AllServiceButton_Click);
            this.AllServiceButton.MouseEnter += new System.EventHandler(this.AllServiceButton_MouseEnter);
            this.AllServiceButton.MouseLeave += new System.EventHandler(this.AllServiceButton_MouseLeave);
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 826);
            this.Controls.Add(this.Gap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServicesForm";
            this.Text = "ServicesFrom";
            this.Gap.ResumeLayout(false);
            this.Gap.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Gap;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label MinimizeButton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button AllServiceButton;
        private System.Windows.Forms.Button TechButton;
        private System.Windows.Forms.Button BodyGuardButton;
        private System.Windows.Forms.Button MassEventsButton;
        private System.Windows.Forms.Button FacilityButton;
        private System.Windows.Forms.Button CargoButton;
    }
}