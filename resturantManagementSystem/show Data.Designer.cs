namespace resturantManagementSystem
{
    partial class show_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(show_Data));
            this.dgView = new System.Windows.Forms.DataGridView();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(72, 195);
            this.dgView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgView.Name = "dgView";
            this.dgView.RowHeadersWidth = 51;
            this.dgView.RowTemplate.Height = 24;
            this.dgView.Size = new System.Drawing.Size(755, 361);
            this.dgView.TabIndex = 0;
            // 
            // cbTables
            // 
            this.cbTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Items.AddRange(new object[] {
            "[User]",
            "[Order]",
            "Payment",
            "TableReservation",
            "Restaurant",
            "Branch",
            "MenuItem",
            "Contain"});
            this.cbTables.Location = new System.Drawing.Point(72, 87);
            this.cbTables.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(176, 44);
            this.cbTables.TabIndex = 1;
            this.cbTables.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(254, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected:";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.Location = new System.Drawing.Point(387, 95);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(19, 28);
            this.lblValue.TabIndex = 3;
            this.lblValue.Text = " ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Font = new System.Drawing.Font("Gotham", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(578, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gotham", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(154, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(581, 41);
            this.label6.TabIndex = 36;
            this.label6.Text = "Select Data You Want to Show";
            // 
            // show_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(900, 586);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTables);
            this.Controls.Add(this.dgView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "show_Data";
            this.Text = "Show Data";
            this.Load += new System.EventHandler(this.show_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}