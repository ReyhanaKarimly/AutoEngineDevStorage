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
    public partial class UpdateProduct : Form
    {

        private string conString;
        SqlConnection mycon;
        SqlDataReader dr = null;
        SqlCommand cmd = null;
        int IDd = -1;
        string ProductName;
        string Brand;
        string Country;
        string description;
        int Category;
        float price;
        int amount;
        int Seller;
        string OldProductName;
        public UpdateProduct(string N,int S)
        {
            Seller = S;
            conString = @"Data Source=DESKTOP-94LT9G1\SQLEXPRESS;Initial Catalog=AutomationEngineeringDevicesStorage;Integrated Security=True";
             OldProductName= N;
            mycon = new SqlConnection(conString);
            InitializeComponent();
            P_Name.Text = IDd.ToString();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            P_Name.Text = "Product Name: ";
            string cmdstr = "select Users.Name,Users.Surname, Products.ID, Products.Category, Products.ProductName,Products.Picture, Products.Description,Products.Country,Products.Price, Products.Amount, Companies.Company from Users,Companies,Products where Products.Seller=Users.UserID and Products.Brand = Companies.ID AND Products.ProductName='" +OldProductName+ "' AND Products.Seller='"+Seller+"'";
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
                product_info[7] = (dr["Price"].ToString());
                product_info[8] = (dr["Amount"]).ToString();
                product_info[9] = (dr["Category"]).ToString();


            }

            textBrand.Text = product_info[1].TrimEnd();
            textName.Text = product_info[2].TrimEnd();
            textCountry.Text = product_info[3].TrimEnd();
         // textSeller.Text = product_info[5] + " " + product_info[6];
            textDescription.Text = product_info[4].TrimEnd();
            textPrice.Text = product_info[7].TrimEnd();
            textAmount.Text = product_info[8].TrimEnd();
            comboBoxCategory.SelectedIndex = int.Parse(product_info[9])-1;
            dr.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (textDescription.Text.Length==0 || textName.Text.Length==0 || textBrand.Text.Length==0 || textCountry.Text.Length==0)
            {
                MessageBox.Show("All fields must be filled");
                return;
            }
            if (!float.TryParse(textPrice.Text.ToString(), out price))
            {
                MessageBox.Show("Price field is invalid!");
                return;

            }
            if (price<0)
            {
                MessageBox.Show("Price field is invalid!");
                return;


            }

            if (!int.TryParse(textAmount.Text.ToString(), out amount))
            {
                MessageBox.Show("Amount field is invalid!");
                return;

            }
            if (amount < 0)
            {
                MessageBox.Show("Amount field is invalid!");
                return;


            }

            SqlConnection con = new SqlConnection(conString);
            {
                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                { int B = 0;
                   
                    

                    string cmdstr = "select ID from Companies where Company='" + Brand + "'";
                    SqlCommand comm = new SqlCommand(cmdstr, con);
                    dr = comm.ExecuteReader();
                   
                    if (dr.HasRows==true)                  
                 
                    while (dr.Read())
                    {
                        B = int.Parse(dr["ID"].ToString());
                        // MessageBox.Show(B.ToString());
                        // break;

                    }
                    dr.Close();
                    con.Close();

con.Open();
                    if (B==0)
                    {
string q1 = "insert into Companies(Company) values('" + Brand + "')";

                    SqlCommand cmd = new SqlCommand(q1, con);
                    cmd.ExecuteNonQuery();
                    // MessageBox.Show("New Brand is Inserted");
                    con.Close();
                    con.Open();

                    string cmdstr2 = "select ID from Companies where Company='" + Brand + "'";
                    SqlCommand com2m = new SqlCommand(cmdstr, con);
                    dr = comm.ExecuteReader();
                    B = 1;
                    while (dr.Read())
                    {
                        B = int.Parse(dr["ID"].ToString());
                        // MessageBox.Show(B.ToString());
                        // break;

                    }
                    dr.Close();
                    con.Close();


                    }

                    con.Close();
                    con.Open();
                    string q = @"Update Products

                    set ProductName='" + ProductName + "', Brand='" + B + "',Description='" + description + "',Country='" + Country + "',Price='" + price + "',Category='" + Category + "',Amount='" + amount + "' where Products.ProductName='"+OldProductName+"' AND Products.Seller='"+Seller+"'"; 

                    SqlCommand cmd2 = new SqlCommand(q, con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    con.Open();

                    MemoryStream ms = new MemoryStream();
                    pictureBoxProduct.Image.Save(ms, pictureBoxProduct.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    String insertQuery = "Update products set picture=@img where ProductName='" + ProductName + "' AND Products.Seller='"+Seller+"'";
                    cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.Add("@img", SqlDbType.VarBinary);
                    cmd.Parameters["@img"].Value = img;
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Product is Updated!");
                    Form4 I = new Form4(Seller);
                    I.Show();
                    this.Close();


                }


            }
        }

        private void PictureChangeBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {

                pictureBoxProduct.Image = Image.FromFile(opf.FileName);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Form3 F = new Form3(Seller);
            F.Show();
            this.Close();
        }

        private void textDescription_TextChanged(object sender, EventArgs e)
        {
            description = textDescription.Text;
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category = comboBoxCategory.FindStringExact(comboBoxCategory.Text);
            Category++;
        }

        private void textAmount_TextChanged(object sender, EventArgs e)
        {
            //amount = int.Parse(textAmount.Text.ToString());
        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {
           // price = float.Parse(textPrice.Text.ToString());
        }

        private void textBrand_TextChanged(object sender, EventArgs e)
        {
            Brand = textBrand.Text.ToString();
        }

        private void textCountry_TextChanged(object sender, EventArgs e)
        {
            Country = textCountry.Text.ToString();
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            ProductName = textName.Text.ToString();
        }
    }
}
