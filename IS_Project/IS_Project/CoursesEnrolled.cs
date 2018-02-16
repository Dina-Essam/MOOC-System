using System;
using System.Collections.Generic;
using System.Configuration;
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
    public partial class Courses_Enrolled : Form
    {
        public student b;
        public Courses_Enrolled(student b)
        {
            InitializeComponent();
            this.b = b;
            fill_listbox();


        }
             
        void fill_listbox()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("dina", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter para = new SqlParameter("@user_id", b.ID);
            cmd.Parameters.Add(para);
            SqlDataReader reader ;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();                
                while (reader.Read())
                {
                    CoursesEnrolled.Items.Add((string)reader["Name"]);
                }
            con.Close();
            reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CoursesEnrolled_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select Course_ID from Course where Name='" + CoursesEnrolled.Text + "' ;",con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    b.course_id =(int)reader["Course_ID"];
                }
                con.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            this.Hide();
            course f2 = new course(b);
            f2.ShowDialog();
          
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentMM f2 = new studentMM(b);
            f2.ShowDialog();
        }
    }
}
