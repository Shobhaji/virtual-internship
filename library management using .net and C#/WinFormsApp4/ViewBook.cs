using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp4
{
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source =DESKTOP-3Q6R0UF\\SQLEXPRESS; database=master;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from newbook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            conn.Open();
        }
        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            panel2.Visible = true;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source =DESKTOP-3Q6R0UF\\SQLEXPRESS; database=master;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from newbook where bid=" + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtname.Text = ds.Tables[0].Rows[0][1].ToString();
            txtauthorname.Text = ds.Tables[0].Rows[0][2].ToString();
            txtpublish.Text = ds.Tables[0].Rows[0][3].ToString();
            txtdate.Text = ds.Tables[0].Rows[0][4].ToString();
            txtprice.Text = ds.Tables[0].Rows[0][5].ToString();
            txtquan.Text = ds.Tables[0].Rows[0][6].ToString();

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtbookname_TextChanged(object sender, EventArgs e)
        {
            if (txtbookname.Text != "")
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source =DESKTOP-3Q6R0UF\\SQLEXPRESS; database=master;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from newbook where bname LIKE '" + txtbookname + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source =DESKTOP-3Q6R0UF\\SQLEXPRESS; database=master;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from newbook";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtbookname.Clear();
            panel2.Visible = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be updated, Confirm", "Sucess", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String bname = txtname.Text;
                string bauthor = txtauthorname.Text;
                string publish = txtpublish.Text;
                string bdate = txtdate.Text;
                Int64 price = Int64.Parse(txtprice.Text);
                Int64 quantity = Int64.Parse(txtquan.Text);
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source =DESKTOP-3Q6R0UF\\SQLEXPRESS; database=master;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update newbook set bname='" + bname + "', bAuthor='" + bauthor + "', bublish='" + publish + "',bdate='" + bdate + "',bprice='" + price + "', bQuan='" + quantity + "' where bid =" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted, Confirm", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source =DESKTOP-3Q6R0UF\\SQLEXPRESS; database=master;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from newbook where bid =" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }
    }
}
