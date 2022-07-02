namespace Contact_Tracing_2._0
{
    partial class QR_Code_Scanner
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
            this.components = new System.ComponentModel.Container();
            this.cmbxCam = new System.Windows.Forms.ComboBox();
            this.lblCamera = new System.Windows.Forms.Label();
            this.pctrbxscan = new System.Windows.Forms.PictureBox();
            this.txtbxQRCodeScan = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.lblQRCodeScanner = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxscan)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxCam
            // 
            this.cmbxCam.FormattingEnabled = true;
            this.cmbxCam.Location = new System.Drawing.Point(82, 69);
            this.cmbxCam.Name = "cmbxCam";
            this.cmbxCam.Size = new System.Drawing.Size(263, 23);
            this.cmbxCam.TabIndex = 21;
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Location = new System.Drawing.Point(25, 77);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(51, 15);
            this.lblCamera.TabIndex = 20;
            this.lblCamera.Text = "Camera:";
            // 
            // pctrbxscan
            // 
            this.pctrbxscan.BackColor = System.Drawing.Color.White;
            this.pctrbxscan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctrbxscan.Location = new System.Drawing.Point(25, 109);
            this.pctrbxscan.Name = "pctrbxscan";
            this.pctrbxscan.Size = new System.Drawing.Size(320, 282);
            this.pctrbxscan.TabIndex = 19;
            this.pctrbxscan.TabStop = false;
            // 
            // txtbxQRCodeScan
            // 
            this.txtbxQRCodeScan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxQRCodeScan.Location = new System.Drawing.Point(360, 109);
            this.txtbxQRCodeScan.Multiline = true;
            this.txtbxQRCodeScan.Name = "txtbxQRCodeScan";
            this.txtbxQRCodeScan.Size = new System.Drawing.Size(436, 282);
            this.txtbxQRCodeScan.TabIndex = 18;
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnScan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnScan.Location = new System.Drawing.Point(119, 397);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(117, 33);
            this.btnScan.TabIndex = 17;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lblQRCodeScanner
            // 
            this.lblQRCodeScanner.AutoSize = true;
            this.lblQRCodeScanner.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblQRCodeScanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQRCodeScanner.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQRCodeScanner.Location = new System.Drawing.Point(119, 31);
            this.lblQRCodeScanner.Name = "lblQRCodeScanner";
            this.lblQRCodeScanner.Size = new System.Drawing.Size(134, 23);
            this.lblQRCodeScanner.TabIndex = 16;
            this.lblQRCodeScanner.Text = "QR Code Scanner";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnRead.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRead.Location = new System.Drawing.Point(524, 397);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(117, 33);
            this.btnRead.TabIndex = 22;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // QR_Code_Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 453);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.cmbxCam);
            this.Controls.Add(this.lblCamera);
            this.Controls.Add(this.pctrbxscan);
            this.Controls.Add(this.txtbxQRCodeScan);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.lblQRCodeScanner);
            this.Name = "QR_Code_Scanner";
            this.Text = "QR_Code_Scanner";
            this.Load += new System.EventHandler(this.QR_Code_Scanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxscan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbxCam;
        private Label lblCamera;
        private PictureBox pctrbxscan;
        private TextBox txtbxQRCodeScan;
        private Button btnScan;
        private Label lblQRCodeScanner;
        private System.Windows.Forms.Timer timer1;
        private Button btnRead;
    }
}