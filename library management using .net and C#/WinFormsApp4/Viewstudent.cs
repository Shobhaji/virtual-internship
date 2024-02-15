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

namespace WinFormsApp4
{
    public partial class Viewstudent : Form
    {
        public Viewstudent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)

        {
            if (txtsearch.Text != "")
            {
                label1.Visible = false;
                Image img = Image.FromFile("C:/Users/acer/Downloads/Liberay Management System Icon and Images/Liberay Management System/search1.gif");
                pictureBox1.Image = img;

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source =DESKTOP-3Q6R0UF\\SQLEXPRESS; database=master;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = " select * from newstudent where enroll LIKE '"+ txtsearch+"%'  ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                label1.Visible = true;
                Image img = Image.FromFile("C:/Users/acer/Downloads/Liberay Management System Icon and Images/Liberay Management System/search.gif");
                pictureBox1.Image = img;

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source =DESKTOP-3Q6R0UF\\SQLEXPRESS; database=master;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = " select * from newstudent";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }

        }

        private void Viewstudent_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source =DESKTOP-3Q6R0UF\\SQLEXPRESS; database=master;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = " select * from newstudent";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
