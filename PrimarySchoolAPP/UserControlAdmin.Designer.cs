
namespace PrimarySchoolAPP
{
    partial class UserControlAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AdminSearTB = new System.Windows.Forms.TextBox();
            this.AdminSearCBO = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.NewAdminBNT = new System.Windows.Forms.Button();
            this.IDAdminTB = new System.Windows.Forms.TextBox();
            this.DeleteAdminBNT = new System.Windows.Forms.Button();
            this.UpdateAdminBNT = new System.Windows.Forms.Button();
            this.NOKconAdminTB = new System.Windows.Forms.TextBox();
            this.SaveAdminBNT = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.AdminPhoto = new System.Windows.Forms.PictureBox();
            this.NOKnameAdminTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.browseAdminBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FnameAdminTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StatcomboAdminBx = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.MiddnameAdminTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LastNameAdminTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DateAppointmentAdminDT = new System.Windows.Forms.DateTimePicker();
            this.EmailAdminTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DOBadminDT = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.GenderComAdminBx = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AdminSearTB);
            this.groupBox1.Controls.Add(this.AdminSearCBO);
            this.groupBox1.Location = new System.Drawing.Point(29, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 45);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // AdminSearTB
            // 
            this.AdminSearTB.Location = new System.Drawing.Point(6, 18);
            this.AdminSearTB.Name = "AdminSearTB";
            this.AdminSearTB.Size = new System.Drawing.Size(223, 20);
            this.AdminSearTB.TabIndex = 67;
            this.AdminSearTB.TextChanged += new System.EventHandler(this.AdminSearTB_TextChanged);
            // 
            // AdminSearCBO
            // 
            this.AdminSearCBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdminSearCBO.FormattingEnabled = true;
            this.AdminSearCBO.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Gender",
            "Status"});
            this.AdminSearCBO.Location = new System.Drawing.Point(235, 17);
            this.AdminSearCBO.Name = "AdminSearCBO";
            this.AdminSearCBO.Size = new System.Drawing.Size(112, 21);
            this.AdminSearCBO.TabIndex = 96;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.dataGridViewAdmin);
            this.panel2.Location = new System.Drawing.Point(25, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 489);
            this.panel2.TabIndex = 100;
            // 
            // dataGridViewAdmin
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridViewAdmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAdmin.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.EnableHeadersVisualStyles = false;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(13, 16);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.Size = new System.Drawing.Size(484, 457);
            this.dataGridViewAdmin.TabIndex = 0;
            this.dataGridViewAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.IDAdminTB);
            this.panel1.Controls.Add(this.NOKconAdminTB);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.AdminPhoto);
            this.panel1.Controls.Add(this.NOKnameAdminTB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.browseAdminBTN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FnameAdminTB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.StatcomboAdminBx);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.MiddnameAdminTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LastNameAdminTB);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.DateAppointmentAdminDT);
            this.panel1.Controls.Add(this.EmailAdminTB);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DOBadminDT);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.GenderComAdminBx);
            this.panel1.Location = new System.Drawing.Point(574, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 455);
            this.panel1.TabIndex = 99;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(14, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 97;
            this.label14.Text = "ID";
            // 
            // NewAdminBNT
            // 
            this.NewAdminBNT.Image = global::PrimarySchoolAPP.Properties.Resources.add_41_32;
            this.NewAdminBNT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewAdminBNT.Location = new System.Drawing.Point(554, 515);
            this.NewAdminBNT.Name = "NewAdminBNT";
            this.NewAdminBNT.Size = new System.Drawing.Size(89, 39);
            this.NewAdminBNT.TabIndex = 95;
            this.NewAdminBNT.Text = "New";
            this.NewAdminBNT.UseVisualStyleBackColor = true;
            this.NewAdminBNT.Click += new System.EventHandler(this.NewAdminBNT_Click);
            // 
            // IDAdminTB
            // 
            this.IDAdminTB.Location = new System.Drawing.Point(40, 136);
            this.IDAdminTB.Name = "IDAdminTB";
            this.IDAdminTB.ReadOnly = true;
            this.IDAdminTB.Size = new System.Drawing.Size(22, 20);
            this.IDAdminTB.TabIndex = 96;
            // 
            // DeleteAdminBNT
            // 
            this.DeleteAdminBNT.Image = global::PrimarySchoolAPP.Properties.Resources.icons8_delete_24;
            this.DeleteAdminBNT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteAdminBNT.Location = new System.Drawing.Point(839, 515);
            this.DeleteAdminBNT.Name = "DeleteAdminBNT";
            this.DeleteAdminBNT.Size = new System.Drawing.Size(89, 39);
            this.DeleteAdminBNT.TabIndex = 80;
            this.DeleteAdminBNT.Text = "   Delete";
            this.DeleteAdminBNT.UseVisualStyleBackColor = true;
            this.DeleteAdminBNT.Click += new System.EventHandler(this.DeleteAdminBNT_Click);
            // 
            // UpdateAdminBNT
            // 
            this.UpdateAdminBNT.Image = global::PrimarySchoolAPP.Properties.Resources.icons8_update_24;
            this.UpdateAdminBNT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateAdminBNT.Location = new System.Drawing.Point(744, 515);
            this.UpdateAdminBNT.Name = "UpdateAdminBNT";
            this.UpdateAdminBNT.Size = new System.Drawing.Size(89, 39);
            this.UpdateAdminBNT.TabIndex = 79;
            this.UpdateAdminBNT.Text = "    Update";
            this.UpdateAdminBNT.UseVisualStyleBackColor = true;
            this.UpdateAdminBNT.Click += new System.EventHandler(this.UpdateAdminBNT_Click);
            // 
            // NOKconAdminTB
            // 
            this.NOKconAdminTB.Location = new System.Drawing.Point(132, 387);
            this.NOKconAdminTB.Name = "NOKconAdminTB";
            this.NOKconAdminTB.Size = new System.Drawing.Size(130, 20);
            this.NOKconAdminTB.TabIndex = 86;
            // 
            // SaveAdminBNT
            // 
            this.SaveAdminBNT.Image = global::PrimarySchoolAPP.Properties.Resources.icons8_save_501;
            this.SaveAdminBNT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveAdminBNT.Location = new System.Drawing.Point(649, 515);
            this.SaveAdminBNT.Name = "SaveAdminBNT";
            this.SaveAdminBNT.Size = new System.Drawing.Size(89, 39);
            this.SaveAdminBNT.TabIndex = 78;
            this.SaveAdminBNT.Text = "Save";
            this.SaveAdminBNT.UseVisualStyleBackColor = true;
            this.SaveAdminBNT.Click += new System.EventHandler(this.SaveAdminBNT_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(10, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 85;
            this.label11.Text = "Next of kin Contact";
            // 
            // AdminPhoto
            // 
            this.AdminPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminPhoto.Image = global::PrimarySchoolAPP.Properties.Resources.unnamed;
            this.AdminPhoto.Location = new System.Drawing.Point(9, 14);
            this.AdminPhoto.Name = "AdminPhoto";
            this.AdminPhoto.Size = new System.Drawing.Size(137, 112);
            this.AdminPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AdminPhoto.TabIndex = 58;
            this.AdminPhoto.TabStop = false;
            // 
            // NOKnameAdminTB
            // 
            this.NOKnameAdminTB.Location = new System.Drawing.Point(117, 413);
            this.NOKnameAdminTB.Name = "NOKnameAdminTB";
            this.NOKnameAdminTB.Size = new System.Drawing.Size(130, 20);
            this.NOKnameAdminTB.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(10, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Next of kin Name";
            // 
            // browseAdminBTN
            // 
            this.browseAdminBTN.Location = new System.Drawing.Point(166, 39);
            this.browseAdminBTN.Name = "browseAdminBTN";
            this.browseAdminBTN.Size = new System.Drawing.Size(75, 28);
            this.browseAdminBTN.TabIndex = 59;
            this.browseAdminBTN.Text = "Browse";
            this.browseAdminBTN.UseVisualStyleBackColor = true;
            this.browseAdminBTN.Click += new System.EventHandler(this.browseAdminBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(13, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "First Name";
            // 
            // FnameAdminTB
            // 
            this.FnameAdminTB.Location = new System.Drawing.Point(82, 165);
            this.FnameAdminTB.Name = "FnameAdminTB";
            this.FnameAdminTB.Size = new System.Drawing.Size(142, 20);
            this.FnameAdminTB.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(13, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Middle Name";
            // 
            // StatcomboAdminBx
            // 
            this.StatcomboAdminBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatcomboAdminBx.FormattingEnabled = true;
            this.StatcomboAdminBx.Location = new System.Drawing.Point(60, 360);
            this.StatcomboAdminBx.Name = "StatcomboAdminBx";
            this.StatcomboAdminBx.Size = new System.Drawing.Size(84, 21);
            this.StatcomboAdminBx.TabIndex = 88;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(11, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 87;
            this.label12.Text = "Status";
            // 
            // MiddnameAdminTB
            // 
            this.MiddnameAdminTB.Location = new System.Drawing.Point(95, 193);
            this.MiddnameAdminTB.Name = "MiddnameAdminTB";
            this.MiddnameAdminTB.Size = new System.Drawing.Size(142, 20);
            this.MiddnameAdminTB.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(13, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Last Name";
            // 
            // LastNameAdminTB
            // 
            this.LastNameAdminTB.Location = new System.Drawing.Point(82, 219);
            this.LastNameAdminTB.Name = "LastNameAdminTB";
            this.LastNameAdminTB.Size = new System.Drawing.Size(142, 20);
            this.LastNameAdminTB.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(14, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 82;
            this.label8.Text = "Date of birth";
            // 
            // DateAppointmentAdminDT
            // 
            this.DateAppointmentAdminDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateAppointmentAdminDT.Location = new System.Drawing.Point(144, 301);
            this.DateAppointmentAdminDT.Name = "DateAppointmentAdminDT";
            this.DateAppointmentAdminDT.Size = new System.Drawing.Size(103, 20);
            this.DateAppointmentAdminDT.TabIndex = 83;
            // 
            // EmailAdminTB
            // 
            this.EmailAdminTB.Location = new System.Drawing.Point(104, 334);
            this.EmailAdminTB.Name = "EmailAdminTB";
            this.EmailAdminTB.Size = new System.Drawing.Size(197, 20);
            this.EmailAdminTB.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(15, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 84;
            this.label10.Text = "Date of Appointment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(12, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Email Address";
            // 
            // DOBadminDT
            // 
            this.DOBadminDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBadminDT.Location = new System.Drawing.Point(95, 245);
            this.DOBadminDT.Name = "DOBadminDT";
            this.DOBadminDT.Size = new System.Drawing.Size(96, 20);
            this.DOBadminDT.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(15, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Gender";
            // 
            // GenderComAdminBx
            // 
            this.GenderComAdminBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComAdminBx.FormattingEnabled = true;
            this.GenderComAdminBx.Location = new System.Drawing.Point(69, 271);
            this.GenderComAdminBx.Name = "GenderComAdminBx";
            this.GenderComAdminBx.Size = new System.Drawing.Size(84, 21);
            this.GenderComAdminBx.TabIndex = 68;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PrimarySchoolAPP.Properties.Resources.wallpaper;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(554, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 496);
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserControlAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NewAdminBNT);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeleteAdminBNT);
            this.Controls.Add(this.UpdateAdminBNT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SaveAdminBNT);
            this.Name = "UserControlAdmin";
            this.Size = new System.Drawing.Size(980, 598);
            this.Load += new System.EventHandler(this.UserControlAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AdminSearTB;
        private System.Windows.Forms.ComboBox AdminSearCBO;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button NewAdminBNT;
        private System.Windows.Forms.TextBox IDAdminTB;
        private System.Windows.Forms.Button DeleteAdminBNT;
        private System.Windows.Forms.Button UpdateAdminBNT;
        private System.Windows.Forms.TextBox NOKconAdminTB;
        private System.Windows.Forms.Button SaveAdminBNT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox AdminPhoto;
        private System.Windows.Forms.TextBox NOKnameAdminTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button browseAdminBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FnameAdminTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StatcomboAdminBx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox MiddnameAdminTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LastNameAdminTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DateAppointmentAdminDT;
        private System.Windows.Forms.TextBox EmailAdminTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DOBadminDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox GenderComAdminBx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
