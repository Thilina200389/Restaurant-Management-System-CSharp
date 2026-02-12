using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace RestaurentManagementSystem
{
    public partial class AdminAddProducts : UserControl
    {


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\restManN2.mdf;Integrated Security=True;Connect Timeout=30");
        private DialogResult check;

        public AdminAddProducts()
        {
            InitializeComponent();

            displayData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayData();
        }
        public bool emptyFields()
        {
            if (Admin_AddProducts_id.Text == "" || Admin_AddProducts_name.Text == ""
                 || Admin_AddProducts_type.SelectedIndex == -1 || Admin_AddProducts_stock.Text == ""
                 || Admin_AddProducts_price.Text == "" || Admin_AddProducts_status.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void displayData()
        {
            AdminAddProductsData prodData = new AdminAddProductsData();
            List<AdminAddProductsData> listData = prodData.productsListData();

            DataGridView1.DataSource = null;

            DataGridView1.DataSource = listData;
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_AddProducts_addBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectProdID = "SELECT * FROM products WHERE prod_id = @prodID";

                        using (SqlCommand selectPID = new SqlCommand(selectProdID, connect))
                        {
                            selectPID.Parameters.AddWithValue("@prodID", Admin_AddProducts_id.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(selectPID);
                            DataTable table = new DataTable();
                            int v = adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Product ID: " + Admin_AddProducts_id.Text.Trim() + "is take Already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO products (prod_id, prod_name, prod_type, " +
                                        "prod_stock, prod_price, prod_status, prod_image, date_insert) VALUES(@prodID, @prodName" +
                                         ", @prodType, @prodStock, @prodPrice, @prodStatus, @prodImage, @dateInsert)";

                                DateTime today = DateTime.Today;

                                string path = Path.Combine(@"E:\DBMS\RestaurentManagementSystem_Test\Product_Directory\" 
                                                 + Admin_AddProducts_id.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(Admin_AddProducts_imageView.ImageLocation, path, true);



                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@prodID", Admin_AddProducts_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodName", Admin_AddProducts_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodType", Admin_AddProducts_type.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodStock", Admin_AddProducts_stock.Text.Trim());
                                    //cmd.Parameters.AddWithValue("@prodStock", Convert.ToInt32(Admin_AddProducts_stock.Text.Trim()));
                                    cmd.Parameters.AddWithValue("@prodPrice", Admin_AddProducts_price.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodStatus", Admin_AddProducts_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodImage", path);
                                    cmd.Parameters.AddWithValue("@dateInsert", today);

                                    cmd.ExecuteNonQuery();
                                    clearFields();

                                    displayData();

                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void Admin_AddProducts_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    Admin_AddProducts_imageView.ImageLocation = imagePath;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clearFields()
        {
            Admin_AddProducts_id.Text = "";
            Admin_AddProducts_name.Text = "";
            Admin_AddProducts_type.SelectedIndex = -1;
            Admin_AddProducts_stock.Text = "";
            Admin_AddProducts_price.Text = "";
            Admin_AddProducts_status.SelectedIndex = -1;
            Admin_AddProducts_imageView.Image = null;

            Admin_AddProducts_id.Enabled = true;

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminAddProducts_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void Admin_AddProducts_deleteBtn_Click(object sender, EventArgs e)
        {
            if (Admin_AddProducts_id.Text == "")
            {
                MessageBox.Show("Please select a product from the table first.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to DELETE Product ID: " + Admin_AddProducts_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();

                            string deleteData = "DELETE FROM products WHERE prod_id = @prodID";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@prodID", Admin_AddProducts_id.Text.Trim());

                                cmd.ExecuteNonQuery();

                                clearFields();

                                // REFRESH THE GRID
                                displayData();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        private void Admin_AddProducts_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // This locks the ID box so users can't break the update
            Admin_AddProducts_id.Enabled = false;

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = DataGridView1.Rows[e.RowIndex];
                Admin_AddProducts_id.Text = row.Cells[1].Value.ToString();
                Admin_AddProducts_name.Text = row.Cells[2].Value.ToString();
                Admin_AddProducts_type.Text = row.Cells[3].Value.ToString();
                Admin_AddProducts_stock.Text = row.Cells[4].Value.ToString();
                Admin_AddProducts_price.Text = row.Cells[5].Value.ToString();
                Admin_AddProducts_status.Text = row.Cells[6].Value.ToString();

                string imagepath = row.Cells[7].Value.ToString();
                try
                {
                    if (imagepath != null)
                    {
                        Admin_AddProducts_imageView.Image = Image.FromFile(imagepath);
                    }
                    else
                    {
                        Admin_AddProducts_imageView.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Image: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Admin_AddProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update Product ID: " + Admin_AddProducts_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();

                            // 1. Check your database column names! 
                            // Ensure 'date_update' exists in your table. If not, remove that part of the query.
                            string updateData = "UPDATE products SET prod_name = @prodName, prod_type = @prodType, prod_stock = @prodStock, prod_price = @prodPrice, prod_status = @prodStatus, date_update = @dateUpdate WHERE prod_id = @prodID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@prodName", Admin_AddProducts_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@prodType", Admin_AddProducts_type.Text.Trim());
                                cmd.Parameters.AddWithValue("@prodStock", Admin_AddProducts_stock.Text.Trim());
                                cmd.Parameters.AddWithValue("@prodPrice", Admin_AddProducts_price.Text.Trim());
                                cmd.Parameters.AddWithValue("@prodStatus", Admin_AddProducts_status.Text.Trim());

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@dateUpdate", today);

                                // IMPORTANT: This ID must match what is CURRENTLY in the database
                                cmd.Parameters.AddWithValue("@prodID", Admin_AddProducts_id.Text.Trim());

                                // 2. CAPTURE THE RESULT
                                int rows = cmd.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    // Success!
                                    clearFields();
                                    displayData(); // Refresh the grid
                                    MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    // Failure: The ID wasn't found
                                    MessageBox.Show("Update Failed: Product ID '" + Admin_AddProducts_id.Text.Trim() + "' was not found in the database.\n\nDid you try to change the ID? You cannot update the ID itself.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }
    }
}
