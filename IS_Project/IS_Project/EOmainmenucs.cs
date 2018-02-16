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
    public partial class EOmainmenucs : Form
    {
        public EO q = new EO();
        public EOmainmenucs(EO q)
        {
            InitializeComponent();
            this.q = q;
            fill_listbox();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EOmainmenucs_Load(object sender, EventArgs e)
        {

        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
           this.Hide();
           login f2 = new login();
           f2.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            add f3 = new add(q);
            f3.ShowDialog();
        }


        void fill_listbox()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select Name from Course where Eo_ID="+q.ID+";", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void CoursesEnrolled_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select Course_ID from Course where Name='" + CoursesEnrolled.Text + "' ;", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    q.course_id = (int)reader["Course_ID"];
                }
                con.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            this.Hide();
            coursesEO f2 = new coursesEO(q);
            f2.ShowDialog();
        }

        private void ADDcourse_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
