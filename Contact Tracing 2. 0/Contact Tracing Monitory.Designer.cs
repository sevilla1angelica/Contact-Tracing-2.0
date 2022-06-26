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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnAllrecords
            // 
            this.btnAllrecords.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAllrecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllrecords.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAllrecords.Location = new System.Drawing.Point(12, 33);
            this.btnAllrecords.Name = "btnAllrecords";
            this.btnAllrecords.Size = new System.Drawing.Size(76, 22);
            this.btnAllrecords.TabIndex = 0;
            this.btnAllrecords.Text = "All Records";
            this.btnAllrecords.UseVisualStyleBackColor = false;
            this.btnAllrecords.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Contact_Tracing_Monitory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(611, 386);
            this.Controls.Add(this.btnAllrecords);
            this.Name = "Contact_Tracing_Monitory";
            this.Text = "Contact_Tracing_Monitory";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAllrecords;
        private OpenFileDialog openFileDialog;
    }
}