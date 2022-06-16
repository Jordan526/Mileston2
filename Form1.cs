using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilestoneProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Inventory inventoryManagement = new Inventory();
        public void itemsNameTextBox_TextChanged(object sender, EventArgs e)
        {
            inventoryManagement.setInventoryName(itemsNameTextBox.Text);
        }

        string itemType = "";
        public void typeTextBox_TextChanged(object sender, EventArgs e)
        {
            inventoryManagement.setInventoryItemType(typeTextBox.Text);
        }
        double price = 0;
        public void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            inventoryManagement.setInventoryItemPrice(double.Parse(priceTextBox.Text));
        }
        long SKU = 0;
        public void skuTextBox_TextChanged(object sender, EventArgs e)
        {
            inventoryManagement.setInventoryItemSKU(skuTextBox.Text);

        }
        public void addItemButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A quantity of " + inventoryManagement.getInventoryItemQuantity() + " " + inventoryManagement.getInventroyItemName() + "'s (SKU: " + inventoryManagement.getInventoryItemSKU() + ") Have Been Added to the Inventory List.");
        }

        public void deleteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(inventoryManagement.getInventroyItemName() + " Has Been Deleted from the Inventory List.");
        }
        int quantity = 0;
        public void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            inventoryManagement.setInventoryItemQuantity(Int32.Parse(quantityTextBox.Text));
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void clearInventoryButton_Click(object sender, EventArgs e)
        {
            itemsNameTextBox.Text = "";
            typeTextBox.Text = "";
            priceTextBox.Text = "";
            skuTextBox.Text = "";
            quantityTextBox.Text = "";
        }
    }
}
