namespace FlightPlanCalculator
{
    partial class Window
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
			this.title = new System.Windows.Forms.Label();
			this.developer = new System.Windows.Forms.Label();
			this.latitudeALabel = new System.Windows.Forms.Label();
			this.latA = new System.Windows.Forms.TextBox();
			this.latB = new System.Windows.Forms.TextBox();
			this.latitudeBLabel = new System.Windows.Forms.Label();
			this.lonB = new System.Windows.Forms.TextBox();
			this.longitudeBLabel = new System.Windows.Forms.Label();
			this.lonA = new System.Windows.Forms.TextBox();
			this.longitudeALabel = new System.Windows.Forms.Label();
			this.courseLabel = new System.Windows.Forms.Label();
			this.planeVelovity = new System.Windows.Forms.TextBox();
			this.trueAirspeedLabel = new System.Windows.Forms.Label();
			this.windVelocity = new System.Windows.Forms.TextBox();
			this.windVelocityLabel = new System.Windows.Forms.Label();
			this.windDirection = new System.Windows.Forms.TextBox();
			this.windDirectionLabel = new System.Windows.Forms.Label();
			this.outputTextbox = new System.Windows.Forms.TextBox();
			this.outputLabel = new System.Windows.Forms.Label();
			this.calculate = new System.Windows.Forms.Button();
			this.planeDirection = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.Location = new System.Drawing.Point(145, 38);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(293, 33);
			this.title.TabIndex = 0;
			this.title.Text = "Flight Plan Calculator";
			// 
			// developer
			// 
			this.developer.AutoSize = true;
			this.developer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.developer.Location = new System.Drawing.Point(252, 80);
			this.developer.Name = "developer";
			this.developer.Size = new System.Drawing.Size(89, 13);
			this.developer.TabIndex = 1;
			this.developer.Text = "By: Christian Loth";
			this.developer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// latitudeALabel
			// 
			this.latitudeALabel.AutoSize = true;
			this.latitudeALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.latitudeALabel.Location = new System.Drawing.Point(35, 123);
			this.latitudeALabel.Name = "latitudeALabel";
			this.latitudeALabel.Size = new System.Drawing.Size(76, 17);
			this.latitudeALabel.TabIndex = 3;
			this.latitudeALabel.Text = "Latitude A:";
			this.latitudeALabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.latitudeALabel.Click += new System.EventHandler(this.latA_Click);
			// 
			// latA
			// 
			this.latA.Location = new System.Drawing.Point(139, 121);
			this.latA.Name = "latA";
			this.latA.Size = new System.Drawing.Size(125, 20);
			this.latA.TabIndex = 4;
			this.latA.TextChanged += new System.EventHandler(this.latA_TextChanged);
			// 
			// latB
			// 
			this.latB.Location = new System.Drawing.Point(419, 123);
			this.latB.Name = "latB";
			this.latB.Size = new System.Drawing.Size(125, 20);
			this.latB.TabIndex = 6;
			this.latB.TextChanged += new System.EventHandler(this.latB_TextChanged);
			// 
			// latitudeBLabel
			// 
			this.latitudeBLabel.AutoSize = true;
			this.latitudeBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.latitudeBLabel.Location = new System.Drawing.Point(315, 125);
			this.latitudeBLabel.Name = "latitudeBLabel";
			this.latitudeBLabel.Size = new System.Drawing.Size(76, 17);
			this.latitudeBLabel.TabIndex = 5;
			this.latitudeBLabel.Text = "Latitude B:";
			this.latitudeBLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lonB
			// 
			this.lonB.Location = new System.Drawing.Point(419, 177);
			this.lonB.Name = "lonB";
			this.lonB.Size = new System.Drawing.Size(125, 20);
			this.lonB.TabIndex = 10;
			this.lonB.TextChanged += new System.EventHandler(this.lonB_TextChanged);
			// 
			// longitudeBLabel
			// 
			this.longitudeBLabel.AutoSize = true;
			this.longitudeBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.longitudeBLabel.Location = new System.Drawing.Point(315, 179);
			this.longitudeBLabel.Name = "longitudeBLabel";
			this.longitudeBLabel.Size = new System.Drawing.Size(88, 17);
			this.longitudeBLabel.TabIndex = 9;
			this.longitudeBLabel.Text = "Longitude B:";
			this.longitudeBLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lonA
			// 
			this.lonA.Location = new System.Drawing.Point(139, 175);
			this.lonA.Name = "lonA";
			this.lonA.Size = new System.Drawing.Size(125, 20);
			this.lonA.TabIndex = 8;
			this.lonA.TextChanged += new System.EventHandler(this.lonA_TextChanged);
			// 
			// longitudeALabel
			// 
			this.longitudeALabel.AutoSize = true;
			this.longitudeALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.longitudeALabel.Location = new System.Drawing.Point(35, 177);
			this.longitudeALabel.Name = "longitudeALabel";
			this.longitudeALabel.Size = new System.Drawing.Size(88, 17);
			this.longitudeALabel.TabIndex = 7;
			this.longitudeALabel.Text = "Longitude A:";
			this.longitudeALabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// courseLabel
			// 
			this.courseLabel.AutoSize = true;
			this.courseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.courseLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.courseLabel.Location = new System.Drawing.Point(35, 286);
			this.courseLabel.Name = "courseLabel";
			this.courseLabel.Size = new System.Drawing.Size(57, 17);
			this.courseLabel.TabIndex = 17;
			this.courseLabel.Text = "Course:";
			this.courseLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// planeVelovity
			// 
			this.planeVelovity.Location = new System.Drawing.Point(419, 287);
			this.planeVelovity.Name = "planeVelovity";
			this.planeVelovity.Size = new System.Drawing.Size(125, 20);
			this.planeVelovity.TabIndex = 16;
			this.planeVelovity.TextChanged += new System.EventHandler(this.planeVelovity_TextChanged);
			// 
			// trueAirspeedLabel
			// 
			this.trueAirspeedLabel.AutoSize = true;
			this.trueAirspeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.trueAirspeedLabel.Location = new System.Drawing.Point(315, 289);
			this.trueAirspeedLabel.Name = "trueAirspeedLabel";
			this.trueAirspeedLabel.Size = new System.Drawing.Size(102, 17);
			this.trueAirspeedLabel.TabIndex = 15;
			this.trueAirspeedLabel.Text = "True Airspeed:";
			this.trueAirspeedLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// windVelocity
			// 
			this.windVelocity.Location = new System.Drawing.Point(419, 232);
			this.windVelocity.Name = "windVelocity";
			this.windVelocity.Size = new System.Drawing.Size(125, 20);
			this.windVelocity.TabIndex = 14;
			this.windVelocity.TextChanged += new System.EventHandler(this.windVelocity_TextChanged);
			// 
			// windVelocityLabel
			// 
			this.windVelocityLabel.AutoSize = true;
			this.windVelocityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.windVelocityLabel.Location = new System.Drawing.Point(315, 234);
			this.windVelocityLabel.Name = "windVelocityLabel";
			this.windVelocityLabel.Size = new System.Drawing.Size(97, 17);
			this.windVelocityLabel.TabIndex = 13;
			this.windVelocityLabel.Text = "Wind Velocity:";
			this.windVelocityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// windDirection
			// 
			this.windDirection.Location = new System.Drawing.Point(139, 230);
			this.windDirection.Name = "windDirection";
			this.windDirection.Size = new System.Drawing.Size(125, 20);
			this.windDirection.TabIndex = 12;
			this.windDirection.TextChanged += new System.EventHandler(this.windDirection_TextChanged);
			// 
			// windDirectionLabel
			// 
			this.windDirectionLabel.AutoSize = true;
			this.windDirectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.windDirectionLabel.Location = new System.Drawing.Point(35, 232);
			this.windDirectionLabel.Name = "windDirectionLabel";
			this.windDirectionLabel.Size = new System.Drawing.Size(104, 17);
			this.windDirectionLabel.TabIndex = 11;
			this.windDirectionLabel.Text = "Wind Direction:";
			this.windDirectionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// outputTextbox
			// 
			this.outputTextbox.Location = new System.Drawing.Point(182, 482);
			this.outputTextbox.Multiline = true;
			this.outputTextbox.Name = "outputTextbox";
			this.outputTextbox.Size = new System.Drawing.Size(241, 254);
			this.outputTextbox.TabIndex = 19;
			// 
			// outputLabel
			// 
			this.outputLabel.AutoSize = true;
			this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.outputLabel.Location = new System.Drawing.Point(270, 448);
			this.outputLabel.Name = "outputLabel";
			this.outputLabel.Size = new System.Drawing.Size(55, 17);
			this.outputLabel.TabIndex = 20;
			this.outputLabel.Text = "Output:";
			this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// calculate
			// 
			this.calculate.Location = new System.Drawing.Point(255, 410);
			this.calculate.Name = "calculate";
			this.calculate.Size = new System.Drawing.Size(87, 25);
			this.calculate.TabIndex = 21;
			this.calculate.Text = "Calculate";
			this.calculate.UseVisualStyleBackColor = true;
			this.calculate.Click += new System.EventHandler(this.calculate_Click);
			// 
			// planeDirection
			// 
			this.planeDirection.Location = new System.Drawing.Point(139, 285);
			this.planeDirection.Name = "planeDirection";
			this.planeDirection.Size = new System.Drawing.Size(125, 20);
			this.planeDirection.TabIndex = 22;
			this.planeDirection.TextChanged += new System.EventHandler(this.planeDirection_TextChanged);
			// 
			// Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 761);
			this.Controls.Add(this.planeDirection);
			this.Controls.Add(this.calculate);
			this.Controls.Add(this.outputLabel);
			this.Controls.Add(this.outputTextbox);
			this.Controls.Add(this.courseLabel);
			this.Controls.Add(this.planeVelovity);
			this.Controls.Add(this.trueAirspeedLabel);
			this.Controls.Add(this.windVelocity);
			this.Controls.Add(this.windVelocityLabel);
			this.Controls.Add(this.windDirection);
			this.Controls.Add(this.windDirectionLabel);
			this.Controls.Add(this.lonB);
			this.Controls.Add(this.longitudeBLabel);
			this.Controls.Add(this.lonA);
			this.Controls.Add(this.longitudeALabel);
			this.Controls.Add(this.latB);
			this.Controls.Add(this.latitudeBLabel);
			this.Controls.Add(this.latA);
			this.Controls.Add(this.latitudeALabel);
			this.Controls.Add(this.developer);
			this.Controls.Add(this.title);
			this.Name = "Window";
			this.Text = "Flight Plan Calculator";
			this.Load += new System.EventHandler(this.Window_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
		private System.Windows.Forms.Label developer;
		private System.Windows.Forms.Label latitudeALabel;
		private System.Windows.Forms.TextBox latA;
		private System.Windows.Forms.TextBox latB;
		private System.Windows.Forms.Label latitudeBLabel;
		private System.Windows.Forms.TextBox lonB;
		private System.Windows.Forms.Label longitudeBLabel;
		private System.Windows.Forms.TextBox lonA;
		private System.Windows.Forms.Label longitudeALabel;
		private System.Windows.Forms.TextBox course;
		private System.Windows.Forms.Label courseLabel;
		private System.Windows.Forms.TextBox planeVelovity;
		private System.Windows.Forms.Label trueAirspeedLabel;
		private System.Windows.Forms.TextBox windVelocity;
		private System.Windows.Forms.Label windVelocityLabel;
		private System.Windows.Forms.TextBox windDirection;
		private System.Windows.Forms.Label windDirectionLabel;
		private System.Windows.Forms.TextBox outputTextbox;
		private System.Windows.Forms.Label outputLabel;
		private System.Windows.Forms.Button calculate;
		private System.Windows.Forms.TextBox planeDirection;
    }
}

