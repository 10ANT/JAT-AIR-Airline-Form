namespace JAT_AIR_Airline_Form
{
	partial class Login
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			pictureBox1 = new PictureBox();
			label1 = new Label();
			label2 = new Label();
			UsernameTextBox = new TextBox();
			PasswordTextBox = new TextBox();
			LoginButton = new Button();
			ExitButton = new Button();
			label3 = new Label();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			label4 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(76, 82);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(206, 156);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.WhiteSmoke;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(360, 108);
			label1.Name = "label1";
			label1.Size = new Size(117, 31);
			label1.TabIndex = 1;
			label1.Text = "Username";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(360, 173);
			label2.Name = "label2";
			label2.Size = new Size(110, 31);
			label2.TabIndex = 2;
			label2.Text = "Password";
			label2.Click += label2_Click;
			// 
			// UsernameTextBox
			// 
			UsernameTextBox.ForeColor = SystemColors.InfoText;
			UsernameTextBox.Location = new Point(495, 108);
			UsernameTextBox.Name = "UsernameTextBox";
			UsernameTextBox.Size = new Size(191, 27);
			UsernameTextBox.TabIndex = 3;
			UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
			// 
			// PasswordTextBox
			// 
			PasswordTextBox.ForeColor = SystemColors.InfoText;
			PasswordTextBox.Location = new Point(495, 173);
			PasswordTextBox.Name = "PasswordTextBox";
			PasswordTextBox.Size = new Size(191, 27);
			PasswordTextBox.TabIndex = 4;
			PasswordTextBox.TextChanged += textBox1_TextChanged;
			// 
			// LoginButton
			// 
			LoginButton.BackColor = SystemColors.Highlight;
			LoginButton.Cursor = Cursors.AppStarting;
			LoginButton.Location = new Point(466, 258);
			LoginButton.Name = "LoginButton";
			LoginButton.Size = new Size(107, 41);
			LoginButton.TabIndex = 5;
			LoginButton.Text = "Login";
			LoginButton.UseVisualStyleBackColor = false;
			LoginButton.Click += LoginButton_Click;
			// 
			// ExitButton
			// 
			ExitButton.BackColor = Color.Red;
			ExitButton.Cursor = Cursors.AppStarting;
			ExitButton.Location = new Point(605, 258);
			ExitButton.Name = "ExitButton";
			ExitButton.Size = new Size(94, 41);
			ExitButton.TabIndex = 6;
			ExitButton.Text = "Exit";
			ExitButton.UseVisualStyleBackColor = false;
			ExitButton.Click += ExitButton_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Lavender;
			label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(353, 26);
			label3.Name = "label3";
			label3.Size = new Size(435, 35);
			label3.TabIndex = 7;
			label3.Text = "Welcome User To JAT Airlines Login";
			label3.Click += label3_Click_2;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(0, -5);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(347, 456);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 8;
			pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = Properties.Resources.final_dl_beatsnoop_com_JEp16x4jHd;
			pictureBox3.Location = new Point(343, -5);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(460, 456);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 9;
			pictureBox3.TabStop = false;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = SystemColors.ButtonHighlight;
			label4.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(142, 254);
			label4.Name = "label4";
			label4.Size = new Size(83, 36);
			label4.TabIndex = 10;
			label4.Text = "User";
			label4.Click += label4_Click;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(ExitButton);
			Controls.Add(LoginButton);
			Controls.Add(PasswordTextBox);
			Controls.Add(UsernameTextBox);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox3);
			Name = "Login";
			Text = "JAT Airlines Login Form";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
		private TextBox UsernameTextBox;
		private TextBox PasswordTextBox;
		private Button LoginButton;
		private Button ExitButton;
		private Label label3;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private Label label4;
	}
}