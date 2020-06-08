namespace Example_Kursach
{
    partial class SecurityGuards
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
            this.Gap = new System.Windows.Forms.Panel();
            this.TariffsLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.StaffGrid = new System.Windows.Forms.DataGridView();
            this.SWorkerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gap.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGrid)).BeginInit();
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
            this.Gap.Size = new System.Drawing.Size(1633, 913);
            this.Gap.TabIndex = 7;
            // 
            // TariffsLabel
            // 
            this.TariffsLabel.AutoSize = true;
            this.TariffsLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TariffsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.TariffsLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TariffsLabel.Location = new System.Drawing.Point(1064, 16);
            this.TariffsLabel.Name = "TariffsLabel";
            this.TariffsLabel.Size = new System.Drawing.Size(287, 34);
            this.TariffsLabel.TabIndex = 9;
            this.TariffsLabel.Text = "security guards";
            this.TariffsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.NameLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NameLabel.Location = new System.Drawing.Point(277, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(284, 34);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "armorguardian";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.DeleteButton);
            this.LoginPanel.Controls.Add(this.BackButton);
            this.LoginPanel.Controls.Add(this.InfoButton);
            this.LoginPanel.Controls.Add(this.StaffGrid);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginPanel.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanel.Location = new System.Drawing.Point(0, 60);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1633, 853);
            this.LoginPanel.TabIndex = 2;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteButton.Location = new System.Drawing.Point(960, 756);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(642, 53);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Choose row to delete and press \"del\"";
            this.DeleteButton.UseVisualStyleBackColor = false;
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
            this.BackButton.Location = new System.Drawing.Point(30, 756);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(265, 53);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseEnter += new System.EventHandler(this.BackButton_MouseEnter);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoButton.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.InfoButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.InfoButton.Location = new System.Drawing.Point(344, 756);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(572, 53);
            this.InfoButton.TabIndex = 6;
            this.InfoButton.Text = "get trasnport & equipment info";
            this.InfoButton.UseMnemonic = false;
            this.InfoButton.UseVisualStyleBackColor = false;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click_1);
            this.InfoButton.MouseEnter += new System.EventHandler(this.InfoButton_MouseEnter);
            this.InfoButton.MouseLeave += new System.EventHandler(this.InfoButton_MouseLeave);
            // 
            // StaffGrid
            // 
            this.StaffGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.StaffGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StaffGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SWorkerID});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StaffGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.StaffGrid.Location = new System.Drawing.Point(30, 24);
            this.StaffGrid.Name = "StaffGrid";
            this.StaffGrid.ReadOnly = true;
            this.StaffGrid.RowHeadersWidth = 82;
            this.StaffGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffGrid.Size = new System.Drawing.Size(1572, 643);
            this.StaffGrid.TabIndex = 0;
            this.StaffGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.StaffGrid_UserDeletingRow);
            // 
            // SWorkerID
            // 
            this.SWorkerID.DataPropertyName = "SWorkerID";
            this.SWorkerID.HeaderText = "SWorkerID";
            this.SWorkerID.Name = "SWorkerID";
            this.SWorkerID.ReadOnly = true;
            this.SWorkerID.Width = 232;
            // 
            // SecurityGuards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 913);
            this.Controls.Add(this.Gap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecurityGuards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecurityGuards";
            this.Gap.ResumeLayout(false);
            this.Gap.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StaffGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Gap;
        private System.Windows.Forms.Label TariffsLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.DataGridView StaffGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SWorkerID;
        private System.Windows.Forms.Button DeleteButton;
    }
}