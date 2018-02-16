namespace IS_Project
{
    partial class add
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.field1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tutor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.discription = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.courselink = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edate = new System.Windows.Forms.DateTimePicker();
            this.sdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.assigno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.examno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lecno = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::IS_Project.Properties.Resources.rect48;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.field1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tutor);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.discription);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.courselink);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.edate);
            this.panel1.Controls.Add(this.sdate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.assigno);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.examno);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lecno);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(38, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 437);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(396, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 32);
            this.button2.TabIndex = 23;
            this.button2.Text = "Main Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(511, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 33);
            this.button1.TabIndex = 22;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(384, 347);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(57, 15);
            this.linkLabel2.TabIndex = 21;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Add Field";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // field1
            // 
            this.field1.FormattingEnabled = true;
            this.field1.Location = new System.Drawing.Point(156, 344);
            this.field1.Name = "field1";
            this.field1.Size = new System.Drawing.Size(200, 23);
            this.field1.TabIndex = 19;
            this.field1.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Field";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // tutor
            // 
            this.tutor.FormattingEnabled = true;
            this.tutor.Location = new System.Drawing.Point(156, 315);
            this.tutor.Name = "tutor";
            this.tutor.Size = new System.Drawing.Size(200, 23);
            this.tutor.TabIndex = 17;
            this.tutor.SelectedIndexChanged += new System.EventHandler(this.tutor_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tutor";
            // 
            // discription
            // 
            this.discription.Location = new System.Drawing.Point(156, 220);
            this.discription.Name = "discription";
            this.discription.Size = new System.Drawing.Size(200, 80);
            this.discription.TabIndex = 15;
            this.discription.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Description";
            // 
            // courselink
            // 
            this.courselink.Location = new System.Drawing.Point(156, 191);
            this.courselink.Name = "courselink";
            this.courselink.Size = new System.Drawing.Size(200, 23);
            this.courselink.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Course Link";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "End Date";
            // 
            // edate
            // 
            this.edate.Location = new System.Drawing.Point(156, 162);
            this.edate.Name = "edate";
            this.edate.Size = new System.Drawing.Size(200, 23);
            this.edate.TabIndex = 10;
            // 
            // sdate
            // 
            this.sdate.Location = new System.Drawing.Point(156, 133);
            this.sdate.Name = "sdate";
            this.sdate.Size = new System.Drawing.Size(200, 23);
            this.sdate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Start Date";
            // 
            // assigno
            // 
            this.assigno.Location = new System.Drawing.Point(156, 104);
            this.assigno.Name = "assigno";
            this.assigno.Size = new System.Drawing.Size(200, 23);
            this.assigno.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Assignments Number";
            // 
            // examno
            // 
            this.examno.Location = new System.Drawing.Point(156, 75);
            this.examno.Name = "examno";
            this.examno.Size = new System.Drawing.Size(200, 23);
            this.examno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Exams Number";
            // 
            // lecno
            // 
            this.lecno.Location = new System.Drawing.Point(156, 46);
            this.lecno.Name = "lecno";
            this.lecno.Size = new System.Drawing.Size(200, 23);
            this.lecno.TabIndex = 3;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.name.Location = new System.Drawing.Point(156, 16);
            this.name.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 23);
            this.name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lectures Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IS_Project.Properties.Resources.hh1;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.panel1);
            this.Name = "add";
            this.Text = "add";
            this.Load += new System.EventHandler(this.add_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox lecno;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox courselink;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker edate;
        private System.Windows.Forms.DateTimePicker sdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox assigno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox examno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox discription;
        private System.Windows.Forms.ComboBox field1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox tutor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button2;
    }
}