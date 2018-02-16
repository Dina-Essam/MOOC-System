using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Project
{
    public partial class notenrolled : Form
    {
        public student b = new student();
        public notenrolled(student b)
        {
             
            InitializeComponent();
            this.b = b;
        }

        private void description_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Course where Course_ID='" + b.course_id + "' ;", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("Name");
            table.Columns.Add("Lecture Numbers");
            table.Columns.Add("Exam Numbers");
            table.Columns.Add("Assignment Numbers");
            table.Columns.Add("Start date");
            table.Columns.Add("End date");
            table.Columns.Add("Course Link");
            table.Columns.Add("Description");
            DataRow row;
            while (reader.Read())
            {
                row = table.NewRow();
                row["Name"] = reader["Name"];
                row["Lecture Numbers"] = reader["Lec_num"];
                row["Exam Numbers"] = reader["Exam_num"];
                row["Assignment Numbers"] = reader["Ass_num"];
                row["Start date"] = reader["Start_date"];
                row["End date"] = reader["End_date"];
                row["Course Link"] = reader["Course_link"];
                row["Description"] = reader["Description_of_course"];
                
                table.Rows.Add(row);
            }

            reader.Close();
            con.Close();
            dgv.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentMM f2 = new studentMM(b);
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into CourseStudent (Course_SID,Student_ID) values(@cid,@sid)", con);
            SqlParameter fname = new SqlParameter("@cid", b.course_id);
            cmd.Parameters.Add(fname);
            SqlParameter Sname = new SqlParameter("@sid", b.ID);
            cmd.Parameters.Add(Sname);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Enrolled successfully");

        }
    }
}
