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
    public partial class AdminAddUsers : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\restManN2.mdf;Integrated Security=True;Connect Timeout=30");
        private string directoryPath;

        public AdminAddUsers()
        {
            InitializeComponent();

            displayAddUsersData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAddUsersData();
        }

        public void displayAddUsersData()
        {
            AdminAddUsersData usersData = new AdminAddUsersData();
            List<AdminAddUsersData> listData = usersData.usersListData();

            dataGridView1.DataSource= listData;
        }
        private void AdminAddUsers_Load(object sender, EventArgs e)
        {

        }

        public bool emptyFields()
        {
            if (Admin_AddUsers_username.Text == "" || Admin_AddUsers_password.Text == ""
               || Admin_AddUsers_role.Text == "" || Admin_AddUsers_status.Text == ""
               || Admin_AddUsers_imageView.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Admin_AddUsers_addBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        // CHECK USERNAME IF EXISTING ALREADY
                        string selectUsern = "SELECT * FROM users WHERE username = @usern";

                        using (SqlCommand checkUsern = new SqlCommand(selectUsern, connect))
                        {
                            checkUsern.Parameters.AddWithValue("@usern", Admin_AddUsers_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                string usern = Admin_AddUsers_username.Text.Substring(0, 1).ToUpper() + Admin_AddUsers_username.Text.Substring(1);
                                MessageBox.Show(usern + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, password, profile_image, role, status, date_reg) VALUES(@usern, @pass, @image, @role, @status, @date)";
                                DateTime today = DateTime.Today;

                                // 1. Define the folder location explicitly
                                string directoryPath = @"E:\DBMS\RestaurentManagementSystem_Test\User_Directory";

                                // 2. Now checking the folder works because 'directoryPath' is defined
                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                // 3. Get the original file extension (e.g., .jpg or .png)
                                string extension = Path.GetExtension(Admin_AddUsers_imageView.ImageLocation);

                                // 4. Create the new filename: "Username" + ".jpg"
                                string fileName = Admin_AddUsers_username.Text.Trim() + extension;

                                // 5. Combine them to make the full Save Path
                                string path = Path.Combine(directoryPath, fileName);

                                // 6. Copy the file
                                File.Copy(Admin_AddUsers_imageView.ImageLocation, path, true); File.Copy(Admin_AddUsers_imageView.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@usern", Admin_AddUsers_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", Admin_AddUsers_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path); // Placeholder for now
                                    cmd.Parameters.AddWithValue("@role", Admin_AddUsers_role.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", Admin_AddUsers_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    displayAddUsersData();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                // Note: There is a small typo in the filter string in the image (missing semicolon)
                dialog.Filter = "Image Files (*.jpg; *.png|*.jpg;*.png)";
                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    Admin_AddUsers_imageView.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            id = (int)row.Cells[0].Value;
            Admin_AddUsers_username.Text = row.Cells[1].Value.ToString();
            Admin_AddUsers_password.Text = row.Cells[2].Value.ToString();
            Admin_AddUsers_role.Text = row.Cells[3].Value.ToString();
            Admin_AddUsers_status.Text = row.Cells[4].Value.ToString();

            string imagePath = row.Cells[5].Value.ToString();

            try
            {
                if (imagePath != null)
                {
                    Admin_AddUsers_imageView.Image = Image.FromFile(imagePath);
                }
                else
                {
                    Admin_AddUsers_imageView.Image = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No Image :3", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Admin_AddUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Update Username: " + Admin_AddUsers_username.Text.Trim()
                        + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE users SET username = @usern, password = @pass, role = @role, status = @status WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", Admin_AddUsers_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", Admin_AddUsers_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", Admin_AddUsers_role.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", Admin_AddUsers_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                displayAddUsersData();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }

            }
        }
        public void clearFields()
        {
            Admin_AddUsers_username.Text = "";
            Admin_AddUsers_password.Text = "";
            Admin_AddUsers_role.SelectedIndex = -1;
            Admin_AddUsers_status.SelectedIndex = -1;
            Admin_AddUsers_imageView.Image = null;
        }
        private void Admin_AddUsers_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void Admin_AddUsers_deleteBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Delete Username: " + Admin_AddUsers_username.Text.Trim()
                        + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();

                            string deletedata = "DELETE FROM users WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(deletedata, connect))
                            {
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                displayAddUsersData();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

