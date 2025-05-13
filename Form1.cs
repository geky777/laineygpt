using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GuiForDentalA;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Label welcomeLabel;

        public Form1()
        {
            InitializeComponent();
            welcomeLabel = new Label(); // Initialize the field
            DatabaseHelper.TestDatabaseConnection(); // Test the database connection
            InitializeWelcomeLabel(); // Initialize the welcome label
        }

        private void InitializeWelcomeLabel()
        {
            try
            {
                // Create and configure the welcome label
                this.welcomeLabel = new Label();
                this.welcomeLabel.AutoSize = false;
                this.welcomeLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                this.welcomeLabel.Location = new Point(150, 50);
                this.welcomeLabel.Name = "welcomeLabel";
                this.welcomeLabel.Size = new Size(500, 60);
                this.welcomeLabel.TabIndex = 0;
                this.welcomeLabel.Text = $"Welcome, {UserSession.FirstName} {UserSession.LastName}!";
                this.welcomeLabel.TextAlign = ContentAlignment.TopLeft;
                this.welcomeLabel.BackColor = Color.LightBlue;
                this.welcomeLabel.ForeColor = Color.DarkBlue;
                this.welcomeLabel.BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(this.welcomeLabel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Fetch all patients and display in DataGridView
                string query = "SELECT * FROM patients";
                using (var reader = DatabaseHelper.ExecuteQuery(query))
                {
                    DataTable table = new DataTable();
                    table.Load(reader);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Fetch all appointments and display in DataGridView
                string query = "SELECT * FROM appointments";
                using (var reader = DatabaseHelper.ExecuteQuery(query))
                {
                    DataTable table = new DataTable();
                    table.Load(reader);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Fetch all dentists and display in DataGridView
                string query = "SELECT * FROM dentists";
                using (var reader = DatabaseHelper.ExecuteQuery(query))
                {
                    DataTable table = new DataTable();
                    table.Load(reader);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Fetch all payments and display in DataGridView
                string query = "SELECT * FROM payments";
                using (var reader = DatabaseHelper.ExecuteQuery(query))
                {
                    DataTable table = new DataTable();
                    table.Load(reader);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                // Fetch all appointment logs and display in DataGridView
                string query = "SELECT * FROM appointment_logs";
                using (var reader = DatabaseHelper.ExecuteQuery(query))
                {
                    DataTable table = new DataTable();
                    table.Load(reader);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            // Log out and redirect to the login form
            Form2 loginForm = new Form2();
            this.Hide();
            loginForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add dentist button clicked.");
        }

  
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"Cell clicked at row {e.RowIndex}, column {e.ColumnIndex}.");
        }

 
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form1 loaded successfully.");
        }

    }
}
