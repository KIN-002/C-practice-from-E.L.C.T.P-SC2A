namespace X_rand
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
            this.red = new System.Windows.Forms.Label();
            this.green = new System.Windows.Forms.Label();
            this.blue = new System.Windows.Forms.Label();
            this.SetColor_button = new System.Windows.Forms.Button();
            this.White_button = new System.Windows.Forms.Button();
            this.Black_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Font = new System.Drawing.Font("新細明體", 15F);
            this.red.Location = new System.Drawing.Point(102, 29);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(34, 20);
            this.red.TabIndex = 0;
            this.red.Text = "紅:";
            // 
            // green
            // 
            this.green.AutoSize = true;
            this.green.Font = new System.Drawing.Font("新細明體", 15F);
            this.green.Location = new System.Drawing.Point(102, 63);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(34, 20);
            this.green.TabIndex = 1;
            this.green.Text = "綠:";
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Font = new System.Drawing.Font("新細明體", 15F);
            this.blue.Location = new System.Drawing.Point(102, 95);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(34, 20);
            this.blue.TabIndex = 2;
            this.blue.Text = "藍:";
            // 
            // SetColor_button
            // 
            this.SetColor_button.Font = new System.Drawing.Font("新細明體", 10F);
            this.SetColor_button.Location = new System.Drawing.Point(106, 153);
            this.SetColor_button.Name = "SetColor_button";
            this.SetColor_button.Size = new System.Drawing.Size(75, 23);
            this.SetColor_button.TabIndex = 3;
            this.SetColor_button.Text = "SetColor";
            this.SetColor_button.UseVisualStyleBackColor = true;
            this.SetColor_button.Click += new System.EventHandler(this.SetColor_button_Click);
            // 
            // White_button
            // 
            this.White_button.Font = new System.Drawing.Font("新細明體", 10F);
            this.White_button.Location = new System.Drawing.Point(37, 198);
            this.White_button.Name = "White_button";
            this.White_button.Size = new System.Drawing.Size(75, 23);
            this.White_button.TabIndex = 4;
            this.White_button.Text = "White";
            this.White_button.UseVisualStyleBackColor = true;
            this.White_button.Click += new System.EventHandler(this.White_button_Click);
            // 
            // Black_button
            // 
            this.Black_button.Font = new System.Drawing.Font("新細明體", 10F);
            this.Black_button.Location = new System.Drawing.Point(174, 198);
            this.Black_button.Name = "Black_button";
            this.Black_button.Size = new System.Drawing.Size(75, 23);
            this.Black_button.TabIndex = 5;
            this.Black_button.Text = "Black";
            this.Black_button.UseVisualStyleBackColor = true;
            this.Black_button.Click += new System.EventHandler(this.Black_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 251);
            this.Controls.Add(this.Black_button);
            this.Controls.Add(this.White_button);
            this.Controls.Add(this.SetColor_button);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.green);
            this.Controls.Add(this.red);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label red;
        private System.Windows.Forms.Label green;
        private System.Windows.Forms.Label blue;
        private System.Windows.Forms.Button SetColor_button;
        private System.Windows.Forms.Button White_button;
        private System.Windows.Forms.Button Black_button;
    }
}

