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
    public partial class NewProduct : Form
    {
        private string conString;
       //SqlConnection mycon;
        SqlDataReader dr = null;

        //SqlCommand cmd = null;



        int Seller;
      
        string ProductName;
        string Brand;
        string Country;
        string description;
        int Category;
        float price;
        int amount;
        SqlCommand cmd = null;
        public NewProduct(int Seller)
        {
            this.Seller = Seller;
            InitializeComponent();
            conString = @"Data Source=DESKTOP-94LT9G1\SQLEXPRESS;Initial Catalog=AutomationEngineeringDevicesStorage;Integrated Security=True";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textDescription.Text.Length == 0 || textName.Text.Length == 0 || textBrand.Text.Length == 0 || textCountry.Text.Length == 0)
            {
                MessageBox.Show("All fields must be filled");
                return;
            }
            if (!float.TryParse(textPrice.Text.ToString(), out price))
            {
                MessageBox.Show("Price field is invalid!");
                return;

            }
            if (price < 0)
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
                {

                    int B = 0;

                   // con.Open();

                    string cmdstr = "select ID from Companies where Company='" + Brand + "'";
                    SqlCommand comm = new SqlCommand(cmdstr, con);
                    dr = comm.ExecuteReader();

                    if (dr.HasRows == true)

                        while (dr.Read())
                        {
                            B = int.Parse(dr["ID"].ToString());
                            // MessageBox.Show(B.ToString());
                            // break;

                        }
                    dr.Close();

                    con.Close();

                    con.Open();
                    if (B == 0)
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
                    }
                        con.Close();


                        con.Open();
                        string q = "insert into Products(ProductName,Brand,Description,Country,Price,Category,Amount,Seller)values('" + ProductName + "','" + B + "','" + description + "','" + Country + "','" + price + "','" + Category + "','" + amount + "','" + Seller + "')";

                        SqlCommand cmd2 = new SqlCommand(q, con);
                        cmd2.ExecuteNonQuery();
                        con.Close();
                        con.Open();

                        MemoryStream ms = new MemoryStream();
                        Productpicture.Image.Save(ms, Productpicture.Image.RawFormat);
                        byte[] img = ms.ToArray();
                        String insertQuery = "Update products set picture=@img where ProductName='" + ProductName + "'";
                        cmd = new SqlCommand(insertQuery, con);
                        cmd.Parameters.Add("@img", SqlDbType.VarBinary);
                        cmd.Parameters["@img"].Value = img;
                        cmd.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("New Product is Added!");
                        Items I = new Items(Seller);
                        I.Show();
                        this.Hide();


                    


                }
            }
        }
            private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            ProductName = textName.Text.ToString();
        }

        private void textCountry_TextChanged(object sender, EventArgs e)
        {
            Country = textCountry.Text.ToString();
        }

        private void textBrand_TextChanged(object sender, EventArgs e)
        {


            Brand = textBrand.Text.ToString();
        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {
            price = float.Parse(textPrice.Text.ToString());
        }

        private void textAmount_TextChanged(object sender, EventArgs e)
        {
            amount = int.Parse(textAmount.Text.ToString());
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category = comboBoxCategory.FindStringExact(comboBoxCategory.Text);
            Category++;
        }

        private void textDescription_TextChanged(object sender, EventArgs e)
        {
            description = textDescription.Text.ToString();
        }

        private void PictureChangeBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog()==DialogResult.OK)
            {

                Productpicture.Image = Image.FromFile(opf.FileName);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult cancel = new DialogResult();
            cancel = MessageBox.Show("Are you sure?", "?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (cancel == DialogResult.OK)
            {

                Items It= new Items(Seller);
                It.Show();

                this.Close();

            }
        }
    }
}
