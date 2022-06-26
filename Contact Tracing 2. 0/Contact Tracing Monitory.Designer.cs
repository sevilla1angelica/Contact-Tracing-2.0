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
            this.lblPath = new System.Windows.Forms.Label();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
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
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPath.Location = new System.Drawing.Point(138, 36);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(32, 13);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "Path:";
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbxSearch.Location = new System.Drawing.Point(176, 33);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(341, 22);
            this.txtbxSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(523, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 74);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 25;
            this.DataGridView.Size = new System.Drawing.Size(578, 300);
            this.DataGridView.TabIndex = 4;
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
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtbxSearch);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnAllrecords);
            this.Name = "Contact_Tracing_Monitory";
            this.Text = "Contact_Tracing_Monitory";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAllrecords;
        private Label lblPath;
        private TextBox txtbxSearch;
        private Button btnSearch;
        private DataGridView DataGridView;
        private OpenFileDialog openFileDialog;
    }
}