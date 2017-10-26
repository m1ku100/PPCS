using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace FrontEnd
{
    public partial class Login : Form
    {
        private string conn;
        private MySqlConnection connect;

        public Login()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(1500);
            InitializeComponent();
            t.Abort();
            
        }

        public static void CapslockCheacker()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
            else
            {
                MessageBox.Show("The Caps Lock key is OFF.");
            }
        }
        public void StartForm()
        {
            Application.Run(new SplashScreen());
            txt_username.Focus();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            cb_type.SelectedIndex = -1;
        }
        private void db_connection()
        {
            try
            {
                conn = "Server=localhost;Database=salwa_ppcs;Uid=root;Pwd=;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }
        private bool validate_login()
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from users where username=@username and password=@password and type=@type";
            cmd.Parameters.AddWithValue("@username", txt_username.Text);
            cmd.Parameters.AddWithValue("@password", txt_password.Text);
            cmd.Parameters.AddWithValue("@type", cb_type.Text);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_username.Text))
            {
                MessageBox.Show("Please enter your username.","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txt_username.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Please enter your password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_password.Focus();
                return;
            }
            else if(string.IsNullOrEmpty(cb_type.Text))
            {
                MessageBox.Show("Please select type, you're gonna login as a Project Manager or C.E.O.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_type.Focus();
                return;
            }
            try
            {
               
                bool r = validate_login();
                if (r)
                {
                    MySqlConnection conn = new MySqlConnection("Server=localhost;Database=salwa_ppcs;Uid=root;Pwd=;");
                    MySqlDataAdapter sda = new MySqlDataAdapter("Select count(*) from users where username='" + txt_username.Text + "' and password='" + txt_password.Text + "' and type='" + cb_type.Text + "'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MySqlDataAdapter sda2 = new MySqlDataAdapter("Select * from users where username='" + txt_username.Text + "' and password='" + txt_password.Text + "' and type='" + cb_type.Text + "'", conn);
                        DataTable dt1 = new DataTable();
                        sda2.Fill(dt1);

                        if (dt1.Rows[0][0].ToString() == "1")
                        {
                            Project p = new Project(cb_type.Text = "PresidentDirector");
                            this.Hide();
                            p.Show();
                        }
                        else if (dt1.Rows[0][0].ToString() == "2")
                        {
                            Project p = new Project(cb_type.Text = "Project Manager");
                            this.Hide();
                            p.Show();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Username and/or password are incorrect!", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    txt_username.Focus();
                    return;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txt_password.Focus();
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btn_login.PerformClick();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
