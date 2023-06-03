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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtbookid.Text != "" && txtbookauthor.Text != "" && txtbooksubject.Text != "" && txtbooktitle.Text != "" && txtpubid.Text != "")
            {
                try
                {
                    String btitle = txtbooktitle.Text;
                    String bauthor = txtbookauthor.Text;
                    String bookid = txtbookid.Text;
                    String bsubject = txtbooksubject.Text;
                    String bpubid = txtpubid.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-EN5VJJJ ; database = Library Management; integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "INSERT INTO Book (Book_ID, Title, Subject, Author, Pub_ID) Values ('" + bookid + "','" + btitle + "','" + bsubject + "','" + bauthor + "','" + bpubid + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbookauthor.Clear();
                    txtbookid.Clear();
                    txtbooksubject.Clear();
                    txtbooktitle.Clear();
                    txtpubid.Clear();
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

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will Delete your Unsaved Data", "Are you Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
