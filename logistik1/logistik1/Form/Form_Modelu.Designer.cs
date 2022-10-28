namespace logistik1
{
    partial class Modelu
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
            this.cmbmarka = new System.Windows.Forms.ComboBox();
            this.txtctrl = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dgvSasan = new System.Windows.Forms.DataGridView();
            this.txtnaran = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSasan)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbmarka
            // 
            this.cmbmarka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbmarka.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmarka.FormattingEnabled = true;
            this.cmbmarka.Location = new System.Drawing.Point(70, 49);
            this.cmbmarka.Name = "cmbmarka";
            this.cmbmarka.Size = new System.Drawing.Size(304, 25);
            this.cmbmarka.TabIndex = 1;
            this.cmbmarka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbmarka_KeyPress);
            // 
            // txtctrl
            // 
            this.txtctrl.Location = new System.Drawing.Point(71, 301);
            this.txtctrl.Name = "txtctrl";
            this.txtctrl.Size = new System.Drawing.Size(27, 20);
            this.txtctrl.TabIndex = 8;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(41, 301);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(27, 20);
            this.txtid.TabIndex = 7;
            // 
            // dgvSasan
            // 
            this.dgvSasan.AllowUserToAddRows = false;
            this.dgvSasan.AllowUserToDeleteRows = false;
            this.dgvSasan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSasan.Location = new System.Drawing.Point(4, 137);
            this.dgvSasan.Name = "dgvSasan";
            this.dgvSasan.ReadOnly = true;
            this.dgvSasan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSasan.Size = new System.Drawing.Size(611, 219);
            this.dgvSasan.TabIndex = 6;
            this.dgvSasan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSasan_CellClick);
            // 
            // txtnaran
            // 
            this.txtnaran.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnaran.Location = new System.Drawing.Point(70, 76);
            this.txtnaran.Name = "txtnaran";
            this.txtnaran.Size = new System.Drawing.Size(304, 22);
            this.txtnaran.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(163, 104);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(98, 30);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click_1);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(57, 104);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 30);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // Modelu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(621, 362);
            this.Controls.Add(this.cmbmarka);
            this.Controls.Add(this.txtctrl);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dgvSasan);
            this.Controls.Add(this.txtnaran);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modelu";
            this.Text = "Modelu";
            this.Load += new System.EventHandler(this.Modelu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSasan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbmarka;
        private System.Windows.Forms.TextBox txtctrl;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView dgvSasan;
        private System.Windows.Forms.TextBox txtnaran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
    }
}