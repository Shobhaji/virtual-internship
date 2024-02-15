namespace WinFormsApp4
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtbookname = new TextBox();
            btnrefresh = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            txtdate = new TextBox();
            btndelete = new Button();
            btncancel = new Button();
            txtauthorname = new TextBox();
            txtpublish = new TextBox();
            txtprice = new TextBox();
            txtquan = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnupdate = new Button();
            txtname = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(901, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(510, 41);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 1;
            label1.Text = "View Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(331, -31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(169, 148);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 1;
            label2.Text = "Book Name:";
            // 
            // txtbookname
            // 
            txtbookname.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtbookname.Location = new Point(296, 148);
            txtbookname.Name = "txtbookname";
            txtbookname.Size = new Size(212, 25);
            txtbookname.TabIndex = 2;
            txtbookname.TextChanged += txtbookname_TextChanged;
            // 
            // btnrefresh
            // 
            btnrefresh.FlatStyle = FlatStyle.Popup;
            btnrefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnrefresh.Location = new Point(521, 150);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(96, 25);
            btnrefresh.TabIndex = 3;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 181);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(901, 267);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(txtdate);
            panel2.Controls.Add(btndelete);
            panel2.Controls.Add(btncancel);
            panel2.Controls.Add(txtauthorname);
            panel2.Controls.Add(txtpublish);
            panel2.Controls.Add(txtprice);
            panel2.Controls.Add(txtquan);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnupdate);
            panel2.Controls.Add(txtname);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(2, 480);
            panel2.Name = "panel2";
            panel2.Size = new Size(889, 260);
            panel2.TabIndex = 5;
            // 
            // txtdate
            // 
            txtdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtdate.Location = new Point(653, 26);
            txtdate.Name = "txtdate";
            txtdate.Size = new Size(200, 25);
            txtdate.TabIndex = 15;
            // 
            // btndelete
            // 
            btndelete.FlatStyle = FlatStyle.Popup;
            btndelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btndelete.Location = new Point(569, 216);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(105, 23);
            btndelete.TabIndex = 14;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btncancel
            // 
            btncancel.FlatStyle = FlatStyle.Popup;
            btncancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncancel.Location = new Point(726, 216);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(102, 23);
            btncancel.TabIndex = 13;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // txtauthorname
            // 
            txtauthorname.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtauthorname.Location = new Point(182, 75);
            txtauthorname.Name = "txtauthorname";
            txtauthorname.Size = new Size(187, 25);
            txtauthorname.TabIndex = 12;
            // 
            // txtpublish
            // 
            txtpublish.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtpublish.Location = new Point(184, 128);
            txtpublish.Name = "txtpublish";
            txtpublish.Size = new Size(187, 25);
            txtpublish.TabIndex = 11;
            // 
            // txtprice
            // 
            txtprice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtprice.Location = new Point(652, 81);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(200, 25);
            txtprice.TabIndex = 10;
            // 
            // txtquan
            // 
            txtquan.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtquan.Location = new Point(652, 132);
            txtquan.Name = "txtquan";
            txtquan.Size = new Size(200, 25);
            txtquan.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(30, 75);
            label8.Name = "label8";
            label8.Size = new Size(146, 21);
            label8.TabIndex = 8;
            label8.Text = "Book Author Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(30, 129);
            label7.Name = "label7";
            label7.Size = new Size(132, 21);
            label7.TabIndex = 7;
            label7.Text = "Book Publication::";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(484, 29);
            label6.Name = "label6";
            label6.Size = new Size(151, 21);
            label6.TabIndex = 6;
            label6.Text = "Book Purchase Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(484, 82);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 5;
            label5.Text = "Book Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(484, 132);
            label4.Name = "label4";
            label4.Size = new Size(112, 21);
            label4.TabIndex = 4;
            label4.Text = "Book Quantity:";
            // 
            // btnupdate
            // 
            btnupdate.FlatStyle = FlatStyle.Popup;
            btnupdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnupdate.Location = new Point(424, 216);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(102, 23);
            btnupdate.TabIndex = 2;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtname.Location = new Point(184, 23);
            txtname.Name = "txtname";
            txtname.Size = new Size(187, 25);
            txtname.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 25);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 0;
            label3.Text = "Book Name:";
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(900, 450);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(btnrefresh);
            Controls.Add(txtbookname);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "ViewBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBook";
            Load += ViewBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private TextBox txtbookname;
        private Button btnrefresh;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btnupdate;
        private TextBox txtname;
        private Label label3;
        private TextBox txtauthorname;
        private TextBox txtpublish;
        private TextBox txtprice;
        private TextBox txtquan;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btndelete;
        private Button btncancel;
        private TextBox txtdate;
    }
}