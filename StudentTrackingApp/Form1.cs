using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;

namespace StudentTrackingApp
{
    public partial class Form1 : Form
    {
        FirestoreDb db;
        int gradeAvg;
        Transactions transactions;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblIDSeen_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"education.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("education-9eed5");

            lblSituation.Text = "Connection Successful";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int grade1 = Convert.ToInt32(txt_Grade1.Text);
            int grade2 = Convert.ToInt32(txt_Grade2.Text);
            gradeAvg = (grade1 + grade2) / 2;
            txt_GradeAvg.Text = gradeAvg.ToString();
            AddStudent();
        }
        private void btn_List_Click(object sender, EventArgs e)
        {
            datagrid.Rows.Clear();
            GetAllStudents();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int grade1 = Convert.ToInt32(txt_Grade1.Text);
            int grade2 = Convert.ToInt32(txt_Grade2.Text);
            gradeAvg = (grade1 + grade2) / 2;
            txt_GradeAvg.Text = gradeAvg.ToString();
            AddStudent();
            UpdateStudent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteStudent();
        }

        private void AddStudent()
        {
            transactions = new Transactions(); 
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"Name", txt_Name.Text},
                {"Surname", txt_Surname.Text},
                {"Class", Convert.ToInt32(txt_Class.Text)},
                {"No", Convert.ToInt32(txt_No.Text)},
                {"Grade1", Convert.ToInt32(txt_Grade1.Text)},
                {"Grade2", Convert.ToInt32(txt_Grade2.Text)},
                {"GradeAvg", Convert.ToInt32(txt_GradeAvg.Text)}
            };

            transactions.SetData(db, "Students", data);
            lblSituation.Text = "Data Insertion Successful";
        }
        private void GetAllStudents()
        {
            transactions = new Transactions();
            QuerySnapshot snapshots = transactions.GetData(db, "Students").Result;
            foreach (DocumentSnapshot docSnap in snapshots)
            {
                Student student = docSnap.ConvertTo<Student>();
                if (docSnap.Exists)
                {
                    datagrid.Rows.Add(docSnap.Id, student.Name, student.Surname, student.Class, student.No, student.Grade1, student.Grade2, student.GradeAvg);
                }
            }
        }

        private void UpdateStudent()
        {
            transactions = new Transactions();
            Dictionary<string, object> update = new Dictionary<string, object>()
            {
                {"Class", Convert.ToInt32(txt_Class.Text)},
                {"No", Convert.ToInt32(txt_No.Text)},
                {"Grade1", Convert.ToInt32(txt_Grade1.Text)},
                {"Grade2", Convert.ToInt32(txt_Grade2.Text)},
                {"GradeAvg", Convert.ToInt32(txt_GradeAvg.Text)}
            };

            transactions.UpdateData(db, "Students", lblIDSeen.Text, update);
            lblSituation.Text = "Update process successful";
        }

        private void DeleteStudent()
        {
            transactions = new Transactions();
            transactions.DeleteDocument(db, "Students", lblIDSeen.Text);
            lblSituation.Text = "Deletion successful";
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIDSeen.Text = datagrid.CurrentRow.Cells["ID"].Value.ToString();
            txt_Name.Text = datagrid.CurrentRow.Cells["Name"].Value.ToString();
            txt_Surname.Text = datagrid.CurrentRow.Cells["Surname"].Value.ToString();
            txt_Class.Text = datagrid.CurrentRow.Cells["Class"].Value.ToString();
            txt_No.Text = datagrid.CurrentRow.Cells["No"].Value.ToString();
            txt_Grade1.Text = datagrid.CurrentRow.Cells["Grade1"].Value.ToString();
            txt_Grade2.Text = datagrid.CurrentRow.Cells["Grade2"].Value.ToString();
            txt_GradeAvg.Text = datagrid.CurrentRow.Cells["GradeAvg"].Value.ToString();
        }

        private void btn_ListByFilter_Click(object sender, EventArgs e)
        {
            datagrid.Rows.Clear();
            if (rdBigger.Checked)
            {
                transactions = new Transactions();
                QuerySnapshot snapshots = transactions.GetGreatherThan(db, "Students", "GradeAvg", Convert.ToInt32(txtFilter.Text)).Result;
                foreach (DocumentSnapshot docSnap in snapshots)
                {
                    Student student = docSnap.ConvertTo<Student>();
                    if (docSnap.Exists)
                    {
                        datagrid.Rows.Add(docSnap.Id, student.Name, student.Surname, student.Class, student.No, student.Grade1, student.Grade2, student.GradeAvg);
                    }
                }
            }

            if (rdSmaller.Checked)
            {
                transactions = new Transactions();
                QuerySnapshot snapshots = transactions.GetLessThan(db, "Students", "GradeAvg", Convert.ToInt32(txtFilter.Text)).Result;
                foreach (DocumentSnapshot docSnap in snapshots)
                {
                    Student student = docSnap.ConvertTo<Student>();
                    if (docSnap.Exists)
                    {
                        datagrid.Rows.Add(docSnap.Id, student.Name, student.Surname, student.Class, student.No, student.Grade1, student.Grade2, student.GradeAvg);
                    }
                }
            }
        }
    }
}
