namespace Library_Management_System
{
    partial class IssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBook));
            panel1 = new Panel();
            btnexit = new Button();
            btnrefresh = new Button();
            btnsearch = new Button();
            txtsearchbox = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnissuebook = new Button();
            dateofissue = new DateTimePicker();
            comboBoxBook = new ComboBox();
            txttelephone = new TextBox();
            txtaddress = new TextBox();
            txtname = new TextBox();
            txtmemberid = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnexit);
            panel1.Controls.Add(btnrefresh);
            panel1.Controls.Add(btnsearch);
            panel1.Controls.Add(txtsearchbox);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(12, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 530);
            panel1.TabIndex = 0;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(203, 305);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(75, 23);
            btnexit.TabIndex = 4;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            // 
            // btnrefresh
            // 
            btnrefresh.Location = new Point(99, 305);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(75, 23);
            btnrefresh.TabIndex = 3;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(159, 258);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(75, 23);
            btnsearch.TabIndex = 2;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // txtsearchbox
            // 
            txtsearchbox.Location = new Point(149, 217);
            txtsearchbox.Name = "txtsearchbox";
            txtsearchbox.Size = new Size(100, 23);
            txtsearchbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 174);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Member ID";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnissuebook);
            panel2.Controls.Add(dateofissue);
            panel2.Controls.Add(comboBoxBook);
            panel2.Controls.Add(txttelephone);
            panel2.Controls.Add(txtaddress);
            panel2.Controls.Add(txtname);
            panel2.Controls.Add(txtmemberid);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(388, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(570, 530);
            panel2.TabIndex = 1;
            // 
            // btnissuebook
            // 
            btnissuebook.Location = new Point(248, 461);
            btnissuebook.Name = "btnissuebook";
            btnissuebook.Size = new Size(75, 23);
            btnissuebook.TabIndex = 12;
            btnissuebook.Text = "Issue";
            btnissuebook.UseVisualStyleBackColor = true;
            btnissuebook.Click += btnissuebook_Click;
            // 
            // dateofissue
            // 
            dateofissue.CustomFormat = "yyyy-MM-dd";
            dateofissue.Format = DateTimePickerFormat.Custom;
            dateofissue.Location = new Point(223, 398);
            dateofissue.Name = "dateofissue";
            dateofissue.RightToLeft = RightToLeft.No;
            dateofissue.Size = new Size(191, 23);
            dateofissue.TabIndex = 11;
            // 
            // comboBoxBook
            // 
            comboBoxBook.FormattingEnabled = true;
            comboBoxBook.Location = new Point(223, 346);
            comboBoxBook.Name = "comboBoxBook";
            comboBoxBook.Size = new Size(191, 23);
            comboBoxBook.TabIndex = 10;
            // 
            // txttelephone
            // 
            txttelephone.Location = new Point(223, 284);
            txttelephone.Name = "txttelephone";
            txttelephone.Size = new Size(191, 23);
            txttelephone.TabIndex = 9;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(223, 222);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(191, 23);
            txtaddress.TabIndex = 8;
            // 
            // txtname
            // 
            txtname.Location = new Point(223, 152);
            txtname.Name = "txtname";
            txtname.Size = new Size(191, 23);
            txtname.TabIndex = 7;
            // 
            // txtmemberid
            // 
            txtmemberid.Location = new Point(223, 92);
            txtmemberid.Name = "txtmemberid";
            txtmemberid.Size = new Size(191, 23);
            txtmemberid.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(77, 398);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 5;
            label7.Text = "Date of Issue";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 346);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 4;
            label6.Text = "Book";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 292);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 3;
            label5.Text = "Telephone ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 225);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 2;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 160);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 1;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 100);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "Member ID";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(333, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(510, 46);
            label8.Name = "label8";
            label8.Size = new Size(104, 25);
            label8.TabIndex = 3;
            label8.Text = "Issue Book";
            // 
            // IssueBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(970, 656);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            MaximizeBox = false;
            Name = "IssueBook";
            Text = "IssueBook";
            Load += IssueBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtsearchbox;
        private Label label1;
        private Button btnexit;
        private Button btnrefresh;
        private Button btnsearch;
        private Panel panel2;
        private DateTimePicker dateofissue;
        private ComboBox comboBoxBook;
        private TextBox txttelephone;
        private TextBox txtaddress;
        private TextBox txtname;
        private TextBox txtmemberid;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnissuebook;
        private PictureBox pictureBox1;
        private Label label8;
    }
}