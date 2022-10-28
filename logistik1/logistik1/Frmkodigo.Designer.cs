namespace logistik1
{
    partial class Frmkodigo
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
            this.dgvkodigo = new System.Windows.Forms.DataGridView();
            this.txtkodigo = new System.Windows.Forms.TextBox();
            this.lblkodigo = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtctrl
            // 
            this.txtctrl.Location = new System.Drawing.Point(167, 241);
            this.txtctrl.Name = "txtctrl";
            this.txtctrl.Size = new System.Drawing.Size(27, 20);
            this.txtctrl.TabIndex = 15;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(137, 241);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(27, 20);
            this.txtid.TabIndex = 14;
            // 
            // dgvkodigo
            // 
            this.dgvkodigo.AllowUserToAddRows = false;
            this.dgvkodigo.AllowUserToDeleteRows = false;
            this.dgvkodigo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkodigo.Location = new System.Drawing.Point(89, 100);
            this.dgvkodigo.Name = "dgvkodigo";
            this.dgvkodigo.ReadOnly = true;
            this.dgvkodigo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvkodigo.Size = new System.Drawing.Size(552, 219);
            this.dgvkodigo.TabIndex = 13;
            this.dgvkodigo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkodigo_CellClick);
            // 
            // txtkodigo
            // 
            this.txtkodigo.Location = new System.Drawing.Point(232, 26);
            this.txtkodigo.Name = "txtkodigo";
            this.txtkodigo.Size = new System.Drawing.Size(304, 20);
            this.txtkodigo.TabIndex = 9;
            // 
            // lblkodigo
            // 
            this.lblkodigo.AutoSize = true;
            this.lblkodigo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkodigo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblkodigo.Location = new System.Drawing.Point(130, 28);
            this.lblkodigo.Name = "lblkodigo";
            this.lblkodigo.Size = new System.Drawing.Size(50, 17);
            this.lblkodigo.TabIndex = 8;
            this.lblkodigo.Text = "Kodigo";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(438, 54);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(98, 30);
            this.btncancel.TabIndex = 12;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(333, 54);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(104, 30);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(232, 54);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 30);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Frmkodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(678, 343);
            this.Controls.Add(this.txtctrl);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dgvkodigo);
            this.Controls.Add(this.txtkodigo);
            this.Controls.Add(this.lblkodigo);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmkodigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmkodigo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvkodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtctrl;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView dgvkodigo;
        private System.Windows.Forms.TextBox txtkodigo;
        private System.Windows.Forms.Label lblkodigo;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
    }
}