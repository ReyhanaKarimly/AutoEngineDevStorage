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
    public partial class Form4 : Form
    {
        int Seller;
        private string conString;
        SqlConnection mycon;
        SqlDataReader dr = null;
        string cmdstr1 = null;
        SqlCommand cmd = null;
        string Product_Name;
        public Form4(int S)
        {
            conString = @"Data Source=DESKTOP-94LT9G1\SQLEXPRESS;Initial Catalog=AutomationEngineeringDevicesStorage;Integrated Security=True";
            Seller = S;
            mycon = new SqlConnection(conString);
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            mycon.Open();
            cmdstr1 = @"select  Products.ID,Products.ProductName,Products.Picture from Products
            where Products.Seller='" + Seller + "'";

            //listView1.Items.Clear();


            //ImageList imgs = new ImageList();
            //imgs.ImageSize = new Size(100, 100);
            //cmd = new SqlCommand(cmdstr1, mycon);

            //dr = cmd.ExecuteReader();

            //string[] product_info = new string[6];
            //int count = -1;
            //while (dr.Read())

            //{
            //    count++;
            //    // Image _image = new Bitmap(new MemoryStream((Byte[])dr["Picture"]));
            //    var imageBytes = (byte[])dr["Picture"];

            //    product_info[1] = (dr["ID"].ToString());

            //    product_info[2] = (dr["ProductName"].ToString());


            //    MemoryStream memStm = new MemoryStream(imageBytes);
            //    memStm.Seek(0, SeekOrigin.Begin);

            //    // create an "Image" from that memory stream
            //    Image image = System.Drawing.Image.FromStream(memStm);
            //    imgs.Images.Add(image);
            //    listView1.SmallImageList = imgs;

            //    this.listView1.Items.Add(product_info[1], product_info[2], count);

            //}
            loaddbase();

            dr.Close();

            mycon.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Items I = new Items(Seller);
            I.Show();
            this.Close();
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
               // Idd = int.Parse(product_info[1]);
                product_info[2] = (dr["ProductName"].ToString());

                
                MemoryStream memStm = new MemoryStream(imageBytes);
                memStm.Seek(0, SeekOrigin.Begin);

                // create an "Image" from that memory stream
                Image image = System.Drawing.Image.FromStream(memStm);
                imgs.Images.Add(image);
                listView1.SmallImageList = imgs;

                this.listView1.Items.Add(product_info[1], product_info[2], count);
                

            }

            dr.Close();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(conString)) { 
                mycon.Open();

            

            string[] select = new string[2];



                foreach (ListViewItem item in listView1.SelectedItems)

                {

                    //SELECT THE SPECIFIC PRODUCT FROM DATABASE

                    select[1] = item.Text;

                    using (SqlCommand command = new SqlCommand("Delete FROM Products WHERE ProductName = '" + select[1] + "' AND Products.Seller='" + Seller + "'"))
                    {
                        
                        command.Connection = mycon;
                        command.ExecuteNonQuery();

                       


                    }
                        loaddbase();
                    mycon.Close();

                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
            {
                return;

            }
            //else MessageBox.Show("Works");
            


                string[] select = new string[2];



                foreach (ListViewItem item in listView1.SelectedItems)

                {

                    //SELECT THE SPECIFIC PRODUCT FROM DATABASE

                    select[1] = item.Text;


                break;

                }
            


            UpdateProduct U = new UpdateProduct(select[1],Seller);
            U.Show();
            this.Close();

        }
    }
}
