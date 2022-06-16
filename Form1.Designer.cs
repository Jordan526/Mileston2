namespace MilestoneProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemPictureBox = new System.Windows.Forms.PictureBox();
            this.ItemPictureLabel = new System.Windows.Forms.Label();
            this.itemDescriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemsTypeLabel = new System.Windows.Forms.Label();
            this.itemsPriceLabel = new System.Windows.Forms.Label();
            this.skuLabel = new System.Windows.Forms.Label();
            this.itemsNameTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.clearInventoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // itemPictureBox
            // 
            this.itemPictureBox.Location = new System.Drawing.Point(12, 25);
            this.itemPictureBox.Name = "itemPictureBox";
            this.itemPictureBox.Size = new System.Drawing.Size(318, 220);
            this.itemPictureBox.TabIndex = 0;
            this.itemPictureBox.TabStop = false;
            this.itemPictureBox.Click += new System.EventHandler(this.itemPictureBox_Click);
            // 
            // ItemPictureLabel
            // 
            this.ItemPictureLabel.AutoSize = true;
            this.ItemPictureLabel.Location = new System.Drawing.Point(140, 9);
            this.ItemPictureLabel.Name = "ItemPictureLabel";
            this.ItemPictureLabel.Size = new System.Drawing.Size(63, 13);
            this.ItemPictureLabel.TabIndex = 1;
            this.ItemPictureLabel.Text = "Item Picture";
            // 
            // itemDescriptionLabel
            // 
            this.itemDescriptionLabel.AutoSize = true;
            this.itemDescriptionLabel.Location = new System.Drawing.Point(130, 268);
            this.itemDescriptionLabel.Name = "itemDescriptionLabel";
            this.itemDescriptionLabel.Size = new System.Drawing.Size(93, 13);
            this.itemDescriptionLabel.TabIndex = 2;
            this.itemDescriptionLabel.Text = "Item\'s Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(52, 284);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(245, 89);
            this.descriptionTextBox.TabIndex = 3;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(377, 25);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(68, 13);
            this.itemNameLabel.TabIndex = 4;
            this.itemNameLabel.Text = "Item\'s Name:";
            // 
            // itemsTypeLabel
            // 
            this.itemsTypeLabel.AutoSize = true;
            this.itemsTypeLabel.Location = new System.Drawing.Point(379, 73);
            this.itemsTypeLabel.Name = "itemsTypeLabel";
            this.itemsTypeLabel.Size = new System.Drawing.Size(61, 13);
            this.itemsTypeLabel.TabIndex = 5;
            this.itemsTypeLabel.Text = "Item\'s Type";
            // 
            // itemsPriceLabel
            // 
            this.itemsPriceLabel.AutoSize = true;
            this.itemsPriceLabel.Location = new System.Drawing.Point(377, 123);
            this.itemsPriceLabel.Name = "itemsPriceLabel";
            this.itemsPriceLabel.Size = new System.Drawing.Size(64, 13);
            this.itemsPriceLabel.TabIndex = 6;
            this.itemsPriceLabel.Text = "Item\'s Price:";
            // 
            // skuLabel
            // 
            this.skuLabel.AutoSize = true;
            this.skuLabel.Location = new System.Drawing.Point(377, 172);
            this.skuLabel.Name = "skuLabel";
            this.skuLabel.Size = new System.Drawing.Size(62, 13);
            this.skuLabel.TabIndex = 7;
            this.skuLabel.Text = "Item\'s SKU:";
            // 
            // itemsNameTextBox
            // 
            this.itemsNameTextBox.Location = new System.Drawing.Point(469, 18);
            this.itemsNameTextBox.Name = "itemsNameTextBox";
            this.itemsNameTextBox.Size = new System.Drawing.Size(92, 20);
            this.itemsNameTextBox.TabIndex = 8;
            this.itemsNameTextBox.TextChanged += new System.EventHandler(this.itemsNameTextBox_TextChanged);
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(469, 66);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(92, 20);
            this.typeTextBox.TabIndex = 9;
            this.typeTextBox.TextChanged += new System.EventHandler(this.typeTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(469, 116);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(92, 20);
            this.priceTextBox.TabIndex = 10;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // skuTextBox
            // 
            this.skuTextBox.Location = new System.Drawing.Point(469, 169);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(92, 20);
            this.skuTextBox.TabIndex = 11;
            this.skuTextBox.TextChanged += new System.EventHandler(this.skuTextBox_TextChanged);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(315, 325);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 12;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(415, 325);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete Item";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(518, 325);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 14;
            this.modifyButton.Text = "Modify Item";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(377, 228);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(86, 13);
            this.quantityLabel.TabIndex = 15;
            this.quantityLabel.Text = "Item\'s Quantity #";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(469, 225);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(92, 20);
            this.quantityTextBox.TabIndex = 16;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            // 
            // clearInventoryButton
            // 
            this.clearInventoryButton.Location = new System.Drawing.Point(380, 361);
            this.clearInventoryButton.Name = "clearInventoryButton";
            this.clearInventoryButton.Size = new System.Drawing.Size(146, 23);
            this.clearInventoryButton.TabIndex = 17;
            this.clearInventoryButton.Text = "Clear Inventory Item";
            this.clearInventoryButton.UseVisualStyleBackColor = true;
            this.clearInventoryButton.Click += new System.EventHandler(this.clearInventoryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 396);
            this.Controls.Add(this.clearInventoryButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.skuTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.itemsNameTextBox);
            this.Controls.Add(this.skuLabel);
            this.Controls.Add(this.itemsPriceLabel);
            this.Controls.Add(this.itemsTypeLabel);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.itemDescriptionLabel);
            this.Controls.Add(this.ItemPictureLabel);
            this.Controls.Add(this.itemPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox itemPictureBox;
        private System.Windows.Forms.Label ItemPictureLabel;
        private System.Windows.Forms.Label itemDescriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label itemsTypeLabel;
        private System.Windows.Forms.Label itemsPriceLabel;
        private System.Windows.Forms.Label skuLabel;
        private System.Windows.Forms.TextBox itemsNameTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox skuTextBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button clearInventoryButton;
    }
}

