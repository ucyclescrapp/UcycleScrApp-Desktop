namespace UCycle
{
    partial class BarterSchedule
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_caf = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dgvSche = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_caf);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 44);
            this.panel1.TabIndex = 169;
            // 
            // btn_caf
            // 
            this.btn_caf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_caf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_caf.Location = new System.Drawing.Point(3, 3);
            this.btn_caf.Name = "btn_caf";
            this.btn_caf.Size = new System.Drawing.Size(28, 35);
            this.btn_caf.TabIndex = 169;
            this.btn_caf.Text = "\"\"";
            this.btn_caf.UseVisualStyleBackColor = true;
            this.btn_caf.Click += new System.EventHandler(this.btn_caf_Click);
            // 
            // btn_update
            // 
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Location = new System.Drawing.Point(37, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(84, 35);
            this.btn_update.TabIndex = 159;
            this.btn_update.Text = "PROCESS";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dgvSche
            // 
            this.dgvSche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSche.Location = new System.Drawing.Point(12, 102);
            this.dgvSche.Name = "dgvSche";
            this.dgvSche.ReadOnly = true;
            this.dgvSche.Size = new System.Drawing.Size(1324, 600);
            this.dgvSche.TabIndex = 167;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::UCycle.Properties.Resources.ucyclelogorectangle;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 34);
            this.pictureBox1.TabIndex = 168;
            this.pictureBox1.TabStop = false;
            // 
            // BarterSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(190)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1348, 727);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvSche);
            this.Name = "BarterSchedule";
            this.Text = "BarterSchedule";
            this.Load += new System.EventHandler(this.BarterSchedule_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_caf;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvSche;
    }
}