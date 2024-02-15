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
    public partial class addstudent : Form
    {
        public addstudent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtsid.Clear();
            txtsname.Clear();
            txteno.Clear();
            txtdepart.Clear();
            txtsem.Clear();
            txtcontact.Clear();
            txtemail.Clear();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtsid.Text != "" && txtsname.Text != "" && txteno.Text != "" && txtdepart.Text != "" && txtsem.Text != "" && txtcontact.Text != "" && txtemail.Text != "")
            {
                Int64 sid = Int64.Parse(txtsid.Text);
                string name = txtsname.Text;
                string enroll = txteno.Text;
                string dep = txtdepart.Text;
                string sem = txtsem.Text;
                Int64 contact = Int64.Parse(txtcontact.Text);
                string email = txtemail.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =DESKTOP-3Q6R0UF\\SQLEXPRESS; database=master;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "Insert into newstudent(sid,sname,enroll,dep,sem,contact,email)values('" + sid + "','" + name + "','" + enroll + "','" + dep + "','" + sem + "','" + contact + "','" + email + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Fill empty fields","Suggest", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

    }
}
