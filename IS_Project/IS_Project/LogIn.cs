using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Project
{
    public partial class login : Form
    {
        student b = new student();
        EO q = new EO();
        public login()
        {
            InitializeComponent();
        }

        private void login_S_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");            
            SqlCommand cmd = new SqlCommand("select Student_ID from Student where Email='"+emailStudent.Text+"' and Pass_word ='"+passstudent.Text+"'", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;            
            try
            {
                con.Open();

                reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                    b.ID = (int)reader["Student_ID"];
                }
                if (count == 1)
                {
                    this.Hide();
                    studentMM f2 = new studentMM(b);
                    f2.ShowDialog();

                }
                else if (count == 0)
                {
                    MessageBox.Show(" invalid email or password ");
                }

                con.Close();
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void signup_S_Click(object sender, EventArgs e)
        {

        }

        private void login_EO_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select Eo_ID from Educational_organization where Email='" + emailEO.Text + "' and Pass_word ='" + passEO.Text + "'", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                con.Open();

                reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                    q.ID = (int)reader["Eo_ID"];
                }
                if (count == 1)
                {
                    this.Hide();
                    EOmainmenucs f2 = new EOmainmenucs(q);
                    f2.ShowDialog();
                }
                else if (count == 0)
                {
                    MessageBox.Show(" invalid email or password ");
                }

                con.Close();
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void signupstudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signupstudent f12 = new signupstudent(b);
            f12.ShowDialog();
        }

        private void signupeo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Signupeo f2 = new Signupeo(b);
            f2.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
