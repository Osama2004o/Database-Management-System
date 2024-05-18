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
            this.dgView = new System.Windows.Forms.DataGridView();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(71, 123);
            this.dgView.Name = "dgView";
            this.dgView.RowHeadersWidth = 51;
            this.dgView.RowTemplate.Height = 24;
            this.dgView.Size = new System.Drawing.Size(671, 289);
            this.dgView.TabIndex = 0;
            // 
            // cbTables
            // 
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
            this.cbTables.Location = new System.Drawing.Point(71, 35);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(121, 24);
            this.cbTables.TabIndex = 1;
            this.cbTables.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "selected";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(338, 43);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(13, 16);
            this.lblValue.TabIndex = 3;
            this.lblValue.Text = "..";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // show_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTables);
            this.Controls.Add(this.dgView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "show_Data";
            this.Text = "show_Data";
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
    }
}