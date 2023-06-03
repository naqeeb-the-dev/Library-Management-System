namespace Library_Management_System
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtbookid = new TextBox();
            txtbooktitle = new TextBox();
            txtbooksubject = new TextBox();
            txtbookauthor = new TextBox();
            btnsave = new Button();
            btncancel = new Button();
            label5 = new Label();
            txtpubid = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 22);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Book ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 133);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 201);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Subject";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 267);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Author";
            // 
            // txtbookid
            // 
            txtbookid.Location = new Point(200, 19);
            txtbookid.Name = "txtbookid";
            txtbookid.Size = new Size(174, 23);
            txtbookid.TabIndex = 4;
            // 
            // txtbooktitle
            // 
            txtbooktitle.Location = new Point(200, 130);
            txtbooktitle.Name = "txtbooktitle";
            txtbooktitle.Size = new Size(174, 23);
            txtbooktitle.TabIndex = 5;
            // 
            // txtbooksubject
            // 
            txtbooksubject.Location = new Point(200, 193);
            txtbooksubject.Name = "txtbooksubject";
            txtbooksubject.Size = new Size(174, 23);
            txtbooksubject.TabIndex = 6;
            // 
            // txtbookauthor
            // 
            txtbookauthor.Location = new Point(200, 259);
            txtbookauthor.Name = "txtbookauthor";
            txtbookauthor.Size = new Size(174, 23);
            txtbookauthor.TabIndex = 7;
            // 
            // btnsave
            // 
            btnsave.FlatStyle = FlatStyle.Popup;
            btnsave.Location = new Point(75, 303);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(75, 23);
            btnsave.TabIndex = 8;
            btnsave.Text = "save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btncancel
            // 
            btncancel.FlatStyle = FlatStyle.Popup;
            btncancel.Location = new Point(240, 303);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(75, 23);
            btncancel.TabIndex = 9;
            btncancel.Text = "cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 78);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 10;
            label5.Text = "Publisher ID";
            // 
            // txtpubid
            // 
            txtpubid.Location = new Point(200, 78);
            txtpubid.Name = "txtpubid";
            txtpubid.Size = new Size(174, 23);
            txtpubid.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 197, 141);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 114);
            panel1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(423, 40);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 1;
            label6.Text = "Add Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(243, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btncancel);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtpubid);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnsave);
            panel2.Controls.Add(txtbookid);
            panel2.Controls.Add(txtbookauthor);
            panel2.Controls.Add(txtbooktitle);
            panel2.Controls.Add(txtbooksubject);
            panel2.Location = new Point(382, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(419, 336);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(-1, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(383, 336);
            panel3.TabIndex = 14;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "AddBook";
            Text = "AddBook";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtbookid;
        private TextBox txtbooktitle;
        private TextBox txtbooksubject;
        private TextBox txtbookauthor;
        private Button btnsave;
        private Button btncancel;
        private Label label5;
        private TextBox txtpubid;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Panel panel2;
        private Panel panel3;
    }
}