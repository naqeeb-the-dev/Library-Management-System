using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Return_Book : Form
    {
        public Return_Book()
        {
            InitializeComponent();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            if (txtbookid.Text != "" && txtmemberid.Text != "")
            {
                String bookid = txtbookid.Text;
                String memid = txtmemberid.Text;
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source = DESKTOP-EN5VJJJ ; database = Library Management ; integrated security = True";
                SqlCommand cmdd = new SqlCommand();
                cmdd.Connection = conn;
                conn.Open();
                cmdd.CommandText = "Delete from Borrower Where Book_ID = '" + bookid + "' and Member_ID = '" + memid + "'";
                int rowsAffected = cmdd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data does not exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
