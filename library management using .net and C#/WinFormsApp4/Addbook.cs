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
using static System.Windows.Forms.AxHost;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace WinFormsApp4
{
    public partial class Addbook : Form
    {
        public Addbook()
        {
            InitializeComponent();
        }

        private void button_save(object sender, EventArgs e)
        {
            if (txtbid.Text!="" && txtBookname.Text != "" && txtauthoe.Text != "" && txtprice.Text != "" && txtpublish.Text != "" && txtquantity.Text != "")
            {
                Int64 bid = Int64.Parse(txtbid.Text);
                string bname = txtBookname.Text;
                string bauthor = txtauthoe.Text;
                string bpublication = txtpublish.Text;
                string bpdate = dateTimePicker1.Text;
                Int64 bprice = Int64.Parse(txtprice.Text);
                Int64 bquantity = Int64.Parse(txtquantity.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-3Q6R0UF\\SQLEXPRESS; database= master; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "Insert into newbook(bid,bname, bAuthor, bublish, bdate, bprice, bQuan)values('" + bid + "','" + bname + "','" + bauthor + "','" + bpublication + "','" + bpdate + "','" + bprice + "', '" + bquantity + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data saved", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbid.Clear();
                txtBookname.Clear();
                txtauthoe.Clear();
                txtpublish.Clear();
                txtprice.Clear();
                txtquantity.Clear();
            }
            else
            {
                MessageBox.Show("Empty field not allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("this will delete unsaved data", " Are you Sure ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
