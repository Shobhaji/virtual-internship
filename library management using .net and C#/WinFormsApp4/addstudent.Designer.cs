namespace WinFormsApp4
{
    partial class addstudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addstudent));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnsave = new Button();
            exit = new Button();
            txteno = new TextBox();
            txtdepart = new TextBox();
            txtsem = new TextBox();
            txtemail = new TextBox();
            txtcontact = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnrefresh = new Button();
            txtsname = new TextBox();
            label2 = new Label();
            label8 = new Label();
            txtsid = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(691, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(396, 42);
            label1.Name = "label1";
            label1.Size = new Size(137, 30);
            label1.TabIndex = 1;
            label1.Text = "Add Student";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(240, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 99);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(238, 381);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Aqua;
            panel2.Controls.Add(txtsid);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnsave);
            panel2.Controls.Add(exit);
            panel2.Controls.Add(txteno);
            panel2.Controls.Add(txtdepart);
            panel2.Controls.Add(txtsem);
            panel2.Controls.Add(txtemail);
            panel2.Controls.Add(txtcontact);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnrefresh);
            panel2.Controls.Add(txtsname);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(241, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 381);
            panel2.TabIndex = 2;
            // 
            // btnsave
            // 
            btnsave.FlatStyle = FlatStyle.Popup;
            btnsave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsave.Location = new Point(206, 292);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(75, 33);
            btnsave.TabIndex = 14;
            btnsave.Text = "Save info";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // exit
            // 
            exit.FlatStyle = FlatStyle.Popup;
            exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exit.Location = new Point(307, 292);
            exit.Name = "exit";
            exit.Size = new Size(75, 33);
            exit.TabIndex = 13;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += button2_Click;
            // 
            // txteno
            // 
            txteno.Location = new Point(177, 88);
            txteno.Name = "txteno";
            txteno.Size = new Size(207, 23);
            txteno.TabIndex = 12;
            // 
            // txtdepart
            // 
            txtdepart.Location = new Point(178, 129);
            txtdepart.Name = "txtdepart";
            txtdepart.Size = new Size(204, 23);
            txtdepart.TabIndex = 11;
            // 
            // txtsem
            // 
            txtsem.Location = new Point(177, 168);
            txtsem.Name = "txtsem";
            txtsem.Size = new Size(204, 23);
            txtsem.TabIndex = 10;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(175, 244);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(204, 23);
            txtemail.TabIndex = 9;
            // 
            // txtcontact
            // 
            txtcontact.Location = new Point(178, 210);
            txtcontact.Name = "txtcontact";
            txtcontact.Size = new Size(204, 23);
            txtcontact.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(21, 245);
            label7.Name = "label7";
            label7.Size = new Size(114, 21);
            label7.TabIndex = 7;
            label7.Text = "Student Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(20, 208);
            label6.Name = "label6";
            label6.Size = new Size(129, 21);
            label6.TabIndex = 6;
            label6.Text = "Student Contact:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(21, 90);
            label5.Name = "label5";
            label5.Size = new Size(122, 21);
            label5.TabIndex = 5;
            label5.Text = "Enrollment No.:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(22, 131);
            label4.Name = "label4";
            label4.Size = new Size(101, 21);
            label4.TabIndex = 4;
            label4.Text = "Department:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(21, 171);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 3;
            label3.Text = "Student Semester:";
            // 
            // btnrefresh
            // 
            btnrefresh.FlatStyle = FlatStyle.Popup;
            btnrefresh.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnrefresh.Location = new Point(103, 292);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(75, 33);
            btnrefresh.TabIndex = 2;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // txtsname
            // 
            txtsname.Location = new Point(175, 46);
            txtsname.Name = "txtsname";
            txtsname.Size = new Size(207, 23);
            txtsname.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(21, 48);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 0;
            label2.Text = "Student Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(21, 9);
            label8.Name = "label8";
            label8.Size = new Size(87, 21);
            label8.TabIndex = 15;
            label8.Text = "Student Id:";
            // 
            // txtsid
            // 
            txtsid.Location = new Point(175, 7);
            txtsid.Name = "txtsid";
            txtsid.Size = new Size(207, 23);
            txtsid.TabIndex = 16;
            // 
            // addstudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 475);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "addstudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addstudent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button btnrefresh;
        private TextBox txtsname;
        private Label label2;
        private TextBox txteno;
        private TextBox txtdepart;
        private TextBox txtsem;
        private TextBox txtemail;
        private TextBox txtcontact;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnsave;
        private Button exit;
        private TextBox txtsid;
        private Label label8;
    }
}