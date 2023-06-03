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
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-EN5VJJJ ; database = Library Management ; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand("SELECT Title FROM Book", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    comboBoxBook.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();
            con.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            String mid = txtsearchbox.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-EN5VJJJ ; database = Library Management ; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from Member where Member_ID = '" + mid + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            if (DS.Tables[0].Rows.Count != 0)
            {
                txtmemberid.Text = DS.Tables[0].Rows[0][0].ToString();
                txtname.Text = DS.Tables[0].Rows[0][1].ToString();
                txtaddress.Text = DS.Tables[0].Rows[0][2].ToString();
                txttelephone.Text = DS.Tables[0].Rows[0][3].ToString();

            }
            else
            {
                txtname.Clear();
                txtmemberid.Clear();
                txtaddress.Clear();
                txttelephone.Clear();

                MessageBox.Show("Invalid Enrollment NO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btnissuebook_Click(object sender, EventArgs e)
        {
            String bookid = "";
            if (txtname.Text != "")
            {
                if (comboBoxBook.SelectedIndex != -1)
                {
                    String MemberID = txtmemberid.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-EN5VJJJ ; database = Library Management ; integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "Select Book_ID from Book where Title = '" + comboBoxBook.SelectedItem.ToString() + "'";
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);

                    if (DS.Tables[0].Rows.Count != 0)
                    {
                        bookid = DS.Tables[0].Rows[0][0].ToString();
                    }
                    String Address = txtaddress.Text;
                    String issuedate = dateofissue.Text;
                    Console.Write(issuedate);
                    con.Close();
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "data source = DESKTOP-EN5VJJJ ; database = Library Management ; integrated security = True";
                    SqlCommand cmdd = new SqlCommand();
                    cmdd.Connection = conn;
                    conn.Open();
                    cmdd.CommandText = "INSERT INTO Borrower (Book_ID, Member_ID, Address, Issue_date) Values('" + bookid + "' ,'" + MemberID + "','" + Address + "','" + issuedate + "')";
                    cmdd.ExecuteNonQuery();
                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
