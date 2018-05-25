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
using System.IO;
namespace AutoEngineDevStorage
{
    public partial class Basket : Form
    {
        private string conString;
        SqlConnection mycon;
        SqlDataReader dr = null;
        SqlCommand cmd = null;
        string ID="-1";
        public Basket(string Id)
        {
            conString = @"Data Source=DESKTOP-94LT9G1\SQLEXPRESS;Initial Catalog=AutomationEngineeringDevicesStorage;Integrated Security=True";
            ID = Id;
            mycon = new SqlConnection(conString);
            InitializeComponent();
            label1.Text = ID;
        }

        private void Basket_Load(object sender, EventArgs e)
        {
            string cmdstr = "select Users.Name,Users.Surname, Products.ID,Products.ProductName,Products.Picture, Products.Amount, Products.Description, Products.Category,Products.Country,Products.Price, Companies.Company from Users,Companies,Products where Products.Seller=Users.UserID and Products.Brand = Companies.ID AND Products.ID='"+label1.Text+"'";
            cmd = new SqlCommand(cmdstr, mycon);
            mycon.Open();

            dr = cmd.ExecuteReader();

            string[] product_info = new string[10];
           
            while (dr.Read())

            {
               
               
                byte[] data = (Byte[])dr["Picture"];
                var stream = new MemoryStream(data);
                pictureBoxProduct.Image = Image.FromStream(stream);

                product_info[1] = (dr["Company"].ToString());

                product_info[2] = (dr["ProductName"].ToString());

                product_info[3] = (dr["Country"].ToString());

                product_info[4] = (dr["Description"].ToString());
                product_info[5] = (dr["Name"].ToString().Trim());
                product_info[6] = (dr["Surname"].ToString().Trim());
                product_info[7]= (dr["Price"].ToString());
                product_info[8] = (dr["Amount"]).ToString();
                product_info[9] = (dr["Category"]).ToString();

            }
            
            textBrand.Text = product_info[1];
            textName.Text = product_info[2];
            textCountry.Text = product_info[3];
            textSeller.Text = product_info[5]+" "+product_info[6];
            textDescription.Text = product_info[4];
            textPrice.Text = product_info[7]+'$';
            AmountTxt.Text = product_info[8];
            CategoryBox.SelectedIndex = int.Parse(product_info[9])-1;
            dr.Close();


           
        }

        private void pictureBoxProduct_Click(object sender, EventArgs e)
        {
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
