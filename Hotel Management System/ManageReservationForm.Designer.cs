namespace Hotel_Management_System
{
    partial class ManageReservationForm
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
            this.dateTimePickerDateOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateIn = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewReservation = new System.Windows.Forms.DataGridView();
            this.buttonRefraish = new System.Windows.Forms.Button();
            this.buttonRemoveReservation = new System.Windows.Forms.Button();
            this.buttonEditRerservation = new System.Windows.Forms.Button();
            this.buttonClearField = new System.Windows.Forms.Button();
            this.buttonAddReservation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIDReservation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRoomID = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxClietId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.textBoxClietId);
            this.panel1.Controls.Add(this.textBoxType);
            this.panel1.Controls.Add(this.textBoxRoomID);
            this.panel1.Controls.Add(this.dateTimePickerDateOut);
            this.panel1.Controls.Add(this.dateTimePickerDateIn);
            this.panel1.Controls.Add(this.dataGridViewReservation);
            this.panel1.Controls.Add(this.buttonRefraish);
            this.panel1.Controls.Add(this.buttonRemoveReservation);
            this.panel1.Controls.Add(this.buttonEditRerservation);
            this.panel1.Controls.Add(this.buttonClearField);
            this.panel1.Controls.Add(this.buttonAddReservation);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxIDReservation);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 450);
            this.panel1.TabIndex = 2;
            // 
            // dateTimePickerDateOut
            // 
            this.dateTimePickerDateOut.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerDateOut.Location = new System.Drawing.Point(126, 223);
            this.dateTimePickerDateOut.Name = "dateTimePickerDateOut";
            this.dateTimePickerDateOut.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDateOut.TabIndex = 6;
            // 
            // dateTimePickerDateIn
            // 
            this.dateTimePickerDateIn.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerDateIn.Location = new System.Drawing.Point(127, 195);
            this.dateTimePickerDateIn.Name = "dateTimePickerDateIn";
            this.dateTimePickerDateIn.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDateIn.TabIndex = 6;
            // 
            // dataGridViewReservation
            // 
            this.dataGridViewReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservation.Location = new System.Drawing.Point(340, 73);
            this.dataGridViewReservation.Name = "dataGridViewReservation";
            this.dataGridViewReservation.Size = new System.Drawing.Size(582, 272);
            this.dataGridViewReservation.TabIndex = 4;
            this.dataGridViewReservation.Click += new System.EventHandler(this.dataGridViewReservation_Click);
            // 
            // buttonRefraish
            // 
            this.buttonRefraish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRefraish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonRefraish.Location = new System.Drawing.Point(363, 361);
            this.buttonRefraish.Name = "buttonRefraish";
            this.buttonRefraish.Size = new System.Drawing.Size(559, 39);
            this.buttonRefraish.TabIndex = 3;
            this.buttonRefraish.Text = "Refraish";
            this.buttonRefraish.UseVisualStyleBackColor = true;
            this.buttonRefraish.Click += new System.EventHandler(this.buttonRefraish_Click);
            // 
            // buttonRemoveReservation
            // 
            this.buttonRemoveReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonRemoveReservation.Location = new System.Drawing.Point(237, 313);
            this.buttonRemoveReservation.Name = "buttonRemoveReservation";
            this.buttonRemoveReservation.Size = new System.Drawing.Size(97, 33);
            this.buttonRemoveReservation.TabIndex = 3;
            this.buttonRemoveReservation.Text = "Remove";
            this.buttonRemoveReservation.UseVisualStyleBackColor = true;
            this.buttonRemoveReservation.Click += new System.EventHandler(this.buttonRemoveReservation_Click);
            // 
            // buttonEditRerservation
            // 
            this.buttonEditRerservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonEditRerservation.Location = new System.Drawing.Point(132, 313);
            this.buttonEditRerservation.Name = "buttonEditRerservation";
            this.buttonEditRerservation.Size = new System.Drawing.Size(97, 33);
            this.buttonEditRerservation.TabIndex = 3;
            this.buttonEditRerservation.Text = "Edit";
            this.buttonEditRerservation.UseVisualStyleBackColor = true;
            this.buttonEditRerservation.Click += new System.EventHandler(this.buttonEditRerservation_Click);
            // 
            // buttonClearField
            // 
            this.buttonClearField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClearField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonClearField.Location = new System.Drawing.Point(19, 361);
            this.buttonClearField.Name = "buttonClearField";
            this.buttonClearField.Size = new System.Drawing.Size(315, 39);
            this.buttonClearField.TabIndex = 3;
            this.buttonClearField.Text = "Clear Fields";
            this.buttonClearField.UseVisualStyleBackColor = true;
            this.buttonClearField.Click += new System.EventHandler(this.buttonClearField_Click);
            // 
            // buttonAddReservation
            // 
            this.buttonAddReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAddReservation.Location = new System.Drawing.Point(19, 313);
            this.buttonAddReservation.Name = "buttonAddReservation";
            this.buttonAddReservation.Size = new System.Drawing.Size(97, 33);
            this.buttonAddReservation.TabIndex = 3;
            this.buttonAddReservation.Text = "Add New Room";
            this.buttonAddReservation.UseVisualStyleBackColor = true;
            this.buttonAddReservation.Click += new System.EventHandler(this.buttonAddReservation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date Out:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Room İd:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date In:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cient id:";
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
            // textBoxIDReservation
            // 
            this.textBoxIDReservation.Location = new System.Drawing.Point(126, 70);
            this.textBoxIDReservation.Name = "textBoxIDReservation";
            this.textBoxIDReservation.Size = new System.Drawing.Size(201, 22);
            this.textBoxIDReservation.TabIndex = 2;
            this.textBoxIDReservation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIDReservation_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 73);
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
            this.panel2.Size = new System.Drawing.Size(933, 65);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(933, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Reservations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRoomID
            // 
            this.textBoxRoomID.Location = new System.Drawing.Point(126, 164);
            this.textBoxRoomID.Name = "textBoxRoomID";
            this.textBoxRoomID.Size = new System.Drawing.Size(201, 22);
            this.textBoxRoomID.TabIndex = 7;
            this.textBoxRoomID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRoomID_KeyPress);
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(126, 136);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(201, 22);
            this.textBoxType.TabIndex = 8;
            this.textBoxType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxType_KeyPress);
            // 
            // textBoxClietId
            // 
            this.textBoxClietId.Location = new System.Drawing.Point(126, 102);
            this.textBoxClietId.Name = "textBoxClietId";
            this.textBoxClietId.Size = new System.Drawing.Size(201, 22);
            this.textBoxClietId.TabIndex = 8;
            this.textBoxClietId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxClietId_KeyPress);
            // 
            // ManageReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ManageReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageReservationForm";
            this.Load += new System.EventHandler(this.ManageReservationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewReservation;
        private System.Windows.Forms.Button buttonRefraish;
        private System.Windows.Forms.Button buttonRemoveReservation;
        private System.Windows.Forms.Button buttonEditRerservation;
        private System.Windows.Forms.Button buttonClearField;
        private System.Windows.Forms.Button buttonAddReservation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIDReservation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRoomID;
        private System.Windows.Forms.TextBox textBoxClietId;
        private System.Windows.Forms.TextBox textBoxType;
    }
}