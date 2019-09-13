using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string customerName, contactNo, address;
            int quantity;
            float pricePerOrder, totalPrice;

            customerName = nameTB.Text;
            contactNo = contactTB.Text;
            address = addressTB.Text;
            quantity = Convert.ToInt32(quantityTB.Text);
            pricePerOrder = Convert.ToInt32(priceTB.Text);

            if(orderComboBox.Text == null)
            {
                MessageBox.Show("Selct item: ");
            }
            else if(orderComboBox.Text == "Black Coffee")
            {
                totalPrice = quantity * pricePerOrder;
                showRichTextBox.Text = "Customer Name: " + customerName + "\n" + "Contact No.: " + contactNo + "\n" + 
                    "Address: " + address + "\n" + "Odered item: " + orderComboBox.Text + "\n" + "Quantity: " + quantity + 
                    "\n" + "Price Per " + orderComboBox.Text + ": " + pricePerOrder + "\n" + "Total Price: " + totalPrice;
            }
            else if (orderComboBox.Text == "Cold Coffee")
            {
                totalPrice = quantity * pricePerOrder;
                showRichTextBox.Text = "Customer Name: " + customerName + "\n" + "Contact No.: " + contactNo + "\n" +
                    "Address: " + address + "\n" + "Odered item: " + orderComboBox.Text + "\n" + "Quantity: " + quantity +
                    "\n" + "Total Price: " + totalPrice;
            }
            else if (orderComboBox.Text == "Hot Coffee")
            {
                totalPrice = quantity * pricePerOrder;
                showRichTextBox.Text = "Customer Name: " + customerName + "\n" + "Contact No.: " + contactNo + "\n" +
                    "Address: " + address + "\n" + "Odered item: " + orderComboBox.Text + "\n" + "Quantity: " + quantity +
                     "\n" + "Total Price: " + totalPrice;
            }
            else if (orderComboBox.Text == "Regular Coffee")
            {
                totalPrice = quantity * pricePerOrder;
                showRichTextBox.Text = "Customer Name: " + customerName + "\n" + "Contact No.: " + contactNo + "\n" +
                    "Address: " + address + "\n" + "Odered item: " + orderComboBox.Text + "\n" + "Quantity: " + quantity +
                      "\n" + "Total Price: " + totalPrice;
            }
        }
    }
}
