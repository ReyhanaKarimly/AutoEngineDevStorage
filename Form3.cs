using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace AutoEngineDevStorage
{
    public partial class Form3 : Form
    {
        private string conString;
        SqlConnection mycon;
        SqlDataReader dr = null;

        SqlCommand cmd = null;
        double total = 0;
        List<Tuple<int, int, string>> L = new List<Tuple<int, int, string>>();
        string Id;
        int cartitems = -1;
        string cmdstr1;
        int Buyer;
        public Form3(int Buyer)
        {
            conString = @"Data Source=DESKTOP-94LT9G1\SQLEXPRESS;Initial Catalog=AutomationEngineeringDevicesStorage;Integrated Security=True";
            this.Buyer = Buyer;
            mycon = new SqlConnection(conString);
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            mycon.Open();
            cmdstr1 = "select Products.ID,Products.ProductName,Products.Picture, Products.Description,Products.Country,Products.Price, Companies.Company from Companies,Products where Products.Brand = Companies.ID";
            loaddbase();

            mycon.Close();

        }

        private void loaddbase()

        {


            listView1.Items.Clear();


            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(100, 100);
            cmd = new SqlCommand(cmdstr1, mycon);

            dr = cmd.ExecuteReader();

            string[] product_info = new string[6];
            int count = -1;
            while (dr.Read())

            {
                count++;
                // Image _image = new Bitmap(new MemoryStream((Byte[])dr["Picture"]));
                var imageBytes = (byte[])dr["Picture"];

                product_info[1] = (dr["ID"].ToString());

                product_info[2] = (dr["ProductName"].ToString());

                product_info[3] = (dr["Country"].ToString());

                product_info[4] = (dr["Description"].ToString());
                MemoryStream memStm = new MemoryStream(imageBytes);
                memStm.Seek(0, SeekOrigin.Begin);

                // create an "Image" from that memory stream
                Image image = System.Drawing.Image.FromStream(memStm);
                imgs.Images.Add(image);
                listView1.SmallImageList = imgs;

                this.listView1.Items.Add(product_info[1], product_info[2], count);
                if (textBox1.Text != "")
                {
                    break;

                }

            }

            dr.Close();

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;

            }
            if (textNumber.Text == "")
            {
                textNumber.Text = "1";

            }
            else if (textNumber.Text == "0")
            {

                textNumber.Text = "1";
            }

            BuyBtn.Enabled = true;
            TotalBtn.Enabled = true;

            mycon.Open();

            string[] product_info = new string[8];

            string[] select = new string[2];

            int[] num = new int[5];

            foreach (ListViewItem item in listView1.SelectedItems)

            {

                //SELECT THE SPECIFIC PRODUCT FROM DATABASE

                select[1] = item.Text;

                string cmdstr = "SELECT distinct * FROM Products WHERE ProductName = '" + select[1] + "'";

                dr = cmd.ExecuteReader();

                while (dr.Read())

                {


                    product_info[1] = (dr["ID"].ToString());
                    Id = product_info[1];

                    product_info[2] = (dr["ProductName"].ToString());

                    product_info[3] = (dr["Country"].ToString());

                    product_info[4] = (dr["Description"].ToString());
                    product_info[5] = (dr["Amount"].ToString());
                    product_info[6] = (dr["Price"].ToString());
                    product_info[7] = (dr["Seller"].ToString());

                    this.listView2.Items.Add(new ListViewItem(new string[] { product_info[2], product_info[6], textNumber.Text }));
                    L.Add(Tuple.Create<int, int, string>(int.Parse(product_info[7]), int.Parse(product_info[1]), product_info[2]));

                    cartitems++;


                    break;





                }
                dr.Close();
                num[1] = int.Parse(product_info[5]);
                num[2] = int.Parse(textNumber.Text);
                if (num[1] <= 0 || num[1] < num[2])
                {
                    MessageBox.Show("Product is not available!");
                    return;

                }

                string cmdstr2 = "UPDATE Products SET Amount = '" + (num[1] - num[2]) + "' WHERE ID = '" + product_info[1] + "'";



                SqlCommand cmd2 = new SqlCommand(cmdstr2, mycon);
                cmd2.ExecuteNonQuery();
            }

            loaddbase();

            mycon.Close();

            textNumber.Text = "0";




        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            if (listView2.Items.Count == 0)
            {
                return;

            }

            TotalBtn_Click(sender, e);
            MessageBox.Show("Thank You for Buying", "");



            textNumber.Text = "0";

            cartitems = -1;
            mycon.Open();


            if (mycon.State == System.Data.ConnectionState.Open)
            {



                foreach (ListViewItem item in listView2.Items)
                {

                    string[] select = new string[2];
                    select[1] = item.Text;


                    string cmdstr = "select * from Products where Products.ProductName='" + select[1] + "'";
                    SqlCommand comm = new SqlCommand(cmdstr, mycon);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        int S = 5;
                        int I = 6;
                        foreach (var lst in L)
                        {
                            if (lst.Item3 == item.Text)
                            {
                                S = lst.Item1;
                                I = lst.Item2;
                                break;
                            }


                        }


                        string q = "insert into Deals(SellerID,Buyer,Price,ProductID,Date)values('" + S + "','" + (Buyer) + "','" + total + "','" + I + "','" + DateTime.Today + "')";
                        dr.Close();
                        SqlCommand cmd3 = new SqlCommand(q, mycon);
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("New DEAL!!");

                        break;
                    }


                }








            }

            listView2.Items.Clear();

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Items I = new Items(Buyer);
            I.Show();
            this.Hide();
            this.Close();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveBtn.Enabled = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mycon.Open();

            string[] product_info = new string[7];

            string[] select = new string[2];

            ViewBtn.Enabled = true;

            foreach (ListViewItem item in listView1.SelectedItems)

            {

                //SELECT THE SPECIFIC PRODUCT FROM DATABASE

                select[1] = item.Text;

                string cmdstr = "SELECT * FROM Products WHERE ProductName = '" + select[1] + "'";

                cmd = new SqlCommand(cmdstr, mycon);

                dr = cmd.ExecuteReader();

                while (dr.Read())

                {


                    product_info[1] = (dr["ID"].ToString());
                    Id = product_info[1];




                }
                dr.Close();
            }



            mycon.Close();



        }

        private void textNumber_TextChanged(object sender, EventArgs e)
        {

            AddBtn.Enabled = true;
            //           if (textNumber.Text=="0")
            //           {
            //textNumber.Clear();
            //           }


        }


        private void ViewBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;

            }
            Basket B = new Basket(Id);
            B.Show();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                return;

            }
            mycon.Close();
            mycon.Open();

            string[] select = new string[3];

            int[] rem = new int[5];

            string[] product_info = new string[7];

            foreach (ListViewItem item in listView2.SelectedItems)

            {



                select[1] = item.Text;

                listView2.FullRowSelect = true;

                string cmdstr = "SELECT * FROM Products WHERE ProductName = '" + select[1] + "'";

                cmd = new SqlCommand(cmdstr, mycon);

                dr = cmd.ExecuteReader();

                while (dr.Read())

                {

                    product_info[1] = (dr["ID"].ToString());

                    product_info[2] = (dr["Amount"].ToString());

                    product_info[3] = (dr["Price"].ToString());

                    product_info[4] = (dr["ProductName"].ToString());

                    L.RemoveAll(p => p.Item3 == product_info[4]);
                    cartitems--;

                    rem[1] = int.Parse(product_info[2]);


                    rem[2] = int.Parse(listView2.SelectedItems[0].SubItems[2].Text);
                    item.Remove();



                    break;



                }
                dr.Close();
                string cmdstr2 = "UPDATE Products SET Amount = '" + (rem[1] + rem[2]) + "' WHERE ID = '" + product_info[1] + "'";

                cmd = new SqlCommand(cmdstr2, mycon);

                cmd.ExecuteNonQuery();
                //  loaddbase();

                mycon.Close();

            }
        }

        private void TotalBtn_Click(object sender, EventArgs e)
        {
            if (listView2.Items.Count == 0)
            {
                return;

            }
            total = 0;

            int i = 0;

            do

            {

                double product = Convert.ToDouble(listView2.Items[i].SubItems[1].Text) * Convert.ToDouble(listView2.Items[i].SubItems[2].Text);

                total = total + product;

                i++;

            } while (i <= cartitems);
            totalLabel.Text = "Total: ";
            CostLabel.Text = "" + total + " $";
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mycon.Close();
            int index = comboBox1.FindStringExact(comboBox1.Text);
            index++;
            if (index == 0)
            {

                cmdstr1 = @"select Products.ID,Products.ProductName,Products.Picture, Products.Description,Products.Country,Products.Price, Companies.Company 
                            from Companies,Products 
                            where Products.Brand = Companies.ID and Products.ProductName  LIKE '%" + textBox1.Text + "%'";
                mycon.Open();
                loaddbase();
                mycon.Close();


            }
            else
            {
                cmdstr1 = "select Products.ID,Products.ProductName,Products.Picture, Products.Description,Products.Country,Products.Price, Companies.Company from Companies,Products where Products.Brand = Companies.ID and Products.ProductName  LIKE '%" + textBox1.Text + "%' and Products.Category='" + index + "'";
                mycon.Open();
                loaddbase();
                mycon.Close();

            }

        }

        private void textNumber_MouseClick(object sender, MouseEventArgs e)
        {
            textNumber.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mycon.Close();

            int index = comboBox1.FindStringExact(comboBox1.Text);
            index++;
            if (textBox1.Text != "")
            {
                cmdstr1 = "select Products.ID,Products.ProductName,Products.Picture, Products.Description,Products.Country,Products.Price, Companies.Company from Companies,Products where Products.Brand = Companies.ID and Products.ProductName  LIKE '%" + textBox1.Text + "%' and Products.Category='" + index + "'";
                mycon.Open();
                loaddbase();
                mycon.Close();

            }
            else
            {
                cmdstr1 = "select Products.ID,Products.ProductName,Products.Picture, Products.Description,Products.Country,Products.Price, Companies.Company from Companies,Products where Products.Brand = Companies.ID  and Products.Category='" + index + "'";
                mycon.Open();
                loaddbase();
                mycon.Close();


            }
        }
    }
}
