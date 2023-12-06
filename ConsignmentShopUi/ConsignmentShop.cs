using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUi
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
       
        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();
            
            GenerateItemsBindings();
            itemsListbox.DataSource = itemsBinding;

            itemsListbox.DisplayMember = "Display";
            itemsListbox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartListbox.DataSource = cartBinding;

            shoppingCartListbox.DisplayMember = "Display";
            shoppingCartListbox.ValueMember = "Display";
        }

        private void GenerateItemsBindings()
        {
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false && x.InCart == false).ToList();
        }

        private void SetupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "evariste", LastName = "galois" });
            store.Vendors.Add(new Vendor { FirstName = "this", LastName = "me" });

            store.Items.Add(new Item
            {
                Title = "Ulyses",
                Description = "A book about life",
                Price = 6.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "To the Lighthouse",
                Description = "A book about a lighthouse",
                Price = 5.50M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Duo",
                Description = "A book in French",
                Price = 7.25M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Eloquent Javascript",
                Description = "A book about coding",
                Price = 4.15M,
                Owner = store.Vendors[1]
            });

            store.Name = "Books u Love";
        }

        private void itemsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConsignmentShop_Load(object sender, EventArgs e)
        {

        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)itemsListbox.SelectedItem;

            if (itemsListbox.Items.Count < 1) return;

            if (!shoppingCartData.Contains(selectedItem))
            {

                shoppingCartData.Add(selectedItem);
                selectedItem.InCart = true;
                cartBinding.ResetBindings(false);
                GenerateItemsBindings();
            }
            else
            {
                MessageBox.Show("Item already in Cart");
            }

        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            foreach (Item item in shoppingCartData)
            {
                item.Sold = true;
            }

            shoppingCartData.Clear();

            GenerateItemsBindings();

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
        }

        private void removeFromcartBtn_Click(object sender, EventArgs e)
        {
            if (shoppingCartListbox.Items.Count > 0)
            {
                Item selectedCartItem = (Item)shoppingCartListbox.SelectedItem;
                selectedCartItem.Sold = false;
                selectedCartItem.InCart = false;
                shoppingCartData.Remove(selectedCartItem);

                cartBinding.ResetBindings(false);
                itemsBinding.ResetBindings(false);
                GenerateItemsBindings();
            }


        }

        private void shoppingCartListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void headertext_Click(object sender, EventArgs e)
        {
            
        }
    }
}
