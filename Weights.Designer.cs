﻿namespace UCycle
{
    partial class Weights
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
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.cmb_plastictype = new System.Windows.Forms.ComboBox();
            this.cmb_color = new System.Windows.Forms.ComboBox();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_plastictype = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pb_plastic = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label7 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_regdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_itempicture = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_plasticname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_plasticcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.dgvVari = new System.Windows.Forms.DataGridView();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_plastic)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVari)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_caf);
            this.panel1.Controls.Add(this.btn_create);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Location = new System.Drawing.Point(108, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 34);
            this.panel1.TabIndex = 165;
            // 
            // btn_caf
            // 
            this.btn_caf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_caf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_caf.Location = new System.Drawing.Point(3, 3);
            this.btn_caf.Name = "btn_caf";
            this.btn_caf.Size = new System.Drawing.Size(28, 28);
            this.btn_caf.TabIndex = 169;
            this.btn_caf.Text = "\"\"";
            this.btn_caf.UseVisualStyleBackColor = true;
            this.btn_caf.Click += new System.EventHandler(this.btn_caf_Click);
            // 
            // btn_create
            // 
            this.btn_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_create.Location = new System.Drawing.Point(71, 3);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(28, 28);
            this.btn_create.TabIndex = 158;
            this.btn_create.Text = "+";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_update
            // 
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Location = new System.Drawing.Point(105, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(28, 28);
            this.btn_update.TabIndex = 159;
            this.btn_update.Text = "u";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cmb_plastictype
            // 
            this.cmb_plastictype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_plastictype.FormattingEnabled = true;
            this.cmb_plastictype.Items.AddRange(new object[] {
            "",
            "PLASTIC",
            "ALUMINIUM",
            "IRON",
            "PAPER",
            "COPPER",
            "CAN",
            "##"});
            this.cmb_plastictype.Location = new System.Drawing.Point(106, 305);
            this.cmb_plastictype.Name = "cmb_plastictype";
            this.cmb_plastictype.Size = new System.Drawing.Size(160, 21);
            this.cmb_plastictype.TabIndex = 204;
            this.cmb_plastictype.Visible = false;
            // 
            // cmb_color
            // 
            this.cmb_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_color.FormattingEnabled = true;
            this.cmb_color.Items.AddRange(new object[] {
            " ",
            "white",
            "tan",
            "yellow",
            "orange",
            "red",
            "pink",
            "purple",
            "blue"});
            this.cmb_color.Location = new System.Drawing.Point(106, 227);
            this.cmb_color.Name = "cmb_color";
            this.cmb_color.Size = new System.Drawing.Size(160, 21);
            this.cmb_color.TabIndex = 203;
            this.cmb_color.Visible = false;
            // 
            // cmb_category
            // 
            this.cmb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Items.AddRange(new object[] {
            "",
            "plastics",
            "aluminim",
            "copper",
            "iron",
            "circuit board"});
            this.cmb_category.Location = new System.Drawing.Point(106, 201);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(160, 21);
            this.cmb_category.TabIndex = 202;
            this.cmb_category.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 201;
            this.label10.Text = "Plastic Type:";
            this.label10.Visible = false;
            // 
            // txt_plastictype
            // 
            this.txt_plastictype.Location = new System.Drawing.Point(106, 305);
            this.txt_plastictype.MaxLength = 15;
            this.txt_plastictype.Name = "txt_plastictype";
            this.txt_plastictype.ReadOnly = true;
            this.txt_plastictype.Size = new System.Drawing.Size(160, 20);
            this.txt_plastictype.TabIndex = 200;
            this.txt_plastictype.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 199;
            this.label11.Text = "Weight:";
            this.label11.Visible = false;
            // 
            // txt_weight
            // 
            this.txt_weight.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_weight.Location = new System.Drawing.Point(106, 279);
            this.txt_weight.MaxLength = 5;
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(160, 20);
            this.txt_weight.TabIndex = 198;
            this.txt_weight.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 197;
            this.label12.Text = "Quantity:";
            this.label12.Visible = false;
            // 
            // txt_quantity
            // 
            this.txt_quantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_quantity.Location = new System.Drawing.Point(106, 253);
            this.txt_quantity.MaxLength = 5;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(160, 20);
            this.txt_quantity.TabIndex = 196;
            this.txt_quantity.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(66, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 195;
            this.label13.Text = "Color:";
            this.label13.Visible = false;
            // 
            // txt_color
            // 
            this.txt_color.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_color.Location = new System.Drawing.Point(106, 227);
            this.txt_color.MaxLength = 15;
            this.txt_color.Name = "txt_color";
            this.txt_color.ReadOnly = true;
            this.txt_color.Size = new System.Drawing.Size(160, 20);
            this.txt_color.TabIndex = 194;
            this.txt_color.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 193;
            this.label14.Text = "Category:";
            this.label14.Visible = false;
            // 
            // txt_category
            // 
            this.txt_category.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_category.Location = new System.Drawing.Point(106, 201);
            this.txt_category.MaxLength = 15;
            this.txt_category.Name = "txt_category";
            this.txt_category.ReadOnly = true;
            this.txt_category.Size = new System.Drawing.Size(160, 20);
            this.txt_category.TabIndex = 192;
            this.txt_category.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(180, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 9);
            this.label9.TabIndex = 191;
            this.label9.Text = "512x512";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 190;
            this.label8.Text = "Item Picture:";
            // 
            // pb_plastic
            // 
            this.pb_plastic.BackColor = System.Drawing.Color.Transparent;
            this.pb_plastic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_plastic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_plastic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_plastic.Location = new System.Drawing.Point(106, 331);
            this.pb_plastic.Name = "pb_plastic";
            this.pb_plastic.Size = new System.Drawing.Size(68, 68);
            this.pb_plastic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_plastic.TabIndex = 189;
            this.pb_plastic.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 705);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1350, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 161;
            this.label7.Text = "Registration Date:";
            this.label7.Visible = false;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.groupBox1);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Location = new System.Drawing.Point(12, 6);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1326, 690);
            this.panelMain.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::UCycle.Properties.Resources.ucyclelogorectangle;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 34);
            this.pictureBox1.TabIndex = 167;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_plastictype);
            this.groupBox1.Controls.Add(this.cmb_color);
            this.groupBox1.Controls.Add(this.cmb_category);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_plastictype);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_weight);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_quantity);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_color);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_category);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pb_plastic);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_regdate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_itempicture);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_description);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_plasticname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_plasticcode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.dgvVari);
            this.groupBox1.Location = new System.Drawing.Point(3, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1320, 644);
            this.groupBox1.TabIndex = 166;
            this.groupBox1.TabStop = false;
            // 
            // txt_regdate
            // 
            this.txt_regdate.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_regdate.Location = new System.Drawing.Point(106, 175);
            this.txt_regdate.Name = "txt_regdate";
            this.txt_regdate.ReadOnly = true;
            this.txt_regdate.Size = new System.Drawing.Size(160, 20);
            this.txt_regdate.TabIndex = 160;
            this.txt_regdate.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 159;
            this.label6.Text = "Item Picture:";
            this.label6.Visible = false;
            // 
            // txt_itempicture
            // 
            this.txt_itempicture.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_itempicture.Location = new System.Drawing.Point(106, 149);
            this.txt_itempicture.MaxLength = 8;
            this.txt_itempicture.Name = "txt_itempicture";
            this.txt_itempicture.ReadOnly = true;
            this.txt_itempicture.Size = new System.Drawing.Size(160, 20);
            this.txt_itempicture.TabIndex = 158;
            this.txt_itempicture.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 157;
            this.label5.Text = "Price:";
            // 
            // txt_price
            // 
            this.txt_price.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_price.Location = new System.Drawing.Point(106, 123);
            this.txt_price.MaxLength = 9;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(160, 20);
            this.txt_price.TabIndex = 156;
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 155;
            this.label4.Text = "Description:";
            // 
            // txt_description
            // 
            this.txt_description.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_description.Location = new System.Drawing.Point(106, 97);
            this.txt_description.MaxLength = 50;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(160, 20);
            this.txt_description.TabIndex = 154;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 153;
            this.label3.Text = "Weight Name:";
            // 
            // txt_plasticname
            // 
            this.txt_plasticname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_plasticname.Location = new System.Drawing.Point(106, 71);
            this.txt_plasticname.MaxLength = 25;
            this.txt_plasticname.Name = "txt_plasticname";
            this.txt_plasticname.Size = new System.Drawing.Size(160, 20);
            this.txt_plasticname.TabIndex = 152;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 151;
            this.label2.Text = "Weight Code:";
            // 
            // txt_plasticcode
            // 
            this.txt_plasticcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_plasticcode.Location = new System.Drawing.Point(106, 45);
            this.txt_plasticcode.MaxLength = 3;
            this.txt_plasticcode.Name = "txt_plasticcode";
            this.txt_plasticcode.ReadOnly = true;
            this.txt_plasticcode.Size = new System.Drawing.Size(160, 20);
            this.txt_plasticcode.TabIndex = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 149;
            this.label1.Text = "Id:";
            // 
            // txt_id
            // 
            this.txt_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_id.Location = new System.Drawing.Point(106, 19);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(160, 20);
            this.txt_id.TabIndex = 148;
            // 
            // dgvVari
            // 
            this.dgvVari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVari.Location = new System.Drawing.Point(272, 19);
            this.dgvVari.Name = "dgvVari";
            this.dgvVari.ReadOnly = true;
            this.dgvVari.Size = new System.Drawing.Size(1042, 619);
            this.dgvVari.TabIndex = 0;
            this.dgvVari.SelectionChanged += new System.EventHandler(this.dgvVari_SelectionChanged);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            // 
            // Weights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(190)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelMain);
            this.Name = "Weights";
            this.Text = "Weights";
            this.Load += new System.EventHandler(this.Weights_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_plastic)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_caf;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox cmb_plastictype;
        private System.Windows.Forms.ComboBox cmb_color;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_plastictype;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pb_plastic;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_regdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_itempicture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_plasticname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_plasticcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridView dgvVari;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}