namespace RestaurentManagementSystem
{
    partial class CashierMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customer_Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.logout_Btn = new System.Windows.Forms.Button();
            this.Order_Btn = new System.Windows.Forms.Button();
            this.addProducts_Btn = new System.Windows.Forms.Button();
            this.dashboard_Btn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminDashboardForm1 = new RestaurentManagementSystem.AdminDashboardForm();
            this.adminAddProducts1 = new RestaurentManagementSystem.AdminAddProducts();
            this.cashierOrderForm1 = new RestaurentManagementSystem.CashierOrderForm();
            this.cashierCustomersForm1 = new RestaurentManagementSystem.CashierCustomersForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(224)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 45);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = " Restaurant Management System";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1444, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 27);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(126)))), ((int)(((byte)(188)))));
            this.panel2.Controls.Add(this.customer_Btn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.logout_Btn);
            this.panel2.Controls.Add(this.Order_Btn);
            this.panel2.Controls.Add(this.addProducts_Btn);
            this.panel2.Controls.Add(this.dashboard_Btn);
            this.panel2.Controls.Add(this.username);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 745);
            this.panel2.TabIndex = 4;
            // 
            // customer_Btn
            // 
            this.customer_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(126)))), ((int)(((byte)(188)))));
            this.customer_Btn.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_Btn.ForeColor = System.Drawing.Color.White;
            this.customer_Btn.Location = new System.Drawing.Point(35, 573);
            this.customer_Btn.Name = "customer_Btn";
            this.customer_Btn.Size = new System.Drawing.Size(282, 46);
            this.customer_Btn.TabIndex = 21;
            this.customer_Btn.Text = "Customers";
            this.customer_Btn.UseVisualStyleBackColor = false;
            this.customer_Btn.Click += new System.EventHandler(this.customer_Btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gotham", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(63, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 30);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cashier\'s Portal";
            // 
            // logout_Btn
            // 
            this.logout_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(126)))), ((int)(((byte)(188)))));
            this.logout_Btn.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_Btn.ForeColor = System.Drawing.Color.White;
            this.logout_Btn.Location = new System.Drawing.Point(35, 640);
            this.logout_Btn.Name = "logout_Btn";
            this.logout_Btn.Size = new System.Drawing.Size(282, 46);
            this.logout_Btn.TabIndex = 19;
            this.logout_Btn.Text = "Logout";
            this.logout_Btn.UseVisualStyleBackColor = false;
            this.logout_Btn.Click += new System.EventHandler(this.logout_Btn_Click);
            // 
            // Order_Btn
            // 
            this.Order_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(126)))), ((int)(((byte)(188)))));
            this.Order_Btn.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_Btn.ForeColor = System.Drawing.Color.White;
            this.Order_Btn.Location = new System.Drawing.Point(35, 512);
            this.Order_Btn.Name = "Order_Btn";
            this.Order_Btn.Size = new System.Drawing.Size(282, 46);
            this.Order_Btn.TabIndex = 18;
            this.Order_Btn.Text = "Order";
            this.Order_Btn.UseVisualStyleBackColor = false;
            this.Order_Btn.Click += new System.EventHandler(this.Order_Btn_Click);
            // 
            // addProducts_Btn
            // 
            this.addProducts_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(126)))), ((int)(((byte)(188)))));
            this.addProducts_Btn.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_Btn.ForeColor = System.Drawing.Color.White;
            this.addProducts_Btn.Location = new System.Drawing.Point(35, 449);
            this.addProducts_Btn.Name = "addProducts_Btn";
            this.addProducts_Btn.Size = new System.Drawing.Size(282, 46);
            this.addProducts_Btn.TabIndex = 17;
            this.addProducts_Btn.Text = "Add Products";
            this.addProducts_Btn.UseVisualStyleBackColor = false;
            this.addProducts_Btn.Click += new System.EventHandler(this.addProducts_Btn_Click);
            // 
            // dashboard_Btn
            // 
            this.dashboard_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(126)))), ((int)(((byte)(188)))));
            this.dashboard_Btn.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_Btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_Btn.Location = new System.Drawing.Point(35, 386);
            this.dashboard_Btn.Name = "dashboard_Btn";
            this.dashboard_Btn.Size = new System.Drawing.Size(282, 46);
            this.dashboard_Btn.TabIndex = 15;
            this.dashboard_Btn.Text = "Dashboard";
            this.dashboard_Btn.UseVisualStyleBackColor = false;
            this.dashboard_Btn.Click += new System.EventHandler(this.dashboard_Btn_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(168, 332);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(72, 24);
            this.username.TabIndex = 14;
            this.username.Text = "Cashier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestaurentManagementSystem.Properties.Resources.rest;
            this.pictureBox1.Location = new System.Drawing.Point(65, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.adminDashboardForm1);
            this.panel3.Controls.Add(this.adminAddProducts1);
            this.panel3.Controls.Add(this.cashierOrderForm1);
            this.panel3.Controls.Add(this.cashierCustomersForm1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(348, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1152, 745);
            this.panel3.TabIndex = 5;
            // 
            // adminDashboardForm1
            // 
            this.adminDashboardForm1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.adminDashboardForm1.Location = new System.Drawing.Point(0, 0);
            this.adminDashboardForm1.Name = "adminDashboardForm1";
            this.adminDashboardForm1.Size = new System.Drawing.Size(1152, 745);
            this.adminDashboardForm1.TabIndex = 3;
            this.adminDashboardForm1.Load += new System.EventHandler(this.adminDashboardForm1_Load);
            // 
            // adminAddProducts1
            // 
            this.adminAddProducts1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.adminAddProducts1.Location = new System.Drawing.Point(0, 0);
            this.adminAddProducts1.Name = "adminAddProducts1";
            this.adminAddProducts1.Size = new System.Drawing.Size(1152, 745);
            this.adminAddProducts1.TabIndex = 2;
            // 
            // cashierOrderForm1
            // 
            this.cashierOrderForm1.Location = new System.Drawing.Point(0, 0);
            this.cashierOrderForm1.Name = "cashierOrderForm1";
            this.cashierOrderForm1.Size = new System.Drawing.Size(1134, 715);
            this.cashierOrderForm1.TabIndex = 1;
            // 
            // cashierCustomersForm1
            // 
            this.cashierCustomersForm1.Location = new System.Drawing.Point(0, 0);
            this.cashierCustomersForm1.Name = "cashierCustomersForm1";
            this.cashierCustomersForm1.Size = new System.Drawing.Size(1134, 715);
            this.cashierCustomersForm1.TabIndex = 0;
            // 
            // CashierMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 790);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashierMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierMainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logout_Btn;
        private System.Windows.Forms.Button Order_Btn;
        private System.Windows.Forms.Button addProducts_Btn;
        private System.Windows.Forms.Button dashboard_Btn;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button customer_Btn;
        private System.Windows.Forms.Panel panel3;
        private AdminDashboardForm adminDashboardForm1;
        private AdminAddProducts adminAddProducts1;
        private CashierOrderForm cashierOrderForm1;
        private CashierCustomersForm cashierCustomersForm1;
    }
}