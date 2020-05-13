namespace Hotel_Management_System
{
    partial class ManageClientsForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxphonenumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonEditClient = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.dataGridView1Client = new System.Windows.Forms.DataGridView();
            this.buttonRefraish = new System.Windows.Forms.Button();
            this.buttonClearField = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Client)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dataGridView1Client);
            this.panel1.Controls.Add(this.buttonRefraish);
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Controls.Add(this.buttonEditClient);
            this.panel1.Controls.Add(this.buttonClearField);
            this.panel1.Controls.Add(this.buttonAddClient);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxphonenumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxLastname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxFirstname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 65);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(873, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Clients";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(155, 91);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(202, 20);
            this.textBoxID.TabIndex = 2;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Firstname:";
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Location = new System.Drawing.Point(155, 129);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(202, 20);
            this.textBoxFirstname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(63, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lastname:";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(155, 167);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(202, 20);
            this.textBoxLastname.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phone Number:";
            // 
            // textBoxphonenumber
            // 
            this.textBoxphonenumber.Location = new System.Drawing.Point(155, 207);
            this.textBoxphonenumber.Name = "textBoxphonenumber";
            this.textBoxphonenumber.Size = new System.Drawing.Size(202, 20);
            this.textBoxphonenumber.TabIndex = 2;
            this.textBoxphonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxphonenumber_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(84, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(155, 249);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(202, 20);
            this.textBoxEmail.TabIndex = 2;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAddClient.Location = new System.Drawing.Point(42, 323);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(97, 23);
            this.buttonAddClient.TabIndex = 3;
            this.buttonAddClient.Text = "Add New Client";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonEditClient.Location = new System.Drawing.Point(155, 323);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(97, 23);
            this.buttonEditClient.TabIndex = 3;
            this.buttonEditClient.Text = "Edit";
            this.buttonEditClient.UseVisualStyleBackColor = true;
            this.buttonEditClient.Click += new System.EventHandler(this.buttonEditClient_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonRemove.Location = new System.Drawing.Point(260, 323);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(97, 23);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // dataGridView1Client
            // 
            this.dataGridView1Client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Client.Location = new System.Drawing.Point(363, 91);
            this.dataGridView1Client.Name = "dataGridView1Client";
            this.dataGridView1Client.Size = new System.Drawing.Size(507, 254);
            this.dataGridView1Client.TabIndex = 4;
            this.dataGridView1Client.Click += new System.EventHandler(this.dataGridView1Client_Click);
            // 
            // buttonRefraish
            // 
            this.buttonRefraish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRefraish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonRefraish.Location = new System.Drawing.Point(363, 361);
            this.buttonRefraish.Name = "buttonRefraish";
            this.buttonRefraish.Size = new System.Drawing.Size(507, 39);
            this.buttonRefraish.TabIndex = 3;
            this.buttonRefraish.Text = "Refraish";
            this.buttonRefraish.UseVisualStyleBackColor = true;
            this.buttonRefraish.Click += new System.EventHandler(this.buttonRefraish_Click);
            // 
            // buttonClearField
            // 
            this.buttonClearField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClearField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonClearField.Location = new System.Drawing.Point(42, 361);
            this.buttonClearField.Name = "buttonClearField";
            this.buttonClearField.Size = new System.Drawing.Size(315, 39);
            this.buttonClearField.TabIndex = 3;
            this.buttonClearField.Text = "Clear Fields";
            this.buttonClearField.UseVisualStyleBackColor = true;
            this.buttonClearField.Click += new System.EventHandler(this.buttonClearField_Click);
            // 
            // ManageClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ManageClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageClientsForm";
            this.Load += new System.EventHandler(this.ManageClientsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Client)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEditClient;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxphonenumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1Client;
        private System.Windows.Forms.Button buttonRefraish;
        private System.Windows.Forms.Button buttonClearField;
    }
}