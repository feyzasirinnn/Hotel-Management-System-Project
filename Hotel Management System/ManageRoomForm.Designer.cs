namespace Hotel_Management_System
{
    partial class ManageRoomForm
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
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.buttonRefraish = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEditRoom = new System.Windows.Forms.Button();
            this.buttonClearField = new System.Windows.Forms.Button();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxtype = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBoxtype);
            this.panel1.Controls.Add(this.dataGridViewRoom);
            this.panel1.Controls.Add(this.buttonRefraish);
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Controls.Add(this.buttonEditRoom);
            this.panel1.Controls.Add(this.buttonClearField);
            this.panel1.Controls.Add(this.buttonAddRoom);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxPhone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 413);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Location = new System.Drawing.Point(363, 91);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.Size = new System.Drawing.Size(415, 254);
            this.dataGridViewRoom.TabIndex = 4;
            this.dataGridViewRoom.Click += new System.EventHandler(this.dataGridViewRoom_Click);
            // 
            // buttonRefraish
            // 
            this.buttonRefraish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRefraish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonRefraish.Location = new System.Drawing.Point(363, 361);
            this.buttonRefraish.Name = "buttonRefraish";
            this.buttonRefraish.Size = new System.Drawing.Size(415, 39);
            this.buttonRefraish.TabIndex = 3;
            this.buttonRefraish.Text = "Refraish";
            this.buttonRefraish.UseVisualStyleBackColor = true;
            this.buttonRefraish.Click += new System.EventHandler(this.buttonRefraish_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonRemove.Location = new System.Drawing.Point(260, 313);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(97, 33);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEditRoom
            // 
            this.buttonEditRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonEditRoom.Location = new System.Drawing.Point(155, 313);
            this.buttonEditRoom.Name = "buttonEditRoom";
            this.buttonEditRoom.Size = new System.Drawing.Size(97, 33);
            this.buttonEditRoom.TabIndex = 3;
            this.buttonEditRoom.Text = "Edit";
            this.buttonEditRoom.UseVisualStyleBackColor = true;
            this.buttonEditRoom.Click += new System.EventHandler(this.buttonEditRoom_Click);
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
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAddRoom.Location = new System.Drawing.Point(42, 313);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(97, 33);
            this.buttonAddRoom.TabIndex = 3;
            this.buttonAddRoom.Text = "Add New Room";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Reserved:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(126, 167);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(231, 22);
            this.textBoxPhone.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Type:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(126, 91);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(231, 22);
            this.textBoxID.TabIndex = 2;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 65);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Rooms";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxtype
            // 
            this.comboBoxtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxtype.FormattingEnabled = true;
            this.comboBoxtype.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxtype.Location = new System.Drawing.Point(126, 127);
            this.comboBoxtype.Name = "comboBoxtype";
            this.comboBoxtype.Size = new System.Drawing.Size(121, 24);
            this.comboBoxtype.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(257, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Show Type";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNo);
            this.groupBox1.Controls.Add(this.radioButtonYes);
            this.groupBox1.Location = new System.Drawing.Point(126, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 37);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Checked = true;
            this.radioButtonYes.ForeColor = System.Drawing.Color.White;
            this.radioButtonYes.Location = new System.Drawing.Point(6, 14);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(53, 20);
            this.radioButtonYes.TabIndex = 0;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.ForeColor = System.Drawing.Color.White;
            this.radioButtonNo.Location = new System.Drawing.Point(76, 14);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(46, 20);
            this.radioButtonNo.TabIndex = 0;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // ManageRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 413);
            this.Controls.Add(this.panel1);
            this.Name = "ManageRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageRoomForm";
            this.Load += new System.EventHandler(this.ManageRoomForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.Button buttonRefraish;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEditRoom;
        private System.Windows.Forms.Button buttonClearField;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxtype;
    }
}