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
using System.Configuration;

namespace IS_Project
{
    public partial class signupstudent : Form
    {
        public student b = new student();
        public signupstudent(student b)
        {
            InitializeComponent();
            this.b = b;
        }

        private void signup_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Student (First_name,Last_name,Email,Pass_word) values(@fname,@lname,@mail,@pass)", con);
                SqlParameter fname = new SqlParameter("@fname", fnamee.Text);
                cmd.Parameters.Add(fname);
                SqlParameter Sname = new SqlParameter("@lname", lname.Text);
                cmd.Parameters.Add(Sname);
                SqlParameter Mail = new SqlParameter("@mail", email.Text);
                cmd.Parameters.Add(Mail);
                SqlParameter Pass = new SqlParameter("@pass", password.Text);
                cmd.Parameters.Add(Pass);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Nice");
                this.Hide();
                login f2 = new login();
                f2.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
