using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Project
{
    public partial class studentMM : Form
    {
        public student b;
        public studentMM(student b)
        {
            InitializeComponent();
            this.b = b;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login f2 = new login();
            f2.ShowDialog();
        }

        private void coursesshow_Click(object sender, EventArgs e)
        {
            this.Hide();
            Courses_Enrolled f2 = new Courses_Enrolled(b);
            f2.ShowDialog();
        }

        private void studentMM_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            this.Hide();
            search f2 = new search(b);
            f2.ShowDialog();
        }
    }
}
