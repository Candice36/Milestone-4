using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_4_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboRestock.Items.Add("Bagels");
            cboRestock.Items.Add("Cupcakes");
            //clear all item cboRestock2
            //init data
            List<Items> list = new List<Items>();
            list.Add(new Items() { ID = "01", Name = "Donuts" });
            list.Add(new Items() { ID = "01", Name = "Cakes" });
            list.Add(new Items() { ID = "01", Name = "Pies" });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string[] listItems = new string[4];
            listItems[0] = cmb_items.SelectedItem.ToString();
            listItems[1] = txt_price.Text;
            listItems[2] = txt_qty.Text;
            listItems[3] = txt_total.Text;

            ListViewItem lvi = new ListViewItem(listItems);

            listView1.Items.Add(lvi);

            txt_sub.Text = (Convert.ToInt32(txt_total.Text)).ToString();


            Console.ReadLine();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Red;

            List<string> Items = new List<string>();

            cmb_items.Items.Clear();
           
            cmb_items.Items.Add("Sweets Item 1");
            cmb_items.Items.Add("Sweets Item 2");
            cmb_items.Items.Add("Sweets Item 3");
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Green;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("Mix Item 1");
            cmb_items.Items.Add("Mix Item 2");
            cmb_items.Items.Add("Mix Item 3");





        }

        private void cmb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            


            if(cmb_items.SelectedItem.ToString() == "Sweets Item 1")
            { 
                txt_price.Text = "50"; 
            }
            else if (cmb_items.SelectedItem.ToString() == "Sweets Item 2")
            {
                txt_price.Text = "100"; 
            }
            else if (cmb_items.SelectedItem.ToString() == "Sweets Item 3")
            {
                txt_price.Text = "150"; }
            else if (cmb_items.SelectedItem.ToString() == "Mix Item 2")
            { txt_price.Text = "200";
            }
            else if (cmb_items.SelectedItem.ToString() == "Mix Item 3")
            { 
                txt_price.Text = "250"; 
            }
            else if (cmb_items.SelectedItem.ToString() == "Mix Item 3")
            {
                txt_price.Text = "300";
            }
            else
            { 
                txt_price.Text = "0"; 
            }

            txt_total.Text = "";
            txt_qty.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txt_total.Text = (Convert.ToInt32(txt_price.Text)).ToString();
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            if(txt_discount.Text.Length > 0)
            {
               txt_net.Text = (Convert.ToInt32(txt_sub.Text) * Convert.ToInt32(txt_discount.Text )).ToString();
            }
        }
        

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
            if (txt_paid.Text.Length > 0)
            {
                txt_balance.Text = (Convert.ToInt32(txt_net.Text)).ToString(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if(listView1.Items[i].Selected)
                    {
                       
                        listView1.Items[i].Remove();
                       
                    }
                }
            }
        }

        private void lblStock_Click(object sender, EventArgs e)
        {
            
        }

        private void cboRestock_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStock.Text = cboRestock.Text;
        }

        private class Items
        {
            internal string Name;

            public string ID { get; internal set; }
        }
    }
}
