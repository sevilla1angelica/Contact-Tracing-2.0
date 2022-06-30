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
            this.btnDateSearch = new System.Windows.Forms.Button();
            this.txtbxsearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dateoffillingup = new System.Windows.Forms.DateTimePicker();
            this.rchtxtbxRecord = new System.Windows.Forms.RichTextBox();
            this.btnNameSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAllrecords
            // 
            this.btnAllrecords.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAllrecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllrecords.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAllrecords.Location = new System.Drawing.Point(12, 21);
            this.btnAllrecords.Name = "btnAllrecords";
            this.btnAllrecords.Size = new System.Drawing.Size(76, 22);
            this.btnAllrecords.TabIndex = 0;
            this.btnAllrecords.Text = "All Records";
            this.btnAllrecords.UseVisualStyleBackColor = false;
            this.btnAllrecords.Click += new System.EventHandler(this.btnAllrecords_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnDateSearch
            // 
            this.btnDateSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDateSearch.Location = new System.Drawing.Point(207, 19);
            this.btnDateSearch.Name = "btnDateSearch";
            this.btnDateSearch.Size = new System.Drawing.Size(104, 23);
            this.btnDateSearch.TabIndex = 1;
            this.btnDateSearch.Text = "Search by Date";
            this.btnDateSearch.UseVisualStyleBackColor = true;
            this.btnDateSearch.Click += new System.EventHandler(this.btnDateSearch_Click_1);
            // 
            // txtbxsearch
            // 
            this.txtbxsearch.Location = new System.Drawing.Point(94, 47);
            this.txtbxsearch.Multiline = true;
            this.txtbxsearch.Name = "txtbxsearch";
            this.txtbxsearch.Size = new System.Drawing.Size(107, 23);
            this.txtbxsearch.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(31, 51);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 15);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search by:";
            // 
            // dateoffillingup
            // 
            this.dateoffillingup.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateoffillingup.Location = new System.Drawing.Point(94, 19);
            this.dateoffillingup.Name = "dateoffillingup";
            this.dateoffillingup.Size = new System.Drawing.Size(107, 23);
            this.dateoffillingup.TabIndex = 96;
            this.dateoffillingup.ValueChanged += new System.EventHandler(this.dateoffillingup_ValueChanged);
            // 
            // rchtxtbxRecord
            // 
            this.rchtxtbxRecord.Location = new System.Drawing.Point(94, 96);
            this.rchtxtbxRecord.Name = "rchtxtbxRecord";
            this.rchtxtbxRecord.Size = new System.Drawing.Size(471, 255);
            this.rchtxtbxRecord.TabIndex = 97;
            this.rchtxtbxRecord.Text = "";
            // 
            // btnNameSearch
            // 
            this.btnNameSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNameSearch.Location = new System.Drawing.Point(207, 47);
            this.btnNameSearch.Name = "btnNameSearch";
            this.btnNameSearch.Size = new System.Drawing.Size(104, 23);
            this.btnNameSearch.TabIndex = 98;
            this.btnNameSearch.Text = "Search by Name";
            this.btnNameSearch.UseVisualStyleBackColor = true;
            this.btnNameSearch.Click += new System.EventHandler(this.btnNameSearch_Click_1);
            // 
            // Contact_Tracing_Monitory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(611, 386);
            this.Controls.Add(this.btnNameSearch);
            this.Controls.Add(this.rchtxtbxRecord);
            this.Controls.Add(this.dateoffillingup);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtbxsearch);
            this.Controls.Add(this.btnDateSearch);
            this.Controls.Add(this.btnAllrecords);
            this.Name = "Contact_Tracing_Monitory";
            this.Text = "Contact_Tracing_Monitory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAllrecords;
        private OpenFileDialog openFileDialog;
        private Button btnDateSearch;
        private TextBox txtbxsearch;
        private Label lblSearch;
        private DateTimePicker dateoffillingup;
        private RichTextBox rchtxtbxRecord;
        private Button btnNameSearch;
    }
}