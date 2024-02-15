namespace WinFormsApp4
{
    partial class Viewstudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewstudent));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtsearch = new TextBox();
            btnrefresh = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            Delete = new Button();
            btncancel = new Button();
            Update = new Button();
            ttxteno = new TextBox();
            txtdepart = new TextBox();
            txtsem = new TextBox();
            txtcontact = new TextBox();
            txtemail = new TextBox();
            txtsname = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-6, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 130);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(347, -15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumTurquoise;
            label1.Location = new Point(522, 33);
            label1.Name = "label1";
            label1.Size = new Size(67, 30);
            label1.TabIndex = 1;
            label1.Text = "View ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumTurquoise;
            label2.Location = new Point(522, 64);
            label2.Name = "label2";
            label2.Size = new Size(90, 30);
            label2.TabIndex = 2;
            label2.Text = "Student";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(124, 150);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 3;
            label3.Text = "Enrollment No.:";
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtsearch.Location = new Point(300, 150);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(219, 25);
            txtsearch.TabIndex = 4;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // btnrefresh
            // 
            btnrefresh.FlatStyle = FlatStyle.Popup;
            btnrefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnrefresh.Location = new Point(568, 150);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(105, 25);
            btnrefresh.TabIndex = 5;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-6, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(883, 182);
            dataGridView1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Controls.Add(Delete);
            panel2.Controls.Add(btncancel);
            panel2.Controls.Add(Update);
            panel2.Controls.Add(ttxteno);
            panel2.Controls.Add(txtdepart);
            panel2.Controls.Add(txtsem);
            panel2.Controls.Add(txtcontact);
            panel2.Controls.Add(txtemail);
            panel2.Controls.Add(txtsname);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(2, 383);
            panel2.Name = "panel2";
            panel2.Size = new Size(865, 361);
            panel2.TabIndex = 7;
            // 
            // Delete
            // 
            Delete.FlatStyle = FlatStyle.Popup;
            Delete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.Location = new Point(562, 279);
            Delete.Name = "Delete";
            Delete.Size = new Size(113, 35);
            Delete.TabIndex = 14;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += button2_Click;
            // 
            // btncancel
            // 
            btncancel.FlatStyle = FlatStyle.Popup;
            btncancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btncancel.Location = new Point(718, 279);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(120, 35);
            btncancel.TabIndex = 13;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            Update.FlatStyle = FlatStyle.Popup;
            Update.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Update.Location = new Point(394, 279);
            Update.Name = "Update";
            Update.Size = new Size(108, 35);
            Update.TabIndex = 12;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            // 
            // ttxteno
            // 
            ttxteno.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ttxteno.Location = new Point(181, 131);
            ttxteno.Name = "ttxteno";
            ttxteno.Size = new Size(194, 25);
            ttxteno.TabIndex = 11;
            // 
            // txtdepart
            // 
            txtdepart.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtdepart.Location = new Point(181, 184);
            txtdepart.Name = "txtdepart";
            txtdepart.Size = new Size(194, 25);
            txtdepart.TabIndex = 10;
            // 
            // txtsem
            // 
            txtsem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtsem.Location = new Point(620, 73);
            txtsem.Name = "txtsem";
            txtsem.Size = new Size(194, 25);
            txtsem.TabIndex = 9;
            // 
            // txtcontact
            // 
            txtcontact.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtcontact.Location = new Point(620, 131);
            txtcontact.Name = "txtcontact";
            txtcontact.Size = new Size(194, 25);
            txtcontact.TabIndex = 8;
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtemail.Location = new Point(620, 184);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(194, 25);
            txtemail.TabIndex = 7;
            // 
            // txtsname
            // 
            txtsname.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtsname.Location = new Point(181, 73);
            txtsname.Name = "txtsname";
            txtsname.Size = new Size(194, 25);
            txtsname.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(10, 131);
            label9.Name = "label9";
            label9.Size = new Size(147, 25);
            label9.TabIndex = 5;
            label9.Text = "Enrollment No.:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(10, 184);
            label8.Name = "label8";
            label8.Size = new Size(122, 25);
            label8.TabIndex = 4;
            label8.Text = "Department:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(407, 73);
            label7.Name = "label7";
            label7.Size = new Size(168, 25);
            label7.TabIndex = 3;
            label7.Text = "Student Semester:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(407, 131);
            label6.Name = "label6";
            label6.Size = new Size(155, 25);
            label6.TabIndex = 2;
            label6.Text = "Student Contact:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(407, 184);
            label5.Name = "label5";
            label5.Size = new Size(135, 25);
            label5.TabIndex = 1;
            label5.Text = "Student Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 73);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 0;
            label4.Text = "Student Name:";
            // 
            // Viewstudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(884, 450);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(btnrefresh);
            Controls.Add(txtsearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Viewstudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Viewstudent";
            Load += Viewstudent_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtsearch;
        private Button btnrefresh;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button Delete;
        private Button btncancel;
        private Button Update;
        private TextBox ttxteno;
        private TextBox txtdepart;
        private TextBox txtsem;
        private TextBox txtcontact;
        private TextBox txtemail;
        private TextBox txtsname;
    }
}