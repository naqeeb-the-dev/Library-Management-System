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

namespace Library_Management_System
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtmemberid.Text != "" && txtname.Text != "" && txtaddress.Text != "" && txtTelephone.Text != "")
            {
                try
                {
                    String mid = txtmemberid.Text;
                    String mname = txtname.Text;
                    String maddress = txtaddress.Text;
                    String mtelephone = txtTelephone.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-EN5VJJJ ; database = Library Management; integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "INSERT INTO Member (Member_ID, Name, Address, Telephone) Values ('" + mid + "','" + mname + "','" + maddress + "','" + mtelephone + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmemberid.Clear();
                    txtname.Clear();
                    txtaddress.Clear();
                    txtTelephone.Clear();
                }
                catch (Exception) {
                    MessageBox.Show("Please Recheck your values. This record may already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("You can not leave any field empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will Delete your Unsaved Data", "Are you Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtmemberid.Clear();
            txtname.Clear();
            txtaddress.Clear();
            txtTelephone.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void txtmemberid_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
