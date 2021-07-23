
namespace PrimarySchoolAPP
{
    partial class userConStudent1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StudentSearTB = new System.Windows.Forms.TextBox();
            this.StudentSearCOBO = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.editBNT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StudentSearTB);
            this.groupBox1.Controls.Add(this.StudentSearCOBO);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 45);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // StudentSearTB
            // 
            this.StudentSearTB.Location = new System.Drawing.Point(6, 18);
            this.StudentSearTB.Name = "StudentSearTB";
            this.StudentSearTB.Size = new System.Drawing.Size(223, 20);
            this.StudentSearTB.TabIndex = 67;
            this.StudentSearTB.TextChanged += new System.EventHandler(this.StudentSearTB_TextChanged);
            // 
            // StudentSearCOBO
            // 
            this.StudentSearCOBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentSearCOBO.FormattingEnabled = true;
            this.StudentSearCOBO.Items.AddRange(new object[] {
            "Student ID",
            "ERN",
            "First Name",
            "Last Name",
            "Gender"});
            this.StudentSearCOBO.Location = new System.Drawing.Point(235, 17);
            this.StudentSearCOBO.Name = "StudentSearCOBO";
            this.StudentSearCOBO.Size = new System.Drawing.Size(112, 21);
            this.StudentSearCOBO.TabIndex = 96;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.dataGridViewStudent);
            this.panel2.Location = new System.Drawing.Point(12, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 480);
            this.panel2.TabIndex = 98;
            // 
            // dataGridViewStudent
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridViewStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStudent.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.EnableHeadersVisualStyles = false;
            this.dataGridViewStudent.Location = new System.Drawing.Point(13, 16);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.Size = new System.Drawing.Size(849, 448);
            this.dataGridViewStudent.TabIndex = 0;
            // 
            // editBNT
            // 
            this.editBNT.Image = global::PrimarySchoolAPP.Properties.Resources.edit;
            this.editBNT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBNT.Location = new System.Drawing.Point(411, 25);
            this.editBNT.Name = "editBNT";
            this.editBNT.Size = new System.Drawing.Size(100, 39);
            this.editBNT.TabIndex = 111;
            this.editBNT.Text = "Edit";
            this.editBNT.UseVisualStyleBackColor = true;
            this.editBNT.Click += new System.EventHandler(this.editBNT_Click);
            // 
            // userConStudent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editBNT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Name = "userConStudent1";
            this.Size = new System.Drawing.Size(917, 600);
            this.Load += new System.EventHandler(this.userConStudent1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox StudentSearTB;
        private System.Windows.Forms.ComboBox StudentSearCOBO;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Button editBNT;
    }
}
