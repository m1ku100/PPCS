using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd;

namespace FrontEnd
{
    

    public partial class Requirements : Form
    {
        Db db = new Db();
        Requierement req = new Requierement();
        int nol = 0;

        public Requirements()
        {
            InitializeComponent();
            /*projectNameLabel.Text = name;
            projectCodelalbel.Text = code;*/
            txt_price_per.Text = "0" ;

        }

        public void LoadData()
        {
            dataGridView1.DataSource = db.query("SELECT * FROM requierement");
        }

        private void txt_price_per_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }//number only
        }

        private void btn_add_direct_Click(object sender, EventArgs e)
        {   //insert to DB

            req._cost_code = txt_cc.ToString();
            req._cost_name = txt_Cname.ToString();
            req._price_per_quantity = Convert.ToDecimal(txt_price_per.ToString());
            req._quantity = num_qty.Value;
            req._unit = txt_units.ToString();
            decimal qty = num_qty.Value; 
            decimal price = Convert.ToDecimal(txt_price_per.Text);
            txt_total_price.Text = (qty * price).ToString();
            req._total_price = Convert.ToDecimal(txt_total_price.ToString());
            req._type_cost = "Direct";
           
            req.create();

        }
        private void hargaPerQtyTextbox_TextChanged(object sender, EventArgs e)
        {
            try {
                decimal qty = num_qty.Value;
                decimal price = Convert.ToDecimal(txt_price_per.Text);
                txt_total_price.Text = (qty * price).ToString();
            }
            catch(Exception ex)//show error detail 
            {
                if (string.IsNullOrEmpty(txt_price_per.Text)){
                    MessageBox.Show(ex.Message, "Error");
                
                }
            }

        }
        private void qty_ValueChanged(object sender, EventArgs e)
        {
            decimal qty = num_qty.Value;
            decimal price = Convert.ToDecimal(txt_price_per.Text);
            txt_total_price.Text = (qty * price).ToString();
        }

        private void txt_price_per_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                txt_price_per.Text =nol.ToString();
            }
        }

        private void inhargaPerQtyTextbox_TextChanged(object sender, EventArgs e)
        {
            decimal qty = in_num_qty.Value;
            decimal price = Convert.ToDecimal(in_txt_price_per.Text);
            in_txt_total_price.Text = (qty * price).ToString();
        }

        private void inqty_ValueChanged(object sender, EventArgs e)
        {
            decimal qty = in_num_qty.Value;
            decimal price = Convert.ToDecimal(in_txt_price_per.Text);
            in_txt_total_price.Text = (qty * price).ToString();
        }

        private void btn_add_indirect_Click(object sender, EventArgs e)
        {//insert to DB

            req._cost_code = in_txt_cc.ToString();
            req._cost_name = in_txt_Cname.ToString();
            req._price_per_quantity = Convert.ToDecimal(in_txt_price_per.ToString());
            req._quantity = in_num_qty.Value;
            req._unit = in_txt_units.ToString();
            decimal qty = in_num_qty.Value;
            decimal price = Convert.ToDecimal(in_txt_price_per.Text);
            in_txt_total_price.Text = (qty * price).ToString();
            req._total_price = Convert.ToDecimal(in_txt_total_price.ToString());
            req._type_cost = "Indirect";

            req.create();

        }
    }
}
