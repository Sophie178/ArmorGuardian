namespace Example_Kursach
{
    partial class Authorization
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
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.EnterButton = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Gap.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Gap
            // 
            this.Gap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gap.Controls.Add(this.MinimizeButton);
            this.Gap.Controls.Add(this.CloseButton);
            this.Gap.Controls.Add(this.LoginPanel);
            this.Gap.Controls.Add(this.Picture);
            this.Gap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gap.Location = new System.Drawing.Point(0, 0);
            this.Gap.Name = "Gap";
            this.Gap.Size = new System.Drawing.Size(1091, 951);
            this.Gap.TabIndex = 0;
            this.Gap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gap_MouseDown);
            this.Gap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Gap_MouseMove);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.Font = new System.Drawing.Font("Perpetua Titling MT", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.MinimizeButton.Location = new System.Drawing.Point(975, 9);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(44, 38);
            this.MinimizeButton.TabIndex = 4;
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
            this.LoginPanel.Controls.Add(this.EnterButton);
            this.LoginPanel.Controls.Add(this.PasswordBox);
            this.LoginPanel.Controls.Add(this.LoginTextBox);
            this.LoginPanel.Controls.Add(this.label3);
            this.LoginPanel.Controls.Add(this.label2);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginPanel.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanel.Location = new System.Drawing.Point(0, 530);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1091, 421);
            this.LoginPanel.TabIndex = 2;
            this.LoginPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginPanel_MouseDown);
            this.LoginPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginPanel_MouseMove);
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.Font = new System.Drawing.Font("Perpetua Titling MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.EnterButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EnterButton.Location = new System.Drawing.Point(414, 324);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(275, 53);
            this.EnterButton.TabIndex = 5;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(457, 212);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(454, 39);
            this.PasswordBox.TabIndex = 4;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTextBox.Location = new System.Drawing.Point(457, 115);
            this.LoginTextBox.Multiline = true;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(454, 38);
            this.LoginTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.label3.Location = new System.Drawing.Point(175, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.label2.Location = new System.Drawing.Point(255, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1091, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authorization";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Picture
            // 
            this.Picture.Dock = System.Windows.Forms.DockStyle.Top;
            this.Picture.Image = global::Example_Kursach.Properties.Resources.logo_upd1;
            this.Picture.Location = new System.Drawing.Point(0, 0);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(1091, 487);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Picture.TabIndex = 1;
            this.Picture.TabStop = false;
            this.Picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Picture_MouseDown);
            this.Picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Picture_MouseMove);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 951);
            this.Controls.Add(this.Gap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.Gap.ResumeLayout(false);
            this.Gap.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Gap;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label MinimizeButton;
    }
}