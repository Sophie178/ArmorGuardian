﻿namespace Example_Kursach
{
    partial class Stock_All
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
            this.AddTransportB = new System.Windows.Forms.Button();
            this.AddWButton = new System.Windows.Forms.Button();
            this.AddEButton = new System.Windows.Forms.Button();
            this.TranGrid = new System.Windows.Forms.DataGridView();
            this.ModelT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufactureYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockID3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeaponGrid = new System.Windows.Forms.DataGridView();
            this.ModelW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeaponID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackButton = new System.Windows.Forms.Button();
            this.EqGrid = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Gap.Size = new System.Drawing.Size(1970, 1459);
            this.Gap.TabIndex = 10;
            // 
            // TariffsLabel
            // 
            this.TariffsLabel.AutoSize = true;
            this.TariffsLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TariffsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.TariffsLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TariffsLabel.Location = new System.Drawing.Point(1381, 25);
            this.TariffsLabel.Name = "TariffsLabel";
            this.TariffsLabel.Size = new System.Drawing.Size(247, 34);
            this.TariffsLabel.TabIndex = 9;
            this.TariffsLabel.Text = "stock supply";
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
            this.LoginPanel.Controls.Add(this.AddTransportB);
            this.LoginPanel.Controls.Add(this.AddWButton);
            this.LoginPanel.Controls.Add(this.AddEButton);
            this.LoginPanel.Controls.Add(this.TranGrid);
            this.LoginPanel.Controls.Add(this.WeaponGrid);
            this.LoginPanel.Controls.Add(this.BackButton);
            this.LoginPanel.Controls.Add(this.EqGrid);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginPanel.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanel.Location = new System.Drawing.Point(0, 75);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1970, 1384);
            this.LoginPanel.TabIndex = 2;
            // 
            // AddTransportB
            // 
            this.AddTransportB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddTransportB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTransportB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.AddTransportB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTransportB.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTransportB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.AddTransportB.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddTransportB.Location = new System.Drawing.Point(1592, 1025);
            this.AddTransportB.Name = "AddTransportB";
            this.AddTransportB.Size = new System.Drawing.Size(305, 101);
            this.AddTransportB.TabIndex = 16;
            this.AddTransportB.Text = "Add new transport";
            this.AddTransportB.UseVisualStyleBackColor = false;
            this.AddTransportB.Click += new System.EventHandler(this.AddTransportB_Click);
            this.AddTransportB.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.AddTransportB.MouseLeave += new System.EventHandler(this.AddTransport_MouseLeave);
            // 
            // AddWButton
            // 
            this.AddWButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddWButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddWButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.AddWButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddWButton.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.AddWButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddWButton.Location = new System.Drawing.Point(1592, 589);
            this.AddWButton.Name = "AddWButton";
            this.AddWButton.Size = new System.Drawing.Size(305, 101);
            this.AddWButton.TabIndex = 15;
            this.AddWButton.Text = "Add new weapon";
            this.AddWButton.UseVisualStyleBackColor = false;
            this.AddWButton.Click += new System.EventHandler(this.AddWButton_Click);
            this.AddWButton.MouseEnter += new System.EventHandler(this.AddWButton_MouseEnter);
            this.AddWButton.MouseLeave += new System.EventHandler(this.AddWButton_MouseLeave);
            // 
            // AddEButton
            // 
            this.AddEButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddEButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.AddEButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEButton.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.AddEButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddEButton.Location = new System.Drawing.Point(1592, 151);
            this.AddEButton.Name = "AddEButton";
            this.AddEButton.Size = new System.Drawing.Size(305, 101);
            this.AddEButton.TabIndex = 14;
            this.AddEButton.Text = "Add new equipment";
            this.AddEButton.UseVisualStyleBackColor = false;
            this.AddEButton.Click += new System.EventHandler(this.AddEButton_Click);
            this.AddEButton.MouseEnter += new System.EventHandler(this.AddEButton_MouseEnter);
            this.AddEButton.MouseLeave += new System.EventHandler(this.AddEButton_MouseLeave);
            // 
            // TranGrid
            // 
            this.TranGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TranGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TranGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TranGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModelT,
            this.ManufactureYear,
            this.StockID3,
            this.TransportID});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TranGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.TranGrid.Location = new System.Drawing.Point(12, 884);
            this.TranGrid.Name = "TranGrid";
            this.TranGrid.RowHeadersWidth = 82;
            this.TranGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TranGrid.Size = new System.Drawing.Size(1511, 369);
            this.TranGrid.TabIndex = 10;
            this.TranGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.TranGrid_DataError);
            this.TranGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.TranGrid_UserDeletingRow);
            // 
            // ModelT
            // 
            this.ModelT.DataPropertyName = "Model";
            this.ModelT.HeaderText = "Model";
            this.ModelT.Name = "ModelT";
            this.ModelT.ReadOnly = true;
            // 
            // ManufactureYear
            // 
            this.ManufactureYear.DataPropertyName = "ManufactureYear";
            this.ManufactureYear.HeaderText = "ManufactureYear";
            this.ManufactureYear.Name = "ManufactureYear";
            this.ManufactureYear.ReadOnly = true;
            // 
            // StockID3
            // 
            this.StockID3.DataPropertyName = "StockID";
            this.StockID3.HeaderText = "StockID";
            this.StockID3.Name = "StockID3";
            // 
            // TransportID
            // 
            this.TransportID.DataPropertyName = "TransportID";
            this.TransportID.HeaderText = "TransportID";
            this.TransportID.Name = "TransportID";
            // 
            // WeaponGrid
            // 
            this.WeaponGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WeaponGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.WeaponGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeaponGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModelW,
            this.Description,
            this.StockID2,
            this.WeaponID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WeaponGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.WeaponGrid.Location = new System.Drawing.Point(12, 448);
            this.WeaponGrid.Name = "WeaponGrid";
            this.WeaponGrid.RowHeadersWidth = 82;
            this.WeaponGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WeaponGrid.Size = new System.Drawing.Size(1511, 369);
            this.WeaponGrid.TabIndex = 9;
            this.WeaponGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.WeaponGrid_DataError);
            this.WeaponGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.WeaponGrid_UserDeletingRow);
            // 
            // ModelW
            // 
            this.ModelW.DataPropertyName = "Model";
            this.ModelW.HeaderText = "Model";
            this.ModelW.Name = "ModelW";
            this.ModelW.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // StockID2
            // 
            this.StockID2.DataPropertyName = "StockID";
            this.StockID2.HeaderText = "StockID";
            this.StockID2.Name = "StockID2";
            // 
            // WeaponID
            // 
            this.WeaponID.DataPropertyName = "WeaponID";
            this.WeaponID.HeaderText = "WeaponID";
            this.WeaponID.Name = "WeaponID";
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
            // EqGrid
            // 
            this.EqGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EqGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EqGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EqGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.Model,
            this.StockID,
            this.EquipID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EqGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.EqGrid.Location = new System.Drawing.Point(12, 22);
            this.EqGrid.Name = "EqGrid";
            this.EqGrid.RowHeadersWidth = 82;
            this.EqGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EqGrid.Size = new System.Drawing.Size(1511, 369);
            this.EqGrid.TabIndex = 0;
            this.EqGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.EqGrid_DataError);
            this.EqGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.EqGrid_UserDeletingRow);
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // StockID
            // 
            this.StockID.DataPropertyName = "StockID";
            this.StockID.HeaderText = "StockID";
            this.StockID.Name = "StockID";
            // 
            // EquipID
            // 
            this.EquipID.DataPropertyName = "EquipID";
            this.EquipID.HeaderText = "EquipmentID";
            this.EquipID.Name = "EquipID";
            // 
            // Stock_All
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1970, 1459);
            this.Controls.Add(this.Gap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock_All";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock_All";
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
        private System.Windows.Forms.DataGridView TranGrid;
        private System.Windows.Forms.DataGridView WeaponGrid;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView EqGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufactureYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelW;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeaponID;
        private System.Windows.Forms.Button AddTransportB;
        private System.Windows.Forms.Button AddWButton;
        private System.Windows.Forms.Button AddEButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipID;
    }
}