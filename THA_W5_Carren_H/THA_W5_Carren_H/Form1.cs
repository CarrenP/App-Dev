using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace THA_W5_Carren_H
{
    public partial class Form1 : Form
    {
        int highestnum = 0;
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dtproduksimpan = new DataTable();
        DataTable dtcategory = new DataTable();
        DataTable filter =new DataTable();
        public static List<string> category = new List<string>() { "C1", "C2", "C3", "C4", "C5" };
        public static List<string> products = new List<string>() { "Jas", "T-Shirt", "Rok", "Celana", "Cawat" };
        private void Form1_Load(object sender, EventArgs e)
        {
            dtproduksimpan.Columns.Add("ID Product");
            dtproduksimpan.Columns.Add("Nama Product");
            dtproduksimpan.Columns.Add("Harga");
            dtproduksimpan.Columns.Add("Stock");
            dtproduksimpan.Columns.Add("ID category");

            dtcategory.Columns.Add("ID category");
            dtcategory.Columns.Add("Nama Category");
            dtablecategory.DataSource = dtcategory;

            dtproduksimpan.Rows.Add("J001", "Jas Hitam", 100000, 10, "C1");
            dtproduksimpan.Rows.Add("T001 ", "T-Shirt Black Pink", 70000, 20, "C2");
            dtproduksimpan.Rows.Add("T002", "T-Shirt Obsessive", 75000, 16, "C2");
            dtproduksimpan.Rows.Add("R001", "Rok mini", 82000, 26, "C3");
            dtproduksimpan.Rows.Add("J002", "Jeans Biru", 90000, 5, "C4");
            dtproduksimpan.Rows.Add("C001", "Celana Pendek Coklat", 60000, 11, "C4");
            dtproduksimpan.Rows.Add("C002", "Cawat Blink-blink", 1000000, 1, "C5");
            dtproduksimpan.Rows.Add("R002", "Rocca Shirt", 50000, 8, "C2");

            dtproduk.DataSource = dtproduksimpan;
            dtcategory.Rows.Add("C1", "Jas");
            dtcategory.Rows.Add("C2", "T-Shirt");
            dtcategory.Rows.Add("C3", "Rok");
            dtcategory.Rows.Add("C4", "Celana");
            dtcategory.Rows.Add("C5", "Cawat");

            filter.Columns.Add("ID Product");
            filter.Columns.Add("Nama Product");
            filter.Columns.Add("Harga");
            filter.Columns.Add("Stock");
            filter.Columns.Add("ID category");
           

            comboBox_category.DataSource = dtcategory;
            comboBox_category.DisplayMember = "Nama Category";

            comboBox_filter.Enabled= false;
            
            
        }
        private void button_filter_Click(object sender, EventArgs e)
        {
            comboBox_filter.Enabled = true;
            //comboBox_filter.DataSource = dtcategory;
            comboBox_filter.DisplayMember = "Nama Category";
        }

        private void button_delproduk_Click(object sender, EventArgs e)
        {
            dtproduksimpan.Rows.RemoveAt(dtproduk.CurrentCell.RowIndex);
        }

        private void button_addproduk_Click(object sender, EventArgs e)
        {
            string abc = "carren lawak";
            bool check = false;
            if (textBox_nama.Text=="" || textBox_harga.Text=="" || textBox_stock.Text=="" || comboBox_category.Text=="")
            {
                MessageBox.Show("Please fill in the blank");
            }
            else
            {
                foreach(DataRow dr in dtproduksimpan.Rows)
                { 
                    if (dr[0].ToString()==textBox_nama.Text)
                    {
                        //check = true;
                    }
                }
                string hurufdepan = textBox_nama.Text.ToString().Substring(0, 1).ToUpper();
                int code = 0;
                int code2 = 0;
                string kjh = "";
                foreach(DataRow a in dtproduksimpan.Rows)
                {
                    
                    if (a[0].ToString().Substring(0,1).ToUpper()==hurufdepan)
                    {
                        
                        if (Convert.ToInt32(a[0].ToString().Substring(1,3)) > code)
                            {
                                code2 = Convert.ToInt32(a[0].ToString().Substring(1,3));
                            

                            }
  
                    }
                }
                
                for(int w =0;  w < dtcategory.Rows.Count; w++)
                {
                    if (comboBox_category.Text == dtcategory.Rows[w][1].ToString())
                    {
                        abc = dtcategory.Rows[w][0].ToString();
                    }
                }
                kjh=(code2+1).ToString("D3");
                if(check==false)
                {
                    dtproduksimpan.Rows.Add(hurufdepan+ kjh, textBox_nama.Text,textBox_harga.Text,textBox_stock.Text,abc);
                }
            }
        }


        //List<string> category = new List<string>() { "Jas", "T-Shirt", "Rok", "Celana", "Cawat" };
        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox_category.Items.Clear();
            //foreach (string a in category)
            //{
            //    comboBox_category.Items.Add(a);
            //}
        }

        private void button_removecategory_Click(object sender, EventArgs e)
        {
            string vbn = "";
            if (dtablecategory.SelectedCells.Count <= 0)
            {
                MessageBox.Show("please selct, is empty now", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                comboBox_category.Items.Remove(dtablecategory.SelectedCells[0].Value.ToString());
                comboBox_filter.Items.Remove(dtablecategory.SelectedCells[0].Value.ToString());
                for (int x = dtproduksimpan.Rows.Count - 1; x >= 0; x--)
                {
                    if (dtproduksimpan.Rows[x][4].ToString() == dtablecategory.SelectedCells[0].Value.ToString())
                    {
                        dtproduksimpan.Rows.RemoveAt(x);
                    }
                }
                if (dtablecategory.SelectedCells[0].Value.ToString().Substring(0) == count.ToString())
                {
                    count--;
                }
                foreach (DataRow b in dtcategory.Rows)
                {
                    if (b[1].ToString() == vbn)
                    {

                        dtcategory.Rows.Remove(b);
                        break;
                    }
                    dtablecategory.Rows.RemoveAt(dtablecategory.CurrentCell.RowIndex);
                    break;
                }
            }
        }

        private void textBox_harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button_addcategory_Click(object sender, EventArgs e)
        {
            
            int angka = 0;
            highestnum = 0;
            
            foreach(DataRow dr in dtcategory.Rows)
            {
                if (Convert.ToInt32(dr[0].ToString().Substring(1)) >= highestnum)
                {
                    highestnum = Convert.ToInt32(dr[0].ToString().Substring(1));
                }
            }
            if (textBox_namacategory.Text == "")
            {
                MessageBox.Show("Please fill in the blank");
            }
            else
            {
                dtcategory.Rows.Add("C" + (highestnum+1),textBox_namacategory.Text);

            }
        }

        private void button_all_Click(object sender, EventArgs e)
        {
            comboBox_filter.Enabled= false;
            dtproduk.DataSource = dtproduksimpan;
        }

        private void comboBox_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string save = "";
            filter.Rows.Clear();

            for (int a = 0; a < dtcategory.Rows.Count; a++)
            {
                if (comboBox_filter.Text == dtcategory.Rows[a][1].ToString())
                {
                    save = dtcategory.Rows[a][0].ToString();
                }
            }
            for (int b = 0; b < dtproduksimpan.Rows.Count; b++)
            {
                if (save == dtproduksimpan.Rows[b][4].ToString())
                {
                    filter.Rows.Add(dtproduksimpan.Rows[b][0], dtproduksimpan.Rows[b][1], dtproduksimpan.Rows[b][2], dtproduksimpan.Rows[b][3], dtproduksimpan.Rows[b][4]);
                }
            }
            dtproduk.DataSource = filter;

        }
        string passID = "";
        private void dtablecategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            passID = dtcategory.Rows[e.RowIndex][0].ToString();
        }
        int count = 0;
        int abc = 0;
        private void button_editproduk_Click(object sender, EventArgs e)
        {
            if (dtproduk.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Select first", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox_stock.Text == "0")
                {
                    dtproduksimpan.Rows.RemoveAt(dtproduk.SelectedCells[0].RowIndex);
                    dtproduk.DataSource = dtproduksimpan;
                    textBox_nama.Clear();
                    textBox_stock.Clear();
                    textBox_harga.Clear();
                   

                }
                else
                {
                    dtproduksimpan.Rows[abc][1] = textBox_nama.Text;
                    dtproduksimpan.Rows[abc][3] = textBox_stock.Text;
                    dtproduksimpan.Rows[abc][2] = textBox_harga.Text;
                    
                    for (int i = 0; i < category.Count; i++)
                    {
                        if (comboBox_category.SelectedItem == products[i])
                        {
                            dtproduksimpan.Rows[abc][4] = category[i];
                        }
                    }
                    dtproduk.DataSource = dtproduksimpan;
                }
            }
        }
    }
}
