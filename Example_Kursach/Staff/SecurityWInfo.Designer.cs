namespace Example_Kursach
{
    partial class SecurityWInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Gap = new System.Windows.Forms.Panel();
            this.TariffsLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.TranGrid = new System.Windows.Forms.DataGridView();
            this.SWorkerID3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeaponGrid = new System.Windows.Forms.DataGridView();
            this.SWorkerID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeaponID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackButton = new System.Windows.Forms.Button();
            this.EqGrid = new System.Windows.Forms.DataGridView();
            this.SWorkerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gap.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TranGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeaponGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EqGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Gap
            // 
            this.Gap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gap.Controls.Add(this.TariffsLabel);
            this.Gap.Controls.Add(this.NameLabel);
            this.Gap.Controls.Add(this.LoginPanel);
            this.Gap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gap.Location = new System.Drawing.Point(0, 0);
            this.Gap.Name = "Gap";
            this.Gap.Size = new System.Drawing.Size(1986, 1216);
            this.Gap.TabIndex = 9;
            // 
            // TariffsLabel
            // 
            this.TariffsLabel.AutoSize = true;
            this.TariffsLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TariffsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.TariffsLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TariffsLabel.Location = new System.Drawing.Point(1105, 25);
            this.TariffsLabel.Name = "TariffsLabel";
            this.TariffsLabel.Size = new System.Drawing.Size(709, 34);
            this.TariffsLabel.TabIndex = 9;
            this.TariffsLabel.Text = "Guard\'s Equipment & Weapon & Transport";
            this.TariffsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TariffsLabel.UseMnemonic = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.NameLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NameLabel.Location = new System.Drawing.Point(250, 25);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(284, 34);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "armorguardian";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.TranGrid);
            this.LoginPanel.Controls.Add(this.WeaponGrid);
            this.LoginPanel.Controls.Add(this.BackButton);
            this.LoginPanel.Controls.Add(this.EqGrid);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginPanel.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanel.Location = new System.Drawing.Point(0, 61);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1986, 1155);
            this.LoginPanel.TabIndex = 2;
            // 
            // TranGrid
            // 
            this.TranGrid.AllowUserToAddRows = false;
            this.TranGrid.AllowUserToDeleteRows = false;
            this.TranGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TranGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TranGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TranGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SWorkerID3,
            this.TransportID});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TranGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.TranGrid.Location = new System.Drawing.Point(21, 767);
            this.TranGrid.Name = "TranGrid";
            this.TranGrid.ReadOnly = true;
            this.TranGrid.RowHeadersWidth = 82;
            this.TranGrid.Size = new System.Drawing.Size(1937, 122);
            this.TranGrid.TabIndex = 10;
            // 
            // SWorkerID3
            // 
            this.SWorkerID3.DataPropertyName = "SWorkerID";
            this.SWorkerID3.HeaderText = "SWorkerID";
            this.SWorkerID3.Name = "SWorkerID3";
            this.SWorkerID3.ReadOnly = true;
            // 
            // TransportID
            // 
            this.TransportID.DataPropertyName = "TransportID";
            this.TransportID.HeaderText = "TransportID";
            this.TransportID.Name = "TransportID";
            this.TransportID.ReadOnly = true;
            // 
            // WeaponGrid
            // 
            this.WeaponGrid.AllowUserToAddRows = false;
            this.WeaponGrid.AllowUserToDeleteRows = false;
            this.WeaponGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WeaponGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.WeaponGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeaponGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SWorkerID2,
            this.WeaponID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WeaponGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.WeaponGrid.Location = new System.Drawing.Point(21, 469);
            this.WeaponGrid.Name = "WeaponGrid";
            this.WeaponGrid.ReadOnly = true;
            this.WeaponGrid.RowHeadersWidth = 82;
            this.WeaponGrid.Size = new System.Drawing.Size(1937, 150);
            this.WeaponGrid.TabIndex = 9;
            // 
            // SWorkerID2
            // 
            this.SWorkerID2.DataPropertyName = "SWorkerID";
            this.SWorkerID2.HeaderText = "SWorkerID";
            this.SWorkerID2.Name = "SWorkerID2";
            this.SWorkerID2.ReadOnly = true;
            // 
            // WeaponID
            // 
            this.WeaponID.DataPropertyName = "WeaponID";
            this.WeaponID.HeaderText = "WeaponID";
            this.WeaponID.Name = "WeaponID";
            this.WeaponID.ReadOnly = true;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.BackButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BackButton.Location = new System.Drawing.Point(64, 1061);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(265, 53);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseEnter += new System.EventHandler(this.BackButton_MouseEnter);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            // 
            // EqGrid
            // 
            this.EqGrid.AllowUserToAddRows = false;
            this.EqGrid.AllowUserToDeleteRows = false;
            this.EqGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EqGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EqGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EqGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SWorkerID,
            this.EquipmentID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EqGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.EqGrid.Location = new System.Drawing.Point(21, 94);
            this.EqGrid.Name = "EqGrid";
            this.EqGrid.ReadOnly = true;
            this.EqGrid.RowHeadersWidth = 82;
            this.EqGrid.Size = new System.Drawing.Size(1937, 233);
            this.EqGrid.TabIndex = 0;
            // 
            // SWorkerID
            // 
            this.SWorkerID.DataPropertyName = "SWorkerID";
            this.SWorkerID.HeaderText = "SWorkerID";
            this.SWorkerID.Name = "SWorkerID";
            this.SWorkerID.ReadOnly = true;
            // 
            // EquipmentID
            // 
            this.EquipmentID.DataPropertyName = "EquipID";
            this.EquipmentID.HeaderText = "EquipmentID";
            this.EquipmentID.Name = "EquipmentID";
            this.EquipmentID.ReadOnly = true;
            // 
            // SecurityWInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1986, 1216);
            this.Controls.Add(this.Gap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecurityWInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecurityWInfo";
            this.Gap.ResumeLayout(false);
            this.Gap.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TranGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeaponGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EqGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Gap;
        private System.Windows.Forms.Label TariffsLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.DataGridView WeaponGrid;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView EqGrid;
        private System.Windows.Forms.DataGridView TranGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SWorkerID3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SWorkerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SWorkerID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeaponID;
    }
}