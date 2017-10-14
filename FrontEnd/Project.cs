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
    public partial class Project : Form
    {
        int ID = 0;
        Db db = new Db();
        Client cli = new Client();

        public Project(string type)
        {
            InitializeComponent();
            user_type.Text = type;
            LoadDataClient();
        }

        public void LoadDataClient()
        {
            dgv_client.DataSource = db.query("SELECT * FROM client");
            groupBox1.Enabled = false;
            openRecentButton.Enabled = false;
            deleteRecentButton.Enabled = false;
        }

        private void linkLabel_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want to logout?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                Login log = new Login();
                log.Show();
            }
        }
        public void ClearData()
        {
            txt_cc.Clear();
            txt_clientName.Clear();
            txt_clientAddress.Clear();
            txt_pc.Clear();
            txt_projectName.Clear();
            txt_contractCost.Clear();
            dpicker_contractDate.Text = "2002-1-1";
            dpicker_contractDeadline.Text = "2002-1-1";
            txt_notes.Clear();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            ClearData();   
        }
        private void dgv_client_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            groupBox1.Enabled = true;
            btn_submit.Enabled = false;
            btn_cancel.Enabled = false;
            openRecentButton.Enabled = true;
            deleteRecentButton.Enabled = true;
            ID = Convert.ToInt32(dgv_client.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_cc.Text = dgv_client.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_clientName.Text = dgv_client.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_clientAddress.Text = dgv_client.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_pc.Text = dgv_client.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_projectName.Text = dgv_client.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_contractCost.Text = dgv_client.Rows[e.RowIndex].Cells[6].Value.ToString();
            dpicker_contractDate.Text = dgv_client.Rows[e.RowIndex].Cells[7].Value.ToString();
            dpicker_contractDeadline.Text = dgv_client.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_notes.Text = dgv_client.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ClearData();
            groupBox1.Enabled = true;
            btn_submit.Enabled = true;
            btn_cancel.Enabled = true;
        }

        private void deleteRecentButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int deleted = cli.delete(ID);
                if (deleted > 0)
                {
                    MessageBox.Show("Succesfully deleted a record!");
                    LoadDataClient();
                    ClearData();
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            cli._client_code = txt_cc.Text;
            cli._client_name = txt_clientName.Text;
            cli._client_address = txt_clientAddress.Text;
            cli._project_code = txt_pc.Text;
            cli._project_name = txt_projectName.Text;
            cli._contract_cost = Convert.ToDecimal(txt_contractCost.Text);
            cli._contract_date = dpicker_contractDate.Text;
            cli._contract_deadline = dpicker_contractDeadline.Text;
            cli._notes = txt_notes.Text;
            int updated = cli.save(ID);
            if (updated > 0)
            {
                MessageBox.Show("Succesfully updated a record!");
                LoadDataClient();
                ClearData();
            }
        }

        private void hanyaangka(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            cli._client_code = txt_cc.Text;
            cli._client_name = txt_clientName.Text;
            cli._client_address = txt_clientAddress.Text;
            cli._project_code = txt_pc.Text;
            cli._project_name = txt_projectName.Text;
            cli._contract_cost = Convert.ToDecimal(txt_contractCost.Text);
            cli._contract_date = dpicker_contractDate.Text;
            cli._contract_deadline = dpicker_contractDeadline.Text;
            cli._notes = txt_notes.Text;
            int created = cli.create();
            if (created > 0)
            {
                MessageBox.Show("Succesfully inserted a record!");
                //Requirements req = new Requirements(txt_projectName.Text,txt_pc.Text);
                Requirements req = new Requirements();
                LoadDataClient();
                ClearData();
                this.Hide();
                req.Show();
            }
        }
    }
}
