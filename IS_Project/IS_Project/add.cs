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
    
    public partial class add : Form
    {
        public EO q = new EO();
        public add(EO q)
        {
            InitializeComponent();
            this.q = q;
            fill_field();
            fill_tutor();
        }

        private void add_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"insert into Course (Name,Lec_num,Exam_num,Ass_num,Start_date,End_date,Course_link,Eo_ID,Description_of_course,T_ID,F_ID)
                                                           values(@Name,@Lec_num,@Exam_num,@Ass_num,@Start_date,@End_date,@Course_link,@Eo_ID,@Description_of_course,@T_ID,@F_ID)", con);
            cmd.CommandType = CommandType.Text;

            try
            {
                con.Open();


                //-----------------------------------------------------------------------------------------------
                SqlParameter namee = new SqlParameter("@Name", name.Text);
                cmd.Parameters.Add(namee);

                SqlParameter lec = new SqlParameter("@Lec_num", lecno.Text);
                cmd.Parameters.Add(lec);

                SqlParameter exa = new SqlParameter("@Exam_num", examno.Text);
                cmd.Parameters.Add(exa);

                SqlParameter ass = new SqlParameter("@Ass_num", assigno.Text);
                cmd.Parameters.Add(ass);

               

                SqlParameter sd = new SqlParameter("@Start_date", sdate.MaxDate);
                cmd.Parameters.Add(sd);

                SqlParameter ed = new SqlParameter("@End_date", edate.MaxDate);
                cmd.Parameters.Add(ed);

                SqlParameter cl = new SqlParameter("@Course_link", courselink.Text);
                cmd.Parameters.Add(cl);

                SqlParameter eoid = new SqlParameter("@Eo_ID", q.ID);
                cmd.Parameters.Add(eoid);

                SqlParameter des = new SqlParameter("@Description_of_course", discription.Text);
                cmd.Parameters.Add(des);

            //-------------------------------------------------------------------------------------------------------------
            SqlConnection con1 = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
            SqlCommand Tutor = new SqlCommand("select T_ID from Tutor where First_name='"+tutor.Text+"'", con1);
            con1.Open();
               Tutor.CommandType = CommandType.Text;
               SqlDataReader read1 = Tutor.ExecuteReader();
               read1.Read();
               SqlParameter tutors = new SqlParameter("@T_ID", (int)read1["T_ID"]);
               cmd.Parameters.Add(tutors);
               
               read1.Close();
            SqlConnection con2 = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
            SqlCommand field = new SqlCommand("select F_ID from Field_Course where Name ='"+field1.Text+"'", con2);
            con2.Open();
              field.CommandType = CommandType.Text;
              SqlDataReader read2 = field.ExecuteReader();

              read2.Read();
              SqlParameter fields = new SqlParameter("@F_ID", (int)read2["F_ID"]);
              cmd.Parameters.Add(fields);

              read2.Close();
              cmd.ExecuteNonQuery();
            con1.Close();
            con2.Close();
              con.Close();

                MessageBox.Show("Course Added :) ");
                this.Hide();
                EOmainmenucs f2 = new EOmainmenucs(q);
                f2.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void fill_field()
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select Name from Field_Course ;", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    field1.Items.Add((string)reader["Name"]);
                }
                con.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void fill_tutor()
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MOOC;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("fefe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter para = new SqlParameter("@eo_id", q.ID);
            cmd.Parameters.Add(para);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tutor.Items.Add((string)reader["First_name"]);
                }
                con.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tutor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            this.Hide();
            addfield f2 = new addfield(q);
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EOmainmenucs f2 = new EOmainmenucs(q);
            f2.ShowDialog();
        }
    }
}
