namespace Library_Management_System
{
    partial class ViewMembers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMembers));
            btnCancel = new Button();
            btnUpdate = new Button();
            label5 = new Label();
            panel2 = new Panel();
            btnDelete = new Button();
            txttelephone = new TextBox();
            txtaddress = new TextBox();
            txtmemname = new TextBox();
            txtmemberid = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnrefresh = new Button();
            txtmembername = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(538, 156);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(286, 156);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(471, 18);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 3;
            label5.Text = "Address";
            label5.Click += label5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txttelephone);
            panel2.Controls.Add(txtaddress);
            panel2.Controls.Add(txtmemname);
            panel2.Controls.Add(txtmemberid);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(5, 402);
            panel2.Name = "panel2";
            panel2.Size = new Size(911, 210);
            panel2.TabIndex = 11;
            panel2.Paint += panel2_Paint;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(413, 156);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txttelephone
            // 
            txttelephone.Location = new Point(586, 94);
            txttelephone.Name = "txttelephone";
            txttelephone.Size = new Size(248, 23);
            txttelephone.TabIndex = 9;
            txttelephone.TextChanged += txttelephone_TextChanged;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(586, 16);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(248, 23);
            txtaddress.TabIndex = 8;
            txtaddress.TextChanged += txtaddress_TextChanged;
            // 
            // txtmemname
            // 
            txtmemname.Location = new Point(189, 94);
            txtmemname.Name = "txtmemname";
            txtmemname.Size = new Size(209, 23);
            txtmemname.TabIndex = 6;
            txtmemname.TextChanged += txtmemname_TextChanged;
            // 
            // txtmemberid
            // 
            txtmemberid.Location = new Point(189, 18);
            txtmemberid.Name = "txtmemberid";
            txtmemberid.Size = new Size(209, 23);
            txtmemberid.TabIndex = 5;
            txtmemberid.TextChanged += txtmemberid_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(471, 96);
            label6.Name = "label6";
            label6.Size = new Size(80, 21);
            label6.TabIndex = 4;
            label6.Text = "Telephone";
            label6.Click += label6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 96);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 1;
            label3.Text = "Member Name";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 18);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 0;
            label2.Text = "Member ID";
            label2.Click += label2_Click;
            // 
            // btnrefresh
            // 
            btnrefresh.FlatStyle = FlatStyle.Popup;
            btnrefresh.Location = new Point(556, 98);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(75, 23);
            btnrefresh.TabIndex = 10;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // txtmembername
            // 
            txtmembername.Location = new Point(398, 99);
            txtmembername.Name = "txtmembername";
            txtmembername.Size = new Size(144, 23);
            txtmembername.TabIndex = 9;
            txtmembername.TextChanged += txtmembername_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(292, 102);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 8;
            label1.Text = "MemberName";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(911, 255);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 93);
            panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(336, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(462, 36);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 1;
            label4.Text = "View Members";
            // 
            // ViewMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(935, 480);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btnrefresh);
            Controls.Add(txtmembername);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ViewMembers";
            Text = "ViewMembers";
            Load += ViewMembers_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnUpdate;
        private Label label5;
        private Panel panel2;
        private Button btnDelete;
        private TextBox txttelephone;
        private TextBox txtaddress;
        private TextBox txtbooksubject;
        private TextBox txtmemname;
        private TextBox txtmemberid;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnrefresh;
        private TextBox txtmembername;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}