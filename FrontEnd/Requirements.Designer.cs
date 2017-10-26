namespace FrontEnd
{
    partial class Requirements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Requirements));
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.projectCodelalbel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_qty = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_cc = new System.Windows.Forms.TextBox();
            this.btn_add_direct = new System.Windows.Forms.Button();
            this.txt_total_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_units = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_price_per = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Cname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.in_num_qty = new System.Windows.Forms.NumericUpDown();
            this.in_txt_units = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.in_txt_cc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_add_indirect = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.in_txt_total_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.in_txt_Cname = new System.Windows.Forms.TextBox();
            this.in_txt_price_per = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btn_add = new System.Windows.Forms.ToolStripButton();
            this.btn_update = new System.Windows.Forms.ToolStripButton();
            this.linkLabel_logout = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.user_type = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_qty)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.in_num_qty)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLabel.Location = new System.Drawing.Point(10, 32);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(0, 19);
            this.projectNameLabel.TabIndex = 0;
            // 
            // projectCodelalbel
            // 
            this.projectCodelalbel.AutoSize = true;
            this.projectCodelalbel.Location = new System.Drawing.Point(10, 51);
            this.projectCodelalbel.Name = "projectCodelalbel";
            this.projectCodelalbel.Size = new System.Drawing.Size(0, 13);
            this.projectCodelalbel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_qty);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.txt_cc);
            this.groupBox1.Controls.Add(this.btn_add_direct);
            this.groupBox1.Controls.Add(this.txt_total_price);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_units);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_price_per);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_Cname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 232);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direct Cost";
            // 
            // num_qty
            // 
            this.num_qty.Location = new System.Drawing.Point(125, 97);
            this.num_qty.Name = "num_qty";
            this.num_qty.Size = new System.Drawing.Size(128, 20);
            this.num_qty.TabIndex = 3;
            this.num_qty.ValueChanged += new System.EventHandler(this.qty_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(206, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 7;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txt_cc
            // 
            this.txt_cc.Location = new System.Drawing.Point(125, 19);
            this.txt_cc.Name = "txt_cc";
            this.txt_cc.Size = new System.Drawing.Size(196, 20);
            this.txt_cc.TabIndex = 0;
            // 
            // btn_add_direct
            // 
            this.btn_add_direct.Location = new System.Drawing.Point(125, 190);
            this.btn_add_direct.Name = "btn_add_direct";
            this.btn_add_direct.Size = new System.Drawing.Size(75, 36);
            this.btn_add_direct.TabIndex = 6;
            this.btn_add_direct.Text = "Add to List";
            this.btn_add_direct.UseVisualStyleBackColor = true;
            this.btn_add_direct.Click += new System.EventHandler(this.btn_add_direct_Click);
            // 
            // txt_total_price
            // 
            this.txt_total_price.Location = new System.Drawing.Point(125, 149);
            this.txt_total_price.Name = "txt_total_price";
            this.txt_total_price.ReadOnly = true;
            this.txt_total_price.Size = new System.Drawing.Size(196, 20);
            this.txt_total_price.TabIndex = 5;
            this.txt_total_price.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Price (IDR)";
            // 
            // txt_units
            // 
            this.txt_units.Location = new System.Drawing.Point(125, 123);
            this.txt_units.Name = "txt_units";
            this.txt_units.Size = new System.Drawing.Size(196, 20);
            this.txt_units.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Units";
            // 
            // txt_price_per
            // 
            this.txt_price_per.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_price_per.Location = new System.Drawing.Point(125, 71);
            this.txt_price_per.Name = "txt_price_per";
            this.txt_price_per.Size = new System.Drawing.Size(196, 20);
            this.txt_price_per.TabIndex = 2;
            this.txt_price_per.TextChanged += new System.EventHandler(this.hargaPerQtyTextbox_TextChanged);
            this.txt_price_per.Enter += new System.EventHandler(this.txt_price_per_Enter);
            this.txt_price_per.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_per_keypress);
            this.txt_price_per.Leave += new System.EventHandler(this.txt_price_per_Leave);
            this.txt_price_per.Validated += new System.EventHandler(this.txt_price_per_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Price per Qty. (IDR)";
            // 
            // txt_Cname
            // 
            this.txt_Cname.Location = new System.Drawing.Point(125, 45);
            this.txt_Cname.Name = "txt_Cname";
            this.txt_Cname.Size = new System.Drawing.Size(196, 20);
            this.txt_Cname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cost Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cost Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.in_num_qty);
            this.groupBox2.Controls.Add(this.in_txt_units);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.in_txt_cc);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btn_add_indirect);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.in_txt_total_price);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.in_txt_Cname);
            this.groupBox2.Controls.Add(this.in_txt_price_per);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(399, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 232);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Indirect Cost";
            // 
            // in_num_qty
            // 
            this.in_num_qty.Location = new System.Drawing.Point(143, 97);
            this.in_num_qty.Name = "in_num_qty";
            this.in_num_qty.Size = new System.Drawing.Size(128, 20);
            this.in_num_qty.TabIndex = 11;
            this.in_num_qty.ValueChanged += new System.EventHandler(this.inqty_ValueChanged);
            // 
            // in_txt_units
            // 
            this.in_txt_units.Location = new System.Drawing.Point(143, 123);
            this.in_txt_units.Name = "in_txt_units";
            this.in_txt_units.Size = new System.Drawing.Size(196, 20);
            this.in_txt_units.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(90, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cost Code";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(224, 190);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 36);
            this.button5.TabIndex = 13;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // in_txt_cc
            // 
            this.in_txt_cc.Location = new System.Drawing.Point(143, 19);
            this.in_txt_cc.Name = "in_txt_cc";
            this.in_txt_cc.Size = new System.Drawing.Size(196, 20);
            this.in_txt_cc.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total Price (IDR)";
            // 
            // btn_add_indirect
            // 
            this.btn_add_indirect.Location = new System.Drawing.Point(143, 190);
            this.btn_add_indirect.Name = "btn_add_indirect";
            this.btn_add_indirect.Size = new System.Drawing.Size(75, 36);
            this.btn_add_indirect.TabIndex = 13;
            this.btn_add_indirect.Text = "Add to List";
            this.btn_add_indirect.UseVisualStyleBackColor = true;
            this.btn_add_indirect.Click += new System.EventHandler(this.btn_add_indirect_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cost Name";
            // 
            // in_txt_total_price
            // 
            this.in_txt_total_price.Location = new System.Drawing.Point(143, 149);
            this.in_txt_total_price.Name = "in_txt_total_price";
            this.in_txt_total_price.ReadOnly = true;
            this.in_txt_total_price.Size = new System.Drawing.Size(196, 20);
            this.in_txt_total_price.TabIndex = 13;
            this.in_txt_total_price.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price per Qty. (IDR)";
            // 
            // in_txt_Cname
            // 
            this.in_txt_Cname.Location = new System.Drawing.Point(143, 45);
            this.in_txt_Cname.Name = "in_txt_Cname";
            this.in_txt_Cname.Size = new System.Drawing.Size(196, 20);
            this.in_txt_Cname.TabIndex = 9;
            // 
            // in_txt_price_per
            // 
            this.in_txt_price_per.ForeColor = System.Drawing.SystemColors.WindowText;
            this.in_txt_price_per.Location = new System.Drawing.Point(143, 71);
            this.in_txt_price_per.Name = "in_txt_price_per";
            this.in_txt_price_per.Size = new System.Drawing.Size(196, 20);
            this.in_txt_price_per.TabIndex = 10;
            this.in_txt_price_per.TextChanged += new System.EventHandler(this.inhargaPerQtyTextbox_TextChanged);
            this.in_txt_price_per.Enter += new System.EventHandler(this.in_txt_price_per_Enter);
            this.in_txt_price_per.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_per_keypress);
            this.in_txt_price_per.Leave += new System.EventHandler(this.in_txt_price_per_Leave);
            this.in_txt_price_per.Validated += new System.EventHandler(this.txt_price_per_Validated);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Units";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.delete_btn);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Location = new System.Drawing.Point(10, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(770, 192);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List of Project\'s Requierement";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 166);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(689, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 1;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(484, 62);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(68, 20);
            this.textBox6.TabIndex = 1;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(689, 20);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 36);
            this.delete_btn.TabIndex = 1;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(322, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(125, 78);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(122, 20);
            this.textBox4.TabIndex = 1;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add,
            this.btn_update});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(795, 25);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(49, 22);
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(65, 22);
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // linkLabel_logout
            // 
            this.linkLabel_logout.AutoSize = true;
            this.linkLabel_logout.Location = new System.Drawing.Point(191, 515);
            this.linkLabel_logout.Name = "linkLabel_logout";
            this.linkLabel_logout.Size = new System.Drawing.Size(116, 13);
            this.linkLabel_logout.TabIndex = 47;
            this.linkLabel_logout.TabStop = true;
            this.linkLabel_logout.Text = "click here to LOGOUT!";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 515);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "you\'re login as a";
            // 
            // user_type
            // 
            this.user_type.AutoSize = true;
            this.user_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_type.Location = new System.Drawing.Point(89, 515);
            this.user_type.Name = "user_type";
            this.user_type.Size = new System.Drawing.Size(0, 13);
            this.user_type.TabIndex = 48;
            // 
            // Requirements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 537);
            this.Controls.Add(this.linkLabel_logout);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.user_type);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.projectCodelalbel);
            this.Controls.Add(this.projectNameLabel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Requirements";
            this.Text = " Project Requirements";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_qty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.in_num_qty)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Label projectCodelalbel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_add_direct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_total_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_units;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_price_per;
        private System.Windows.Forms.TextBox txt_Cname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btn_add;
        private System.Windows.Forms.ToolStripButton btn_update;
        private System.Windows.Forms.NumericUpDown num_qty;
        private System.Windows.Forms.NumericUpDown in_num_qty;
        private System.Windows.Forms.TextBox in_txt_units;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox in_txt_cc;
        private System.Windows.Forms.Button btn_add_indirect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox in_txt_total_price;
        private System.Windows.Forms.TextBox in_txt_Cname;
        private System.Windows.Forms.TextBox in_txt_price_per;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabel_logout;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label user_type;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
    }
}