namespace FrontEnd
{
    partial class Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Project));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_client = new System.Windows.Forms.DataGridView();
            this.deleteRecentButton = new System.Windows.Forms.Button();
            this.openRecentButton = new System.Windows.Forms.Button();
            this.dpicker_contractDeadline = new System.Windows.Forms.DateTimePicker();
            this.dpicker_contractDate = new System.Windows.Forms.DateTimePicker();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_contractCost = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btn_add = new System.Windows.Forms.ToolStripButton();
            this.btn_update = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.txt_projectName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_clientAddress = new System.Windows.Forms.TextBox();
            this.txt_clientName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_pc = new System.Windows.Forms.TextBox();
            this.txt_cc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabel_logout = new System.Windows.Forms.LinkLabel();
            this.user_type = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_client);
            this.groupBox2.Controls.Add(this.deleteRecentButton);
            this.groupBox2.Controls.Add(this.openRecentButton);
            this.groupBox2.Location = new System.Drawing.Point(352, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 350);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recent Project";
            // 
            // dgv_client
            // 
            this.dgv_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_client.Location = new System.Drawing.Point(7, 20);
            this.dgv_client.Name = "dgv_client";
            this.dgv_client.Size = new System.Drawing.Size(526, 312);
            this.dgv_client.TabIndex = 0;
            this.dgv_client.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_client_RowHeaderMouseClick);
            // 
            // deleteRecentButton
            // 
            this.deleteRecentButton.Location = new System.Drawing.Point(539, 68);
            this.deleteRecentButton.Name = "deleteRecentButton";
            this.deleteRecentButton.Size = new System.Drawing.Size(75, 36);
            this.deleteRecentButton.TabIndex = 11;
            this.deleteRecentButton.Text = "Delete";
            this.deleteRecentButton.UseVisualStyleBackColor = true;
            this.deleteRecentButton.Click += new System.EventHandler(this.deleteRecentButton_Click);
            // 
            // openRecentButton
            // 
            this.openRecentButton.Location = new System.Drawing.Point(539, 20);
            this.openRecentButton.Name = "openRecentButton";
            this.openRecentButton.Size = new System.Drawing.Size(75, 36);
            this.openRecentButton.TabIndex = 10;
            this.openRecentButton.Text = "Open";
            this.openRecentButton.UseVisualStyleBackColor = true;
            // 
            // dpicker_contractDeadline
            // 
            this.dpicker_contractDeadline.CustomFormat = "yyyy-MM-dd";
            this.dpicker_contractDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpicker_contractDeadline.Location = new System.Drawing.Point(148, 209);
            this.dpicker_contractDeadline.Name = "dpicker_contractDeadline";
            this.dpicker_contractDeadline.Size = new System.Drawing.Size(93, 20);
            this.dpicker_contractDeadline.TabIndex = 8;
            this.dpicker_contractDeadline.Value = new System.DateTime(2017, 10, 12, 0, 0, 0, 0);
            // 
            // dpicker_contractDate
            // 
            this.dpicker_contractDate.CustomFormat = "yyyy-MM-dd";
            this.dpicker_contractDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpicker_contractDate.Location = new System.Drawing.Point(148, 183);
            this.dpicker_contractDate.MinDate = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            this.dpicker_contractDate.Name = "dpicker_contractDate";
            this.dpicker_contractDate.Size = new System.Drawing.Size(93, 20);
            this.dpicker_contractDate.TabIndex = 7;
            this.dpicker_contractDate.Value = new System.DateTime(2017, 10, 12, 0, 0, 0, 0);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(229, 296);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 36);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Contract Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contract Cost (USD)";
            // 
            // txt_contractCost
            // 
            this.txt_contractCost.Location = new System.Drawing.Point(148, 160);
            this.txt_contractCost.Name = "txt_contractCost";
            this.txt_contractCost.Size = new System.Drawing.Size(177, 20);
            this.txt_contractCost.TabIndex = 6;
            this.txt_contractCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hanyaangka);
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
            this.bindingNavigator1.Size = new System.Drawing.Size(978, 25);
            this.bindingNavigator1.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // txt_notes
            // 
            this.txt_notes.Location = new System.Drawing.Point(148, 234);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(176, 47);
            this.txt_notes.TabIndex = 9;
            // 
            // txt_projectName
            // 
            this.txt_projectName.Location = new System.Drawing.Point(148, 134);
            this.txt_projectName.Name = "txt_projectName";
            this.txt_projectName.Size = new System.Drawing.Size(176, 20);
            this.txt_projectName.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Notes";
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(148, 296);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 36);
            this.btn_submit.TabIndex = 10;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_clientAddress
            // 
            this.txt_clientAddress.Location = new System.Drawing.Point(148, 68);
            this.txt_clientAddress.Multiline = true;
            this.txt_clientAddress.Name = "txt_clientAddress";
            this.txt_clientAddress.Size = new System.Drawing.Size(176, 33);
            this.txt_clientAddress.TabIndex = 3;
            // 
            // txt_clientName
            // 
            this.txt_clientName.Location = new System.Drawing.Point(148, 42);
            this.txt_clientName.Name = "txt_clientName";
            this.txt_clientName.Size = new System.Drawing.Size(176, 20);
            this.txt_clientName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contract Deadline";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Client Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dpicker_contractDeadline);
            this.groupBox1.Controls.Add(this.dpicker_contractDate);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_contractCost);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_notes);
            this.groupBox1.Controls.Add(this.txt_pc);
            this.groupBox1.Controls.Add(this.txt_projectName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_submit);
            this.groupBox1.Controls.Add(this.txt_clientAddress);
            this.groupBox1.Controls.Add(this.txt_cc);
            this.groupBox1.Controls.Add(this.txt_clientName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 350);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Project";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(69, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Project Code";
            // 
            // txt_pc
            // 
            this.txt_pc.Location = new System.Drawing.Point(148, 107);
            this.txt_pc.Name = "txt_pc";
            this.txt_pc.Size = new System.Drawing.Size(176, 20);
            this.txt_pc.TabIndex = 4;
            // 
            // txt_cc
            // 
            this.txt_cc.Location = new System.Drawing.Point(148, 16);
            this.txt_cc.Name = "txt_cc";
            this.txt_cc.Size = new System.Drawing.Size(176, 20);
            this.txt_cc.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Client Code";
            // 
            // linkLabel_logout
            // 
            this.linkLabel_logout.AutoSize = true;
            this.linkLabel_logout.Location = new System.Drawing.Point(193, 399);
            this.linkLabel_logout.Name = "linkLabel_logout";
            this.linkLabel_logout.Size = new System.Drawing.Size(116, 13);
            this.linkLabel_logout.TabIndex = 3;
            this.linkLabel_logout.TabStop = true;
            this.linkLabel_logout.Text = "click here to LOGOUT!";
            this.linkLabel_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_logout_LinkClicked);
            // 
            // user_type
            // 
            this.user_type.AutoSize = true;
            this.user_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_type.Location = new System.Drawing.Point(91, 399);
            this.user_type.Name = "user_type";
            this.user_type.Size = new System.Drawing.Size(0, 13);
            this.user_type.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "you\'re login as a";
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 420);
            this.Controls.Add(this.linkLabel_logout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.user_type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Project";
            this.Text = "Project";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_client;
        private System.Windows.Forms.Button deleteRecentButton;
        private System.Windows.Forms.Button openRecentButton;
        private System.Windows.Forms.DateTimePicker dpicker_contractDeadline;
        private System.Windows.Forms.DateTimePicker dpicker_contractDate;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_contractCost;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btn_add;
        private System.Windows.Forms.ToolStripButton btn_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.TextBox txt_projectName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_clientAddress;
        private System.Windows.Forms.TextBox txt_clientName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel_logout;
        private System.Windows.Forms.Label user_type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_pc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_cc;
    }
}