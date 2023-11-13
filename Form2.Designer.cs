namespace JAT_AIR_Airline_Form
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			label3 = new Label();
			label2 = new Label();
			DestinationComboBox = new ComboBox();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			SeatingPreferenceComboBox = new ComboBox();
			FlightDatePicker = new DateTimePicker();
			label7 = new Label();
			pictureBox1 = new PictureBox();
			QuitButton = new Button();
			label8 = new Label();
			ReservationInfo = new Button();
			ArrowPointing = new PictureBox();
			FirstNameTextBox = new TextBox();
			LastNameTextBox = new TextBox();
			SeatingNumberTextBox = new TextBox();
			SaveInfo = new Button();
			DeleteButton = new Button();
			label1 = new Label();
			pictureBox2 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)ArrowPointing).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// label3
			// 
			resources.ApplyResources(label3, "label3");
			label3.Name = "label3";
			label3.Click += label3_Click;
			// 
			// label2
			// 
			resources.ApplyResources(label2, "label2");
			label2.Name = "label2";
			// 
			// DestinationComboBox
			// 
			resources.ApplyResources(DestinationComboBox, "DestinationComboBox");
			DestinationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			DestinationComboBox.FormattingEnabled = true;
			DestinationComboBox.Items.AddRange(new object[] { resources.GetString("DestinationComboBox.Items"), resources.GetString("DestinationComboBox.Items1"), resources.GetString("DestinationComboBox.Items2"), resources.GetString("DestinationComboBox.Items3") });
			DestinationComboBox.Name = "DestinationComboBox";
			DestinationComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// label4
			// 
			resources.ApplyResources(label4, "label4");
			label4.Name = "label4";
			// 
			// label5
			// 
			resources.ApplyResources(label5, "label5");
			label5.Name = "label5";
			// 
			// label6
			// 
			resources.ApplyResources(label6, "label6");
			label6.Name = "label6";
			// 
			// SeatingPreferenceComboBox
			// 
			resources.ApplyResources(SeatingPreferenceComboBox, "SeatingPreferenceComboBox");
			SeatingPreferenceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			SeatingPreferenceComboBox.FormattingEnabled = true;
			SeatingPreferenceComboBox.Items.AddRange(new object[] { resources.GetString("SeatingPreferenceComboBox.Items"), resources.GetString("SeatingPreferenceComboBox.Items1"), resources.GetString("SeatingPreferenceComboBox.Items2") });
			SeatingPreferenceComboBox.Name = "SeatingPreferenceComboBox";
			SeatingPreferenceComboBox.SelectedIndexChanged += SeatingPreferenceComboBox_SelectedIndexChanged;
			// 
			// FlightDatePicker
			// 
			resources.ApplyResources(FlightDatePicker, "FlightDatePicker");
			FlightDatePicker.Name = "FlightDatePicker";
			FlightDatePicker.ValueChanged += FlightDatePicker_ValueChanged;
			// 
			// label7
			// 
			resources.ApplyResources(label7, "label7");
			label7.Name = "label7";
			// 
			// pictureBox1
			// 
			resources.ApplyResources(pictureBox1, "pictureBox1");
			pictureBox1.BorderStyle = BorderStyle.Fixed3D;
			pictureBox1.Image = Properties.Resources.final_dl_beatsnoop_com_LkzVAvtPYF;
			pictureBox1.Name = "pictureBox1";
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// QuitButton
			// 
			resources.ApplyResources(QuitButton, "QuitButton");
			QuitButton.BackColor = Color.Fuchsia;
			QuitButton.Cursor = Cursors.Hand;
			QuitButton.Name = "QuitButton";
			QuitButton.UseVisualStyleBackColor = false;
			QuitButton.Click += QuitButton_Click;
			// 
			// label8
			// 
			resources.ApplyResources(label8, "label8");
			label8.Name = "label8";
			label8.Click += label8_Click;
			// 
			// ReservationInfo
			// 
			resources.ApplyResources(ReservationInfo, "ReservationInfo");
			ReservationInfo.BackColor = Color.Gold;
			ReservationInfo.Cursor = Cursors.AppStarting;
			ReservationInfo.Name = "ReservationInfo";
			ReservationInfo.UseVisualStyleBackColor = false;
			ReservationInfo.Click += ReservationInfo_Click;
			// 
			// ArrowPointing
			// 
			resources.ApplyResources(ArrowPointing, "ArrowPointing");
			ArrowPointing.Image = Properties.Resources.giphy;
			ArrowPointing.Name = "ArrowPointing";
			ArrowPointing.TabStop = false;
			ArrowPointing.Click += ArrowPointing_Click;
			// 
			// FirstNameTextBox
			// 
			resources.ApplyResources(FirstNameTextBox, "FirstNameTextBox");
			FirstNameTextBox.Name = "FirstNameTextBox";
			FirstNameTextBox.TextChanged += FirstNameTextBox_TextChanged;
			// 
			// LastNameTextBox
			// 
			resources.ApplyResources(LastNameTextBox, "LastNameTextBox");
			LastNameTextBox.Name = "LastNameTextBox";
			LastNameTextBox.TextChanged += LastNameTextBox_TextChanged;
			// 
			// SeatingNumberTextBox
			// 
			resources.ApplyResources(SeatingNumberTextBox, "SeatingNumberTextBox");
			SeatingNumberTextBox.Name = "SeatingNumberTextBox";
			SeatingNumberTextBox.TextChanged += SeatingNumberTextBox_TextChanged;
			// 
			// SaveInfo
			// 
			resources.ApplyResources(SaveInfo, "SaveInfo");
			SaveInfo.BackColor = Color.Lime;
			SaveInfo.Cursor = Cursors.Hand;
			SaveInfo.Name = "SaveInfo";
			SaveInfo.UseVisualStyleBackColor = false;
			SaveInfo.Click += SaveInfo_Click;
			// 
			// DeleteButton
			// 
			resources.ApplyResources(DeleteButton, "DeleteButton");
			DeleteButton.BackColor = Color.SlateBlue;
			DeleteButton.Cursor = Cursors.Hand;
			DeleteButton.Name = "DeleteButton";
			DeleteButton.UseVisualStyleBackColor = false;
			DeleteButton.Click += DeleteButton_Click;
			// 
			// label1
			// 
			resources.ApplyResources(label1, "label1");
			label1.BackColor = SystemColors.Info;
			label1.Name = "label1";
			label1.Click += label1_Click;
			// 
			// pictureBox2
			// 
			resources.ApplyResources(pictureBox2, "pictureBox2");
			pictureBox2.Image = Properties.Resources.final_dl_beatsnoop_com_2esDP5cb78;
			pictureBox2.Name = "pictureBox2";
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click_1;
			// 
			// Form2
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(ArrowPointing);
			Controls.Add(ReservationInfo);
			Controls.Add(label8);
			Controls.Add(QuitButton);
			Controls.Add(pictureBox1);
			Controls.Add(DeleteButton);
			Controls.Add(SaveInfo);
			Controls.Add(SeatingNumberTextBox);
			Controls.Add(LastNameTextBox);
			Controls.Add(FirstNameTextBox);
			Controls.Add(label7);
			Controls.Add(FlightDatePicker);
			Controls.Add(SeatingPreferenceComboBox);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(DestinationComboBox);
			Controls.Add(label2);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(pictureBox2);
			ForeColor = SystemColors.ActiveCaptionText;
			Name = "Form2";
			Load += Form2_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)ArrowPointing).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label3;
		private Label label2;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private PictureBox pictureBox1;
		private Button QuitButton;
		private Label label8;
		private Button ReservationInfo;
		private PictureBox ArrowPointing;
		internal ComboBox DestinationComboBox;
		internal ComboBox SeatingPreferenceComboBox;
		internal DateTimePicker FlightDatePicker;
		internal TextBox FirstNameTextBox;
		internal TextBox LastNameTextBox;
		internal TextBox SeatingNumberTextBox;
		private Button SaveInfo;
		private Button DeleteButton;
		private Label label1;
		private PictureBox pictureBox2;
	}
}