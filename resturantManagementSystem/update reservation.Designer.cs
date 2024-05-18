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
            this.button1.Location = new System.Drawing.Point(382, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbReservationDate
            // 
            this.tbReservationDate.Location = new System.Drawing.Point(421, 68);
            this.tbReservationDate.Name = "tbReservationDate";
            this.tbReservationDate.Size = new System.Drawing.Size(100, 22);
            this.tbReservationDate.TabIndex = 1;
            // 
            // tbReservationId
            // 
            this.tbReservationId.Location = new System.Drawing.Point(421, 157);
            this.tbReservationId.Name = "tbReservationId";
            this.tbReservationId.Size = new System.Drawing.Size(100, 22);
            this.tbReservationId.TabIndex = 2;
            // 
            // tbSatus
            // 
            this.tbSatus.Location = new System.Drawing.Point(421, 113);
            this.tbSatus.Name = "tbSatus";
            this.tbSatus.Size = new System.Drawing.Size(100, 22);
            this.tbSatus.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "reservationDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "reservation id";
            // 
            // update_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSatus);
            this.Controls.Add(this.tbReservationId);
            this.Controls.Add(this.tbReservationDate);
            this.Controls.Add(this.button1);
            this.Name = "update_reservation";
            this.Text = "update_reservation";
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