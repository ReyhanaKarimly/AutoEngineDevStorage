using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AutoEngineDevStorage
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
        public string conString = @"Data Source=DESKTOP-94LT9G1\SQLEXPRESS;Initial Catalog=AutomationEngineeringDevicesStorage;Integrated Security=True";

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                SqlCommand com = new SqlCommand("SELECT *FROM Users WHERE Email=@user and Password=@CardID", con);
                con.Open();
                com.Parameters.AddWithValue("@user", textLogin.Text);
                com.Parameters.AddWithValue("@CardID", textPassword.Text);

                SqlDataReader Dr = com.ExecuteReader();

                int User = 0;


                if (Dr.HasRows == true)
                {
                    MessageBox.Show("Correct!");

                    while (Dr.Read())
                    {
                        User = int.Parse(((Dr["UserID"]).ToString()));
                        break;
                    }
                    textLogin.Text = "";
                    textPassword.Text = "";
                    Items I = new Items(User);
                    I.Show();
                    I.TopMost = true;
                    // this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Login or Password!");
                    textLogin.Clear();
                    textPassword.Clear();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPassBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassBtn.Checked)
            {
                textPassword.UseSystemPasswordChar = false;
            }
            else textPassword.UseSystemPasswordChar = true;
        }

        private void NewUserBtn_Click(object sender, EventArgs e)
        {
            Registration R = new Registration();
            R.Show();
            R.TopMost = true;

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
