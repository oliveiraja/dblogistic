namespace logistik1
{
    partial class Form_Kategoria
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
            this.txtctrl = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dgvSasan = new System.Windows.Forms.DataGridView();
            this.txtnaran = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtkodigo = new System.Windows.Forms.TextBox();
            this.lblkodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSasan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtctrl
            // 
            this.txtctrl.Location = new System.Drawing.Point(122, 137);
            this.txtctrl.Name = "txtctrl";
            this.txtctrl.Size = new System.Drawing.Size(27, 20);
            this.txtctrl.TabIndex = 15;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(92, 137);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(27, 20);
            this.txtid.TabIndex = 14;
            // 
            // dgvSasan
            // 
            this.dgvSasan.AllowUserToAddRows = false;
            this.dgvSasan.AllowUserToDeleteRows = false;
            this.dgvSasan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSasan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvSasan.Location = new System.Drawing.Point(3, 97);
            this.dgvSasan.Name = "dgvSasan";
            this.dgvSasan.ReadOnly = true;
            this.dgvSasan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSasan.Size = new System.Drawing.Size(586, 219);
            this.dgvSasan.TabIndex = 13;
            this.dgvSasan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSasan_CellClick);
            // 
            // txtnaran
            // 
            this.txtnaran.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnaran.Location = new System.Drawing.Point(92, 8);
            this.txtnaran.Name = "txtnaran";
            this.txtnaran.Size = new System.Drawing.Size(304, 22);
            this.txtnaran.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(18, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kategoria";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(196, 64);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(98, 30);
            this.btncancel.TabIndex = 12;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(90, 64);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 30);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtkodigo
            // 
            this.txtkodigo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkodigo.Location = new System.Drawing.Point(91, 36);
            this.txtkodigo.Name = "txtkodigo";
            this.txtkodigo.Size = new System.Drawing.Size(304, 22);
            this.txtkodigo.TabIndex = 16;
            // 
            // lblkodigo
            // 
            this.lblkodigo.AutoSize = true;
            this.lblkodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkodigo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblkodigo.Location = new System.Drawing.Point(12, 36);
            this.lblkodigo.Name = "lblkodigo";
            this.lblkodigo.Size = new System.Drawing.Size(55, 17);
            this.lblkodigo.TabIndex = 17;
            this.lblkodigo.Text = "Kodigo";
            // 
            // Form_Kategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(590, 325);
            this.Controls.Add(this.lblkodigo);
            this.Controls.Add(this.txtkodigo);
            this.Controls.Add(this.txtctrl);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dgvSasan);
            this.Controls.Add(this.txtnaran);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Kategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategoria";
            this.Load += new System.EventHandler(this.Form_Kategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSasan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtctrl;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView dgvSasan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        public System.Windows.Forms.TextBox txtnaran;
        public System.Windows.Forms.TextBox txtkodigo;
        private System.Windows.Forms.Label lblkodigo;
    }
}