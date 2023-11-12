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

		Form2 f2;
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
		}

		private void PassengerFirstName_Click(object sender, EventArgs e)
		{

		}

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
	}
}
