using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAT_AIR_Airline_Form
{
	public partial class Form3 : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tnt52\source\repos\JAT-AIR Airline Form\FlightReservationDB.mdf"";Integrated Security=True");
		
		//Creation of Form2 Object 
		Form2 f2;

		//Form 3 Constructor 
		public Form3(Form2 frm2)
		{
			InitializeComponent();
			this.f2 = frm2;

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}
		//Initializes Several Form3 Controls with Form 2 Control Values as soon as the Form Loads
		private void Form3_Load(object sender, EventArgs e)
		{
			PassengerFirstName.Text = f2.FirstNameTextBox.Text;
			PassengerLastName.Text = f2.LastNameTextBox.Text;
			PassengerDestination.Text = f2.DestinationComboBox.Text;
			PassengerFlightDate.Text = f2.FlightDatePicker.Text;
			PassengerSeatinPreference.Text = f2.SeatingPreferenceComboBox.Text;
			PassengerSeatingNumber.Text = f2.SeatingNumberTextBox.Text;

			//Calculations
			TotalTickCostBefTax.Text = f2.TotalTicketCostbefTax.ToString("C2");
			TotalTicketCostAfterTax.Text = f2.TotalTicketCostAfterTax.ToString("C2");
			//Show Greetings at Top 
			label1.Text = "Hi " + f2.FirstNameTextBox.Text + ", Here are your Flight Reservation Details: ";
		}

		private void PassengerFirstName_Click(object sender, EventArgs e)
		{

		}

		//Allows Passenger Record to be seen using an Sql Adapter
		private void ShowRecord_Click(object sender, EventArgs e)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM ReservedPassengerInfoTable ORDER BY passenger_id DESC", con);
				con.Open();
				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				con.Close();
				dataGridView1.DataSource = dt;
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message, "Error Message");
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void TotalTickCostBefTax_Click(object sender, EventArgs e)
		{

		}
		//Exit Button
		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult confirm = MessageBox.Show("Are you sure you want to exit?", "Exit	Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (confirm == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void label9_Click(object sender, EventArgs e)
		{

		}
	}
}
