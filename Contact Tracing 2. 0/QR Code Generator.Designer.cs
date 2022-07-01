namespace Contact_Tracing_2._0
{
    partial class QR_Code_Generator
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
            this.lblQRCodeGenerator = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtbxQRCodeGen = new System.Windows.Forms.TextBox();
            this.pctrbxCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxCode)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQRCodeGenerator
            // 
            this.lblQRCodeGenerator.AutoSize = true;
            this.lblQRCodeGenerator.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblQRCodeGenerator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQRCodeGenerator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQRCodeGenerator.Location = new System.Drawing.Point(119, 13);
            this.lblQRCodeGenerator.Name = "lblQRCodeGenerator";
            this.lblQRCodeGenerator.Size = new System.Drawing.Size(148, 23);
            this.lblQRCodeGenerator.TabIndex = 0;
            this.lblQRCodeGenerator.Text = "QR Code Generator";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.Location = new System.Drawing.Point(131, 406);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(117, 33);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtbxQRCodeGen
            // 
            this.txtbxQRCodeGen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxQRCodeGen.Location = new System.Drawing.Point(35, 337);
            this.txtbxQRCodeGen.Multiline = true;
            this.txtbxQRCodeGen.Name = "txtbxQRCodeGen";
            this.txtbxQRCodeGen.Size = new System.Drawing.Size(320, 63);
            this.txtbxQRCodeGen.TabIndex = 2;
            // 
            // pctrbxCode
            // 
            this.pctrbxCode.BackColor = System.Drawing.Color.White;
            this.pctrbxCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctrbxCode.Location = new System.Drawing.Point(35, 49);
            this.pctrbxCode.Name = "pctrbxCode";
            this.pctrbxCode.Size = new System.Drawing.Size(320, 282);
            this.pctrbxCode.TabIndex = 3;
            this.pctrbxCode.TabStop = false;
            // 
            // QR_Code_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.pctrbxCode);
            this.Controls.Add(this.txtbxQRCodeGen);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblQRCodeGenerator);
            this.Name = "QR_Code_Generator";
            this.Text = "QR Code Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblQRCodeGenerator;
        private Button btnGenerate;
        private TextBox txtbxQRCodeGen;
        private PictureBox pctrbxCode;
    }
}