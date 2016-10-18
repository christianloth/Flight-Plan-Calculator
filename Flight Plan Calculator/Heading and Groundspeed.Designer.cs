namespace FlightPlanCalculator {
	partial class windowHeadingGroundspeed {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.title = new System.Windows.Forms.Label();
			this.lblCourse = new System.Windows.Forms.Label();
			this.txtboxAirspeed = new System.Windows.Forms.TextBox();
			this.lblTrueAirspeed = new System.Windows.Forms.Label();
			this.txtboxWindSpeed = new System.Windows.Forms.TextBox();
			this.lblWindVelocity = new System.Windows.Forms.Label();
			this.txtboxWindDirection = new System.Windows.Forms.TextBox();
			this.lblWindDirection = new System.Windows.Forms.Label();
			this.outputTextbox = new System.Windows.Forms.TextBox();
			this.lblOutput = new System.Windows.Forms.Label();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.txtboxCourse = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.Location = new System.Drawing.Point(0, 15);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(584, 33);
			this.title.TabIndex = 0;
			this.title.Text = "Heading and Groundspeed";
			this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCourse
			// 
			this.lblCourse.AutoSize = true;
			this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCourse.Location = new System.Drawing.Point(35, 127);
			this.lblCourse.Name = "lblCourse";
			this.lblCourse.Size = new System.Drawing.Size(57, 17);
			this.lblCourse.TabIndex = 17;
			this.lblCourse.Text = "Course:";
			this.lblCourse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtboxAirspeed
			// 
			this.txtboxAirspeed.Location = new System.Drawing.Point(419, 128);
			this.txtboxAirspeed.Name = "txtboxAirspeed";
			this.txtboxAirspeed.Size = new System.Drawing.Size(125, 20);
			this.txtboxAirspeed.TabIndex = 8;
			// 
			// lblTrueAirspeed
			// 
			this.lblTrueAirspeed.AutoSize = true;
			this.lblTrueAirspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTrueAirspeed.Location = new System.Drawing.Point(315, 130);
			this.lblTrueAirspeed.Name = "lblTrueAirspeed";
			this.lblTrueAirspeed.Size = new System.Drawing.Size(102, 17);
			this.lblTrueAirspeed.TabIndex = 15;
			this.lblTrueAirspeed.Text = "True Airspeed:";
			this.lblTrueAirspeed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtboxWindSpeed
			// 
			this.txtboxWindSpeed.Location = new System.Drawing.Point(419, 73);
			this.txtboxWindSpeed.Name = "txtboxWindSpeed";
			this.txtboxWindSpeed.Size = new System.Drawing.Size(125, 20);
			this.txtboxWindSpeed.TabIndex = 6;
			// 
			// lblWindVelocity
			// 
			this.lblWindVelocity.AutoSize = true;
			this.lblWindVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWindVelocity.Location = new System.Drawing.Point(315, 75);
			this.lblWindVelocity.Name = "lblWindVelocity";
			this.lblWindVelocity.Size = new System.Drawing.Size(97, 17);
			this.lblWindVelocity.TabIndex = 13;
			this.lblWindVelocity.Text = "Wind Velocity:";
			this.lblWindVelocity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtboxWindDirection
			// 
			this.txtboxWindDirection.Location = new System.Drawing.Point(139, 71);
			this.txtboxWindDirection.Name = "txtboxWindDirection";
			this.txtboxWindDirection.Size = new System.Drawing.Size(125, 20);
			this.txtboxWindDirection.TabIndex = 5;
			// 
			// lblWindDirection
			// 
			this.lblWindDirection.AutoSize = true;
			this.lblWindDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWindDirection.Location = new System.Drawing.Point(35, 73);
			this.lblWindDirection.Name = "lblWindDirection";
			this.lblWindDirection.Size = new System.Drawing.Size(104, 17);
			this.lblWindDirection.TabIndex = 11;
			this.lblWindDirection.Text = "Wind Direction:";
			this.lblWindDirection.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// outputTextbox
			// 
			this.outputTextbox.Location = new System.Drawing.Point(182, 247);
			this.outputTextbox.Multiline = true;
			this.outputTextbox.Name = "outputTextbox";
			this.outputTextbox.ReadOnly = true;
			this.outputTextbox.Size = new System.Drawing.Size(241, 151);
			this.outputTextbox.TabIndex = 19;
			this.outputTextbox.TabStop = false;
			// 
			// lblOutput
			// 
			this.lblOutput.AutoSize = true;
			this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOutput.Location = new System.Drawing.Point(270, 213);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(55, 17);
			this.lblOutput.TabIndex = 20;
			this.lblOutput.Text = "Output:";
			this.lblOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(255, 175);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(87, 25);
			this.btnCalculate.TabIndex = 21;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.calculate_Click);
			// 
			// txtboxCourse
			// 
			this.txtboxCourse.Location = new System.Drawing.Point(139, 127);
			this.txtboxCourse.Name = "txtboxCourse";
			this.txtboxCourse.Size = new System.Drawing.Size(125, 20);
			this.txtboxCourse.TabIndex = 7;
			// 
			// windowHeadingGroundspeed
			// 
			this.AcceptButton = this.btnCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 423);
			this.Controls.Add(this.txtboxCourse);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.outputTextbox);
			this.Controls.Add(this.lblCourse);
			this.Controls.Add(this.txtboxAirspeed);
			this.Controls.Add(this.lblTrueAirspeed);
			this.Controls.Add(this.txtboxWindSpeed);
			this.Controls.Add(this.lblWindVelocity);
			this.Controls.Add(this.txtboxWindDirection);
			this.Controls.Add(this.lblWindDirection);
			this.Controls.Add(this.title);
			this.Name = "windowHeadingGroundspeed";
			this.Text = "Heading And Groundspeed";
			this.Load += new System.EventHandler(this.Window_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Label lblCourse;
		private System.Windows.Forms.TextBox txtboxAirspeed;
		private System.Windows.Forms.Label lblTrueAirspeed;
		private System.Windows.Forms.TextBox txtboxWindSpeed;
		private System.Windows.Forms.Label lblWindVelocity;
		private System.Windows.Forms.TextBox txtboxWindDirection;
		private System.Windows.Forms.Label lblWindDirection;
		private System.Windows.Forms.TextBox outputTextbox;
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.TextBox txtboxCourse;
	}
}

