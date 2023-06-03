namespace Library_Management_System
{
    partial class AddMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMember));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtmemberid = new TextBox();
            txtname = new TextBox();
            txtaddress = new TextBox();
            txtTelephone = new TextBox();
            btnrefresh = new Button();
            btnsave = new Button();
            btnexit = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 113);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Member ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 182);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 246);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Address";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 312);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "Telephone";
            label4.Click += label4_Click;
            // 
            // txtmemberid
            // 
            txtmemberid.Location = new Point(398, 113);
            txtmemberid.Name = "txtmemberid";
            txtmemberid.Size = new Size(166, 23);
            txtmemberid.TabIndex = 4;
            txtmemberid.TextChanged += txtmemberid_TextChanged;
            // 
            // txtname
            // 
            txtname.Location = new Point(398, 174);
            txtname.Name = "txtname";
            txtname.Size = new Size(166, 23);
            txtname.TabIndex = 5;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(398, 238);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(166, 23);
            txtaddress.TabIndex = 6;
            txtaddress.TextChanged += txtaddress_TextChanged;
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(398, 309);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(166, 23);
            txtTelephone.TabIndex = 7;
            txtTelephone.TextChanged += txtTelephone_TextChanged;
            // 
            // btnrefresh
            // 
            btnrefresh.Location = new Point(243, 388);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(75, 23);
            btnrefresh.TabIndex = 8;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(385, 388);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(79, 23);
            btnsave.TabIndex = 9;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(516, 388);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(84, 23);
            btnexit.TabIndex = 10;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(302, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(439, 38);
            label5.Name = "label5";
            label5.Size = new Size(125, 25);
            label5.TabIndex = 12;
            label5.Text = "Add Member";
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(btnexit);
            Controls.Add(btnsave);
            Controls.Add(btnrefresh);
            Controls.Add(txtTelephone);
            Controls.Add(txtaddress);
            Controls.Add(txtname);
            Controls.Add(txtmemberid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "AddMember";
            Text = "AddMember";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtmemberid;
        private TextBox txtname;
        private TextBox txtaddress;
        private TextBox txtTelephone;
        private Button btnrefresh;
        private Button btnsave;
        private Button btnexit;
        private PictureBox pictureBox1;
        private Label label5;
    }
}