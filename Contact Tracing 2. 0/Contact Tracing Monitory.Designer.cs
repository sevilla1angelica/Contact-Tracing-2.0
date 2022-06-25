namespace Contact_Tracing_2._0
{
    partial class Contact_Tracing_Monitory
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
            this.btnAllrecords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAllrecords
            // 
            this.btnAllrecords.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAllrecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllrecords.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAllrecords.Location = new System.Drawing.Point(21, 12);
            this.btnAllrecords.Name = "btnAllrecords";
            this.btnAllrecords.Size = new System.Drawing.Size(110, 37);
            this.btnAllrecords.TabIndex = 0;
            this.btnAllrecords.Text = "All Records";
            this.btnAllrecords.UseVisualStyleBackColor = false;
            this.btnAllrecords.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // Contact_Tracing_Monitory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.btnAllrecords);
            this.Name = "Contact_Tracing_Monitory";
            this.Text = "Contact_Tracing_Monitory";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAllrecords;
    }
}