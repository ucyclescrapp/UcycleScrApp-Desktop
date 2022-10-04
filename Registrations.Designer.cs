namespace UCycle
{
    partial class Registrations
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
            this.dgvReg = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtPK = new System.Windows.Forms.TextBox();
            this.btnAppend = new System.Windows.Forms.Button();
            this.btn_caf = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dgvWal = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReg)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReg
            // 
            this.dgvReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReg.Location = new System.Drawing.Point(12, 62);
            this.dgvReg.Name = "dgvReg";
            this.dgvReg.ReadOnly = true;
            this.dgvReg.Size = new System.Drawing.Size(779, 590);
            this.dgvReg.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.txtPK);
            this.panel1.Controls.Add(this.btnAppend);
            this.panel1.Controls.Add(this.btn_caf);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Location = new System.Drawing.Point(144, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 44);
            this.panel1.TabIndex = 167;
            // 
            // btnCopy
            // 
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopy.Location = new System.Drawing.Point(763, 18);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(20, 20);
            this.btnCopy.TabIndex = 172;
            this.btnCopy.Text = "c";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtPK
            // 
            this.txtPK.Location = new System.Drawing.Point(789, 18);
            this.txtPK.Name = "txtPK";
            this.txtPK.ReadOnly = true;
            this.txtPK.Size = new System.Drawing.Size(400, 20);
            this.txtPK.TabIndex = 171;
            // 
            // btnAppend
            // 
            this.btnAppend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppend.Enabled = false;
            this.btnAppend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAppend.Location = new System.Drawing.Point(653, 3);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(84, 35);
            this.btnAppend.TabIndex = 170;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
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
            this.btn_update.Text = "provision";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dgvWal
            // 
            this.dgvWal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWal.Location = new System.Drawing.Point(797, 62);
            this.dgvWal.Name = "dgvWal";
            this.dgvWal.ReadOnly = true;
            this.dgvWal.Size = new System.Drawing.Size(539, 590);
            this.dgvWal.TabIndex = 168;
            this.dgvWal.SelectionChanged += new System.EventHandler(this.dgvWal_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::UCycle.Properties.Resources.ucyclelogorectangle;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 44);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Registrations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 727);
            this.Controls.Add(this.dgvWal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvReg);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Registrations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrations";
            this.Load += new System.EventHandler(this.Registrations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvReg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_caf;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dgvWal;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.TextBox txtPK;
        private System.Windows.Forms.Button btnCopy;
    }
}