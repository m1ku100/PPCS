namespace FrontEnd
{
    partial class Report_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cash_in = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Cash_out = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cash_inout = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_profit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cash_inUSD = new System.Windows.Forms.TextBox();
            this.linkLabel_logout = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.user_type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Project Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cash IN (IDR)";
            // 
            // txt_Cash_in
            // 
            this.txt_Cash_in.Location = new System.Drawing.Point(184, 98);
            this.txt_Cash_in.Name = "txt_Cash_in";
            this.txt_Cash_in.ReadOnly = true;
            this.txt_Cash_in.Size = new System.Drawing.Size(170, 20);
            this.txt_Cash_in.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cash OUT (IDR)";
            // 
            // txt_Cash_out
            // 
            this.txt_Cash_out.Location = new System.Drawing.Point(184, 124);
            this.txt_Cash_out.Name = "txt_Cash_out";
            this.txt_Cash_out.ReadOnly = true;
            this.txt_Cash_out.Size = new System.Drawing.Size(170, 20);
            this.txt_Cash_out.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cash IN - OUT (IDR)";
            // 
            // txt_cash_inout
            // 
            this.txt_cash_inout.Location = new System.Drawing.Point(184, 150);
            this.txt_cash_inout.Name = "txt_cash_inout";
            this.txt_cash_inout.ReadOnly = true;
            this.txt_cash_inout.Size = new System.Drawing.Size(170, 20);
            this.txt_cash_inout.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Profit (%)";
            // 
            // txt_profit
            // 
            this.txt_profit.Location = new System.Drawing.Point(184, 176);
            this.txt_profit.Name = "txt_profit";
            this.txt_profit.ReadOnly = true;
            this.txt_profit.Size = new System.Drawing.Size(170, 20);
            this.txt_profit.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Contract Cost (Cash IN (USD))";
            // 
            // txt_cash_inUSD
            // 
            this.txt_cash_inUSD.Location = new System.Drawing.Point(184, 69);
            this.txt_cash_inUSD.Name = "txt_cash_inUSD";
            this.txt_cash_inUSD.ReadOnly = true;
            this.txt_cash_inUSD.Size = new System.Drawing.Size(170, 20);
            this.txt_cash_inUSD.TabIndex = 2;
            // 
            // linkLabel_logout
            // 
            this.linkLabel_logout.AutoSize = true;
            this.linkLabel_logout.Location = new System.Drawing.Point(193, 305);
            this.linkLabel_logout.Name = "linkLabel_logout";
            this.linkLabel_logout.Size = new System.Drawing.Size(116, 13);
            this.linkLabel_logout.TabIndex = 50;
            this.linkLabel_logout.TabStop = true;
            this.linkLabel_logout.Text = "click here to LOGOUT!";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "you\'re login as a";
            // 
            // user_type
            // 
            this.user_type.AutoSize = true;
            this.user_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_type.Location = new System.Drawing.Point(91, 305);
            this.user_type.Name = "user_type";
            this.user_type.Size = new System.Drawing.Size(0, 13);
            this.user_type.TabIndex = 51;
            // 
            // Report_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 327);
            this.Controls.Add(this.linkLabel_logout);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.user_type);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_profit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cash_inout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Cash_out);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cash_inUSD);
            this.Controls.Add(this.txt_Cash_in);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Report_form";
            this.Text = "Report Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Cash_in;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Cash_out;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cash_inout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_profit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cash_inUSD;
        private System.Windows.Forms.LinkLabel linkLabel_logout;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label user_type;
    }
}