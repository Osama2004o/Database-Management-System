namespace resturantManagementSystem
{
    partial class update_reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_reservation));
            this.button1 = new System.Windows.Forms.Button();
            this.tbReservationDate = new System.Windows.Forms.TextBox();
            this.tbReservationId = new System.Windows.Forms.TextBox();
            this.tbSatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(604, 114);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbReservationDate
            // 
            this.tbReservationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tbReservationDate.Location = new System.Drawing.Point(361, 125);
            this.tbReservationDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbReservationDate.Name = "tbReservationDate";
            this.tbReservationDate.Size = new System.Drawing.Size(204, 48);
            this.tbReservationDate.TabIndex = 1;
            // 
            // tbReservationId
            // 
            this.tbReservationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tbReservationId.Location = new System.Drawing.Point(361, 45);
            this.tbReservationId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbReservationId.Name = "tbReservationId";
            this.tbReservationId.Size = new System.Drawing.Size(204, 48);
            this.tbReservationId.TabIndex = 2;
            // 
            // tbSatus
            // 
            this.tbSatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tbSatus.Location = new System.Drawing.Point(361, 206);
            this.tbSatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSatus.Name = "tbSatus";
            this.tbSatus.Size = new System.Drawing.Size(204, 48);
            this.tbSatus.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reservation Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "Reservation ID";
            // 
            // update_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(792, 309);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSatus);
            this.Controls.Add(this.tbReservationId);
            this.Controls.Add(this.tbReservationDate);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "update_reservation";
            this.Text = "Update Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbReservationDate;
        private System.Windows.Forms.TextBox tbReservationId;
        private System.Windows.Forms.TextBox tbSatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}