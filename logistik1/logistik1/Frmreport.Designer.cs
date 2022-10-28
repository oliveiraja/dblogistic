namespace logistik1
{
    partial class Frmreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmreport));
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnTaka = new System.Windows.Forms.Button();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.llblto = new System.Windows.Forms.Label();
            this.lblhusi = new System.Windows.Forms.Label();
            this.dateto = new System.Windows.Forms.DateTimePicker();
            this.datehusi = new System.Windows.Forms.DateTimePicker();
            this.btnprint = new System.Windows.Forms.Button();
            this.pnlContent.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlTitle);
            this.pnlContent.Controls.Add(this.llblto);
            this.pnlContent.Controls.Add(this.lblhusi);
            this.pnlContent.Controls.Add(this.dateto);
            this.pnlContent.Controls.Add(this.datehusi);
            this.pnlContent.Controls.Add(this.btnprint);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(800, 450);
            this.pnlContent.TabIndex = 0;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.DimGray;
            this.pnlTitle.Controls.Add(this.btnTaka);
            this.pnlTitle.Controls.Add(this.lblTitlu);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(800, 33);
            this.pnlTitle.TabIndex = 90;
            // 
            // btnTaka
            // 
            this.btnTaka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaka.FlatAppearance.BorderSize = 0;
            this.btnTaka.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTaka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaka.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaka.ForeColor = System.Drawing.Color.Maroon;
            this.btnTaka.Image = ((System.Drawing.Image)(resources.GetObject("btnTaka.Image")));
            this.btnTaka.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaka.Location = new System.Drawing.Point(762, 3);
            this.btnTaka.Name = "btnTaka";
            this.btnTaka.Size = new System.Drawing.Size(35, 30);
            this.btnTaka.TabIndex = 0;
            this.btnTaka.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaka.UseVisualStyleBackColor = true;
            this.btnTaka.Click += new System.EventHandler(this.btnTaka_Click);
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.Color.White;
            this.lblTitlu.Location = new System.Drawing.Point(6, 5);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(96, 23);
            this.lblTitlu.TabIndex = 1;
            this.lblTitlu.Text = "Relatorio";
            // 
            // llblto
            // 
            this.llblto.AutoSize = true;
            this.llblto.Location = new System.Drawing.Point(264, 43);
            this.llblto.Name = "llblto";
            this.llblto.Size = new System.Drawing.Size(20, 13);
            this.llblto.TabIndex = 7;
            this.llblto.Text = "To";
            // 
            // lblhusi
            // 
            this.lblhusi.AutoSize = true;
            this.lblhusi.Location = new System.Drawing.Point(24, 42);
            this.lblhusi.Name = "lblhusi";
            this.lblhusi.Size = new System.Drawing.Size(28, 13);
            this.lblhusi.TabIndex = 6;
            this.lblhusi.Text = "Husi";
            // 
            // dateto
            // 
            this.dateto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateto.Location = new System.Drawing.Point(290, 43);
            this.dateto.Name = "dateto";
            this.dateto.Size = new System.Drawing.Size(200, 20);
            this.dateto.TabIndex = 5;
            // 
            // datehusi
            // 
            this.datehusi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datehusi.Location = new System.Drawing.Point(58, 41);
            this.datehusi.Name = "datehusi";
            this.datehusi.Size = new System.Drawing.Size(200, 20);
            this.datehusi.TabIndex = 4;
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(518, 41);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 23);
            this.btnprint.TabIndex = 3;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // Frmreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmreport";
            this.Text = "Frmreport";
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.DateTimePicker dateto;
        private System.Windows.Forms.DateTimePicker datehusi;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label llblto;
        private System.Windows.Forms.Label lblhusi;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnTaka;
        private System.Windows.Forms.Label lblTitlu;
    }
}