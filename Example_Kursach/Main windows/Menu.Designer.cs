namespace Example_Kursach
{
    partial class Menu
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
            this.StaffSupplyButton = new System.Windows.Forms.Button();
            this.SupplyButton = new System.Windows.Forms.Button();
            this.TransportButton = new System.Windows.Forms.Button();
            this.EquipmentButton = new System.Windows.Forms.Button();
            this.ContractButton = new System.Windows.Forms.Button();
            this.BuildingsButton = new System.Windows.Forms.Button();
            this.StaffButton = new System.Windows.Forms.Button();
            this.ServiceButton = new System.Windows.Forms.Button();
            this.TimetableB = new System.Windows.Forms.Button();
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
            this.Gap.Size = new System.Drawing.Size(1094, 823);
            this.Gap.TabIndex = 1;
            this.Gap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gap_MouseDown);
            this.Gap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Gap_MouseMove);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.NameLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NameLabel.Location = new System.Drawing.Point(311, 12);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(489, 34);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "armorguardian   main menu";
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
            this.LoginPanel.Controls.Add(this.TimetableB);
            this.LoginPanel.Controls.Add(this.StaffSupplyButton);
            this.LoginPanel.Controls.Add(this.SupplyButton);
            this.LoginPanel.Controls.Add(this.TransportButton);
            this.LoginPanel.Controls.Add(this.EquipmentButton);
            this.LoginPanel.Controls.Add(this.ContractButton);
            this.LoginPanel.Controls.Add(this.BuildingsButton);
            this.LoginPanel.Controls.Add(this.StaffButton);
            this.LoginPanel.Controls.Add(this.ServiceButton);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginPanel.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanel.Location = new System.Drawing.Point(0, 49);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1094, 774);
            this.LoginPanel.TabIndex = 2;
            this.LoginPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginPanel_MouseDown);
            this.LoginPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginPanel_MouseMove);
            // 
            // StaffSupplyButton
            // 
            this.StaffSupplyButton.AutoSize = true;
            this.StaffSupplyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StaffSupplyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.StaffSupplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffSupplyButton.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffSupplyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.StaffSupplyButton.Location = new System.Drawing.Point(829, 706);
            this.StaffSupplyButton.Name = "StaffSupplyButton";
            this.StaffSupplyButton.Size = new System.Drawing.Size(215, 41);
            this.StaffSupplyButton.TabIndex = 9;
            this.StaffSupplyButton.Text = "staff supply";
            this.StaffSupplyButton.UseVisualStyleBackColor = true;
            this.StaffSupplyButton.Click += new System.EventHandler(this.StaffSupplyButton_Click);
            this.StaffSupplyButton.MouseEnter += new System.EventHandler(this.StaffSupplyButton_MouseEnter);
            this.StaffSupplyButton.MouseLeave += new System.EventHandler(this.StaffSupplyButton_MouseLeave);
            // 
            // SupplyButton
            // 
            this.SupplyButton.AutoSize = true;
            this.SupplyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SupplyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.SupplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupplyButton.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.SupplyButton.Location = new System.Drawing.Point(449, 706);
            this.SupplyButton.Name = "SupplyButton";
            this.SupplyButton.Size = new System.Drawing.Size(215, 41);
            this.SupplyButton.TabIndex = 8;
            this.SupplyButton.Text = "stock supply";
            this.SupplyButton.UseVisualStyleBackColor = true;
            this.SupplyButton.Click += new System.EventHandler(this.SupplyButton_Click);
            this.SupplyButton.MouseEnter += new System.EventHandler(this.SupplyButton_MouseEnter);
            this.SupplyButton.MouseLeave += new System.EventHandler(this.SupplyButton_MouseLeave);
            // 
            // TransportButton
            // 
            this.TransportButton.AutoSize = true;
            this.TransportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.TransportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransportButton.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.TransportButton.Location = new System.Drawing.Point(618, 229);
            this.TransportButton.Name = "TransportButton";
            this.TransportButton.Size = new System.Drawing.Size(426, 70);
            this.TransportButton.TabIndex = 7;
            this.TransportButton.Text = "transport";
            this.TransportButton.UseVisualStyleBackColor = true;
            this.TransportButton.Click += new System.EventHandler(this.TransportButton_Click);
            this.TransportButton.MouseEnter += new System.EventHandler(this.TransportButton_MouseEnter);
            this.TransportButton.MouseLeave += new System.EventHandler(this.TransportButton_MouseLeave);
            // 
            // EquipmentButton
            // 
            this.EquipmentButton.AutoSize = true;
            this.EquipmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EquipmentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.EquipmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EquipmentButton.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipmentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.EquipmentButton.Location = new System.Drawing.Point(673, 457);
            this.EquipmentButton.Name = "EquipmentButton";
            this.EquipmentButton.Size = new System.Drawing.Size(371, 70);
            this.EquipmentButton.TabIndex = 6;
            this.EquipmentButton.Text = "equipment";
            this.EquipmentButton.UseVisualStyleBackColor = true;
            this.EquipmentButton.Click += new System.EventHandler(this.EquipmentButton_Click);
            this.EquipmentButton.MouseEnter += new System.EventHandler(this.EquipmentButton_MouseEnter);
            this.EquipmentButton.MouseLeave += new System.EventHandler(this.EquipmentButton_MouseLeave);
            // 
            // ContractButton
            // 
            this.ContractButton.AutoSize = true;
            this.ContractButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContractButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ContractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContractButton.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContractButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.ContractButton.Location = new System.Drawing.Point(50, 229);
            this.ContractButton.Name = "ContractButton";
            this.ContractButton.Size = new System.Drawing.Size(398, 70);
            this.ContractButton.TabIndex = 5;
            this.ContractButton.Text = "Contracts";
            this.ContractButton.UseVisualStyleBackColor = true;
            this.ContractButton.Click += new System.EventHandler(this.ContractButton_Click);
            this.ContractButton.MouseEnter += new System.EventHandler(this.ContractButton_MouseEnter);
            this.ContractButton.MouseLeave += new System.EventHandler(this.ContractButton_MouseLeave);
            // 
            // BuildingsButton
            // 
            this.BuildingsButton.AutoSize = true;
            this.BuildingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuildingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BuildingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuildingsButton.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.BuildingsButton.Location = new System.Drawing.Point(517, 47);
            this.BuildingsButton.Name = "BuildingsButton";
            this.BuildingsButton.Size = new System.Drawing.Size(527, 70);
            this.BuildingsButton.TabIndex = 4;
            this.BuildingsButton.Text = "offices & stocks";
            this.BuildingsButton.UseMnemonic = false;
            this.BuildingsButton.UseVisualStyleBackColor = true;
            this.BuildingsButton.Click += new System.EventHandler(this.BuildingsButton_Click);
            this.BuildingsButton.MouseEnter += new System.EventHandler(this.BuildingsButton_MouseEnter);
            this.BuildingsButton.MouseLeave += new System.EventHandler(this.BuildingsButton_MouseLeave);
            // 
            // StaffButton
            // 
            this.StaffButton.AutoSize = true;
            this.StaffButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StaffButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.StaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffButton.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.StaffButton.Location = new System.Drawing.Point(50, 457);
            this.StaffButton.Name = "StaffButton";
            this.StaffButton.Size = new System.Drawing.Size(481, 70);
            this.StaffButton.TabIndex = 3;
            this.StaffButton.Text = "staff members";
            this.StaffButton.UseVisualStyleBackColor = true;
            this.StaffButton.Click += new System.EventHandler(this.StaffButton_Click);
            this.StaffButton.MouseEnter += new System.EventHandler(this.StaffButton_MouseEnter);
            this.StaffButton.MouseLeave += new System.EventHandler(this.StaffButton_MouseLeave);
            // 
            // ServiceButton
            // 
            this.ServiceButton.AutoSize = true;
            this.ServiceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServiceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServiceButton.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.ServiceButton.Location = new System.Drawing.Point(50, 47);
            this.ServiceButton.Name = "ServiceButton";
            this.ServiceButton.Size = new System.Drawing.Size(301, 70);
            this.ServiceButton.TabIndex = 0;
            this.ServiceButton.Text = " Services ";
            this.ServiceButton.UseVisualStyleBackColor = true;
            this.ServiceButton.Click += new System.EventHandler(this.ServiceButton_Click);
            this.ServiceButton.MouseEnter += new System.EventHandler(this.ServiceButton_MouseEnter);
            this.ServiceButton.MouseLeave += new System.EventHandler(this.ServiceButton_MouseLeave);
            // 
            // TimetableB
            // 
            this.TimetableB.AutoSize = true;
            this.TimetableB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimetableB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.TimetableB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimetableB.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimetableB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.TimetableB.Location = new System.Drawing.Point(50, 706);
            this.TimetableB.Name = "TimetableB";
            this.TimetableB.Size = new System.Drawing.Size(215, 41);
            this.TimetableB.TabIndex = 10;
            this.TimetableB.Text = "timetable";
            this.TimetableB.UseVisualStyleBackColor = true;
            this.TimetableB.Click += new System.EventHandler(this.timetable_Click);
            this.TimetableB.MouseEnter += new System.EventHandler(this.timetable_MouseEnter);
            this.TimetableB.MouseLeave += new System.EventHandler(this.timetable_MouseLeave);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 823);
            this.Controls.Add(this.Gap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Gap.ResumeLayout(false);
            this.Gap.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Gap;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label MinimizeButton;
        private System.Windows.Forms.Button StaffButton;
        private System.Windows.Forms.Button ServiceButton;
        private System.Windows.Forms.Button BuildingsButton;
        private System.Windows.Forms.Button ContractButton;
        private System.Windows.Forms.Button TransportButton;
        private System.Windows.Forms.Button EquipmentButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button StaffSupplyButton;
        private System.Windows.Forms.Button SupplyButton;
        private System.Windows.Forms.Button TimetableB;
    }
}