namespace Example_Kursach
{
    partial class DepForms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Gap = new System.Windows.Forms.Panel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.TariffsLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.StaffGrid = new System.Windows.Forms.DataGridView();
            this.DepID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Gap.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Gap
            // 
            this.Gap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gap.Controls.Add(this.NameLabel);
            this.Gap.Controls.Add(this.LoginPanel);
            this.Gap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gap.Location = new System.Drawing.Point(0, 0);
            this.Gap.Name = "Gap";
            this.Gap.Size = new System.Drawing.Size(1632, 836);
            this.Gap.TabIndex = 7;
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
            this.LoginPanel.Controls.Add(this.UpdateButton);
            this.LoginPanel.Controls.Add(this.TariffsLabel);
            this.LoginPanel.Controls.Add(this.BackButton);
            this.LoginPanel.Controls.Add(this.AddButton);
            this.LoginPanel.Controls.Add(this.StaffGrid);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginPanel.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanel.Location = new System.Drawing.Point(0, -17);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1632, 853);
            this.LoginPanel.TabIndex = 2;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UpdateButton.Location = new System.Drawing.Point(1297, 653);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(305, 71);
            this.UpdateButton.TabIndex = 16;
            this.UpdateButton.Text = "update record";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            this.UpdateButton.MouseEnter += new System.EventHandler(this.UpdateButton_MouseEnter);
            this.UpdateButton.MouseLeave += new System.EventHandler(this.UpdateButton_MouseLeave);
            // 
            // TariffsLabel
            // 
            this.TariffsLabel.AutoSize = true;
            this.TariffsLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TariffsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.TariffsLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TariffsLabel.Location = new System.Drawing.Point(1048, 33);
            this.TariffsLabel.Name = "TariffsLabel";
            this.TariffsLabel.Size = new System.Drawing.Size(205, 34);
            this.TariffsLabel.TabIndex = 9;
            this.TariffsLabel.Text = "Deparments";
            this.TariffsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BackButton.Location = new System.Drawing.Point(42, 747);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(265, 62);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseEnter += new System.EventHandler(this.BackButton_MouseEnter);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddButton.Location = new System.Drawing.Point(1297, 747);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(305, 62);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add record";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseEnter += new System.EventHandler(this.AddButton_MouseEnter);
            this.AddButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            // 
            // StaffGrid
            // 
            this.StaffGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.StaffGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StaffGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StaffGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.StaffGrid.Location = new System.Drawing.Point(153, 163);
            this.StaffGrid.Name = "StaffGrid";
            this.StaffGrid.RowHeadersWidth = 82;
            this.StaffGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffGrid.Size = new System.Drawing.Size(1325, 336);
            this.StaffGrid.TabIndex = 0;
            this.StaffGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.StaffGrid_CellBeginEdit);
            this.StaffGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffGrid_CellEndEdit);
            this.StaffGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.StaffGrid_DataError);
            this.StaffGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.StaffGrid_UserDeletingRow);
            // 
            // DepID
            // 
            this.DepID.DataPropertyName = "DepID";
            this.DepID.HeaderText = "DepartmentID";
            this.DepID.Name = "DepID";
            this.DepID.ReadOnly = true;
            this.DepID.Width = 289;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteButton.Location = new System.Drawing.Point(448, 747);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(705, 62);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "Choose row to delete and press \"del\"";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // DepForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 836);
            this.Controls.Add(this.Gap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepForms";
            this.Gap.ResumeLayout(false);
            this.Gap.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Gap;
        private System.Windows.Forms.Label TariffsLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView StaffGrid;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepID;
        private System.Windows.Forms.Button DeleteButton;
    }
}