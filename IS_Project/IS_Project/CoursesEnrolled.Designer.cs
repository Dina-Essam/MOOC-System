namespace IS_Project
{
    partial class Courses_Enrolled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Courses_Enrolled));
            this.CoursesEnrolled = new System.Windows.Forms.ListBox();
            this.MainMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.CoursesEnrolled.Location = new System.Drawing.Point(19, 44);
            this.CoursesEnrolled.Name = "CoursesEnrolled";
            this.CoursesEnrolled.Size = new System.Drawing.Size(395, 276);
            this.CoursesEnrolled.TabIndex = 0;
            this.CoursesEnrolled.SelectedIndexChanged += new System.EventHandler(this.CoursesEnrolled_SelectedIndexChanged);
            // 
            // MainMenu
            // 
            this.MainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenu.BackColor = System.Drawing.Color.Transparent;
            this.MainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainMenu.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.ForeColor = System.Drawing.Color.LightCoral;
            this.MainMenu.Location = new System.Drawing.Point(511, 373);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(117, 32);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::IS_Project.Properties.Resources.rect48;
            this.panel1.Controls.Add(this.MainMenu);
            this.panel1.Controls.Add(this.CoursesEnrolled);
            this.panel1.Location = new System.Drawing.Point(39, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 437);
            this.panel1.TabIndex = 2;
            // 
            // Courses_Enrolled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.panel1);
            this.Name = "Courses_Enrolled";
            this.Text = "Courses Enrolled";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CoursesEnrolled;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Panel panel1;
    }
}

