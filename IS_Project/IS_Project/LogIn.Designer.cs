namespace IS_Project
{
    partial class login
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
            this.emailStudent = new System.Windows.Forms.TextBox();
            this.passstudent = new System.Windows.Forms.TextBox();
            this.login_S = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.signupstudent = new System.Windows.Forms.LinkLabel();
            this.login_EO = new System.Windows.Forms.Button();
            this.signupeo = new System.Windows.Forms.LinkLabel();
            this.passEO = new System.Windows.Forms.TextBox();
            this.emailEO = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailStudent
            // 
            this.emailStudent.Location = new System.Drawing.Point(86, 70);
            this.emailStudent.Name = "emailStudent";
            this.emailStudent.Size = new System.Drawing.Size(158, 26);
            this.emailStudent.TabIndex = 0;
            // 
            // passstudent
            // 
            this.passstudent.Location = new System.Drawing.Point(86, 111);
            this.passstudent.Name = "passstudent";
            this.passstudent.Size = new System.Drawing.Size(158, 26);
            this.passstudent.TabIndex = 1;
            this.passstudent.UseSystemPasswordChar = true;
            // 
            // login_S
            // 
            this.login_S.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_S.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_S.Location = new System.Drawing.Point(149, 143);
            this.login_S.Name = "login_S";
            this.login_S.Size = new System.Drawing.Size(79, 28);
            this.login_S.TabIndex = 4;
            this.login_S.Text = "Log In";
            this.login_S.UseVisualStyleBackColor = true;
            this.login_S.Click += new System.EventHandler(this.login_S_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(138, 383);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 6;
            // 
            // signupstudent
            // 
            this.signupstudent.ActiveLinkColor = System.Drawing.Color.Cyan;
            this.signupstudent.AutoSize = true;
            this.signupstudent.BackColor = System.Drawing.Color.Transparent;
            this.signupstudent.LinkColor = System.Drawing.Color.White;
            this.signupstudent.Location = new System.Drawing.Point(155, 174);
            this.signupstudent.Name = "signupstudent";
            this.signupstudent.Size = new System.Drawing.Size(59, 19);
            this.signupstudent.TabIndex = 9;
            this.signupstudent.TabStop = true;
            this.signupstudent.Text = "Sign UP";
            this.signupstudent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupstudent_LinkClicked);
            // 
            // login_EO
            // 
            this.login_EO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_EO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_EO.Location = new System.Drawing.Point(144, 143);
            this.login_EO.Name = "login_EO";
            this.login_EO.Size = new System.Drawing.Size(79, 28);
            this.login_EO.TabIndex = 5;
            this.login_EO.Text = "Log In";
            this.login_EO.UseVisualStyleBackColor = true;
            this.login_EO.Click += new System.EventHandler(this.login_EO_Click);
            // 
            // signupeo
            // 
            this.signupeo.ActiveLinkColor = System.Drawing.Color.Cyan;
            this.signupeo.AutoSize = true;
            this.signupeo.BackColor = System.Drawing.Color.Transparent;
            this.signupeo.LinkColor = System.Drawing.Color.White;
            this.signupeo.Location = new System.Drawing.Point(155, 174);
            this.signupeo.Name = "signupeo";
            this.signupeo.Size = new System.Drawing.Size(59, 19);
            this.signupeo.TabIndex = 10;
            this.signupeo.TabStop = true;
            this.signupeo.Text = "Sign UP";
            this.signupeo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupeo_LinkClicked);
            // 
            // passEO
            // 
            this.passEO.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.passEO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.passEO.Location = new System.Drawing.Point(86, 111);
            this.passEO.Name = "passEO";
            this.passEO.Size = new System.Drawing.Size(157, 26);
            this.passEO.TabIndex = 2;
            this.passEO.UseSystemPasswordChar = true;
            // 
            // emailEO
            // 
            this.emailEO.Location = new System.Drawing.Point(86, 70);
            this.emailEO.Name = "emailEO";
            this.emailEO.Size = new System.Drawing.Size(157, 26);
            this.emailEO.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::IS_Project.Properties.Resources.Untitled;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.signupstudent);
            this.panel1.Controls.Add(this.emailStudent);
            this.panel1.Controls.Add(this.login_S);
            this.panel1.Controls.Add(this.passstudent);
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(45, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 221);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Log In As Student";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Email :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::IS_Project.Properties.Resources.Untitled;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.signupeo);
            this.panel2.Controls.Add(this.emailEO);
            this.panel2.Controls.Add(this.passEO);
            this.panel2.Controls.Add(this.login_EO);
            this.panel2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.LightCoral;
            this.panel2.Location = new System.Drawing.Point(445, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 221);
            this.panel2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(15, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Log In As Eductional Organization";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Papyrus", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(86, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(554, 100);
            this.label7.TabIndex = 18;
            this.label7.Text = "MOOC System";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::IS_Project.Properties.Resources.hh2;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Name = "login";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Tag = "Log In";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailStudent;
        private System.Windows.Forms.TextBox passstudent;
        private System.Windows.Forms.Button login_S;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel signupstudent;
        private System.Windows.Forms.Button login_EO;
        private System.Windows.Forms.LinkLabel signupeo;
        private System.Windows.Forms.TextBox passEO;
        private System.Windows.Forms.TextBox emailEO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}