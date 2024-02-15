namespace WinFormsApp4
{
    partial class Addbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addbook));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            cancel = new Button();
            save = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtauthoe = new TextBox();
            txtpublish = new TextBox();
            txtquantity = new TextBox();
            txtprice = new TextBox();
            txtBookname = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtbid = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(636, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(293, 37);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 0;
            label1.Text = "Add Book";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(txtbid);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(cancel);
            panel2.Controls.Add(save);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtauthoe);
            panel2.Controls.Add(txtpublish);
            panel2.Controls.Add(txtquantity);
            panel2.Controls.Add(txtprice);
            panel2.Controls.Add(txtBookname);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-1, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(636, 329);
            panel2.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(26, 12);
            label8.Name = "label8";
            label8.Size = new Size(58, 17);
            label8.TabIndex = 15;
            label8.Text = "Book Id:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(474, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // cancel
            // 
            cancel.FlatStyle = FlatStyle.Popup;
            cancel.Location = new Point(486, 291);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 13;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // save
            // 
            save.FlatStyle = FlatStyle.Popup;
            save.Location = new Point(367, 291);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 12;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += button_save;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(180, 162);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // txtauthoe
            // 
            txtauthoe.Location = new Point(180, 81);
            txtauthoe.Name = "txtauthoe";
            txtauthoe.Size = new Size(230, 23);
            txtauthoe.TabIndex = 10;
            // 
            // txtpublish
            // 
            txtpublish.Location = new Point(180, 124);
            txtpublish.Name = "txtpublish";
            txtpublish.Size = new Size(230, 23);
            txtpublish.TabIndex = 9;
            // 
            // txtquantity
            // 
            txtquantity.Location = new Point(180, 234);
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(230, 23);
            txtquantity.TabIndex = 8;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(182, 200);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(230, 23);
            txtprice.TabIndex = 7;
            // 
            // txtBookname
            // 
            txtBookname.Location = new Point(180, 45);
            txtBookname.Name = "txtBookname";
            txtBookname.Size = new Size(230, 23);
            txtBookname.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(26, 84);
            label7.Name = "label7";
            label7.Size = new Size(129, 17);
            label7.TabIndex = 5;
            label7.Text = "Book Author Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(26, 128);
            label6.Name = "label6";
            label6.Size = new Size(113, 17);
            label6.TabIndex = 4;
            label6.Text = "Book Publication:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(23, 168);
            label5.Name = "label5";
            label5.Size = new Size(132, 17);
            label5.TabIndex = 3;
            label5.Text = "Book Purchase date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 200);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 2;
            label4.Text = "Book price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 239);
            label3.Name = "label3";
            label3.Size = new Size(99, 17);
            label3.TabIndex = 1;
            label3.Text = "Book Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 46);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 0;
            label2.Text = "Book Name:";
            // 
            // txtbid
            // 
            txtbid.Location = new Point(178, 11);
            txtbid.Name = "txtbid";
            txtbid.Size = new Size(230, 23);
            txtbid.TabIndex = 16;
            // 
            // Addbook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(634, 428);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Addbook";
            Text = "Addbook";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox txtauthoe;
        private TextBox txtpublish;
        private TextBox txtquantity;
        private TextBox txtprice;
        private TextBox txtBookname;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Button cancel;
        private Button save;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private TextBox txtbid;
    }
}