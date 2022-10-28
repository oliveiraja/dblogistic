namespace logistik1
{
    partial class Frmautenticatio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmautenticatio));
            this.txtfunsaun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnaran = new System.Windows.Forms.TextBox();
            this.txtctrl = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnrai = new System.Windows.Forms.Button();
            this.btnkancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dvgautentication = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgautentication)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfunsaun
            // 
            this.txtfunsaun.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtfunsaun.Location = new System.Drawing.Point(111, 156);
            this.txtfunsaun.Name = "txtfunsaun";
            this.txtfunsaun.Size = new System.Drawing.Size(276, 24);
            this.txtfunsaun.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(23, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funsaun";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtemail.Location = new System.Drawing.Point(111, 123);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(276, 24);
            this.txtemail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(31, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtpass.Location = new System.Drawing.Point(111, 87);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(276, 24);
            this.txtpass.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(23, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Naran";
            // 
            // txtnaran
            // 
            this.txtnaran.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtnaran.Location = new System.Drawing.Point(111, 55);
            this.txtnaran.Name = "txtnaran";
            this.txtnaran.Size = new System.Drawing.Size(276, 24);
            this.txtnaran.TabIndex = 6;
            // 
            // txtctrl
            // 
            this.txtctrl.Location = new System.Drawing.Point(536, 263);
            this.txtctrl.Name = "txtctrl";
            this.txtctrl.Size = new System.Drawing.Size(27, 20);
            this.txtctrl.TabIndex = 8;
            this.txtctrl.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(484, 263);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(27, 20);
            this.txtid.TabIndex = 9;
            this.txtid.Visible = false;
            // 
            // btnrai
            // 
            this.btnrai.Location = new System.Drawing.Point(107, 191);
            this.btnrai.Name = "btnrai";
            this.btnrai.Size = new System.Drawing.Size(75, 23);
            this.btnrai.TabIndex = 10;
            this.btnrai.Text = "Rai";
            this.btnrai.UseVisualStyleBackColor = true;
            this.btnrai.Click += new System.EventHandler(this.btnrai_Click);
            // 
            // btnkancel
            // 
            this.btnkancel.Location = new System.Drawing.Point(202, 191);
            this.btnkancel.Name = "btnkancel";
            this.btnkancel.Size = new System.Drawing.Size(75, 23);
            this.btnkancel.TabIndex = 11;
            this.btnkancel.Text = "Kancel";
            this.btnkancel.UseVisualStyleBackColor = true;
            this.btnkancel.Click += new System.EventHandler(this.btnkancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 37);
            this.panel1.TabIndex = 12;
            // 
            // dvgautentication
            // 
            this.dvgautentication.AllowUserToAddRows = false;
            this.dvgautentication.AllowUserToDeleteRows = false;
            this.dvgautentication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgautentication.Location = new System.Drawing.Point(0, 220);
            this.dvgautentication.Name = "dvgautentication";
            this.dvgautentication.ReadOnly = true;
            this.dvgautentication.Size = new System.Drawing.Size(654, 150);
            this.dvgautentication.TabIndex = 13;
            this.dvgautentication.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgautentication_CellClick);
            // 
            // Frmautenticatio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(654, 378);
            this.Controls.Add(this.dvgautentication);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnkancel);
            this.Controls.Add(this.btnrai);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtctrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnaran);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfunsaun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmautenticatio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Autenticatio";
            ((System.ComponentModel.ISupportInitialize)(this.dvgautentication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfunsaun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnaran;
        private System.Windows.Forms.TextBox txtctrl;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnrai;
        private System.Windows.Forms.Button btnkancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dvgautentication;
    }
}