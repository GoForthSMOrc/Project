namespace ExampleSQLApp
{
    partial class LoginForm1
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
            this.GreyPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PassField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BluePanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GreyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BluePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GreyPanel
            // 
            this.GreyPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GreyPanel.Controls.Add(this.button1);
            this.GreyPanel.Controls.Add(this.PassField);
            this.GreyPanel.Controls.Add(this.pictureBox2);
            this.GreyPanel.Controls.Add(this.LoginField);
            this.GreyPanel.Controls.Add(this.pictureBox1);
            this.GreyPanel.Controls.Add(this.BluePanel);
            this.GreyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GreyPanel.Location = new System.Drawing.Point(0, 0);
            this.GreyPanel.Name = "GreyPanel";
            this.GreyPanel.Size = new System.Drawing.Size(341, 474);
            this.GreyPanel.TabIndex = 0;
            this.GreyPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GreyPanel_MouseDown);
            this.GreyPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GreyPanel_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(85, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 93);
            this.button1.TabIndex = 5;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(134, 273);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(150, 44);
            this.PassField.TabIndex = 4;
            this.PassField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ExampleSQLApp.Properties.Resources.Pass;
            this.pictureBox2.Location = new System.Drawing.Point(56, 273);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(134, 176);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(150, 50);
            this.LoginField.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExampleSQLApp.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(56, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // BluePanel
            // 
            this.BluePanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.BluePanel.Controls.Add(this.CloseButton);
            this.BluePanel.Controls.Add(this.label1);
            this.BluePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BluePanel.Location = new System.Drawing.Point(0, 0);
            this.BluePanel.Name = "BluePanel";
            this.BluePanel.Size = new System.Drawing.Size(341, 100);
            this.BluePanel.TabIndex = 0;
            this.BluePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.BluePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BluePanel_MouseDown);
            this.BluePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BluePanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Location = new System.Drawing.Point(315, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(14, 13);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // LoginForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 474);
            this.Controls.Add(this.GreyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm1";
            this.Text = "LoginForm1";
            this.GreyPanel.ResumeLayout(false);
            this.GreyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BluePanel.ResumeLayout(false);
            this.BluePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GreyPanel;
        private System.Windows.Forms.Panel BluePanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Button button1;
    }
}