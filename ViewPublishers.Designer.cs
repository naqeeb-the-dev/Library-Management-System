namespace Library_Management_System
{
    partial class ViewPublishers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPublishers));
            panel1 = new Panel();
            btnCancel = new Button();
            btnrefresh = new Button();
            txtpubname = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            txtpublishername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnUpdate = new Button();
            txtaddress = new TextBox();
            txtpubid = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(9, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(946, 96);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(568, 165);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnrefresh
            // 
            btnrefresh.FlatStyle = FlatStyle.Popup;
            btnrefresh.Location = new Point(565, 111);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(75, 23);
            btnrefresh.TabIndex = 16;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // txtpubname
            // 
            txtpubname.Location = new Point(372, 112);
            txtpubname.Name = "txtpubname";
            txtpubname.Size = new Size(158, 23);
            txtpubname.TabIndex = 15;
            txtpubname.TextChanged += txtmembername_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(260, 115);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 14;
            label1.Text = "Publisher Name";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(943, 249);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(443, 165);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtpublishername
            // 
            txtpublishername.Location = new Point(418, 101);
            txtpublishername.Name = "txtpublishername";
            txtpublishername.Size = new Size(210, 23);
            txtpublishername.TabIndex = 6;
            txtpublishername.TextChanged += txtpublishername_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(277, 103);
            label3.Name = "label3";
            label3.Size = new Size(121, 21);
            label3.TabIndex = 1;
            label3.Text = "Publisher Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 18);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 0;
            label2.Text = "Publisher ID";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtaddress);
            panel2.Controls.Add(txtpublishername);
            panel2.Controls.Add(txtpubid);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 407);
            panel2.Name = "panel2";
            panel2.Size = new Size(946, 210);
            panel2.TabIndex = 17;
            panel2.Paint += panel2_Paint;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(316, 165);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(586, 16);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(335, 23);
            txtaddress.TabIndex = 8;
            // 
            // txtpubid
            // 
            txtpubid.Location = new Point(188, 16);
            txtpubid.Name = "txtpubid";
            txtpubid.Size = new Size(240, 23);
            txtpubid.TabIndex = 5;
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
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(332, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(486, 41);
            label4.Name = "label4";
            label4.Size = new Size(145, 25);
            label4.TabIndex = 1;
            label4.Text = "View Publishers";
            // 
            // ViewPublishers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(970, 656);
            Controls.Add(panel1);
            Controls.Add(btnrefresh);
            Controls.Add(txtpubname);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            MaximizeBox = false;
            Name = "ViewPublishers";
            Text = "ViewPublishers";
            Load += ViewPublishers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        private Button btnrefresh;
        private TextBox txtpubname;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private TextBox txtpublishername;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Button btnUpdate;
        private TextBox txtaddress;
        private TextBox txtpubid;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
    }
}