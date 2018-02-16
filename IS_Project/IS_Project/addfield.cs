using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Project
{
    public partial class addfield : Form
    {
        public EO q = new EO();
        public addfield(EO q)
        {
            InitializeComponent();
            this.q = q;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Field_Course(Name)values(@name)", con);
            
            try
            {
                con.Open();

                SqlParameter naame = new SqlParameter("@name", textBox1.Text);
                cmd.Parameters.Add(naame);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
                add f2 = new add(q);
                f2.ShowDialog();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
