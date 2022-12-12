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
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblSituation = new System.Windows.Forms.Label();
            this.btn_List = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btn_ListByFilter = new System.Windows.Forms.Button();
            this.rdBigger = new System.Windows.Forms.RadioButton();
            this.rdSmaller = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.panel1.SuspendLayout();
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
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Surname,
            this.Class,
            this.No,
            this.Grade1,
            this.Grade2,
            this.GradeAvg});
            this.datagrid.Location = new System.Drawing.Point(538, 37);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersWidth = 51;
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.Size = new System.Drawing.Size(913, 308);
            this.datagrid.TabIndex = 2;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
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
            this.btn_Add.Location = new System.Drawing.Point(72, 420);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(154, 44);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add Student";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(242, 420);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(154, 44);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update Student";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(413, 420);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(154, 44);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete Student";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lblSituation
            // 
            this.lblSituation.AutoSize = true;
            this.lblSituation.Location = new System.Drawing.Point(24, 361);
            this.lblSituation.Name = "lblSituation";
            this.lblSituation.Size = new System.Drawing.Size(44, 16);
            this.lblSituation.TabIndex = 8;
            this.lblSituation.Text = "label7";
            // 
            // btn_List
            // 
            this.btn_List.Location = new System.Drawing.Point(1297, 374);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(154, 44);
            this.btn_List.TabIndex = 9;
            this.btn_List.Text = "List Students";
            this.btn_List.UseVisualStyleBackColor = true;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdSmaller);
            this.panel1.Controls.Add(this.rdBigger);
            this.panel1.Controls.Add(this.btn_ListByFilter);
            this.panel1.Controls.Add(this.txtFilter);
            this.panel1.Location = new System.Drawing.Point(812, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 179);
            this.panel1.TabIndex = 10;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(27, 22);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(258, 22);
            this.txtFilter.TabIndex = 0;
            // 
            // btn_ListByFilter
            // 
            this.btn_ListByFilter.Location = new System.Drawing.Point(107, 102);
            this.btn_ListByFilter.Name = "btn_ListByFilter";
            this.btn_ListByFilter.Size = new System.Drawing.Size(91, 38);
            this.btn_ListByFilter.TabIndex = 1;
            this.btn_ListByFilter.Text = "List By Filter";
            this.btn_ListByFilter.UseVisualStyleBackColor = true;
            this.btn_ListByFilter.Click += new System.EventHandler(this.btn_ListByFilter_Click);
            // 
            // rdBigger
            // 
            this.rdBigger.AutoSize = true;
            this.rdBigger.Location = new System.Drawing.Point(64, 50);
            this.rdBigger.Name = "rdBigger";
            this.rdBigger.Size = new System.Drawing.Size(125, 20);
            this.rdBigger.TabIndex = 2;
            this.rdBigger.TabStop = true;
            this.rdBigger.Text = "List the Big ones";
            this.rdBigger.UseVisualStyleBackColor = true;
            // 
            // rdSmaller
            // 
            this.rdSmaller.AutoSize = true;
            this.rdSmaller.Location = new System.Drawing.Point(64, 76);
            this.rdSmaller.Name = "rdSmaller";
            this.rdSmaller.Size = new System.Drawing.Size(134, 20);
            this.rdSmaller.TabIndex = 3;
            this.rdSmaller.TabStop = true;
            this.rdSmaller.Text = "List the Little Ones";
            this.rdSmaller.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.lblSituation);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lblIDSeen);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.datagrid);
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
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIDSeen;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lblSituation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeAvg;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdSmaller;
        private System.Windows.Forms.RadioButton rdBigger;
        private System.Windows.Forms.Button btn_ListByFilter;
        private System.Windows.Forms.TextBox txtFilter;
    }
}

