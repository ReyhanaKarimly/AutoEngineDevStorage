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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Reigstration_Load(object sender, EventArgs e)
        {

        }
        public string conString = @"Data Source=DESKTOP-94LT9G1\SQLEXPRESS;Initial Catalog=AutomationEngineeringDevicesStorage;Integrated Security=True";
        private void ShowPassBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPassBtn.Checked)
            {

                textPassword.UseSystemPasswordChar = false;
            }
            else textPassword.UseSystemPasswordChar = true;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

            DialogResult cancel = new DialogResult();
            cancel = MessageBox.Show("Are you sure?", "?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (cancel == DialogResult.OK)
            {

                this.Close();
               
            }

        }
       
        private void RegisterBtn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conString);
            {
                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {





                    string q = "insert into Users(Name,Surname,Email,Password,TypeID,CreditCardID)values('" + textName.Text.ToString() + "','" + textSurname.Text.ToString() + "','"+textEmail.Text.ToString()+"','"+textPassword.Text.ToString()+"','"+2+"','"+textCredit.Text.ToString()+"')";
                    if (textEmail.Text!="" && textPassword.Text!="")
                    {
 SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Connection made!");

                        Login L = new Login();
                        L.Show();
                        // this.Close();
                        L.TopMost = true;
                    }
                    else
                    {
                        MessageBox.Show("The fields with * must be filled!");
                    }
                   
                }


                
                textName.Text = "";
                textSurname.Text= "";
                textEmail.Text = "";
                textPassword.Text = "";
                textCredit.Text = "";
                ShowPassBtn.Tag = false;

                
            }

        }
    }
}
