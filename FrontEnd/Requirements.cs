using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BackEnd;

namespace FrontEnd
{
    

    public partial class Requirements : Form
    {

        MySqlConnection conn = new MySqlConnection("Server = localhost; Database=salwa_ppcs;Uid=root;Pwd=;");
        MySqlCommand cmd;
        MySqlDataReader mdr;

        Db db = new Db();
        Requierement req = new Requierement();
        int nol = 0;
        int ID = 0;
        
        public Requirements(string name,string code,decimal cost,string client_code,string type)
        {
            InitializeComponent();
            projectNameLabel.Text = name;
            projectCodelalbel.Text = code;
            user_type.Text = type;
           
            //txt_price_per.Text = "0" ;
            textBox4.Text = cost.ToString();
            idclient(client_code);
           
            LoadData();
        }

        public void idclient(string ambil)
        { //fungsi untuk mengambil id client yang dikirim dari project form
            string cc = ambil;
            conn.Open();
            string query = "SELECT id_client FROM client WHERE client_code=@code";
            cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@code", cc);
            mdr = cmd.ExecuteReader();

            if (mdr.Read())
            {
                textBox1.Text = mdr.GetString("id_client");
            }
            conn.Close();

        }

        
        public void hasil()
        { // menampilkan hasil pertihungan total cost per client
         
            conn.Open();
            string query = "SELECT SUM(total_price) AS total FROM requierement WHERE id_client_fk="+textBox1.Text;
            cmd = new MySqlCommand(query, conn);

            mdr = cmd.ExecuteReader();

            if(mdr.Read())
            {
                decimal cash_out = Convert.ToDecimal(mdr.GetString("total"));
                decimal cash_in = Convert.ToDecimal(textBox4.Text);
                decimal cash_inRupiah = cash_in * 13300;// 
                textBox3.Text = ((cash_inRupiah - cash_out)).ToString();
                textBox6.Text = ((decimal.Parse(textBox3.Text) / cash_inRupiah)).ToString("0%");
                Report_form report = new Report_form(projectCodelalbel.Text,projectCodelalbel.Text,cash_in,cash_out,decimal.Parse(textBox3.Text),textBox6.Text, user_type.Text);
                report.Show();

            }
            conn.Close();
        }

        public void ClearDatadirect()
        {
            txt_cc.Text = "";
            txt_Cname.Text = "";
            txt_price_per.Text = "";
            num_qty.Text = "";
            txt_total_price.Text = "";
            txt_units.Text = "";
        }

        public void ClearDataindirect()
        {
            in_txt_cc.Text = "";
            in_txt_Cname.Text = "";
            in_txt_price_per.Text = "";
            in_num_qty.Text = "";
            in_txt_total_price.Text = "";
            in_txt_units.Text = "";
        }
        
        public void LoadData()
        {
            dataGridView1.DataSource = db.query("SELECT * FROM requierement WHERE id_client_fk="+textBox1.Text);
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            delete_btn.Enabled = false;
            if (dataGridView1.Rows.Count <= 1)
            {
                button3.Enabled = false;
            }
            else
                button3.Enabled = true;

            button4.Enabled = false;
            button5.Enabled = false;
            btn_add_direct.Enabled = false;
            btn_add_indirect.Enabled = false;
        }
      
        private void txt_price_per_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }//number only
        }

        private void btn_add_direct_Click(object sender, EventArgs e)
        {
            //insert to DB
            string id_user = db.single("SELECT id_user FROM users WHERE type='"+user_type.Text+"'");

            req._cost_code = txt_cc.Text;
            req._cost_name = txt_Cname.Text;
            req._id_client_fk = Convert.ToInt32(textBox1.Text);
            req._price_per_quantity = Convert.ToDecimal(txt_price_per.Text);
            req._quantity = num_qty.Value;
            req._unit = txt_units.Text;
            decimal qty = num_qty.Value; 
            decimal price = Convert.ToDecimal(txt_price_per.Text);
            txt_total_price.Text = (qty * price).ToString();
            req._total_price = Convert.ToDecimal(txt_total_price.Text);
            req._type_cost = "Direct";
            req._id_user_fk = id_user;
           
            req.create();
            ClearDatadirect();
            LoadData();

        }
        private void hargaPerQtyTextbox_TextChanged(object sender, EventArgs e)
        {//numer only exception
            try {
                decimal qty = num_qty.Value;
                decimal price = Convert.ToDecimal(txt_price_per.Text);
                txt_total_price.Text = (qty * price).ToString();
            }
            catch(Exception ex)//show error detail 
            {
                if (string.IsNullOrEmpty(txt_price_per.Text)){
                    //MessageBox.Show(ex.Message, "Error");
                
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
        {//numer only exception
            try
            {
                decimal qty = in_num_qty.Value;
                decimal price = Convert.ToDecimal(in_txt_price_per.Text);
                in_txt_total_price.Text = (qty * price).ToString();
            }
            catch (Exception ex)//show error detail 
            {
                if (string.IsNullOrEmpty(in_txt_price_per.Text)|| string.IsNullOrEmpty(txt_price_per.Text))
                {
                    //MessageBox.Show(ex.Message, "Error");

                }
            }
        }

        private void inqty_ValueChanged(object sender, EventArgs e)
        {
            decimal qty = in_num_qty.Value;
            decimal price = Convert.ToDecimal(in_txt_price_per.Text);
            in_txt_total_price.Text = (qty * price).ToString();
        }

        private void btn_add_indirect_Click(object sender, EventArgs e)
        {//insert to DB
            string id_user = db.single("SELECT id_user FROM users WHERE type='" + user_type.Text + "'");
            req._cost_code = in_txt_cc.Text;
            req._cost_name = in_txt_Cname.Text;
            req._id_client_fk = Convert.ToInt32(textBox1.Text);
            req._price_per_quantity = Convert.ToDecimal(in_txt_price_per.Text);
            req._quantity = in_num_qty.Value;
            req._unit = in_txt_units.Text;
            decimal qty = in_num_qty.Value;
            decimal price = Convert.ToDecimal(in_txt_price_per.Text);
            in_txt_total_price.Text = (qty * price).ToString();
            req._total_price = Convert.ToDecimal(in_txt_total_price.Text);
            req._type_cost = "Indirect";
            req._id_user_fk = id_user;


            req.create();
            ClearDataindirect();
            LoadData();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //calculate button
            hasil();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            ClearDatadirect();
            ClearDataindirect();
            button3.Enabled = false;
            delete_btn.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;
            btn_add_direct.Enabled = true;
            btn_add_indirect.Enabled = true;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int deleted = req.delete(ID);
                if (deleted > 0)
                {
                    MessageBox.Show("Succesfully deleted a record!");
                    LoadData();
                    
                }
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            delete_btn.Enabled = true;
            button3.Enabled = true;
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            button4.Enabled = false;
            button5.Enabled = false;
            btn_add_indirect.Enabled = false;
            btn_add_direct.Enabled = false;
            if (dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString() == "Direct")
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                txt_cc.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_Cname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_price_per.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                num_qty.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_units.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_total_price.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                ClearDataindirect();
            }
            else
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                in_txt_cc.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                in_txt_Cname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                in_txt_price_per.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                in_num_qty.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                in_txt_units.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                in_txt_total_price.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                ClearDatadirect();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (groupBox1.Enabled == true && groupBox2.Enabled == false)//direct update
            {
                /*req._cost_code = txt_cc.Text;
                req._cost_name = txt_Cname.Text;
                req._id_client_fk = Convert.ToInt32(textBox1.Text);
                req._price_per_quantity = Convert.ToDecimal(txt_price_per.Text);
                req._quantity = num_qty.Value;
                req._unit = txt_units.Text;
                decimal qty = num_qty.Value;
                decimal price = Convert.ToDecimal(txt_price_per.Text);
                txt_total_price.Text = (qty * price).ToString();
                req._total_price = Convert.ToDecimal(txt_total_price.Text);
                req._type_cost = "Direct";*/
                queryDirect();
                MessageBox.Show("Succesfully updated a direct record!");
                ClearDatadirect();
                LoadData();
            }

            else if (groupBox1.Enabled == false && groupBox2.Enabled == true)
            {
                /*req._cost_code = in_txt_cc.Text;
                req._cost_name = in_txt_Cname.Text;
                req._id_client_fk = Convert.ToInt32(textBox1.Text);
                req._price_per_quantity = Convert.ToDecimal(in_txt_price_per.Text);
                req._quantity = in_num_qty.Value;
                req._unit = in_txt_units.Text;
                decimal qty1 = in_num_qty.Value;
                decimal price1 = Convert.ToDecimal(in_txt_price_per.Text);
                in_txt_total_price.Text = (qty1 * price1).ToString();
                req._total_price = Convert.ToDecimal(in_txt_total_price.Text);
                req._type_cost = "Indirect";*/
                queryIndirect();
                MessageBox.Show("Succesfully updated an indirect record!");
                ClearDataindirect();
                LoadData();
            }
            /*int updated = 
            if (updated > 0)
            {
               
                if (groupBox1.Enabled == true && groupBox2.Enabled == false)
                {
                    MessageBox.Show("Succesfully updated a direct record!");
                    ClearDatadirect();
                    LoadData();
                }
                else if(groupBox1.Enabled == false && groupBox2.Enabled == true)
                {
                    MessageBox.Show("Succesfully updated an indirect record!");
                    ClearDataindirect();
                    LoadData();
                }
                
               
            }
            */
        }

        public void queryDirect()
        {
            db.nQuery("UPDATE requierement SET cost_code='" + txt_cc.Text + "', cost_name='" + txt_Cname.Text + "', price_per_quantity='" + Convert.ToDecimal(txt_price_per.Text) + "',id_client_fk='"+ Convert.ToInt32(textBox1.Text) + "', quantity='" + num_qty.Value + "', unit='" + txt_units.Text + "', total_price='" + Convert.ToDecimal(txt_total_price.Text) + "', type_cost='Direct' WHERE id_requierement='" + ID + "'");
        }
        public void queryIndirect()
        {
            db.nQuery("UPDATE requierement SET cost_code='" + in_txt_cc.Text + "', cost_name='" + in_txt_Cname.Text + "', price_per_quantity='" + Convert.ToDecimal(in_txt_price_per.Text) + "',id_client_fk='" + Convert.ToInt32(textBox1.Text) + "', quantity='" + num_qty.Value + "', unit='" + in_txt_units.Text + "', total_price='" + Convert.ToDecimal(in_txt_total_price.Text) + "', type_cost='Indirect' WHERE id_requierement='" + ID + "'");
        }
        // place holder till

        private void txt_price_per_Enter(object sender, EventArgs e)
        {
            if(txt_price_per.Text=="0")
            {
                txt_price_per.Text = "";
                txt_price_per.ForeColor = Color.Black;
            }
        }

        private void txt_price_per_Leave(object sender, EventArgs e)
        {
            if (txt_price_per.Text == "")
            {
                txt_price_per.Text = "0";
                txt_price_per.ForeColor = Color.Black;
            }
        }

        private void in_txt_price_per_Enter(object sender, EventArgs e)
        {
            if (in_txt_price_per.Text == "0")
            {
                txt_price_per.Text = "";
                txt_price_per.ForeColor = Color.Black;
            }
        }

        private void in_txt_price_per_Leave(object sender, EventArgs e)
        {
            if (in_txt_price_per.Text == "")
            {
                txt_price_per.Text = "0";
                txt_price_per.ForeColor = Color.Black;
            }
        }
        // this 

    }
}
