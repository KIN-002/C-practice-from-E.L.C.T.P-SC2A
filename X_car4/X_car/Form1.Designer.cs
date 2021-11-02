namespace X_car
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
            this.car = new System.Windows.Forms.PictureBox();
            this.Left = new System.Windows.Forms.PictureBox();
            this.up = new System.Windows.Forms.PictureBox();
            this.Right = new System.Windows.Forms.PictureBox();
            this.Down = new System.Windows.Forms.PictureBox();
            this.Leftlabel = new System.Windows.Forms.Label();
            this.uplabel = new System.Windows.Forms.Label();
            this.Rightlabel = new System.Windows.Forms.Label();
            this.Downlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Down)).BeginInit();
            this.SuspendLayout();
            // 
            // car
            // 
            this.car.Image = global::X_car.Properties.Resources.BMW_car;
            this.car.Location = new System.Drawing.Point(660, 168);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(137, 94);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 0;
            this.car.TabStop = false;
            // 
            // Left
            // 
            this.Left.Image = global::X_car.Properties.Resources.left;
            this.Left.Location = new System.Drawing.Point(487, 344);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(87, 33);
            this.Left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Left.TabIndex = 1;
            this.Left.TabStop = false;
            // 
            // up
            // 
            this.up.Image = global::X_car.Properties.Resources.up;
            this.up.Location = new System.Drawing.Point(580, 295);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(38, 52);
            this.up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.up.TabIndex = 2;
            this.up.TabStop = false;
            // 
            // Right
            // 
            this.Right.Image = global::X_car.Properties.Resources.right;
            this.Right.Location = new System.Drawing.Point(635, 343);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(73, 34);
            this.Right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Right.TabIndex = 3;
            this.Right.TabStop = false;
            // 
            // Down
            // 
            this.Down.Image = global::X_car.Properties.Resources.down;
            this.Down.Location = new System.Drawing.Point(580, 374);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(39, 52);
            this.Down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Down.TabIndex = 4;
            this.Down.TabStop = false;
            // 
            // Leftlabel
            // 
            this.Leftlabel.AutoSize = true;
            this.Leftlabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Leftlabel.Location = new System.Drawing.Point(452, 352);
            this.Leftlabel.Name = "Leftlabel";
            this.Leftlabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Leftlabel.Size = new System.Drawing.Size(24, 12);
            this.Leftlabel.TabIndex = 5;
            this.Leftlabel.Text = "Left";
            this.Leftlabel.Visible = false;
            // 
            // uplabel
            // 
            this.uplabel.AutoSize = true;
            this.uplabel.Location = new System.Drawing.Point(590, 280);
            this.uplabel.Name = "uplabel";
            this.uplabel.Size = new System.Drawing.Size(19, 12);
            this.uplabel.TabIndex = 6;
            this.uplabel.Text = "UP";
            this.uplabel.Visible = false;
            // 
            // Rightlabel
            // 
            this.Rightlabel.AutoSize = true;
            this.Rightlabel.Location = new System.Drawing.Point(714, 352);
            this.Rightlabel.Name = "Rightlabel";
            this.Rightlabel.Size = new System.Drawing.Size(31, 12);
            this.Rightlabel.TabIndex = 7;
            this.Rightlabel.Text = "Right";
            this.Rightlabel.Visible = false;
            // 
            // Downlabel
            // 
            this.Downlabel.AutoSize = true;
            this.Downlabel.Location = new System.Drawing.Point(589, 429);
            this.Downlabel.Name = "Downlabel";
            this.Downlabel.Size = new System.Drawing.Size(33, 12);
            this.Downlabel.TabIndex = 8;
            this.Downlabel.Text = "Down";
            this.Downlabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "速度:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Downlabel);
            this.Controls.Add(this.Rightlabel);
            this.Controls.Add(this.uplabel);
            this.Controls.Add(this.Leftlabel);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.up);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.car);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Down)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox car;
		private System.Windows.Forms.PictureBox Left;
		private System.Windows.Forms.PictureBox up;
		private System.Windows.Forms.PictureBox Right;
		private System.Windows.Forms.PictureBox Down;
		private System.Windows.Forms.Label Leftlabel;
		private System.Windows.Forms.Label uplabel;
		private System.Windows.Forms.Label Rightlabel;
		private System.Windows.Forms.Label Downlabel;
        private System.Windows.Forms.Label label1;
    }
}

