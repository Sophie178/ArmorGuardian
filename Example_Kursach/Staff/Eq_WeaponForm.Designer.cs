namespace Example_Kursach
{
    partial class Eq_WeaponForm
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
            this.AddWeaponButton = new System.Windows.Forms.Button();
            this.UpdateWeapButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.WeaponGrid = new System.Windows.Forms.DataGridView();
            this.WeaponID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EqGrid = new System.Windows.Forms.DataGridView();
            this.EquipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gap.SuspendLayout();
            this.LoginPanel.SuspendLayout();
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
            this.Gap.Size = new System.Drawing.Size(1989, 1207);
            this.Gap.TabIndex = 8;
            // 
            // TariffsLabel
            // 
            this.TariffsLabel.AutoSize = true;
            this.TariffsLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TariffsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.TariffsLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TariffsLabel.Location = new System.Drawing.Point(1273, 16);
            this.TariffsLabel.Name = "TariffsLabel";
            this.TariffsLabel.Size = new System.Drawing.Size(357, 34);
            this.TariffsLabel.TabIndex = 9;
            this.TariffsLabel.Text = "Equipment & Weapon";
            this.TariffsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TariffsLabel.UseMnemonic = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.NameLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NameLabel.Location = new System.Drawing.Point(393, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(284, 34);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "armorguardian";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.AddWeaponButton);
            this.LoginPanel.Controls.Add(this.UpdateWeapButton);
            this.LoginPanel.Controls.Add(this.UpdateButton);
            this.LoginPanel.Controls.Add(this.DeleteButton);
            this.LoginPanel.Controls.Add(this.WeaponGrid);
            this.LoginPanel.Controls.Add(this.BackButton);
            this.LoginPanel.Controls.Add(this.AddButton);
            this.LoginPanel.Controls.Add(this.EqGrid);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginPanel.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanel.Location = new System.Drawing.Point(0, 52);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1989, 1155);
            this.LoginPanel.TabIndex = 2;
            // 
            // AddWeaponButton
            // 
            this.AddWeaponButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddWeaponButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddWeaponButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.AddWeaponButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddWeaponButton.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWeaponButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.AddWeaponButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddWeaponButton.Location = new System.Drawing.Point(1445, 884);
            this.AddWeaponButton.Name = "AddWeaponButton";
            this.AddWeaponButton.Size = new System.Drawing.Size(439, 53);
            this.AddWeaponButton.TabIndex = 17;
            this.AddWeaponButton.Text = "Add weapon record";
            this.AddWeaponButton.UseVisualStyleBackColor = false;
            this.AddWeaponButton.Click += new System.EventHandler(this.AddWeaponButton_Click);
            this.AddWeaponButton.MouseEnter += new System.EventHandler(this.AddWeaponButton_MouseEnter);
            this.AddWeaponButton.MouseLeave += new System.EventHandler(this.AddWeaponButton_MouseLeave);
            // 
            // UpdateWeapButton
            // 
            this.UpdateWeapButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateWeapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateWeapButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.UpdateWeapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateWeapButton.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateWeapButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.UpdateWeapButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UpdateWeapButton.Location = new System.Drawing.Point(1445, 643);
            this.UpdateWeapButton.Name = "UpdateWeapButton";
            this.UpdateWeapButton.Size = new System.Drawing.Size(439, 53);
            this.UpdateWeapButton.TabIndex = 16;
            this.UpdateWeapButton.Text = "update weapon record";
            this.UpdateWeapButton.UseVisualStyleBackColor = false;
            this.UpdateWeapButton.Click += new System.EventHandler(this.UpdateWeapButton_Click);
            this.UpdateWeapButton.MouseEnter += new System.EventHandler(this.UpdateWeapButton_MouseEnter);
            this.UpdateWeapButton.MouseLeave += new System.EventHandler(this.UpdateWeapButton_MouseLeave);
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
            this.UpdateButton.Location = new System.Drawing.Point(1659, 71);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(265, 114);
            this.UpdateButton.TabIndex = 15;
            this.UpdateButton.Text = "update equipment record";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            this.UpdateButton.MouseEnter += new System.EventHandler(this.UpdateButton_MouseEnter);
            this.UpdateButton.MouseLeave += new System.EventHandler(this.UpdateButton_MouseLeave);
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
            this.DeleteButton.Location = new System.Drawing.Point(675, 1061);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(642, 53);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Choose row to delete and press \"del\"";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // WeaponGrid
            // 
            this.WeaponGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WeaponGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.WeaponGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeaponGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WeaponID});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WeaponGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.WeaponGrid.Location = new System.Drawing.Point(64, 551);
            this.WeaponGrid.Name = "WeaponGrid";
            this.WeaponGrid.RowHeadersWidth = 82;
            this.WeaponGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WeaponGrid.Size = new System.Drawing.Size(1297, 464);
            this.WeaponGrid.TabIndex = 9;
            this.WeaponGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.WeaponGrid_CellBeginEdit);
            this.WeaponGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.WeaponGrid_CellEndEdit);
            this.WeaponGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.WeaponGrid_DataError);
            this.WeaponGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.WeaponGrid_UserDeletingRow);
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
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddButton.Location = new System.Drawing.Point(1659, 315);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(265, 128);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add equipment record";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseEnter += new System.EventHandler(this.AddButton_MouseEnter);
            this.AddButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            // 
            // EqGrid
            // 
            this.EqGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.EqGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EqGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EqGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EqGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EqGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.EqGrid.Location = new System.Drawing.Point(64, 34);
            this.EqGrid.Name = "EqGrid";
            this.EqGrid.RowHeadersWidth = 82;
            this.EqGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EqGrid.Size = new System.Drawing.Size(1566, 466);
            this.EqGrid.TabIndex = 0;
            this.EqGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.EqGrid_CellBeginEdit);
            this.EqGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.EqGrid_CellEndEdit);
            this.EqGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.EqGrid_DataError);
            this.EqGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.EqGrid_UserDeletingRow);
            // 
            // EquipID
            // 
            this.EquipID.DataPropertyName = "EquipID";
            this.EquipID.HeaderText = "EquipmentID";
            this.EquipID.Name = "EquipID";
            this.EquipID.ReadOnly = true;
            this.EquipID.Width = 263;
            // 
            // Eq_WeaponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1989, 1207);
            this.Controls.Add(this.Gap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Eq_WeaponForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eq_WeaponForm";
            this.Gap.ResumeLayout(false);
            this.Gap.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WeaponGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EqGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Gap;
        private System.Windows.Forms.Label TariffsLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView EqGrid;
        private System.Windows.Forms.DataGridView WeaponGrid;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddWeaponButton;
        private System.Windows.Forms.Button UpdateWeapButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeaponID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipID;
    }
}