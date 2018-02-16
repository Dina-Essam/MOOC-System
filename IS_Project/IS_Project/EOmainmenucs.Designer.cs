namespace IS_Project
{
    partial class EOmainmenucs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LOGOUT = new System.Windows.Forms.Button();
            this.CoursesEnrolled = new System.Windows.Forms.ListBox();
            this.ADDCOURSE = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::IS_Project.Properties.Resources.rect48;
            this.panel1.Controls.Add(this.ADDCOURSE);
            this.panel1.Controls.Add(this.LOGOUT);
            this.panel1.Controls.Add(this.CoursesEnrolled);
            this.panel1.Location = new System.Drawing.Point(40, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 437);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LOGOUT
            // 
            this.LOGOUT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LOGOUT.BackColor = System.Drawing.Color.Transparent;
            this.LOGOUT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LOGOUT.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGOUT.ForeColor = System.Drawing.Color.LightCoral;
            this.LOGOUT.Location = new System.Drawing.Point(511, 373);
            this.LOGOUT.Name = "LOGOUT";
            this.LOGOUT.Size = new System.Drawing.Size(117, 32);
            this.LOGOUT.TabIndex = 1;
            this.LOGOUT.Text = "Log Out";
            this.LOGOUT.UseVisualStyleBackColor = false;
            this.LOGOUT.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // CoursesEnrolled
            // 
            this.CoursesEnrolled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoursesEnrolled.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CoursesEnrolled.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoursesEnrolled.ForeColor = System.Drawing.Color.LightCoral;
            this.CoursesEnrolled.FormattingEnabled = true;
            this.CoursesEnrolled.ItemHeight = 34;
            this.CoursesEnrolled.Location = new System.Drawing.Point(29, 57);
            this.CoursesEnrolled.Name = "CoursesEnrolled";
            this.CoursesEnrolled.Size = new System.Drawing.Size(395, 276);
            this.CoursesEnrolled.TabIndex = 0;
            this.CoursesEnrolled.SelectedIndexChanged += new System.EventHandler(this.CoursesEnrolled_SelectedIndexChanged);
            // 
            // ADDCOURSE
            // 
            this.ADDCOURSE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ADDCOURSE.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDCOURSE.ForeColor = System.Drawing.Color.LightCoral;
            this.ADDCOURSE.Location = new System.Drawing.Point(511, 310);
            this.ADDCOURSE.Name = "ADDCOURSE";
            this.ADDCOURSE.Size = new System.Drawing.Size(117, 35);
            this.ADDCOURSE.TabIndex = 2;
            this.ADDCOURSE.Text = "ADD Course";
            this.ADDCOURSE.UseVisualStyleBackColor = true;
            this.ADDCOURSE.Click += new System.EventHandler(this.button1_Click);
            // 
            // EOmainmenucs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IS_Project.Properties.Resources.hh1;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.panel1);
            this.Name = "EOmainmenucs";
            this.Text = "EOmainmenucs";
            this.Load += new System.EventHandler(this.EOmainmenucs_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LOGOUT;
        private System.Windows.Forms.ListBox CoursesEnrolled;
        private System.Windows.Forms.Button ADDCOURSE;
    }
}