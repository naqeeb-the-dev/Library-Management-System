namespace Library_Management_System
{
    partial class ViewBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBooks));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            txtbookname = new TextBox();
            btnrefresh = new Button();
            panel2 = new Panel();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtpubId = new TextBox();
            txtbookauthor = new TextBox();
            txtbooksubject = new TextBox();
            txtbooktitle = new TextBox();
            txtbookid = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 161);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(946, 255);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(946, 107);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 135);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 2;
            label1.Text = "Book Name";
            label1.Click += label1_Click;
            // 
            // txtbookname
            // 
            txtbookname.Location = new Point(426, 132);
            txtbookname.Name = "txtbookname";
            txtbookname.Size = new Size(142, 23);
            txtbookname.TabIndex = 3;
            txtbookname.TextChanged += txtbookname_TextChanged;
            // 
            // btnrefresh
            // 
            btnrefresh.FlatStyle = FlatStyle.Popup;
            btnrefresh.Location = new Point(588, 132);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(75, 23);
            btnrefresh.TabIndex = 4;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtpubId);
            panel2.Controls.Add(txtbookauthor);
            panel2.Controls.Add(txtbooksubject);
            panel2.Controls.Add(txtbooktitle);
            panel2.Controls.Add(txtbookid);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 434);
            panel2.Name = "panel2";
            panel2.Size = new Size(946, 210);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(755, 154);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(611, 154);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(471, 154);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtpubId
            // 
            txtpubId.Location = new Point(586, 94);
            txtpubId.Name = "txtpubId";
            txtpubId.Size = new Size(100, 23);
            txtpubId.TabIndex = 9;
            txtpubId.TextChanged += txtpubId_TextChanged;
            // 
            // txtbookauthor
            // 
            txtbookauthor.Location = new Point(586, 16);
            txtbookauthor.Name = "txtbookauthor";
            txtbookauthor.Size = new Size(100, 23);
            txtbookauthor.TabIndex = 8;
            txtbookauthor.TextChanged += txtbookauthor_TextChanged;
            // 
            // txtbooksubject
            // 
            txtbooksubject.Location = new Point(189, 173);
            txtbooksubject.Name = "txtbooksubject";
            txtbooksubject.Size = new Size(100, 23);
            txtbooksubject.TabIndex = 7;
            txtbooksubject.TextChanged += txtbooksubject_TextChanged;
            // 
            // txtbooktitle
            // 
            txtbooktitle.Location = new Point(189, 94);
            txtbooktitle.Name = "txtbooktitle";
            txtbooktitle.Size = new Size(100, 23);
            txtbooktitle.TabIndex = 6;
            txtbooktitle.TextChanged += txtbooktitle_TextChanged;
            // 
            // txtbookid
            // 
            txtbookid.Location = new Point(189, 18);
            txtbookid.Name = "txtbookid";
            txtbookid.Size = new Size(100, 23);
            txtbookid.TabIndex = 5;
            txtbookid.TextChanged += txtbookid_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(471, 96);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 4;
            label6.Text = "Pub_ID";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(471, 18);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 3;
            label5.Text = "Author";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(48, 171);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 2;
            label4.Text = "Subject";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 96);
            label3.Name = "label3";
            label3.Size = new Size(39, 21);
            label3.TabIndex = 1;
            label3.Text = "Title";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 18);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 0;
            label2.Text = "Book ID";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(354, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(516, 43);
            label7.Name = "label7";
            label7.Size = new Size(94, 21);
            label7.TabIndex = 1;
            label7.Text = "View Books";
            // 
            // ViewBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(970, 656);
            Controls.Add(panel2);
            Controls.Add(btnrefresh);
            Controls.Add(txtbookname);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "ViewBooks";
            Text = "ViewBooks";
            Load += ViewBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private TextBox txtbookname;
        private Button btnrefresh;
        private Panel panel2;
        private Label label2;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtpubId;
        private TextBox txtbookauthor;
        private TextBox txtbooksubject;
        private TextBox txtbooktitle;
        private TextBox txtbookid;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private PictureBox pictureBox1;
    }
}