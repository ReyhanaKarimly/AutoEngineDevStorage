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
    public partial class Items : Form
    {
        int User;
        public Items(int u)
        {
            User = u;
            InitializeComponent();
        }
        SqlConnection sqlconnection;

        SqlCommand sqlcommand;
        string Query;




        SqlDataReader dr = null;

        public string ConnectionString = @"Data Source=DESKTOP-94LT9G1\SQLEXPRESS;Initial Catalog=AutomationEngineeringDevicesStorage;Integrated Security=True";

        private void Items_Load(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(ConnectionString);
            sqlconnection.Open();
            Query = "select Picture from Products";


            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(200, 200);
            sqlcommand = new SqlCommand(Query, sqlconnection);

            dr = sqlcommand.ExecuteReader();

            string[] product_info = new string[6];
            int count = -1;
            while (dr.Read())

            {
                count++;
                // Image _image = new Bitmap(new MemoryStream((Byte[])dr["Picture"]));
                var imageBytes = (byte[])dr["Picture"];



                MemoryStream memStm = new MemoryStream(imageBytes);
                memStm.Seek(0, SeekOrigin.Begin);

                // create an "Image" from that memory stream
                Image image = System.Drawing.Image.FromStream(memStm);

                imgs.Images.Add(image);
                Button B = new Button();
                B.Image = image;
                B.Size = new Size(200, 200);
                flowLayoutPanel1.Controls.Add(B);


            }

            dr.Close();


            //sqlcommand = new SqlCommand(Query, sqlconnection);

            //sqladapter = new SqlDataAdapter();

            //datatable = new DataTable();

            //sqladapter.SelectCommand = sqlcommand;

            //sqladapter.Fill(datatable);

            //dataGridViewItems.DataSource = datatable;
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            //DataView DV = new DataView(datatable);

            //DV.RowFilter = string.Format("ProductName LIKE '%{0}%'", textSearch.Text);

            //dataGridViewItems.DataSource = DV;
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 F = new Form3(User);
            F.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InvManBtn_Click(object sender, EventArgs e)
        {
            //Form inventory_management = new Form4();

            //inventory_management.Show();

            //this.Hide();
        }

        private void transactionBtn_Click(object sender, EventArgs e)
        {
            Form transaction = new Form3(User);

            transaction.Show();

            this.Hide();

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Login L = new Login();
          //  L.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void newProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProduct N = new NewProduct(User);
            N.Show();
            this.Hide();
        }

        private void removeProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 F = new Form4(User);
            F.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
