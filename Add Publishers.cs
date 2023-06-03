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
    public partial class Add_Publishers : Form
    {
        public Add_Publishers()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtpubid.Text != "" && txtname.Text != "" && txtaddress.Text != "")
            {
                try
                {
                    String pid = txtpubid.Text;
                    String pname = txtname.Text;
                    String paddress = txtaddress.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-EN5VJJJ ; database = Library Management; integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "INSERT INTO Publisher (Pub_ID, Name, Address) Values ('" + pid + "','" + pname + "','" + paddress + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtpubid.Clear();
                    txtname.Clear();
                    txtaddress.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Recheck your values as the record may already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtpubid.Clear();
            txtname.Clear();
            txtaddress.Clear();
        }
    }
}
