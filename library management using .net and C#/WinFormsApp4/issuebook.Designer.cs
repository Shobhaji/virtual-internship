namespace WinFormsApp4
{
    partial class issuebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(issuebook));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnrefresh = new Button();
            btnexit = new Button();
            btnsearch = new Button();
            label2 = new Label();
            txtenroll = new TextBox();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            comboBox1 = new ComboBox();
            btnissuebook = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtsname = new TextBox();
            txtdepart = new TextBox();
            txtsem = new TextBox();
            txtcontact = new TextBox();
            txtemail = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(11, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 131);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Turquoise;
            label1.Location = new Point(419, 58);
            label1.Name = "label1";
            label1.Size = new Size(128, 30);
            label1.TabIndex = 1;
            label1.Text = "Issue Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(194, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(btnrefresh);
            panel2.Controls.Add(btnexit);
            panel2.Controls.Add(btnsearch);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtenroll);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(12, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 345);
            panel2.TabIndex = 1;
            // 
            // btnrefresh
            // 
            btnrefresh.FlatStyle = FlatStyle.Popup;
            btnrefresh.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnrefresh.Location = new Point(36, 293);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(75, 34);
            btnrefresh.TabIndex = 4;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += button3_Click;
            // 
            // btnexit
            // 
            btnexit.FlatStyle = FlatStyle.Popup;
            btnexit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnexit.Location = new Point(138, 292);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(75, 34);
            btnexit.TabIndex = 3;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // btnsearch
            // 
            btnsearch.FlatStyle = FlatStyle.Popup;
            btnsearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnsearch.Location = new Point(67, 224);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(123, 32);
            btnsearch.TabIndex = 0;
            btnsearch.Text = "Search Student";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(73, 150);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 2;
            label2.Text = "Enrollment No";
            // 
            // txtenroll
            // 
            txtenroll.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtenroll.Location = new Point(57, 184);
            txtenroll.Name = "txtenroll";
            txtenroll.Size = new Size(140, 25);
            txtenroll.TabIndex = 1;
            txtenroll.TextChanged += txtenroll_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(82, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(192, 255, 255);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(btnissuebook);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(txtsname);
            panel3.Controls.Add(txtdepart);
            panel3.Controls.Add(txtsem);
            panel3.Controls.Add(txtcontact);
            panel3.Controls.Add(txtemail);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(273, 138);
            panel3.Name = "panel3";
            panel3.Size = new Size(534, 345);
            panel3.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(195, 214);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 25);
            comboBox1.TabIndex = 18;
            // 
            // btnissuebook
            // 
            btnissuebook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnissuebook.FlatStyle = FlatStyle.Popup;
            btnissuebook.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnissuebook.Location = new Point(381, 282);
            btnissuebook.Name = "btnissuebook";
            btnissuebook.Size = new Size(124, 34);
            btnissuebook.TabIndex = 17;
            btnissuebook.Text = "Issue  Book";
            btnissuebook.UseVisualStyleBackColor = true;
            btnissuebook.Click += btnissuebook_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(195, 250);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // txtsname
            // 
            txtsname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtsname.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtsname.Location = new Point(193, 18);
            txtsname.Name = "txtsname";
            txtsname.ReadOnly = true;
            txtsname.Size = new Size(220, 25);
            txtsname.TabIndex = 15;
            // 
            // txtdepart
            // 
            txtdepart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtdepart.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtdepart.Location = new Point(193, 56);
            txtdepart.Name = "txtdepart";
            txtdepart.ReadOnly = true;
            txtdepart.Size = new Size(220, 25);
            txtdepart.TabIndex = 14;
            // 
            // txtsem
            // 
            txtsem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtsem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtsem.Location = new Point(193, 97);
            txtsem.Name = "txtsem";
            txtsem.ReadOnly = true;
            txtsem.Size = new Size(220, 25);
            txtsem.TabIndex = 13;
            txtsem.TextChanged += textBox5_TextChanged;
            // 
            // txtcontact
            // 
            txtcontact.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtcontact.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtcontact.Location = new Point(193, 136);
            txtcontact.Name = "txtcontact";
            txtcontact.ReadOnly = true;
            txtcontact.Size = new Size(220, 25);
            txtcontact.TabIndex = 12;
            // 
            // txtemail
            // 
            txtemail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtemail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtemail.Location = new Point(194, 172);
            txtemail.Name = "txtemail";
            txtemail.ReadOnly = true;
            txtemail.Size = new Size(218, 25);
            txtemail.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(22, 18);
            label9.Name = "label9";
            label9.Size = new Size(119, 21);
            label9.TabIndex = 9;
            label9.Text = "Student Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(22, 59);
            label8.Name = "label8";
            label8.Size = new Size(102, 21);
            label8.TabIndex = 8;
            label8.Text = "Department:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(22, 99);
            label7.Name = "label7";
            label7.Size = new Size(146, 21);
            label7.TabIndex = 7;
            label7.Text = "Student Semester:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 137);
            label6.Name = "label6";
            label6.Size = new Size(133, 21);
            label6.TabIndex = 6;
            label6.Text = "Student Contact:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 173);
            label5.Name = "label5";
            label5.Size = new Size(114, 21);
            label5.TabIndex = 5;
            label5.Text = "Student Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 212);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 4;
            label4.Text = "Book Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 248);
            label3.Name = "label3";
            label3.Size = new Size(130, 21);
            label3.TabIndex = 3;
            label3.Text = "Book Issue date:";
            // 
            // issuebook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(816, 494);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "issuebook";
            Text = "issuebook";
            Load += issuebook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Button btnrefresh;
        private Button btnexit;
        private Button btnsearch;
        private Label label2;
        private TextBox txtenroll;
        private PictureBox pictureBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtsname;
        private TextBox txtdepart;
        private TextBox txtsem;
        private TextBox txtcontact;
        private TextBox txtemail;
        private Button btnissuebook;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
    }
}