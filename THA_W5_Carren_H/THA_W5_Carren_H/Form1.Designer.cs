namespace THA_W5_Carren_H
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtproduk = new System.Windows.Forms.DataGridView();
            this.dtablecategory = new System.Windows.Forms.DataGridView();
            this.label_product = new System.Windows.Forms.Label();
            this.label_category = new System.Windows.Forms.Label();
            this.label_detail = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_detailcategory = new System.Windows.Forms.Label();
            this.label_harga = new System.Windows.Forms.Label();
            this.label_stock = new System.Windows.Forms.Label();
            this.label_namacategory = new System.Windows.Forms.Label();
            this.textBox_nama = new System.Windows.Forms.TextBox();
            this.textBox_harga = new System.Windows.Forms.TextBox();
            this.textBox_stock = new System.Windows.Forms.TextBox();
            this.textBox_namacategory = new System.Windows.Forms.TextBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.comboBox_filter = new System.Windows.Forms.ComboBox();
            this.button_all = new System.Windows.Forms.Button();
            this.button_filter = new System.Windows.Forms.Button();
            this.button_addproduk = new System.Windows.Forms.Button();
            this.button_editproduk = new System.Windows.Forms.Button();
            this.button_delproduk = new System.Windows.Forms.Button();
            this.button_addcategory = new System.Windows.Forms.Button();
            this.button_removecategory = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtproduk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtablecategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtproduk
            // 
            this.dtproduk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtproduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtproduk.Location = new System.Drawing.Point(12, 62);
            this.dtproduk.Name = "dtproduk";
            this.dtproduk.RowHeadersWidth = 62;
            this.dtproduk.RowTemplate.Height = 28;
            this.dtproduk.Size = new System.Drawing.Size(672, 398);
            this.dtproduk.TabIndex = 0;
            // 
            // dtablecategory
            // 
            this.dtablecategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtablecategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtablecategory.Location = new System.Drawing.Point(716, 62);
            this.dtablecategory.Name = "dtablecategory";
            this.dtablecategory.RowHeadersWidth = 62;
            this.dtablecategory.RowTemplate.Height = 28;
            this.dtablecategory.Size = new System.Drawing.Size(391, 325);
            this.dtablecategory.TabIndex = 1;
            this.dtablecategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtablecategory_CellClick);
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_product.Location = new System.Drawing.Point(13, 13);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(103, 29);
            this.label_product.TabIndex = 2;
            this.label_product.Text = "Product";
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category.Location = new System.Drawing.Point(711, 18);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(118, 29);
            this.label_category.TabIndex = 3;
            this.label_category.Text = "Category";
            // 
            // label_detail
            // 
            this.label_detail.AutoSize = true;
            this.label_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_detail.Location = new System.Drawing.Point(21, 464);
            this.label_detail.Name = "label_detail";
            this.label_detail.Size = new System.Drawing.Size(81, 29);
            this.label_detail.TabIndex = 4;
            this.label_detail.Text = "Detail";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(44, 517);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(55, 20);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "Nama:";
            // 
            // label_detailcategory
            // 
            this.label_detailcategory.AutoSize = true;
            this.label_detailcategory.Location = new System.Drawing.Point(22, 555);
            this.label_detailcategory.Name = "label_detailcategory";
            this.label_detailcategory.Size = new System.Drawing.Size(77, 20);
            this.label_detailcategory.TabIndex = 6;
            this.label_detailcategory.Text = "Category:";
            // 
            // label_harga
            // 
            this.label_harga.AutoSize = true;
            this.label_harga.Location = new System.Drawing.Point(42, 603);
            this.label_harga.Name = "label_harga";
            this.label_harga.Size = new System.Drawing.Size(57, 20);
            this.label_harga.TabIndex = 7;
            this.label_harga.Text = "Harga:";
            // 
            // label_stock
            // 
            this.label_stock.AutoSize = true;
            this.label_stock.Location = new System.Drawing.Point(45, 646);
            this.label_stock.Name = "label_stock";
            this.label_stock.Size = new System.Drawing.Size(54, 20);
            this.label_stock.TabIndex = 8;
            this.label_stock.Text = "Stock:";
            // 
            // label_namacategory
            // 
            this.label_namacategory.AutoSize = true;
            this.label_namacategory.Location = new System.Drawing.Point(730, 408);
            this.label_namacategory.Name = "label_namacategory";
            this.label_namacategory.Size = new System.Drawing.Size(55, 20);
            this.label_namacategory.TabIndex = 9;
            this.label_namacategory.Text = "Nama:";
            // 
            // textBox_nama
            // 
            this.textBox_nama.Location = new System.Drawing.Point(135, 517);
            this.textBox_nama.Name = "textBox_nama";
            this.textBox_nama.Size = new System.Drawing.Size(394, 26);
            this.textBox_nama.TabIndex = 10;
            // 
            // textBox_harga
            // 
            this.textBox_harga.Location = new System.Drawing.Point(135, 603);
            this.textBox_harga.Name = "textBox_harga";
            this.textBox_harga.Size = new System.Drawing.Size(121, 26);
            this.textBox_harga.TabIndex = 11;
            this.textBox_harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_harga_KeyPress);
            // 
            // textBox_stock
            // 
            this.textBox_stock.Location = new System.Drawing.Point(135, 646);
            this.textBox_stock.Name = "textBox_stock";
            this.textBox_stock.Size = new System.Drawing.Size(121, 26);
            this.textBox_stock.TabIndex = 12;
            this.textBox_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_stock_KeyPress);
            // 
            // textBox_namacategory
            // 
            this.textBox_namacategory.Location = new System.Drawing.Point(860, 408);
            this.textBox_namacategory.Name = "textBox_namacategory";
            this.textBox_namacategory.Size = new System.Drawing.Size(237, 26);
            this.textBox_namacategory.TabIndex = 13;
            // 
            // comboBox_category
            // 
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(135, 555);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(121, 28);
            this.comboBox_category.TabIndex = 14;
            this.comboBox_category.SelectedIndexChanged += new System.EventHandler(this.comboBox_category_SelectedIndexChanged);
            // 
            // comboBox_filter
            // 
            this.comboBox_filter.FormattingEnabled = true;
            this.comboBox_filter.Items.AddRange(new object[] {
            "Jas",
            "T-shirt",
            "Rok",
            "Celana",
            "Cawat"});
            this.comboBox_filter.Location = new System.Drawing.Point(401, 14);
            this.comboBox_filter.Name = "comboBox_filter";
            this.comboBox_filter.Size = new System.Drawing.Size(121, 28);
            this.comboBox_filter.TabIndex = 15;
            this.comboBox_filter.SelectedIndexChanged += new System.EventHandler(this.comboBox_filter_SelectedIndexChanged);
            // 
            // button_all
            // 
            this.button_all.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_all.Location = new System.Drawing.Point(157, 18);
            this.button_all.Name = "button_all";
            this.button_all.Size = new System.Drawing.Size(99, 29);
            this.button_all.TabIndex = 16;
            this.button_all.Text = "All";
            this.button_all.UseVisualStyleBackColor = false;
            this.button_all.Click += new System.EventHandler(this.button_all_Click);
            // 
            // button_filter
            // 
            this.button_filter.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button_filter.Location = new System.Drawing.Point(272, 18);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(105, 29);
            this.button_filter.TabIndex = 17;
            this.button_filter.Text = "Filter";
            this.button_filter.UseVisualStyleBackColor = false;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // button_addproduk
            // 
            this.button_addproduk.BackColor = System.Drawing.Color.Lime;
            this.button_addproduk.Location = new System.Drawing.Point(272, 588);
            this.button_addproduk.Name = "button_addproduk";
            this.button_addproduk.Size = new System.Drawing.Size(87, 56);
            this.button_addproduk.TabIndex = 18;
            this.button_addproduk.Text = "Add Product";
            this.button_addproduk.UseVisualStyleBackColor = false;
            this.button_addproduk.Click += new System.EventHandler(this.button_addproduk_Click);
            // 
            // button_editproduk
            // 
            this.button_editproduk.BackColor = System.Drawing.Color.Yellow;
            this.button_editproduk.Location = new System.Drawing.Point(365, 584);
            this.button_editproduk.Name = "button_editproduk";
            this.button_editproduk.Size = new System.Drawing.Size(79, 57);
            this.button_editproduk.TabIndex = 19;
            this.button_editproduk.Text = "Edit Product";
            this.button_editproduk.UseVisualStyleBackColor = false;
            this.button_editproduk.Click += new System.EventHandler(this.button_editproduk_Click);
            // 
            // button_delproduk
            // 
            this.button_delproduk.BackColor = System.Drawing.Color.Red;
            this.button_delproduk.Location = new System.Drawing.Point(450, 584);
            this.button_delproduk.Name = "button_delproduk";
            this.button_delproduk.Size = new System.Drawing.Size(79, 57);
            this.button_delproduk.TabIndex = 20;
            this.button_delproduk.Text = "Delete Product";
            this.button_delproduk.UseVisualStyleBackColor = false;
            this.button_delproduk.Click += new System.EventHandler(this.button_delproduk_Click);
            // 
            // button_addcategory
            // 
            this.button_addcategory.BackColor = System.Drawing.Color.Lime;
            this.button_addcategory.Location = new System.Drawing.Point(860, 439);
            this.button_addcategory.Name = "button_addcategory";
            this.button_addcategory.Size = new System.Drawing.Size(113, 54);
            this.button_addcategory.TabIndex = 21;
            this.button_addcategory.Text = "Add Category";
            this.button_addcategory.UseVisualStyleBackColor = false;
            this.button_addcategory.Click += new System.EventHandler(this.button_addcategory_Click);
            // 
            // button_removecategory
            // 
            this.button_removecategory.BackColor = System.Drawing.Color.Red;
            this.button_removecategory.Location = new System.Drawing.Point(989, 439);
            this.button_removecategory.Name = "button_removecategory";
            this.button_removecategory.Size = new System.Drawing.Size(108, 54);
            this.button_removecategory.TabIndex = 22;
            this.button_removecategory.Text = "Remove Category";
            this.button_removecategory.UseVisualStyleBackColor = false;
            this.button_removecategory.Click += new System.EventHandler(this.button_removecategory_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(903, 499);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1179, 709);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_removecategory);
            this.Controls.Add(this.button_addcategory);
            this.Controls.Add(this.button_delproduk);
            this.Controls.Add(this.button_editproduk);
            this.Controls.Add(this.button_addproduk);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.button_all);
            this.Controls.Add(this.comboBox_filter);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.textBox_namacategory);
            this.Controls.Add(this.textBox_stock);
            this.Controls.Add(this.textBox_harga);
            this.Controls.Add(this.textBox_nama);
            this.Controls.Add(this.label_namacategory);
            this.Controls.Add(this.label_stock);
            this.Controls.Add(this.label_harga);
            this.Controls.Add(this.label_detailcategory);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_detail);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.label_product);
            this.Controls.Add(this.dtablecategory);
            this.Controls.Add(this.dtproduk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtproduk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtablecategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtproduk;
        private System.Windows.Forms.DataGridView dtablecategory;
        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.Label label_detail;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_detailcategory;
        private System.Windows.Forms.Label label_harga;
        private System.Windows.Forms.Label label_stock;
        private System.Windows.Forms.Label label_namacategory;
        private System.Windows.Forms.TextBox textBox_nama;
        private System.Windows.Forms.TextBox textBox_harga;
        private System.Windows.Forms.TextBox textBox_stock;
        private System.Windows.Forms.TextBox textBox_namacategory;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.ComboBox comboBox_filter;
        private System.Windows.Forms.Button button_all;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.Button button_addproduk;
        private System.Windows.Forms.Button button_editproduk;
        private System.Windows.Forms.Button button_delproduk;
        private System.Windows.Forms.Button button_addcategory;
        private System.Windows.Forms.Button button_removecategory;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

