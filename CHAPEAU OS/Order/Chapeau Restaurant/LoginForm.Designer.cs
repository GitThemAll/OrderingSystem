namespace Chapeau_Restaurant
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Password_txtbx = new System.Windows.Forms.TextBox();
            this.Username_txtbx = new System.Windows.Forms.TextBox();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 112);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Login_btn);
            this.panel2.Controls.Add(this.Password_txtbx);
            this.panel2.Controls.Add(this.Username_txtbx);
            this.panel2.Controls.Add(this.Password_lbl);
            this.panel2.Controls.Add(this.Username_lbl);
            this.panel2.Location = new System.Drawing.Point(30, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 144);
            this.panel2.TabIndex = 4;
            // 
            // Login_btn
            // 
            this.Login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.Location = new System.Drawing.Point(16, 76);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(272, 50);
            this.Login_btn.TabIndex = 4;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Password_txtbx
            // 
            this.Password_txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txtbx.Location = new System.Drawing.Point(102, 47);
            this.Password_txtbx.Name = "Password_txtbx";
            this.Password_txtbx.Size = new System.Drawing.Size(186, 26);
            this.Password_txtbx.TabIndex = 3;
            this.Password_txtbx.UseSystemPasswordChar = true;
            // 
            // Username_txtbx
            // 
            this.Username_txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_txtbx.Location = new System.Drawing.Point(102, 15);
            this.Username_txtbx.Name = "Username_txtbx";
            this.Username_txtbx.Size = new System.Drawing.Size(186, 26);
            this.Username_txtbx.TabIndex = 2;
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lbl.Location = new System.Drawing.Point(13, 47);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(78, 20);
            this.Password_lbl.TabIndex = 1;
            this.Password_lbl.Text = "Password";
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lbl.Location = new System.Drawing.Point(13, 15);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(83, 20);
            this.Username_lbl.TabIndex = 0;
            this.Username_lbl.Text = "Username";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(361, 306);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.TextBox Password_txtbx;
        private System.Windows.Forms.TextBox Username_txtbx;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.Label Username_lbl;
    }
}