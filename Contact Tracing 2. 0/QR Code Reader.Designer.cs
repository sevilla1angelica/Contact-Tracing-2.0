namespace Contact_Tracing_2._0
{
    partial class QR_Code_Reader
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
            this.pctrbxCode = new System.Windows.Forms.PictureBox();
            this.txtbxQRCodeGen = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.lblQRCodeScanner = new System.Windows.Forms.Label();
            this.lblCamera = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrbxCode
            // 
            this.pctrbxCode.BackColor = System.Drawing.Color.White;
            this.pctrbxCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctrbxCode.Location = new System.Drawing.Point(21, 96);
            this.pctrbxCode.Name = "pctrbxCode";
            this.pctrbxCode.Size = new System.Drawing.Size(320, 282);
            this.pctrbxCode.TabIndex = 7;
            this.pctrbxCode.TabStop = false;
            // 
            // txtbxQRCodeGen
            // 
            this.txtbxQRCodeGen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxQRCodeGen.Location = new System.Drawing.Point(21, 384);
            this.txtbxQRCodeGen.Multiline = true;
            this.txtbxQRCodeGen.Name = "txtbxQRCodeGen";
            this.txtbxQRCodeGen.Size = new System.Drawing.Size(320, 63);
            this.txtbxQRCodeGen.TabIndex = 6;
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnScan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnScan.Location = new System.Drawing.Point(120, 453);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(117, 33);
            this.btnScan.TabIndex = 5;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = false;
            // 
            // lblQRCodeScanner
            // 
            this.lblQRCodeScanner.AutoSize = true;
            this.lblQRCodeScanner.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblQRCodeScanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQRCodeScanner.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQRCodeScanner.Location = new System.Drawing.Point(115, 18);
            this.lblQRCodeScanner.Name = "lblQRCodeScanner";
            this.lblQRCodeScanner.Size = new System.Drawing.Size(134, 23);
            this.lblQRCodeScanner.TabIndex = 4;
            this.lblQRCodeScanner.Text = "QR Code Scanner";
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Location = new System.Drawing.Point(21, 59);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(51, 15);
            this.lblCamera.TabIndex = 8;
            this.lblCamera.Text = "Camera:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // QR_Code_Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 486);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCamera);
            this.Controls.Add(this.pctrbxCode);
            this.Controls.Add(this.txtbxQRCodeGen);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.lblQRCodeScanner);
            this.Name = "QR_Code_Reader";
            this.Text = "QR_Code_Reader";
            this.Load += new System.EventHandler(this.QR_Code_Reader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pctrbxCode;
        private TextBox txtbxQRCodeGen;
        private Button btnScan;
        private Label lblQRCodeScanner;
        private Label lblCamera;
        private ComboBox comboBox1;
    }
}