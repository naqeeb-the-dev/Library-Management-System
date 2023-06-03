using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class ViewMembers : Form
    {
        public ViewMembers()
        {
            InitializeComponent();
        }
        int bid;
        Int64 rowid;
        private void txtmembername_TextChanged(object sender, EventArgs e)
        {
            if (txtmembername.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-EN5VJJJ ; database = Library Management ; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM Member WHERE Name LIKE '" + txtmembername.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-EN5VJJJ ; database = Library Management ; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM Member";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Data will be updated, Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    String name = txtmemname.Text;
                    String id = txtmemberid.Text;
                    String address = txtaddress.Text;
                    String telephone = txttelephone.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-EN5VJJJ ; database = Library Management ; integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "UPDATE Member SET Member_ID = '" + id + "', Name = '" + name + "', Address= '" + address + "', Telephone='" + telephone + "' WHERE Member_ID = '" + rowid + "'";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                   
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Recheck your values, This record may already exist", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-EN5VJJJ ; database = Library Management ; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM Member";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    Console.WriteLine(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                }
                panel2.Visible = true;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-EN5VJJJ ; database = Library Management ; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM Member where Member_ID = '" + bid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                txtmemberid.Text = ds.Tables[0].Rows[0][0].ToString();
                txtmemname.Text = ds.Tables[0].Rows[0][1].ToString();
                txtaddress.Text = ds.Tables[0].Rows[0][2].ToString();
                txttelephone.Text = ds.Tables[0].Rows[0][3].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please click on Member ID Cell", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted, Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-EN5VJJJ ; database = Library Management ; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "DELETE FROM Member WHERE Member_ID = '" + rowid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtmembername.Clear();
            panel2.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txttelephone_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtmemname_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtmemberid_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
