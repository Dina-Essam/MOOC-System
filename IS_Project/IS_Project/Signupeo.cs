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
    public partial class Signupeo : Form
    {
        public student b = new student();
        public Signupeo(student b)
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
                SqlCommand cmd = new SqlCommand("insert into Educational_organization (Name,Email,Pass_word) values(@name,@mail,@pass)", con);
                SqlParameter fname = new SqlParameter("@name", nameeo.Text);
                cmd.Parameters.Add(fname);
                SqlParameter Mail = new SqlParameter("@mail", emaileo.Text);
                cmd.Parameters.Add(Mail);
                SqlParameter Pass = new SqlParameter("@pass", passwordeo.Text);
                cmd.Parameters.Add(Pass);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Nice");
                this.Hide();
                login f2 = new login();
                f2.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
