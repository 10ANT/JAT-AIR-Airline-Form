namespace JAT_AIR_Airline_Form
{
	partial class Form3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			label1 = new Label();
			label31 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			pictureBox1 = new PictureBox();
			label9 = new Label();
			label10 = new Label();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			PassengerFirstName = new Label();
			PassengerLastName = new Label();
			PassengerDestination = new Label();
			PassengerFlightDate = new Label();
			PassengerSeatinPreference = new Label();
			PassengerSeatingNumber = new Label();
			TotalTickCostBefTax = new Label();
			TotalTicketCostAfterTax = new Label();
			ShowRecord = new Button();
			dataGridView1 = new DataGridView();
			pictureBox5 = new PictureBox();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = SystemColors.Info;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(314, 53);
			label1.Name = "label1";
			label1.Size = new Size(452, 31);
			label1.TabIndex = 0;
			label1.Text = "Here are your Flight Reservation Details: ";
			label1.Click += label1_Click;
			// 
			// label31
			// 
			label31.AutoSize = true;
			label31.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label31.Location = new Point(79, 159);
			label31.Name = "label31";
			label31.Size = new Size(152, 20);
			label31.TabIndex = 1;
			label31.Text = "Passenger FirstName: ";
			label31.Click += label2_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(80, 188);
			label2.Name = "label2";
			label2.Size = new Size(151, 20);
			label2.TabIndex = 2;
			label2.Text = "Passenger Last Name:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(79, 235);
			label3.Name = "label3";
			label3.Size = new Size(121, 20);
			label3.TabIndex = 3;
			label3.Text = "Your Destination:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(79, 264);
			label4.Name = "label4";
			label4.Size = new Size(118, 20);
			label4.TabIndex = 4;
			label4.Text = "Your Flight Date:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(76, 294);
			label5.Name = "label5";
			label5.Size = new Size(169, 20);
			label5.TabIndex = 5;
			label5.Text = "Your Seating Preference:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(76, 324);
			label6.Name = "label6";
			label6.Size = new Size(153, 20);
			label6.TabIndex = 6;
			label6.Text = "Your Seating Number:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			label7.Location = new Point(169, 494);
			label7.Name = "label7";
			label7.Size = new Size(557, 22);
			label7.TabIndex = 7;
			label7.Text = "Thank you for choosing JAT-AIR Airline for your flight reservation!";
			label7.Click += label7_Click;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.BackColor = Color.LavenderBlush;
			label8.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
			label8.Location = new Point(578, 159);
			label8.Name = "label8";
			label8.Size = new Size(59, 26);
			label8.TabIndex = 8;
			label8.Text = "Fees";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.assets;
			pictureBox1.Location = new Point(647, 149);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(42, 36);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 9;
			pictureBox1.TabStop = false;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label9.Location = new Point(578, 201);
			label9.Name = "label9";
			label9.Size = new Size(188, 20);
			label9.TabIndex = 10;
			label9.Text = "Total ticket cost before tax:";
			label9.Click += label9_Click;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label10.Location = new Point(578, 276);
			label10.Name = "label10";
			label10.Size = new Size(260, 20);
			label10.TabIndex = 11;
			label10.Text = "Final ticket cost (Tax Applied @16.5%)";
			label10.Click += label10_Click;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.thank_you;
			pictureBox2.Location = new Point(415, 546);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(159, 89);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 12;
			pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = Properties.Resources.wallhaven_858eqk;
			pictureBox3.Location = new Point(80, 23);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(149, 119);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 13;
			pictureBox3.TabStop = false;
			// 
			// PassengerFirstName
			// 
			PassengerFirstName.AutoSize = true;
			PassengerFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			PassengerFirstName.Location = new Point(245, 159);
			PassengerFirstName.Name = "PassengerFirstName";
			PassengerFirstName.Size = new Size(54, 20);
			PassengerFirstName.TabIndex = 14;
			PassengerFirstName.Text = "Empty";
			PassengerFirstName.Click += PassengerFirstName_Click;
			// 
			// PassengerLastName
			// 
			PassengerLastName.AutoSize = true;
			PassengerLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			PassengerLastName.Location = new Point(245, 188);
			PassengerLastName.Name = "PassengerLastName";
			PassengerLastName.Size = new Size(58, 20);
			PassengerLastName.TabIndex = 15;
			PassengerLastName.Text = "Empty ";
			// 
			// PassengerDestination
			// 
			PassengerDestination.AutoSize = true;
			PassengerDestination.Location = new Point(205, 236);
			PassengerDestination.Name = "PassengerDestination";
			PassengerDestination.Size = new Size(51, 20);
			PassengerDestination.TabIndex = 16;
			PassengerDestination.Text = "Empty";
			// 
			// PassengerFlightDate
			// 
			PassengerFlightDate.AutoSize = true;
			PassengerFlightDate.Location = new Point(204, 265);
			PassengerFlightDate.Name = "PassengerFlightDate";
			PassengerFlightDate.Size = new Size(51, 20);
			PassengerFlightDate.TabIndex = 17;
			PassengerFlightDate.Text = "Empty";
			// 
			// PassengerSeatinPreference
			// 
			PassengerSeatinPreference.AutoSize = true;
			PassengerSeatinPreference.Location = new Point(251, 294);
			PassengerSeatinPreference.Name = "PassengerSeatinPreference";
			PassengerSeatinPreference.Size = new Size(51, 20);
			PassengerSeatinPreference.TabIndex = 18;
			PassengerSeatinPreference.Text = "Empty";
			// 
			// PassengerSeatingNumber
			// 
			PassengerSeatingNumber.AutoSize = true;
			PassengerSeatingNumber.Location = new Point(245, 324);
			PassengerSeatingNumber.Name = "PassengerSeatingNumber";
			PassengerSeatingNumber.Size = new Size(55, 20);
			PassengerSeatingNumber.TabIndex = 19;
			PassengerSeatingNumber.Text = "Empty ";
			// 
			// TotalTickCostBefTax
			// 
			TotalTickCostBefTax.AutoSize = true;
			TotalTickCostBefTax.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			TotalTickCostBefTax.Location = new Point(578, 236);
			TotalTickCostBefTax.Name = "TotalTickCostBefTax";
			TotalTickCostBefTax.Size = new Size(58, 20);
			TotalTickCostBefTax.TabIndex = 20;
			TotalTickCostBefTax.Text = "Empty ";
			TotalTickCostBefTax.Click += TotalTickCostBefTax_Click;
			// 
			// TotalTicketCostAfterTax
			// 
			TotalTicketCostAfterTax.AutoSize = true;
			TotalTicketCostAfterTax.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			TotalTicketCostAfterTax.Location = new Point(578, 309);
			TotalTicketCostAfterTax.Name = "TotalTicketCostAfterTax";
			TotalTicketCostAfterTax.Size = new Size(54, 20);
			TotalTicketCostAfterTax.TabIndex = 21;
			TotalTicketCostAfterTax.Text = "Empty";
			// 
			// ShowRecord
			// 
			ShowRecord.BackColor = Color.Lime;
			ShowRecord.Cursor = Cursors.AppStarting;
			ShowRecord.Location = new Point(64, 412);
			ShowRecord.Name = "ShowRecord";
			ShowRecord.Size = new Size(165, 29);
			ShowRecord.TabIndex = 22;
			ShowRecord.Text = "ShowYourRecord";
			ShowRecord.UseVisualStyleBackColor = false;
			ShowRecord.Click += ShowRecord_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(245, 387);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(564, 84);
			dataGridView1.TabIndex = 23;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// pictureBox5
			// 
			pictureBox5.Dock = DockStyle.Fill;
			pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
			pictureBox5.Location = new Point(0, 0);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(909, 647);
			pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox5.TabIndex = 25;
			pictureBox5.TabStop = false;
			// 
			// button1
			// 
			button1.BackColor = Color.Silver;
			button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
			button1.Location = new Point(763, 491);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 26;
			button1.Text = "Quit";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// Form3
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(909, 647);
			Controls.Add(button1);
			Controls.Add(dataGridView1);
			Controls.Add(ShowRecord);
			Controls.Add(TotalTicketCostAfterTax);
			Controls.Add(TotalTickCostBefTax);
			Controls.Add(PassengerSeatingNumber);
			Controls.Add(PassengerSeatinPreference);
			Controls.Add(PassengerFlightDate);
			Controls.Add(PassengerDestination);
			Controls.Add(PassengerLastName);
			Controls.Add(PassengerFirstName);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(pictureBox1);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label31);
			Controls.Add(label1);
			Controls.Add(pictureBox5);
			Name = "Form3";
			Text = "YourReservationDetails";
			Load += Form3_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label31;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private PictureBox pictureBox1;
		private Label label9;
		private Label label10;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private Label PassengerFirstName;
		private Label PassengerLastName;
		private Label PassengerDestination;
		private Label PassengerFlightDate;
		private Label PassengerSeatinPreference;
		private Label PassengerSeatingNumber;
		private Label TotalTickCostBefTax;
		private Label TotalTicketCostAfterTax;
		private Button ShowRecord;
		private DataGridView dataGridView1;
		private PictureBox pictureBox5;
		private Button button1;
	}
}