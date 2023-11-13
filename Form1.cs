using System.Data.SqlClient;


namespace JAT_AIR_Airline_Form

{
	public partial class Login : Form
	{
		//Place Connect string some where here
		SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tnt52\source\repos\JAT-AIR Airline Form\CredentialsDatabase1.mdf"";Integrated Security=True");
		SqlCommand cmd;

		public Login()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void UsernameTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		//Login Button 
		private void LoginButton_Click(object sender, EventArgs e)
		{
			try
			{
				string SQLSelect = "Select count(*) From login_Table Where uname = @username and password = @pass"; SqlCommand cmd = new SqlCommand(SQLSelect, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@username", UsernameTextBox.Text);
				cmd.Parameters.AddWithValue("@pass", PasswordTextBox.Text);
				conn.Open();
				if (cmd.ExecuteScalar().ToString() == "1")
				{
					MessageBox.Show("Welcome back, " + UsernameTextBox.Text + " you are logged in.");
					this.Hide();

					Form2 f2 = new Form2();
					f2.Show();
				}
				else
				{
					MessageBox.Show("Incorrect Username or Password, Try again!");
					UsernameTextBox.Clear();
					PasswordTextBox.Clear();
				}
				conn.Close();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message, "Error Message");
			}

		}
		//The Exit Button
		private void ExitButton_Click(object sender, EventArgs e)
		{
			DialogResult confirm = MessageBox.Show("Are you sure you want to exit?", "Exit	Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (confirm == DialogResult.Yes)
			{
				Application.Exit();
			}

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click_1(object sender, EventArgs e)
		{

		}

		private void label3_Click_2(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}