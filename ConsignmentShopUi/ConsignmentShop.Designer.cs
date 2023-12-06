namespace ConsignmentShopUi
{
    partial class ConsignmentShop
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
            this.headertext = new System.Windows.Forms.Label();
            this.itemsListbox = new System.Windows.Forms.ListBox();
            this.itemsListboxLabel = new System.Windows.Forms.Label();
            this.shoppingCartListboxLabel = new System.Windows.Forms.Label();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.addToCartBtn = new System.Windows.Forms.Button();
            this.makePurchase = new System.Windows.Forms.Button();
            this.removeFromcartBtn = new System.Windows.Forms.Button();
            this.refreshDataBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headertext
            // 
            this.headertext.AutoSize = true;
            this.headertext.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headertext.Location = new System.Drawing.Point(443, 0);
            this.headertext.Name = "headertext";
            this.headertext.Padding = new System.Windows.Forms.Padding(10);
            this.headertext.Size = new System.Drawing.Size(282, 80);
            this.headertext.TabIndex = 0;
            this.headertext.Text = "store name";
            this.headertext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headertext.Click += new System.EventHandler(this.headertext_Click);
            // 
            // itemsListbox
            // 
            this.itemsListbox.BackColor = System.Drawing.SystemColors.Window;
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.ItemHeight = 20;
            this.itemsListbox.Location = new System.Drawing.Point(76, 103);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(360, 264);
            this.itemsListbox.TabIndex = 1;
            this.itemsListbox.SelectedIndexChanged += new System.EventHandler(this.itemsListbox_SelectedIndexChanged);
            // 
            // itemsListboxLabel
            // 
            this.itemsListboxLabel.AutoSize = true;
            this.itemsListboxLabel.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListboxLabel.Location = new System.Drawing.Point(72, 80);
            this.itemsListboxLabel.Name = "itemsListboxLabel";
            this.itemsListboxLabel.Size = new System.Drawing.Size(100, 20);
            this.itemsListboxLabel.TabIndex = 2;
            this.itemsListboxLabel.Text = "Store items";
            // 
            // shoppingCartListboxLabel
            // 
            this.shoppingCartListboxLabel.AutoSize = true;
            this.shoppingCartListboxLabel.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartListboxLabel.Location = new System.Drawing.Point(732, 80);
            this.shoppingCartListboxLabel.Name = "shoppingCartListboxLabel";
            this.shoppingCartListboxLabel.Size = new System.Drawing.Size(119, 20);
            this.shoppingCartListboxLabel.TabIndex = 4;
            this.shoppingCartListboxLabel.Text = "Shopping Cart";
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.BackColor = System.Drawing.SystemColors.Window;
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.ItemHeight = 20;
            this.shoppingCartListbox.Location = new System.Drawing.Point(736, 103);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(360, 264);
            this.shoppingCartListbox.TabIndex = 3;
            this.shoppingCartListbox.SelectedIndexChanged += new System.EventHandler(this.shoppingCartListbox_SelectedIndexChanged);
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addToCartBtn.Location = new System.Drawing.Point(505, 165);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(165, 56);
            this.addToCartBtn.TabIndex = 5;
            this.addToCartBtn.Text = "Add To Cart  =>";
            this.addToCartBtn.UseVisualStyleBackColor = false;
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click);
            // 
            // makePurchase
            // 
            this.makePurchase.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.makePurchase.Location = new System.Drawing.Point(959, 373);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(137, 56);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = false;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // removeFromcartBtn
            // 
            this.removeFromcartBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.removeFromcartBtn.Location = new System.Drawing.Point(505, 240);
            this.removeFromcartBtn.Name = "removeFromcartBtn";
            this.removeFromcartBtn.Size = new System.Drawing.Size(165, 56);
            this.removeFromcartBtn.TabIndex = 7;
            this.removeFromcartBtn.Text = "<=  Remove From Cart ";
            this.removeFromcartBtn.UseVisualStyleBackColor = false;
            this.removeFromcartBtn.Click += new System.EventHandler(this.removeFromcartBtn_Click);
            // 
            // refreshDataBtn
            // 
            this.refreshDataBtn.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshDataBtn.Location = new System.Drawing.Point(2, 485);
            this.refreshDataBtn.Name = "refreshDataBtn";
            this.refreshDataBtn.Size = new System.Drawing.Size(70, 40);
            this.refreshDataBtn.TabIndex = 8;
            this.refreshDataBtn.Text = "Refresh";
            this.refreshDataBtn.UseVisualStyleBackColor = true;
            this.refreshDataBtn.Click += new System.EventHandler(this.refreshDataBtn_Click);
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1164, 528);
            this.Controls.Add(this.refreshDataBtn);
            this.Controls.Add(this.removeFromcartBtn);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.addToCartBtn);
            this.Controls.Add(this.shoppingCartListboxLabel);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.itemsListboxLabel);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.headertext);
            this.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop Demo";
            this.Load += new System.EventHandler(this.ConsignmentShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headertext;
        private System.Windows.Forms.ListBox itemsListbox;
        private System.Windows.Forms.Label itemsListboxLabel;
        private System.Windows.Forms.Label shoppingCartListboxLabel;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Button addToCartBtn;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Button removeFromcartBtn;
        private System.Windows.Forms.Button refreshDataBtn;
    }
}

