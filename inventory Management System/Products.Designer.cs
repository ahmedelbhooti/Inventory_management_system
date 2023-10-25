namespace inventory_Management_System
{
    partial class Products
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_user = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPprice = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPQty = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPId = new System.Windows.Forms.TextBox();
            this.btnRefr = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDeleteP = new System.Windows.Forms.Button();
            this.btnEditP = new System.Windows.Forms.Button();
            this.btnAddP = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.catogariesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryMSDataSet = new inventory_Management_System.inventoryMSDataSet();
            this.catogariesTableAdapter = new inventory_Management_System.inventoryMSDataSetTableAdapters.CatogariesTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catogariesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 89);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.lbl_user);
            this.panel7.Location = new System.Drawing.Point(1182, 26);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(193, 44);
            this.panel7.TabIndex = 45;
            // 
            // lbl_user
            // 
            this.lbl_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.Black;
            this.lbl_user.Location = new System.Drawing.Point(25, 6);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(140, 34);
            this.lbl_user.TabIndex = 4;
            this.lbl_user.Text = "user";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(572, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manage Products";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 30);
            this.label9.TabIndex = 15;
            this.label9.Text = "Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 30);
            this.label7.TabIndex = 17;
            this.label7.Text = "Product Qyt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 30);
            this.label6.TabIndex = 18;
            this.label6.Text = "Product Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.txtPprice);
            this.panel5.Location = new System.Drawing.Point(206, 300);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 44);
            this.panel5.TabIndex = 11;
            // 
            // txtPprice
            // 
            this.txtPprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPprice.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPprice.ForeColor = System.Drawing.Color.Black;
            this.txtPprice.Location = new System.Drawing.Point(5, 10);
            this.txtPprice.Multiline = true;
            this.txtPprice.Name = "txtPprice";
            this.txtPprice.Size = new System.Drawing.Size(194, 28);
            this.txtPprice.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.txtPQty);
            this.panel4.Location = new System.Drawing.Point(206, 242);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 44);
            this.panel4.TabIndex = 12;
            // 
            // txtPQty
            // 
            this.txtPQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPQty.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPQty.ForeColor = System.Drawing.Color.Black;
            this.txtPQty.Location = new System.Drawing.Point(5, 10);
            this.txtPQty.Multiline = true;
            this.txtPQty.Name = "txtPQty";
            this.txtPQty.Size = new System.Drawing.Size(194, 28);
            this.txtPQty.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtPname);
            this.panel3.Location = new System.Drawing.Point(206, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 44);
            this.panel3.TabIndex = 13;
            // 
            // txtPname
            // 
            this.txtPname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPname.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPname.ForeColor = System.Drawing.Color.Black;
            this.txtPname.Location = new System.Drawing.Point(5, 10);
            this.txtPname.Multiline = true;
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(194, 28);
            this.txtPname.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtPId);
            this.panel2.Location = new System.Drawing.Point(206, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 44);
            this.panel2.TabIndex = 14;
            // 
            // txtPId
            // 
            this.txtPId.BackColor = System.Drawing.Color.White;
            this.txtPId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPId.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPId.ForeColor = System.Drawing.Color.Black;
            this.txtPId.Location = new System.Drawing.Point(5, 10);
            this.txtPId.Multiline = true;
            this.txtPId.Name = "txtPId";
            this.txtPId.Size = new System.Drawing.Size(194, 28);
            this.txtPId.TabIndex = 4;
            // 
            // btnRefr
            // 
            this.btnRefr.BackColor = System.Drawing.Color.SeaShell;
            this.btnRefr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefr.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefr.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnRefr.Location = new System.Drawing.Point(17, 553);
            this.btnRefr.Name = "btnRefr";
            this.btnRefr.Size = new System.Drawing.Size(118, 40);
            this.btnRefr.TabIndex = 25;
            this.btnRefr.Text = "Refresh";
            this.btnRefr.UseVisualStyleBackColor = false;
            this.btnRefr.Click += new System.EventHandler(this.btnRefr_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.SeaShell;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnHome.Location = new System.Drawing.Point(141, 553);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(112, 41);
            this.btnHome.TabIndex = 21;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnDeleteP
            // 
            this.btnDeleteP.BackColor = System.Drawing.Color.SeaShell;
            this.btnDeleteP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteP.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteP.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDeleteP.Location = new System.Drawing.Point(267, 506);
            this.btnDeleteP.Name = "btnDeleteP";
            this.btnDeleteP.Size = new System.Drawing.Size(115, 41);
            this.btnDeleteP.TabIndex = 22;
            this.btnDeleteP.Text = "Delete";
            this.btnDeleteP.UseVisualStyleBackColor = false;
            this.btnDeleteP.Click += new System.EventHandler(this.btnDeleteP_Click);
            // 
            // btnEditP
            // 
            this.btnEditP.BackColor = System.Drawing.Color.SeaShell;
            this.btnEditP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditP.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditP.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEditP.Location = new System.Drawing.Point(141, 506);
            this.btnEditP.Name = "btnEditP";
            this.btnEditP.Size = new System.Drawing.Size(100, 41);
            this.btnEditP.TabIndex = 23;
            this.btnEditP.Text = "Edit";
            this.btnEditP.UseVisualStyleBackColor = false;
            this.btnEditP.Click += new System.EventHandler(this.btnEditP_Click);
            // 
            // btnAddP
            // 
            this.btnAddP.BackColor = System.Drawing.Color.SeaShell;
            this.btnAddP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddP.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddP.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddP.Location = new System.Drawing.Point(17, 506);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(100, 41);
            this.btnAddP.TabIndex = 24;
            this.btnAddP.Text = "Add";
            this.btnAddP.UseVisualStyleBackColor = false;
            this.btnAddP.Click += new System.EventHandler(this.btnAddP_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Dungeon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(562, 121);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(670, 33);
            this.txtSearch.TabIndex = 28;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.SeaShell;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Dungeon", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSearch.Location = new System.Drawing.Point(1238, 116);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 38);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView2.Location = new System.Drawing.Point(562, 161);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(822, 663);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.txtDesc);
            this.panel6.Location = new System.Drawing.Point(206, 363);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(213, 44);
            this.panel6.TabIndex = 11;
            // 
            // txtDesc
            // 
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesc.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.ForeColor = System.Drawing.Color.Black;
            this.txtDesc.Location = new System.Drawing.Point(5, 10);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(194, 28);
            this.txtDesc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Categories:";
            // 
            // cmbCat
            // 
            this.cmbCat.DataSource = this.catogariesBindingSource;
            this.cmbCat.DisplayMember = "CatName";
            this.cmbCat.Font = new System.Drawing.Font("Gadugi", 13.8F);
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Location = new System.Drawing.Point(206, 423);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(213, 35);
            this.cmbCat.TabIndex = 29;
            this.cmbCat.ValueMember = "Catid";
            // 
            // catogariesBindingSource
            // 
            this.catogariesBindingSource.DataMember = "Catogaries";
            this.catogariesBindingSource.DataSource = this.inventoryMSDataSet;
            // 
            // inventoryMSDataSet
            // 
            this.inventoryMSDataSet.DataSetName = "inventoryMSDataSet";
            this.inventoryMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catogariesTableAdapter
            // 
            this.catogariesTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::inventory_Management_System.Properties.Resources.Homee;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 79);
            this.button3.TabIndex = 49;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::inventory_Management_System.Properties.Resources.old_black_background_grunge_texture_dark_wallpaper_blackboard_chalkboard_room_wall;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1389, 837);
            this.Controls.Add(this.cmbCat);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnRefr);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnDeleteP);
            this.Controls.Add(this.btnEditP);
            this.Controls.Add(this.btnAddP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catogariesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtPprice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPQty;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPId;
        private System.Windows.Forms.Button btnRefr;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnDeleteP;
        private System.Windows.Forms.Button btnEditP;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCat;
        private inventoryMSDataSet inventoryMSDataSet;
        private System.Windows.Forms.BindingSource catogariesBindingSource;
        private inventoryMSDataSetTableAdapters.CatogariesTableAdapter catogariesTableAdapter;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Button button3;
    }
}