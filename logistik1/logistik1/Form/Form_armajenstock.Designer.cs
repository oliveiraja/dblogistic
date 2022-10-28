namespace logistik1
{
    partial class Form_armajenstock
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
            this.dgvsasan = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsasan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsasan
            // 
            this.dgvsasan.AllowUserToAddRows = false;
            this.dgvsasan.AllowUserToDeleteRows = false;
            this.dgvsasan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsasan.Location = new System.Drawing.Point(23, 90);
            this.dgvsasan.Name = "dgvsasan";
            this.dgvsasan.ReadOnly = true;
            this.dgvsasan.Size = new System.Drawing.Size(709, 314);
            this.dgvsasan.TabIndex = 0;
            this.dgvsasan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsasan_CellClick);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(23, 52);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 32);
            this.btnrefresh.TabIndex = 1;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // Form_armajenstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 416);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.dgvsasan);
            this.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_armajenstock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Armajen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvsasan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsasan;
        private System.Windows.Forms.Button btnrefresh;
    }
}