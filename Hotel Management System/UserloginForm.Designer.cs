namespace Hotel_Management_System
{
    partial class UserloginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelGotoCreate = new System.Windows.Forms.Label();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelpassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelusername = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BackgroundImage = global::Hotel_Management_System.Properties.Resources.unnamed;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.labelGotoCreate);
            this.panel1.Controls.Add(this.buttonlogin);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.labelpassword);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.labelusername);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 357);
            this.panel1.TabIndex = 0;
            // 
            // labelGotoCreate
            // 
            this.labelGotoCreate.AutoSize = true;
            this.labelGotoCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGotoCreate.ForeColor = System.Drawing.Color.White;
            this.labelGotoCreate.Location = new System.Drawing.Point(143, 328);
            this.labelGotoCreate.Name = "labelGotoCreate";
            this.labelGotoCreate.Size = new System.Drawing.Size(326, 15);
            this.labelGotoCreate.TabIndex = 9;
            this.labelGotoCreate.Text = "I Don\'t Have An Account? Press Here To Create An Account";
            this.labelGotoCreate.Click += new System.EventHandler(this.labelGotoCreate_Click);
            this.labelGotoCreate.MouseEnter += new System.EventHandler(this.labelGotoCreate_MouseEnter);
            this.labelGotoCreate.MouseLeave += new System.EventHandler(this.labelGotoCreate_MouseLeave);
            // 
            // buttonlogin
            // 
            this.buttonlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonlogin.Location = new System.Drawing.Point(275, 277);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(194, 37);
            this.buttonlogin.TabIndex = 8;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPassword.Location = new System.Drawing.Point(179, 220);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(291, 38);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.ForeColor = System.Drawing.Color.White;
            this.labelpassword.Location = new System.Drawing.Point(43, 231);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(119, 24);
            this.labelpassword.TabIndex = 4;
            this.labelpassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUsername.Location = new System.Drawing.Point(179, 167);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(291, 38);
            this.textBoxUsername.TabIndex = 7;
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.ForeColor = System.Drawing.Color.White;
            this.labelusername.Location = new System.Drawing.Point(43, 181);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(128, 24);
            this.labelusername.TabIndex = 5;
            this.labelusername.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO NOOM HOTEL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserloginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 357);
            this.Controls.Add(this.panel1);
            this.Name = "UserloginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserloginForm";
            this.Load += new System.EventHandler(this.UserloginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelGotoCreate;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label label1;
    }
}