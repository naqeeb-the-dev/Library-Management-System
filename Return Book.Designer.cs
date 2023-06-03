namespace Library_Management_System
{
    partial class Return_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return_Book));
            label1 = new Label();
            label2 = new Label();
            txtbookid = new TextBox();
            txtmemberid = new TextBox();
            btnreturn = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 158);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Book ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 216);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter Member ID";
            // 
            // txtbookid
            // 
            txtbookid.Location = new Point(393, 150);
            txtbookid.Name = "txtbookid";
            txtbookid.Size = new Size(100, 23);
            txtbookid.TabIndex = 2;
            // 
            // txtmemberid
            // 
            txtmemberid.Location = new Point(393, 208);
            txtmemberid.Name = "txtmemberid";
            txtmemberid.Size = new Size(100, 23);
            txtmemberid.TabIndex = 3;
            // 
            // btnreturn
            // 
            btnreturn.Location = new Point(334, 271);
            btnreturn.Name = "btnreturn";
            btnreturn.Size = new Size(75, 23);
            btnreturn.TabIndex = 4;
            btnreturn.Text = "Return";
            btnreturn.UseVisualStyleBackColor = true;
            btnreturn.Click += btnreturn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(240, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(398, 61);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 6;
            label3.Text = "Return Book";
            // 
            // Return_Book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnreturn);
            Controls.Add(txtmemberid);
            Controls.Add(txtbookid);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Return_Book";
            Text = "Return_Book";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtbookid;
        private TextBox txtmemberid;
        private Button btnreturn;
        private PictureBox pictureBox1;
        private Label label3;
    }
}