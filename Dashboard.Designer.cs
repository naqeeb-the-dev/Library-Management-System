namespace Library_Management_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addNewBookToolStripMenuItem = new ToolStripMenuItem();
            viewBookToolStripMenuItem = new ToolStripMenuItem();
            memberToolStripMenuItem = new ToolStripMenuItem();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            viewMemberInfoToolStripMenuItem = new ToolStripMenuItem();
            publishersToolStripMenuItem = new ToolStripMenuItem();
            addPublisherToolStripMenuItem = new ToolStripMenuItem();
            viewPublishersToolStripMenuItem = new ToolStripMenuItem();
            issueBookToolStripMenuItem = new ToolStripMenuItem();
            returnBookToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, memberToolStripMenuItem, publishersToolStripMenuItem, issueBookToolStripMenuItem, returnBookToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewBookToolStripMenuItem, viewBookToolStripMenuItem });
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(107, 54);
            booksToolStripMenuItem.Text = "Books";
            // 
            // addNewBookToolStripMenuItem
            // 
            addNewBookToolStripMenuItem.Image = (Image)resources.GetObject("addNewBookToolStripMenuItem.Image");
            addNewBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            addNewBookToolStripMenuItem.Size = new Size(214, 56);
            addNewBookToolStripMenuItem.Text = "Add New Book";
            addNewBookToolStripMenuItem.Click += addNewBookToolStripMenuItem_Click;
            // 
            // viewBookToolStripMenuItem
            // 
            viewBookToolStripMenuItem.Image = (Image)resources.GetObject("viewBookToolStripMenuItem.Image");
            viewBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewBookToolStripMenuItem.Name = "viewBookToolStripMenuItem";
            viewBookToolStripMenuItem.Size = new Size(214, 56);
            viewBookToolStripMenuItem.Text = "View Book";
            viewBookToolStripMenuItem.Click += viewBookToolStripMenuItem_Click;
            // 
            // memberToolStripMenuItem
            // 
            memberToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStudentToolStripMenuItem, viewMemberInfoToolStripMenuItem });
            memberToolStripMenuItem.Image = (Image)resources.GetObject("memberToolStripMenuItem.Image");
            memberToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            memberToolStripMenuItem.Size = new Size(121, 54);
            memberToolStripMenuItem.Text = "Member";
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.Image = (Image)resources.GetObject("addStudentToolStripMenuItem.Image");
            addStudentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(221, 56);
            addStudentToolStripMenuItem.Text = "Add Member";
            addStudentToolStripMenuItem.Click += addStudentToolStripMenuItem_Click;
            // 
            // viewMemberInfoToolStripMenuItem
            // 
            viewMemberInfoToolStripMenuItem.Image = (Image)resources.GetObject("viewMemberInfoToolStripMenuItem.Image");
            viewMemberInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewMemberInfoToolStripMenuItem.Name = "viewMemberInfoToolStripMenuItem";
            viewMemberInfoToolStripMenuItem.Size = new Size(221, 56);
            viewMemberInfoToolStripMenuItem.Text = "View Member Info";
            viewMemberInfoToolStripMenuItem.Click += viewMemberInfoToolStripMenuItem_Click;
            // 
            // publishersToolStripMenuItem
            // 
            publishersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addPublisherToolStripMenuItem, viewPublishersToolStripMenuItem });
            publishersToolStripMenuItem.Image = (Image)resources.GetObject("publishersToolStripMenuItem.Image");
            publishersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            publishersToolStripMenuItem.Name = "publishersToolStripMenuItem";
            publishersToolStripMenuItem.Size = new Size(132, 54);
            publishersToolStripMenuItem.Text = "Publishers";
            // 
            // addPublisherToolStripMenuItem
            // 
            addPublisherToolStripMenuItem.Image = (Image)resources.GetObject("addPublisherToolStripMenuItem.Image");
            addPublisherToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addPublisherToolStripMenuItem.Name = "addPublisherToolStripMenuItem";
            addPublisherToolStripMenuItem.Size = new Size(214, 56);
            addPublisherToolStripMenuItem.Text = "Add Publisher";
            addPublisherToolStripMenuItem.Click += addPublisherToolStripMenuItem_Click;
            // 
            // viewPublishersToolStripMenuItem
            // 
            viewPublishersToolStripMenuItem.Image = (Image)resources.GetObject("viewPublishersToolStripMenuItem.Image");
            viewPublishersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewPublishersToolStripMenuItem.Name = "viewPublishersToolStripMenuItem";
            viewPublishersToolStripMenuItem.Size = new Size(214, 56);
            viewPublishersToolStripMenuItem.Text = "View Publishers";
            viewPublishersToolStripMenuItem.Click += viewPublishersToolStripMenuItem_Click;
            // 
            // issueBookToolStripMenuItem
            // 
            issueBookToolStripMenuItem.Image = (Image)resources.GetObject("issueBookToolStripMenuItem.Image");
            issueBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            issueBookToolStripMenuItem.Size = new Size(136, 54);
            issueBookToolStripMenuItem.Text = "Issue Book";
            issueBookToolStripMenuItem.Click += issueBookToolStripMenuItem_Click;
            // 
            // returnBookToolStripMenuItem
            // 
            returnBookToolStripMenuItem.Image = (Image)resources.GetObject("returnBookToolStripMenuItem.Image");
            returnBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            returnBookToolStripMenuItem.Size = new Size(146, 54);
            returnBookToolStripMenuItem.Text = "Return Book";
            returnBookToolStripMenuItem.Click += returnBookToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(92, 54);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addNewBookToolStripMenuItem;
        private ToolStripMenuItem viewBookToolStripMenuItem;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem viewMemberInfoToolStripMenuItem;
        private ToolStripMenuItem issueBookToolStripMenuItem;
        private ToolStripMenuItem returnBookToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem publishersToolStripMenuItem;
        private ToolStripMenuItem addPublisherToolStripMenuItem;
        private ToolStripMenuItem viewPublishersToolStripMenuItem;
    }
}