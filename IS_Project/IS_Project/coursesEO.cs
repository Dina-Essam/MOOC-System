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
    public partial class coursesEO : Form
    {
        public EO q = new EO();
        public coursesEO(EO q)
        {
            InitializeComponent();
            this.q = q;
            fill_listbox();
        }

        private void coursesEO_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reviews_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void fill_listbox()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select Review from CourseStudent where Course_SID='" + q.course_id + "' ;", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reviews.Items.Add(reader["Review"]);
                }
                con.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EOmainmenucs f2 = new EOmainmenucs(q);
            f2.ShowDialog();
        }
    }
}
