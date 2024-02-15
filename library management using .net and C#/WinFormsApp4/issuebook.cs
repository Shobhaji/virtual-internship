using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace WinFormsApp4
{
    public partial class issuebook : Form
    {
        public issuebook()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtenroll.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void issuebook_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source =DESKTOP-3Q6R0UF\\SQLEXPRESS; database=master;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd = new SqlCommand("Select bname from newbook", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    comboBox1.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            conn.Close();
        }
        int count;
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtenroll.Text != "")
            {
                String eid = txtenroll.Text;

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source =DESKTOP-3Q6R0UF\\SQLEXPRESS; database=master;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from newstudent where enroll='" + eid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                ////////////////////////
                cmd.CommandText = "Select count(std_enroll) from newstudent where std_enroll='" + eid + "' and book_return_date is null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da.Fill(ds1);

                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());



                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtsname.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtdepart.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtsem.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtcontact.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtemail.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtsname.Clear();
                    txtdepart.Clear();
                    txtsem.Clear();
                    txtcontact.Clear();
                    txtemail.Clear();
                    MessageBox.Show("Invalid enrollment no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnissuebook_Click(object sender, EventArgs e)
        {
            if (txtsname.Text != "")
            {
                if (comboBox1.SelectedIndex != -1 && count <= 2)
                {
                    String enroll = txtenroll.Text;
                    String sname = txtsname.Text;
                    string dep = txtdepart.Text;
                    string sem = txtsem.Text;
                    Int64 contact = Int64.Parse(txtcontact.Text);
                    string email = txtemail.Text;
                    string bookname = comboBox1.Text;
                    string bookisdate = dateTimePicker1.Text;

                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "data source =DESKTOP-3Q6R0UF\\SQLEXPRESS; database=master;integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = "insert into Issuebook(std_enroll,std_name,std_depat,std_sem,std_,contact,std_email,book_name,book_issue_date,book_return_date)values('" + enroll + "','" + sname + "','" + dep + "','" + sem + "'," + contact + ",'" + email + "','" + bookname + "','" + bookisdate + "')";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("book issued", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("select book ", "No book selected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Enter valid enrollment number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtenroll_TextChanged(object sender, EventArgs e)
        {
            if (txtenroll.Text == "")
            {
                txtsname.Clear();
                txtdepart.Clear();
                txtsem.Clear();
                txtcontact.Clear();
                txtemail.Clear();

            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
           
        }
    }
}
