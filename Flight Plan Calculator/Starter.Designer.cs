namespace FlightPlanCalculator {
	partial class windowStarter {
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
			this.developer = new System.Windows.Forms.Label();
			this.title = new System.Windows.Forms.Label();
			this.btnHeadingAndGroundspeed = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// developer
			// 
			this.developer.AutoSize = true;
			this.developer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.developer.Location = new System.Drawing.Point(250, 80);
			this.developer.Name = "developer";
			this.developer.Size = new System.Drawing.Size(89, 13);
			this.developer.TabIndex = 3;
			this.developer.Text = "By: Christian Loth";
			this.developer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.Location = new System.Drawing.Point(145, 40);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(293, 33);
			this.title.TabIndex = 2;
			this.title.Text = "Flight Plan Calculator";
			// 
			// btnHeadingAndGroundspeed
			// 
			this.btnHeadingAndGroundspeed.Location = new System.Drawing.Point(73, 134);
			this.btnHeadingAndGroundspeed.Name = "btnHeadingAndGroundspeed";
			this.btnHeadingAndGroundspeed.Size = new System.Drawing.Size(150, 46);
			this.btnHeadingAndGroundspeed.TabIndex = 1;
			this.btnHeadingAndGroundspeed.Text = "Heading and Groundspeed";
			this.btnHeadingAndGroundspeed.UseVisualStyleBackColor = true;
			this.btnHeadingAndGroundspeed.Click += new System.EventHandler(this.btnHeadingAndGroundspeed_Click);
			// 
			// windowStarter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 561);
			this.Controls.Add(this.btnHeadingAndGroundspeed);
			this.Controls.Add(this.developer);
			this.Controls.Add(this.title);
			this.Name = "windowStarter";
			this.Text = "Flight Plan Calculator";
			this.Load += new System.EventHandler(this.windowFPC_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label developer;
		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Button btnHeadingAndGroundspeed;
	}
}