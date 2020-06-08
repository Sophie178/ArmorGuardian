namespace Example_Kursach
{
    partial class NPC_Workers
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
            this.Gap = new System.Windows.Forms.Panel();
            this.TariffsLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.AddJPButton = new System.Windows.Forms.Button();
            this.AddNPButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.JPCGrid = new System.Windows.Forms.DataGridView();
            this.JPContractID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SWorkerID3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuardSurname1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuardName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackButton = new System.Windows.Forms.Button();
            this.NPCGrid = new System.Windows.Forms.DataGridView();
            this.NPContractID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SWorkerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuardSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gap.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JPCGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPCGrid)).BeginInit();
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
            this.Gap.Size = new System.Drawing.Size(1973, 1462);
            this.Gap.TabIndex = 12;
            // 
            // TariffsLabel
            // 
            this.TariffsLabel.AutoSize = true;
            this.TariffsLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TariffsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.TariffsLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TariffsLabel.Location = new System.Drawing.Point(1381, 25);
            this.TariffsLabel.Name = "TariffsLabel";
            this.TariffsLabel.Size = new System.Drawing.Size(384, 34);
            this.TariffsLabel.TabIndex = 9;
            this.TariffsLabel.Text = "Contracts & Guards";
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
            this.LoginPanel.Controls.Add(this.AddJPButton);
            this.LoginPanel.Controls.Add(this.AddNPButton);
            this.LoginPanel.Controls.Add(this.label2);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Controls.Add(this.JPCGrid);
            this.LoginPanel.Controls.Add(this.BackButton);
            this.LoginPanel.Controls.Add(this.NPCGrid);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginPanel.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanel.Location = new System.Drawing.Point(0, 78);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1973, 1384);
            this.LoginPanel.TabIndex = 2;
            // 
            // AddJPButton
            // 
            this.AddJPButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddJPButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddJPButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.AddJPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddJPButton.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddJPButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.AddJPButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddJPButton.Location = new System.Drawing.Point(1425, 1201);
            this.AddJPButton.Name = "AddJPButton";
            this.AddJPButton.Size = new System.Drawing.Size(305, 62);
            this.AddJPButton.TabIndex = 14;
            this.AddJPButton.Text = "Add record";
            this.AddJPButton.UseVisualStyleBackColor = false;
            this.AddJPButton.Click += new System.EventHandler(this.AddJPButton_Click);
            this.AddJPButton.MouseEnter += new System.EventHandler(this.AddJPButton_MouseEnter);
            this.AddJPButton.MouseLeave += new System.EventHandler(this.AddJPButton_MouseLeave);
            // 
            // AddNPButton
            // 
            this.AddNPButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddNPButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNPButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.AddNPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNPButton.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNPButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.AddNPButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddNPButton.Location = new System.Drawing.Point(1425, 530);
            this.AddNPButton.Name = "AddNPButton";
            this.AddNPButton.Size = new System.Drawing.Size(305, 62);
            this.AddNPButton.TabIndex = 13;
            this.AddNPButton.Text = "Add record";
            this.AddNPButton.UseVisualStyleBackColor = false;
            this.AddNPButton.Click += new System.EventHandler(this.AddNPButton_Click);
            this.AddNPButton.MouseEnter += new System.EventHandler(this.AddNPButton_MouseEnter);
            this.AddNPButton.MouseLeave += new System.EventHandler(this.AddNPButton_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(384, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(820, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Natural Person Clients Contracts & Guards";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(384, 1214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(831, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Juridical Person Clients Contracts & Guards";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // JPCGrid
            // 
            this.JPCGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.JPCGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.JPCGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JPCGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JPContractID,
            this.SWorkerID3,
            this.ClientName1,
            this.GuardSurname1,
            this.GuardName1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.JPCGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.JPCGrid.Location = new System.Drawing.Point(97, 743);
            this.JPCGrid.Name = "JPCGrid";
            this.JPCGrid.RowHeadersWidth = 82;
            this.JPCGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.JPCGrid.Size = new System.Drawing.Size(1788, 439);
            this.JPCGrid.TabIndex = 10;
            this.JPCGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.JPCGrid_UserDeletingRow);
            // 
            // JPContractID
            // 
            this.JPContractID.DataPropertyName = "JPContractID";
            this.JPContractID.HeaderText = "JPContract ID";
            this.JPContractID.Name = "JPContractID";
            // 
            // SWorkerID3
            // 
            this.SWorkerID3.DataPropertyName = "SWorkerID";
            this.SWorkerID3.HeaderText = "Guard ID";
            this.SWorkerID3.Name = "SWorkerID3";
            // 
            // ClientName1
            // 
            this.ClientName1.DataPropertyName = "ClientName";
            this.ClientName1.HeaderText = "Client_Name";
            this.ClientName1.Name = "ClientName1";
            this.ClientName1.ReadOnly = true;
            // 
            // GuardSurname1
            // 
            this.GuardSurname1.DataPropertyName = "Guard_Surname";
            this.GuardSurname1.HeaderText = "Guard_Surname";
            this.GuardSurname1.Name = "GuardSurname1";
            this.GuardSurname1.ReadOnly = true;
            // 
            // GuardName1
            // 
            this.GuardName1.DataPropertyName = "Guard_Name";
            this.GuardName1.HeaderText = "Guard_Name";
            this.GuardName1.Name = "GuardName1";
            this.GuardName1.ReadOnly = true;
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
            this.BackButton.Location = new System.Drawing.Point(866, 1306);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(265, 53);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseEnter += new System.EventHandler(this.BackButton_MouseEnter);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            // 
            // NPCGrid
            // 
            this.NPCGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NPCGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.NPCGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NPCGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NPContractID,
            this.SWorkerID,
            this.ClientSurname,
            this.ClientName,
            this.GuardSurname,
            this.GuardName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NPCGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.NPCGrid.Location = new System.Drawing.Point(97, 31);
            this.NPCGrid.Name = "NPCGrid";
            this.NPCGrid.RowHeadersWidth = 82;
            this.NPCGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NPCGrid.Size = new System.Drawing.Size(1788, 483);
            this.NPCGrid.TabIndex = 0;
            this.NPCGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.NPCGrid_UserDeletingRow);
            // 
            // NPContractID
            // 
            this.NPContractID.DataPropertyName = "NPContractID";
            this.NPContractID.HeaderText = "NPContract ID";
            this.NPContractID.Name = "NPContractID";
            // 
            // SWorkerID
            // 
            this.SWorkerID.DataPropertyName = "SWorkerID";
            this.SWorkerID.HeaderText = "Guard ID";
            this.SWorkerID.Name = "SWorkerID";
            // 
            // ClientSurname
            // 
            this.ClientSurname.DataPropertyName = "Client_Surname";
            this.ClientSurname.HeaderText = "Client_Surname";
            this.ClientSurname.Name = "ClientSurname";
            this.ClientSurname.ReadOnly = true;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "Client_Name";
            this.ClientName.HeaderText = "Client_Name";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // GuardSurname
            // 
            this.GuardSurname.DataPropertyName = "Guard_Name";
            this.GuardSurname.HeaderText = "Guard_Surname";
            this.GuardSurname.Name = "GuardSurname";
            this.GuardSurname.ReadOnly = true;
            // 
            // GuardName
            // 
            this.GuardName.DataPropertyName = "Guard_Name";
            this.GuardName.HeaderText = "Guard_Name";
            this.GuardName.Name = "GuardName";
            this.GuardName.ReadOnly = true;
            // 
            // NPC_Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1973, 1462);
            this.Controls.Add(this.Gap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NPC_Workers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPC_Workers";
            this.Gap.ResumeLayout(false);
            this.Gap.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JPCGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPCGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Gap;
        private System.Windows.Forms.Label TariffsLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.DataGridView JPCGrid;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView NPCGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddJPButton;
        private System.Windows.Forms.Button AddNPButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn JPContractID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SWorkerID3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuardSurname1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuardName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NPContractID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SWorkerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuardSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuardName;
    }
}