namespace IS_Project
{
    partial class course
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(course));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.review = new System.Windows.Forms.Button();
            this.reviewCourse = new System.Windows.Forms.TextBox();
            this.rate = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Button();
            this.rateCourse = new System.Windows.Forms.DomainUpDown();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::IS_Project.Properties.Resources.rect48;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.review);
            this.panel1.Controls.Add(this.reviewCourse);
            this.panel1.Controls.Add(this.rate);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.rateCourse);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(42, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 437);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightCoral;
            this.button2.Location = new System.Drawing.Point(538, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 27);
            this.button2.TabIndex = 13;
            this.button2.Text = "Main Menu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // review
            // 
            this.review.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.review.BackColor = System.Drawing.Color.Transparent;
            this.review.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.review.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review.ForeColor = System.Drawing.Color.LightCoral;
            this.review.Location = new System.Drawing.Point(538, 277);
            this.review.Name = "review";
            this.review.Size = new System.Drawing.Size(108, 28);
            this.review.TabIndex = 12;
            this.review.Text = "Review";
            this.review.UseVisualStyleBackColor = false;
            this.review.Click += new System.EventHandler(this.review_Click_1);
            // 
            // reviewCourse
            // 
            this.reviewCourse.BackColor = System.Drawing.SystemColors.Window;
            this.reviewCourse.Location = new System.Drawing.Point(291, 283);
            this.reviewCourse.Name = "reviewCourse";
            this.reviewCourse.Size = new System.Drawing.Size(213, 26);
            this.reviewCourse.TabIndex = 11;
            // 
            // rate
            // 
            this.rate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rate.BackColor = System.Drawing.Color.Transparent;
            this.rate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rate.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate.ForeColor = System.Drawing.Color.LightCoral;
            this.rate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rate.Location = new System.Drawing.Point(538, 228);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(108, 29);
            this.rate.TabIndex = 10;
            this.rate.Text = "Rate";
            this.rate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rate.UseVisualStyleBackColor = false;
            this.rate.Click += new System.EventHandler(this.rate_Click_1);
            // 
            // description
            // 
            this.description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.description.BackColor = System.Drawing.Color.Transparent;
            this.description.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.description.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.LightCoral;
            this.description.Location = new System.Drawing.Point(510, 101);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(136, 29);
            this.description.TabIndex = 9;
            this.description.Text = "Show Description";
            this.description.UseVisualStyleBackColor = false;
            this.description.Click += new System.EventHandler(this.description_Click_1);
            // 
            // rateCourse
            // 
            this.rateCourse.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rateCourse.ForeColor = System.Drawing.Color.LightCoral;
            this.rateCourse.Items.Add("1");
            this.rateCourse.Items.Add("2");
            this.rateCourse.Items.Add("3");
            this.rateCourse.Items.Add("4");
            this.rateCourse.Items.Add("5");
            this.rateCourse.Location = new System.Drawing.Point(384, 232);
            this.rateCourse.Name = "rateCourse";
            this.rateCourse.Size = new System.Drawing.Size(120, 26);
            this.rateCourse.TabIndex = 8;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.NullValue = null;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(13, 22);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(491, 197);
            this.dgv.TabIndex = 7;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(538, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Certificate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(384, 329);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 26);
            this.textBox1.TabIndex = 15;
            // 
            // course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.panel1);
            this.Name = "course";
            this.Text = "course";
            this.Load += new System.EventHandler(this.course_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button review;
        private System.Windows.Forms.TextBox reviewCourse;
        private System.Windows.Forms.Button rate;
        private System.Windows.Forms.Button description;
        private System.Windows.Forms.DomainUpDown rateCourse;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}