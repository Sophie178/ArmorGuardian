namespace Example_Kursach
{
    partial class OfficesStocksForm
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
            this.UpOButton = new System.Windows.Forms.Button();
            this.addOButton = new System.Windows.Forms.Button();
            this.StockGrid = new System.Windows.Forms.DataGridView();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.MainPageButton = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.OfficeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gap.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Gap
            // 
            this.Gap.AllowDrop = true;
            this.Gap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gap.Controls.Add(this.TariffsLabel);
            this.Gap.Controls.Add(this.NameLabel);
            this.Gap.Controls.Add(this.LoginPanel);
            this.Gap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gap.Location = new System.Drawing.Point(0, 0);
            this.Gap.Name = "Gap";
            this.Gap.Size = new System.Drawing.Size(1679, 757);
            this.Gap.TabIndex = 9;
            // 
            // TariffsLabel
            // 
            this.TariffsLabel.AutoSize = true;
            this.TariffsLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TariffsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.TariffsLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TariffsLabel.Location = new System.Drawing.Point(1052, 14);
            this.TariffsLabel.Name = "TariffsLabel";
            this.TariffsLabel.Size = new System.Drawing.Size(282, 34);
            this.TariffsLabel.TabIndex = 9;
            this.TariffsLabel.Text = "Offices & Stocks";
            this.TariffsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TariffsLabel.UseMnemonic = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.NameLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NameLabel.Location = new System.Drawing.Point(269, 14);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(284, 34);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "armorguardian";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.UpOButton);
            this.LoginPanel.Controls.Add(this.addOButton);
            this.LoginPanel.Controls.Add(this.StockGrid);
            this.LoginPanel.Controls.Add(this.DeleteButton);
            this.LoginPanel.Controls.Add(this.AddButton);
            this.LoginPanel.Controls.Add(this.UpdateButton);
            this.LoginPanel.Controls.Add(this.MainPageButton);
            this.LoginPanel.Controls.Add(this.Grid);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginPanel.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanel.Location = new System.Drawing.Point(0, 57);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1679, 700);
            this.LoginPanel.TabIndex = 2;
            // 
            // UpOButton
            // 
            this.UpOButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpOButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpOButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.UpOButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpOButton.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpOButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.UpOButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UpOButton.Location = new System.Drawing.Point(1358, 158);
            this.UpOButton.Name = "UpOButton";
            this.UpOButton.Size = new System.Drawing.Size(276, 79);
            this.UpOButton.TabIndex = 20;
            this.UpOButton.Text = "update office record";
            this.UpOButton.UseVisualStyleBackColor = false;
            this.UpOButton.Click += new System.EventHandler(this.UpOButton_Click);
            this.UpOButton.MouseEnter += new System.EventHandler(this.UpOButton_MouseEnter);
            this.UpOButton.MouseLeave += new System.EventHandler(this.UpOButton_MouseLeave);
            // 
            // addOButton
            // 
            this.addOButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addOButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.addOButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addOButton.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.addOButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addOButton.Location = new System.Drawing.Point(1358, 43);
            this.addOButton.Name = "addOButton";
            this.addOButton.Size = new System.Drawing.Size(276, 82);
            this.addOButton.TabIndex = 19;
            this.addOButton.Text = "Add office record";
            this.addOButton.UseVisualStyleBackColor = false;
            this.addOButton.Click += new System.EventHandler(this.addOButton_Click);
            this.addOButton.MouseEnter += new System.EventHandler(this.addOButton_MouseEnter);
            this.addOButton.MouseLeave += new System.EventHandler(this.addOButton_MouseLeave);
            // 
            // StockGrid
            // 
            this.StockGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StockGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.StockGrid.Location = new System.Drawing.Point(73, 346);
            this.StockGrid.Name = "StockGrid";
            this.StockGrid.RowHeadersWidth = 82;
            this.StockGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StockGrid.Size = new System.Drawing.Size(1250, 194);
            this.StockGrid.TabIndex = 18;
            this.StockGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.StockGrid_DataError);
            this.StockGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.StockGrid_UserDeletingRow);
            // 
            // StockID
            // 
            this.StockID.DataPropertyName = "StockID";
            this.StockID.HeaderText = "StockID";
            this.StockID.Name = "StockID";
            this.StockID.ReadOnly = true;
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
            this.DeleteButton.Location = new System.Drawing.Point(75, 609);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(642, 53);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "Choose row to delete and press \"del\"";
            this.DeleteButton.UseVisualStyleBackColor = false;
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
            this.AddButton.Location = new System.Drawing.Point(1358, 346);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(276, 77);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Add stock record";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseEnter += new System.EventHandler(this.AddButton_MouseEnter);
            this.AddButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
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
            this.UpdateButton.Location = new System.Drawing.Point(1358, 454);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(276, 86);
            this.UpdateButton.TabIndex = 15;
            this.UpdateButton.Text = "update stock record";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            this.UpdateButton.MouseEnter += new System.EventHandler(this.UpdateButton_MouseEnter);
            this.UpdateButton.MouseLeave += new System.EventHandler(this.UpdateButton_MouseLeave);
            // 
            // MainPageButton
            // 
            this.MainPageButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainPageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.MainPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainPageButton.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.MainPageButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MainPageButton.Location = new System.Drawing.Point(1058, 609);
            this.MainPageButton.Name = "MainPageButton";
            this.MainPageButton.Size = new System.Drawing.Size(265, 53);
            this.MainPageButton.TabIndex = 8;
            this.MainPageButton.Text = "Main page";
            this.MainPageButton.UseVisualStyleBackColor = false;
            this.MainPageButton.Click += new System.EventHandler(this.MainPageButton_Click);
            this.MainPageButton.MouseEnter += new System.EventHandler(this.MainPageButton_MouseEnter);
            this.MainPageButton.MouseLeave += new System.EventHandler(this.MainPageButton_MouseLeave);
            // 
            // Grid
            // 
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OfficeID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.Location = new System.Drawing.Point(75, 43);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 82;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(1250, 194);
            this.Grid.TabIndex = 0;
            this.Grid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Grid_CellBeginEdit);
            this.Grid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellEndEdit);
            this.Grid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Grid_DataError);
            this.Grid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Grid_UserDeletingRow);
            // 
            // OfficeID
            // 
            this.OfficeID.DataPropertyName = "OfficeID";
            this.OfficeID.HeaderText = "OfficeID";
            this.OfficeID.Name = "OfficeID";
            this.OfficeID.ReadOnly = true;
            // 
            // OfficesStocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1679, 757);
            this.Controls.Add(this.Gap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OfficesStocksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OfficesStocksForm";
            this.Gap.ResumeLayout(false);
            this.Gap.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StockGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Gap;
        private System.Windows.Forms.Label TariffsLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button MainPageButton;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpOButton;
        private System.Windows.Forms.Button addOButton;
        private System.Windows.Forms.DataGridView StockGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfficeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
    }
}