using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoneProject

{
   
    public class Inventory
    {
        private string inventoryItemName = "";
        private string inventoryItemType = "";
        private double inventoryItemPrice = 0.00;
        private string inventroyItemSKU = "";
        private int inventoryItemQuantity = 0;

        public Inventory()
        {
           
        }

        public string getInventroyItemName()
        {
            return inventoryItemName;
        }
        public string getInventoryItemType()
        {
            return inventoryItemType;
        }
        public double getInventoryItemPrice()
        {
            return inventoryItemPrice;
        }
        public string getInventoryItemSKU()
        {
            return inventroyItemSKU; 
        }
        public int getInventoryItemQuantity()
        {
            return inventoryItemQuantity;
        }


        public void setInventoryName(string inventoryName)
        {
            inventoryItemName = inventoryName;
        }
        public void setInventoryItemType(string itemTpye)
        {
            inventoryItemType = itemTpye;
        }
        public void setInventoryItemPrice(double itemPrice)
        {
            inventoryItemPrice = itemPrice;
        }
        public void setInventoryItemSKU(string itemSKU)
        {
            inventroyItemSKU = itemSKU;
        }
        public void setInventoryItemQuantity(int itemQuantity)
        {
            this.inventoryItemQuantity = itemQuantity; 
        }
    }

}
