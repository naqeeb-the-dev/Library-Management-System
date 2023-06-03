namespace Library_Management_System
{
    partial class Add_Publishers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Publishers));
            btnexit = new Button();
            btnsave = new Button();
            btnrefresh = new Button();
            txtaddress = new TextBox();
            txtname = new TextBox();
            txtpubid = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnexit
            // 
            btnexit.Location = new Point(490, 334);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(75, 23);
            btnexit.TabIndex = 21;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(380, 334);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(75, 23);
            btnsave.TabIndex = 20;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btnrefresh
            // 
            btnrefresh.Location = new Point(277, 334);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(75, 23);
            btnrefresh.TabIndex = 19;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(387, 263);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(201, 23);
            txtaddress.TabIndex = 17;
            // 
            // txtname
            // 
            txtname.Location = new Point(387, 200);
            txtname.Name = "txtname";
            txtname.Size = new Size(201, 23);
            txtname.TabIndex = 16;
            // 
            // txtpubid
            // 
            txtpubid.Location = new Point(387, 148);
            txtpubid.Name = "txtpubid";
            txtpubid.Size = new Size(201, 23);
            txtpubid.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 264);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 13;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 201);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 12;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 148);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 11;
            label1.Text = "PubId";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(277, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(445, 57);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 23;
            label4.Text = "Add Publishers";
            // 
            // Add_Publishers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(btnexit);
            Controls.Add(btnsave);
            Controls.Add(btnrefresh);
            Controls.Add(txtaddress);
            Controls.Add(txtname);
            Controls.Add(txtpubid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Add_Publishers";
            Text = "Add_Publishers";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnexit;
        private Button btnsave;
        private Button btnrefresh;
        private TextBox txtaddress;
        private TextBox txtname;
        private TextBox txtpubid;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
    }
}