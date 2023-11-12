using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace JAT_AIR_Airline_Form
{
	public partial class Form2 : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tnt52\source\repos\JAT-AIR Airline Form\FlightReservationDB.mdf"";Integrated Security=True");
		SqlCommand cmd;
		SqlCommand checkFullCmd;
		SqlCommand checkDupes;

		public Form2()
		{
			InitializeComponent();
			DeleteButton.Enabled = false;
			ReservationInfo.Enabled = false;
			ArrowPointing.Enabled = false;
			ArrowPointing.Visible = false;
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

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
		private void button2_Click(object sender, EventArgs e)
		{
		}

		private bool SaveInfo_Clickbutton = false;


		private void SaveInfo_Click(object sender, EventArgs e)
		{
			try
			{
				///Console.WriteLine(LastNameTextBox.Text.ToString());
				///
				//Checks if Flight is at capacity i for testing purposes set atCapacity at 1 to demonstrate error
				checkFullCmd = new SqlCommand("SELECT CASE WHEN COUNT(*) >= 200 THEN 1 ELSE 0 END FROM ReservedPassengerInfoTable WHERE seating_num BETWEEN 1 AND 200", con);

				con.Open();
				int atCapacity = Convert.ToInt32(checkFullCmd.ExecuteScalar());
				atCapacity = 0;
				con.Close();

				if (atCapacity == 1)
				{
					MessageBox.Show("SORRY, FLIGHT IS AT CAPACITY!");
					return;
					//return exits function and prevents data entry
				}



				//Establishes Upper and Lower limit of Seat numbers and prevents record entry if limit is exceeded
				if (Convert.ToInt32(SeatingNumberTextBox.Text) > 200 || Convert.ToInt32(SeatingNumberTextBox.Text) < 1)
				{
					MessageBox.Show("THE SEAT LIMIT IS 1 - 200! choose a between that range");
					return;
				}


				//Test if Value already exists in field Checks for Duplicates
				//  parameterized query to avoid SQL injection as stated in Class
				using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tnt52\source\repos\JAT-AIR Airline Form\FlightReservationDB.mdf"";Integrated Security=True"))
				{

					con.Open();

					using (SqlCommand checkDupes = new SqlCommand("SELECT COUNT(*) FROM ReservedPassengerInfoTable WHERE seating_num = @seatnumber", con))
					{
						checkDupes.Parameters.AddWithValue("@seatnumber", Convert.ToInt32(SeatingNumberTextBox.Text));


						int count = Convert.ToInt32(checkDupes.ExecuteScalar());

						if (count > 0)
						{
							MessageBox.Show("Seat Number is Already Occupied!  Please Choose another Number");
							return;
						}
						else
						{
							MessageBox.Show("Seating Number Ok");
						}
					}
				}





				//used to insert passenger record into data base
				cmd = new SqlCommand("insert into ReservedPassengerInfoTable(passenger_firstname,passenger_lastname,destination,flight_date,seating_preference,seating_num) " +
						"values(@passen_fname, @passen_lname, @passen_destin, @passenf_date, @seat_pref, @seat_number)", con);
				con.Open();
				cmd.Parameters.AddWithValue("@passen_fname", FirstNameTextBox.Text);
				cmd.Parameters.AddWithValue("@passen_lname", LastNameTextBox.Text);
				cmd.Parameters.AddWithValue("@passen_destin", DestinationComboBox.Text);
				cmd.Parameters.AddWithValue("@passenf_date", FlightDatePicker.Text);
				cmd.Parameters.AddWithValue("@seat_pref", SeatingPreferenceComboBox.Text);
				cmd.Parameters.AddWithValue("@seat_number", SeatingNumberTextBox.Text);
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Record Inserted Successfully");
				DeleteButton.Enabled = true;
				ReservationInfo.Enabled = true;
				ArrowPointing.Enabled = true;
				ArrowPointing.Visible = true;


			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message, "Error Message");
			}
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void FlightDatePicker_ValueChanged(object sender, EventArgs e)
		{

		}





		private void DeleteButton_Click(object sender, EventArgs e)
		{

			try
			{
				cmd = new SqlCommand("DELETE FROM ReservedPassengerInfoTable WHERE passenger_id = (SELECT TOP 1 passenger_id FROM ReservedPassengerInfoTable ORDER BY passenger_id DESC)", con);
				con.Open();
				int rowsAffected = cmd.ExecuteNonQuery();
				con.Close();

				if (rowsAffected > 0)
				{
					MessageBox.Show("Last Record Deleted Successfully!");
				}
				else
				{
					MessageBox.Show("No records found to delete.", "Info");
				}


				DeleteButton.Enabled = false; // Disable the button
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message, "Error Message");
			}


		}


		private void QuitButton_Click(object sender, EventArgs e)
		{
			DialogResult confirm = MessageBox.Show("Are you sure you want to exit?", "Exit	Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (confirm == DialogResult.Yes)
			{
				System.Windows.Forms.Application.Exit();
			}
		}

		private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void LastNameTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void SeatingNumberTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		public double airfarecost { set; get; }
		public double distance { set; get; }
		public double TotalTicketCostbefTax { set; get; }
		public double TotalTicketCostAfterTax { set; get; }


		public const double TAX = 0.165;

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void ReservationInfo_Click(object sender, EventArgs e)
		{
			try
			{
				switch (SeatingPreferenceComboBox.Text)
				{
					case "First Class – $18 per km":
						airfarecost = 18;
						break;
					case "Business Class – $12 per km":
						airfarecost = 12;
						break;
					case "Economy Class – $8 per km":
						airfarecost = 8;

						break;

				}
				switch (DestinationComboBox.Text)
				{
					case "Jamaica to Azerbaijan - Distance 11,381 (km)":
						distance = 11381;
						break;
					case "Jamaica to Timbuktu - Distance 7,819 (km)":
						distance = 7819;
						break;
					case "Jamaica to Eritrea - Distance 12,184 (km)":
						distance = 12184;
						break;
					case "Jamaica to Somali - Distance 13,318 (km)":
						distance = 13318;
						break;
				}

				TotalTicketCostbefTax = airfarecost * distance;
				TotalTicketCostAfterTax = TotalTicketCostbefTax + (TAX * TotalTicketCostbefTax);

				/*
				label8.Text = TotalTicketCostAfterTax.ToString();
				label8.Text = TotalTicketCostbefTax.ToString();
				*/
			}
			catch (Exception ex)
			{
				Console.WriteLine($"An error occurred: {ex.Message}");
			}
			//creating a form3 object and passing this form2 (this) as a parameter so we can extract data from it in form3
			Form3 f3 = new Form3(this);
			this.Hide();
			f3.ShowDialog();

		}

		private void ArrowPointing_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}
	}
}
