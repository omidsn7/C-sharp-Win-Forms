using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        ShoppingCartModel cart = new ShoppingCartModel();

        public Dashboard()
        {
            InitializeComponent();
            PopulateCartWithDemoData();
        }

        private void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
        }

        private void messageBoxDemoButton_Click(object sender, EventArgs e)
        {
            decimal total = cart.GenerateTotal(CalculateSumTotal, CalculateSumDiscountTotal, PrintOutDiscountAlert);

            MessageBox.Show($"The Total of price With Discount is : {total:C2}");
        }

        private void textBoxDemoButton_Click(object sender, EventArgs e)
        {
            decimal total = cart.GenerateTotal((sumtotal) => subTotalTextBox.Text = $"{sumtotal:C2}",
                (prodcts, sumtotal) => sumtotal - (prodcts.Count * 2), (message) => { });

            totalTextBox.Text = $"{total:C2}";
        }

        private void PrintOutDiscountAlert(string Message)
        {
            MessageBox.Show(Message);
        }

        private void CalculateSumTotal(decimal sumtotal)
        {
            MessageBox.Show($"the Total price of cart is : {sumtotal:C2}");
        }

        private decimal CalculateSumDiscountTotal(List<ProductModel> products , decimal sumtotal)
        {
            return sumtotal - products.Count();
        }
    }
}
