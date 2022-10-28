namespace logistik1
{
    partial class Form_sasansai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_sasansai));
            this.txtctrl = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.cmbdept = new System.Windows.Forms.ComboBox();
            this.cmbarmajen = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbkategori = new System.Windows.Forms.ComboBox();
            this.cmbsubkategori = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbmarka = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbmodelo = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtmarkaid = new System.Windows.Forms.TextBox();
            this.txtkatid = new System.Windows.Forms.TextBox();
            this.txtskatid = new System.Windows.Forms.TextBox();
            this.txtsasanidtuan = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnrai = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtctrl
            // 
            this.txtctrl.Location = new System.Drawing.Point(371, 21);
            this.txtctrl.Name = "txtctrl";
            this.txtctrl.Size = new System.Drawing.Size(25, 20);
            this.txtctrl.TabIndex = 0;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(340, 21);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(25, 20);
            this.txtid.TabIndex = 0;
            // 
            // txtqtd
            // 
            this.txtqtd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtd.Location = new System.Drawing.Point(115, 258);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(131, 22);
            this.txtqtd.TabIndex = 5;
            this.txtqtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqtd_KeyPress);
            // 
            // cmbdept
            // 
            this.cmbdept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbdept.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdept.FormattingEnabled = true;
            this.cmbdept.Location = new System.Drawing.Point(115, 130);
            this.cmbdept.Name = "cmbdept";
            this.cmbdept.Size = new System.Drawing.Size(335, 25);
            this.cmbdept.TabIndex = 3;
            this.cmbdept.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbdept_KeyPress);
            // 
            // cmbarmajen
            // 
            this.cmbarmajen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbarmajen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbarmajen.FormattingEnabled = true;
            this.cmbarmajen.Location = new System.Drawing.Point(115, 90);
            this.cmbarmajen.Name = "cmbarmajen";
            this.cmbarmajen.Size = new System.Drawing.Size(335, 25);
            this.cmbarmajen.TabIndex = 2;
            this.cmbarmajen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbarmajen_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(30, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Quantidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(33, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(13, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Departemento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Armajen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Sai";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // cmbkategori
            // 
            this.cmbkategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbkategori.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbkategori.FormattingEnabled = true;
            this.cmbkategori.Location = new System.Drawing.Point(115, 169);
            this.cmbkategori.Name = "cmbkategori";
            this.cmbkategori.Size = new System.Drawing.Size(335, 25);
            this.cmbkategori.TabIndex = 4;
            this.cmbkategori.SelectedIndexChanged += new System.EventHandler(this.cmbkategori_SelectedIndexChanged);
            this.cmbkategori.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbsasan_KeyPress);
            // 
            // cmbsubkategori
            // 
            this.cmbsubkategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbsubkategori.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsubkategori.FormattingEnabled = true;
            this.cmbsubkategori.Location = new System.Drawing.Point(115, 214);
            this.cmbsubkategori.Name = "cmbsubkategori";
            this.cmbsubkategori.Size = new System.Drawing.Size(335, 25);
            this.cmbsubkategori.TabIndex = 23;
            this.cmbsubkategori.SelectedIndexChanged += new System.EventHandler(this.cmbsubkategori_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(26, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Sub Kategori";
            // 
            // cmbmarka
            // 
            this.cmbmarka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbmarka.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmarka.FormattingEnabled = true;
            this.cmbmarka.Location = new System.Drawing.Point(519, 168);
            this.cmbmarka.Name = "cmbmarka";
            this.cmbmarka.Size = new System.Drawing.Size(335, 25);
            this.cmbmarka.TabIndex = 26;
            this.cmbmarka.SelectedIndexChanged += new System.EventHandler(this.cmbmarka_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(456, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "Marka";
            // 
            // cmbmodelo
            // 
            this.cmbmodelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbmodelo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmodelo.FormattingEnabled = true;
            this.cmbmodelo.Location = new System.Drawing.Point(519, 214);
            this.cmbmodelo.Name = "cmbmodelo";
            this.cmbmodelo.Size = new System.Drawing.Size(335, 25);
            this.cmbmodelo.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(459, 222);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 17);
            this.label16.TabIndex = 28;
            this.label16.Text = "Modelo";
            // 
            // txtmarkaid
            // 
            this.txtmarkaid.Location = new System.Drawing.Point(880, 21);
            this.txtmarkaid.Name = "txtmarkaid";
            this.txtmarkaid.Size = new System.Drawing.Size(25, 20);
            this.txtmarkaid.TabIndex = 30;
            this.txtmarkaid.Visible = false;
            // 
            // txtkatid
            // 
            this.txtkatid.Location = new System.Drawing.Point(818, 21);
            this.txtkatid.Name = "txtkatid";
            this.txtkatid.Size = new System.Drawing.Size(25, 20);
            this.txtkatid.TabIndex = 31;
            this.txtkatid.Visible = false;
            // 
            // txtskatid
            // 
            this.txtskatid.Location = new System.Drawing.Point(849, 21);
            this.txtskatid.Name = "txtskatid";
            this.txtskatid.Size = new System.Drawing.Size(25, 20);
            this.txtskatid.TabIndex = 32;
            this.txtskatid.Visible = false;
            // 
            // txtsasanidtuan
            // 
            this.txtsasanidtuan.Location = new System.Drawing.Point(405, 21);
            this.txtsasanidtuan.Name = "txtsasanidtuan";
            this.txtsasanidtuan.Size = new System.Drawing.Size(25, 20);
            this.txtsasanidtuan.TabIndex = 33;
            this.txtsasanidtuan.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 41);
            this.panel1.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inskrisaun Sasan Sai";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.btnrai);
            this.panel3.Controls.Add(this.txtmarkaid);
            this.panel3.Controls.Add(this.txtsasanidtuan);
            this.panel3.Controls.Add(this.txtkatid);
            this.panel3.Controls.Add(this.txtid);
            this.panel3.Controls.Add(this.txtskatid);
            this.panel3.Controls.Add(this.txtctrl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 421);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(909, 59);
            this.panel3.TabIndex = 112;
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(147, 11);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(157, 38);
            this.btnReset.TabIndex = 54;
            this.btnReset.Text = "Restabelese";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnrai
            // 
            this.btnrai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrai.FlatAppearance.BorderSize = 0;
            this.btnrai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnrai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrai.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrai.ForeColor = System.Drawing.Color.White;
            this.btnrai.Image = ((System.Drawing.Image)(resources.GetObject("btnrai.Image")));
            this.btnrai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrai.Location = new System.Drawing.Point(3, 10);
            this.btnrai.Name = "btnrai";
            this.btnrai.Size = new System.Drawing.Size(118, 38);
            this.btnrai.TabIndex = 53;
            this.btnrai.Text = "Rai";
            this.btnrai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnrai.UseVisualStyleBackColor = true;
            this.btnrai.Click += new System.EventHandler(this.btnrai_Click);
            // 
            // Form_sasansai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(909, 480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbmodelo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbmarka);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbsubkategori);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtqtd);
            this.Controls.Add(this.cmbkategori);
            this.Controls.Add(this.cmbdept);
            this.Controls.Add(this.cmbarmajen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_sasansai";
            this.Text = "Sasan Sai";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_sasansai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtctrl;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtqtd;
        private System.Windows.Forms.ComboBox cmbdept;
        private System.Windows.Forms.ComboBox cmbarmajen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbkategori;
        private System.Windows.Forms.ComboBox cmbsubkategori;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbmarka;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbmodelo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtmarkaid;
        private System.Windows.Forms.TextBox txtkatid;
        private System.Windows.Forms.TextBox txtskatid;
        private System.Windows.Forms.TextBox txtsasanidtuan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnrai;
    }
}