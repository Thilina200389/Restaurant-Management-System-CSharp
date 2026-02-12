namespace RestaurentManagementSystem
{
    partial class AdminAddProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminAddProducts_clearBtn = new System.Windows.Forms.Button();
            this.Admin_AddProducts_imageView = new System.Windows.Forms.PictureBox();
            this.Admin_AddProducts_importBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Admin_AddProducts_deleteBtn = new System.Windows.Forms.Button();
            this.Admin_AddProducts_updateBtn = new System.Windows.Forms.Button();
            this.Admin_AddProducts_addBtn = new System.Windows.Forms.Button();
            this.Admin_AddProducts_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Admin_AddProducts_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Admin_AddProducts_stock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Admin_AddProducts_type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Admin_AddProducts_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Admin_AddProducts_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_AddProducts_imageView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data of Products";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.Location = new System.Drawing.Point(254, 113);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.Size = new System.Drawing.Size(1116, 357);
            this.DataGridView1.TabIndex = 2;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DataGridView1);
            this.panel1.Location = new System.Drawing.Point(-234, -59);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1621, 489);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gotham", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(250, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 22);
            this.label8.TabIndex = 30;
            this.label8.Text = "Data of Products";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.adminAddProducts_clearBtn);
            this.panel2.Controls.Add(this.Admin_AddProducts_imageView);
            this.panel2.Controls.Add(this.Admin_AddProducts_importBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Admin_AddProducts_deleteBtn);
            this.panel2.Controls.Add(this.Admin_AddProducts_updateBtn);
            this.panel2.Controls.Add(this.Admin_AddProducts_addBtn);
            this.panel2.Controls.Add(this.Admin_AddProducts_status);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Admin_AddProducts_price);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Admin_AddProducts_stock);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Admin_AddProducts_type);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Admin_AddProducts_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Admin_AddProducts_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(20, 451);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1116, 279);
            this.panel2.TabIndex = 3;
            // 
            // adminAddProducts_clearBtn
            // 
            this.adminAddProducts_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(126)))), ((int)(((byte)(188)))));
            this.adminAddProducts_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddProducts_clearBtn.Font = new System.Drawing.Font("Gotham", 10.8F, System.Drawing.FontStyle.Bold);
            this.adminAddProducts_clearBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddProducts_clearBtn.Location = new System.Drawing.Point(694, 206);
            this.adminAddProducts_clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.adminAddProducts_clearBtn.Name = "adminAddProducts_clearBtn";
            this.adminAddProducts_clearBtn.Size = new System.Drawing.Size(164, 60);
            this.adminAddProducts_clearBtn.TabIndex = 30;
            this.adminAddProducts_clearBtn.Text = "CLEAR";
            this.adminAddProducts_clearBtn.UseVisualStyleBackColor = false;
            this.adminAddProducts_clearBtn.Click += new System.EventHandler(this.adminAddProducts_clearBtn_Click);
            // 
            // Admin_AddProducts_imageView
            // 
            this.Admin_AddProducts_imageView.Location = new System.Drawing.Point(936, 21);
            this.Admin_AddProducts_imageView.Margin = new System.Windows.Forms.Padding(4);
            this.Admin_AddProducts_imageView.Name = "Admin_AddProducts_imageView";
            this.Admin_AddProducts_imageView.Size = new System.Drawing.Size(144, 150);
            this.Admin_AddProducts_imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Admin_AddProducts_imageView.TabIndex = 18;
            this.Admin_AddProducts_imageView.TabStop = false;
            // 
            // Admin_AddProducts_importBtn
            // 
            this.Admin_AddProducts_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(126)))), ((int)(((byte)(188)))));
            this.Admin_AddProducts_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin_AddProducts_importBtn.Font = new System.Drawing.Font("Gotham", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_AddProducts_importBtn.ForeColor = System.Drawing.Color.White;
            this.Admin_AddProducts_importBtn.Location = new System.Drawing.Point(936, 192);
            this.Admin_AddProducts_importBtn.Margin = new System.Windows.Forms.Padding(4);
            this.Admin_AddProducts_importBtn.Name = "Admin_AddProducts_importBtn";
            this.Admin_AddProducts_importBtn.Size = new System.Drawing.Size(144, 41);
            this.Admin_AddProducts_importBtn.TabIndex = 28;
            this.Admin_AddProducts_importBtn.Text = "Import";
            this.Admin_AddProducts_importBtn.UseVisualStyleBackColor = false;
            this.Admin_AddProducts_importBtn.Click += new System.EventHandler(this.Admin_AddProducts_importBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(936, 21);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 150);
            this.panel3.TabIndex = 29;
            // 
            // Admin_AddProducts_deleteBtn
            // 
            this.Admin_AddProducts_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(126)))), ((int)(((byte)(188)))));
            this.Admin_AddProducts_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin_AddProducts_deleteBtn.Font = new System.Drawing.Font("Gotham", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_AddProducts_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.Admin_AddProducts_deleteBtn.Location = new System.Drawing.Point(473, 206);
            this.Admin_AddProducts_deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.Admin_AddProducts_deleteBtn.Name = "Admin_AddProducts_deleteBtn";
            this.Admin_AddProducts_deleteBtn.Size = new System.Drawing.Size(164, 60);
            this.Admin_AddProducts_deleteBtn.TabIndex = 27;
            this.Admin_AddProducts_deleteBtn.Text = "DELETE";
            this.Admin_AddProducts_deleteBtn.UseVisualStyleBackColor = false;
            this.Admin_AddProducts_deleteBtn.Click += new System.EventHandler(this.Admin_AddProducts_deleteBtn_Click);
            // 
            // Admin_AddProducts_updateBtn
            // 
            this.Admin_AddProducts_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(126)))), ((int)(((byte)(188)))));
            this.Admin_AddProducts_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin_AddProducts_updateBtn.Font = new System.Drawing.Font("Gotham", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_AddProducts_updateBtn.ForeColor = System.Drawing.Color.White;
            this.Admin_AddProducts_updateBtn.Location = new System.Drawing.Point(261, 206);
            this.Admin_AddProducts_updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.Admin_AddProducts_updateBtn.Name = "Admin_AddProducts_updateBtn";
            this.Admin_AddProducts_updateBtn.Size = new System.Drawing.Size(164, 60);
            this.Admin_AddProducts_updateBtn.TabIndex = 26;
            this.Admin_AddProducts_updateBtn.Text = "UPDATE";
            this.Admin_AddProducts_updateBtn.UseVisualStyleBackColor = false;
            this.Admin_AddProducts_updateBtn.Click += new System.EventHandler(this.Admin_AddProducts_updateBtn_Click);
            // 
            // Admin_AddProducts_addBtn
            // 
            this.Admin_AddProducts_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(126)))), ((int)(((byte)(188)))));
            this.Admin_AddProducts_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin_AddProducts_addBtn.Font = new System.Drawing.Font("Gotham", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_AddProducts_addBtn.ForeColor = System.Drawing.Color.White;
            this.Admin_AddProducts_addBtn.Location = new System.Drawing.Point(49, 206);
            this.Admin_AddProducts_addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.Admin_AddProducts_addBtn.Name = "Admin_AddProducts_addBtn";
            this.Admin_AddProducts_addBtn.Size = new System.Drawing.Size(164, 60);
            this.Admin_AddProducts_addBtn.TabIndex = 25;
            this.Admin_AddProducts_addBtn.Text = "ADD";
            this.Admin_AddProducts_addBtn.UseVisualStyleBackColor = false;
            this.Admin_AddProducts_addBtn.Click += new System.EventHandler(this.Admin_AddProducts_addBtn_Click);
            // 
            // Admin_AddProducts_status
            // 
            this.Admin_AddProducts_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_AddProducts_status.FormattingEnabled = true;
            this.Admin_AddProducts_status.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.Admin_AddProducts_status.Location = new System.Drawing.Point(577, 124);
            this.Admin_AddProducts_status.Margin = new System.Windows.Forms.Padding(4);
            this.Admin_AddProducts_status.Name = "Admin_AddProducts_status";
            this.Admin_AddProducts_status.Size = new System.Drawing.Size(281, 37);
            this.Admin_AddProducts_status.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gotham", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(490, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Status:";
            // 
            // Admin_AddProducts_price
            // 
            this.Admin_AddProducts_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_AddProducts_price.Location = new System.Drawing.Point(577, 71);
            this.Admin_AddProducts_price.Margin = new System.Windows.Forms.Padding(4);
            this.Admin_AddProducts_price.Name = "Admin_AddProducts_price";
            this.Admin_AddProducts_price.Size = new System.Drawing.Size(281, 30);
            this.Admin_AddProducts_price.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gotham", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(469, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Price ($):";
            // 
            // Admin_AddProducts_stock
            // 
            this.Admin_AddProducts_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_AddProducts_stock.Location = new System.Drawing.Point(577, 14);
            this.Admin_AddProducts_stock.Margin = new System.Windows.Forms.Padding(4);
            this.Admin_AddProducts_stock.Name = "Admin_AddProducts_stock";
            this.Admin_AddProducts_stock.Size = new System.Drawing.Size(281, 30);
            this.Admin_AddProducts_stock.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gotham", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(496, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Stock:";
            // 
            // Admin_AddProducts_type
            // 
            this.Admin_AddProducts_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_AddProducts_type.FormattingEnabled = true;
            this.Admin_AddProducts_type.Items.AddRange(new object[] {
            "Meal",
            "Drinks"});
            this.Admin_AddProducts_type.Location = new System.Drawing.Point(171, 125);
            this.Admin_AddProducts_type.Margin = new System.Windows.Forms.Padding(4);
            this.Admin_AddProducts_type.Name = "Admin_AddProducts_type";
            this.Admin_AddProducts_type.Size = new System.Drawing.Size(281, 37);
            this.Admin_AddProducts_type.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gotham", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Type:";
            // 
            // Admin_AddProducts_name
            // 
            this.Admin_AddProducts_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_AddProducts_name.Location = new System.Drawing.Point(171, 72);
            this.Admin_AddProducts_name.Margin = new System.Windows.Forms.Padding(4);
            this.Admin_AddProducts_name.Name = "Admin_AddProducts_name";
            this.Admin_AddProducts_name.Size = new System.Drawing.Size(281, 30);
            this.Admin_AddProducts_name.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gotham", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Product Name:";
            // 
            // Admin_AddProducts_id
            // 
            this.Admin_AddProducts_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_AddProducts_id.Location = new System.Drawing.Point(171, 15);
            this.Admin_AddProducts_id.Margin = new System.Windows.Forms.Padding(4);
            this.Admin_AddProducts_id.Name = "Admin_AddProducts_id";
            this.Admin_AddProducts_id.Size = new System.Drawing.Size(281, 30);
            this.Admin_AddProducts_id.TabIndex = 14;
            this.Admin_AddProducts_id.TextChanged += new System.EventHandler(this.Admin_AddProducts_id_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Product ID:";
            // 
            // AdminAddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddProducts";
            this.Size = new System.Drawing.Size(1152, 745);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_AddProducts_imageView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Admin_AddProducts_deleteBtn;
        private System.Windows.Forms.Button Admin_AddProducts_updateBtn;
        private System.Windows.Forms.Button Admin_AddProducts_addBtn;
        private System.Windows.Forms.ComboBox Admin_AddProducts_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Admin_AddProducts_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Admin_AddProducts_stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Admin_AddProducts_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Admin_AddProducts_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Admin_AddProducts_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox Admin_AddProducts_imageView;
        private System.Windows.Forms.Button Admin_AddProducts_importBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button adminAddProducts_clearBtn;
    }
}
