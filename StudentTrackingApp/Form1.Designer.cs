namespace StudentTrackingApp
{
    partial class Form1
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Class = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_No = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Grade1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Grade2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_GradeAvg = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblID = new System.Windows.Forms.Label();
            this.lblIDSeen = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(24, 37);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(101, 16);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Student Name : ";
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(219, 82);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(287, 22);
            this.txt_Surname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Surname : ";
            // 
            // txt_Class
            // 
            this.txt_Class.Location = new System.Drawing.Point(219, 124);
            this.txt_Class.Name = "txt_Class";
            this.txt_Class.Size = new System.Drawing.Size(287, 22);
            this.txt_Class.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student\'s Class : ";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(219, 37);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(287, 22);
            this.txt_Name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Student No : ";
            // 
            // txt_No
            // 
            this.txt_No.Location = new System.Drawing.Point(219, 169);
            this.txt_No.Name = "txt_No";
            this.txt_No.Size = new System.Drawing.Size(287, 22);
            this.txt_No.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Student Grade 1 : ";
            // 
            // txt_Grade1
            // 
            this.txt_Grade1.Location = new System.Drawing.Point(219, 220);
            this.txt_Grade1.Name = "txt_Grade1";
            this.txt_Grade1.Size = new System.Drawing.Size(287, 22);
            this.txt_Grade1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Student Grade 2 : ";
            // 
            // txt_Grade2
            // 
            this.txt_Grade2.Location = new System.Drawing.Point(219, 275);
            this.txt_Grade2.Name = "txt_Grade2";
            this.txt_Grade2.Size = new System.Drawing.Size(287, 22);
            this.txt_Grade2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Student Grade Average : ";
            // 
            // txt_GradeAvg
            // 
            this.txt_GradeAvg.Location = new System.Drawing.Point(219, 323);
            this.txt_GradeAvg.Name = "txt_GradeAvg";
            this.txt_GradeAvg.Size = new System.Drawing.Size(287, 22);
            this.txt_GradeAvg.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Surname,
            this.Class,
            this.No,
            this.Grade1,
            this.Grade2,
            this.GradeAvg});
            this.dataGridView1.Location = new System.Drawing.Point(538, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(913, 308);
            this.dataGridView1.TabIndex = 2;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Surname
            // 
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Surname.HeaderText = "Surname";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            // 
            // Class
            // 
            this.Class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Class.HeaderText = "Class";
            this.Class.MinimumWidth = 6;
            this.Class.Name = "Class";
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            // 
            // Grade1
            // 
            this.Grade1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Grade1.HeaderText = "Grade1";
            this.Grade1.MinimumWidth = 6;
            this.Grade1.Name = "Grade1";
            // 
            // Grade2
            // 
            this.Grade2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Grade2.HeaderText = "Grade2";
            this.Grade2.MinimumWidth = 6;
            this.Grade2.Name = "Grade2";
            // 
            // GradeAvg
            // 
            this.GradeAvg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GradeAvg.HeaderText = "GradeAvg";
            this.GradeAvg.MinimumWidth = 6;
            this.GradeAvg.Name = "GradeAvg";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(597, 361);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(77, 16);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Student ID : ";
            // 
            // lblIDSeen
            // 
            this.lblIDSeen.AutoSize = true;
            this.lblIDSeen.Location = new System.Drawing.Point(671, 361);
            this.lblIDSeen.Name = "lblIDSeen";
            this.lblIDSeen.Size = new System.Drawing.Size(20, 16);
            this.lblIDSeen.TabIndex = 4;
            this.lblIDSeen.Text = "ID";
            this.lblIDSeen.Click += new System.EventHandler(this.lblIDSeen_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(72, 398);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(154, 44);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add Student";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(244, 398);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(154, 44);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update Student";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(419, 398);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(154, 44);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete Student";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 512);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lblIDSeen);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_GradeAvg);
            this.Controls.Add(this.txt_Grade2);
            this.Controls.Add(this.txt_Grade1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_No);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Class);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Surname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_No;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Grade1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Grade2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_GradeAvg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeAvg;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIDSeen;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
    }
}

