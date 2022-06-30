namespace Contact_Tracing_2._0
{
    partial class Authorized_Personnel_Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorized_Personnel_Log));
            this.pctrlock = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.btnLog_in = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrlock)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrlock
            // 
            this.pctrlock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctrlock.BackgroundImage")));
            this.pctrlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctrlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctrlock.Location = new System.Drawing.Point(33, 38);
            this.pctrlock.Name = "pctrlock";
            this.pctrlock.Size = new System.Drawing.Size(250, 250);
            this.pctrlock.TabIndex = 0;
            this.pctrlock.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Beige;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblUsername.Location = new System.Drawing.Point(308, 69);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(82, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Beige;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblPassword.Location = new System.Drawing.Point(308, 143);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Location = new System.Drawing.Point(308, 92);
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(100, 23);
            this.txtbxUsername.TabIndex = 3;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(308, 166);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(100, 23);
            this.txtbxPassword.TabIndex = 4;
            this.txtbxPassword.TextChanged += new System.EventHandler(this.txtbxPassword_TextChanged);
            // 
            // btnLog_in
            // 
            this.btnLog_in.BackColor = System.Drawing.Color.Beige;
            this.btnLog_in.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLog_in.Location = new System.Drawing.Point(308, 246);
            this.btnLog_in.Name = "btnLog_in";
            this.btnLog_in.Size = new System.Drawing.Size(82, 28);
            this.btnLog_in.TabIndex = 5;
            this.btnLog_in.Text = "Log in";
            this.btnLog_in.UseVisualStyleBackColor = false;
            this.btnLog_in.Click += new System.EventHandler(this.btnLog_in_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(414, 166);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(46, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(466, 166);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(46, 23);
            this.btnHide.TabIndex = 7;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            // 
            // Authorized_Personnel_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 377);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnLog_in);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.txtbxUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pctrlock);
            this.Name = "Authorized_Personnel_Log";
            this.Text = "Authorized_Personnel_Log";
            ((System.ComponentModel.ISupportInitialize)(this.pctrlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pctrlock;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtbxUsername;
        private TextBox txtbxPassword;
        private Button btnLog_in;
        private Button btnShow;
        private Button btnHide;
    }
}