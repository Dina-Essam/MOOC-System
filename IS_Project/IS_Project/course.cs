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
    public partial class course : Form
    {
        public student b;
        public course(student b)
        {
            InitializeComponent();
            this.b = b;
        }

        private void course_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
      
        private void description_Click_1(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            studentMM f2 = new studentMM(b);
            f2.ShowDialog();
        }

        private void review_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update CourseStudent set Review ='" + reviewCourse.Text + "' where Course_SID='" + b.course_id + " ' and Student_ID='" + b.ID + "' ;", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Review is Updated :)");
        }

        private void rate_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update CourseStudent set rate ='" + rateCourse.Text + "' where Course_SID='" + b.course_id + "' and Student_ID='" + b.ID + "' ;", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Rate is Updated :)");
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("bosy", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter course_id = new SqlParameter("@course_id", b.course_id);
            cmd.Parameters.Add(course_id);
            SqlParameter course_id1 = new SqlParameter("@student_id", b.ID);
            cmd.Parameters.Add(course_id1);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                textBox1.Text = "YES";
                certi f2 = new certi();
                f2.ShowDialog();
            }
            else
            {
                textBox1.Text="NO";
            }
            reader.Close();
            con.Close();

        }
    }
    }

