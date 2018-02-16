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
    public partial class search : Form
    {
        public student b = new student();
        public search(student b)
        {
            InitializeComponent();
            this.b = b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("mepo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter course = new SqlParameter("@course_name", textBox1.Text);
            cmd.Parameters.Add(course);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                search4.Items.Clear();
                while (reader.Read())
                {
                    search4.Items.Add(reader["Name"]);
                }
                con.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentMM f2 = new studentMM(b);
            f2.ShowDialog();
        }

        private void search4_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("courseid", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter coursename = new SqlParameter("@course_name", search4.Text);
            cmd.Parameters.Add(coursename);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    b.course_id = (int)reader["Course_id"];

                }
                con.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //------------------------------------------------------------------------------------------------------------------------------
            SqlConnection con1 = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand("enrolled", con1);
            cmd1.CommandType = CommandType.StoredProcedure;
            SqlParameter courseid = new SqlParameter("@course_id", b.course_id);
            cmd1.Parameters.Add(courseid);
            SqlParameter userid = new SqlParameter("@usre_id", b.ID);
            cmd1.Parameters.Add(userid);
            SqlDataReader reader1;
            try
            {
                con1.Open();
                reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    
                        this.Hide();
                        course f2 = new course(b);
                        f2.ShowDialog();
                    
                 }
                else
                {
                    this.Hide();
                    notenrolled f3 = new notenrolled(b);
                    f3.ShowDialog();
                }

                con1.Close();
                reader1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }








        }
    }
}
