using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBProject
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=THE-WANYA\\SQLEXPRESS;Database=DB;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Donor", connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvDonors.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnAddDonor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You entered: " + txtAge.Text);

            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Please enter a valid number for Age.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Donor (Name, Age, Gender, BloodGroup, Phone, Email, City, LastDonationDate) VALUES (@Name, @Age, @Gender, @BloodGroup, @Phone, @Email, @City, @LastDonationDate)", connection);

                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Age", age); // already validated above
                    cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                    cmd.Parameters.AddWithValue("@BloodGroup", txtBloodGroup.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@City", txtCity.Text);
                    cmd.Parameters.AddWithValue("@LastDonationDate", dtpLastDonationDate); // ✅ FIXED

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donor Added Successfully!");

                    // Optionally refresh grid
                    button1_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding donor: " + ex.Message);
                }
            }
        }
        private void btnUpdateDonor_Click(object sender, EventArgs e)
        {
            if (dgvDonors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a donor to update.");
                return;
            }

            int donorId = Convert.ToInt32(dgvDonors.SelectedRows[0].Cells["DonorId"].Value);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Donor SET Name=@Name, Age=@Age, Gender=@Gender, BloodGroup=@BloodGroup, Phone=@Phone, Email=@Email, City=@City, LastDonationDate=@LastDonationDate WHERE DonorId=@DonorId", connection);

                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                    cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                    cmd.Parameters.AddWithValue("@BloodGroup", txtBloodGroup.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@City", txtCity.Text);
                    cmd.Parameters.AddWithValue("@LastDonationDate", dtpLastDonationDate);
                    cmd.Parameters.AddWithValue("@DonorId", donorId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donor updated successfully!");
                    button1_Click(null, null); // refresh grid
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating donor: " + ex.Message);
                }
            }
        }
        private void btnDeleteDonor_Click(object sender, EventArgs e)
        {
            if (dgvDonors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a donor to delete.");
                return;
            }

            int donorId = Convert.ToInt32(dgvDonors.SelectedRows[0].Cells["DonorId"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this donor?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Donor WHERE DonorId=@DonorId", connection);
                        cmd.Parameters.AddWithValue("@DonorId", donorId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Donor deleted successfully!");
                        button1_Click(null, null); // refresh grid
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting donor: " + ex.Message);
                    }
                }
            }
        }
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_Click(object sender, EventArgs e)
        {

        }

        private void ttxtage_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
