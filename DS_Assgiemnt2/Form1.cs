using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_Assgiemnt2
{
    public partial class Form1 : Form
    {
        // Declaring a LinkedList to hold products; it will be accessible throughout the form's instance.
        LinkedList<Product> products = new LinkedList<Product>();

        // Constructor for the Form1 class
        public Form1()
        {
            InitializeComponent();// Initializing form components
        }

        // Event handler for the 'Insert' button click
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new product object from user input
                Product newProduct = new Product
                {
                    ProductCode = txtProductCode.Text,
                    Name = txtProductName.Text,
                    Price = double.Parse(txtProductPrice.Text)
                };

                // If the products list is empty, add the new product as the first element
                if (!products.Any())
                {
                    products.AddFirst(newProduct);
                }
                else
                {
                    LinkedListNode<Product> currentNode = products.First;

                    // Find the position to insert the new product to keep the list ordered by price
                    while (currentNode != null && currentNode.Value.Price < newProduct.Price)
                    {
                        currentNode = currentNode.Next;
                    }

                    // If reached the end of the list, add the product to the end
                    if (currentNode == null)
                    {
                        products.AddLast(newProduct);
                    }
                    else // Else, insert the product before the current node
                    {
                        products.AddBefore(currentNode, newProduct);
                    }
                }

                // Notify the user that the product has been added
                MessageBox.Show("Product added successfully!");
            }
            catch (Exception ex)
            {
                // Display any exceptions that occur to the user
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Event handler for the 'Remove' button click
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Find the product to remove based on the name
                Product productToRemove = products.FirstOrDefault(p => p.Name == txtProductName.Text);
                if (productToRemove != null)
                {
                    products.Remove(productToRemove);
                    MessageBox.Show("Product removed successfully!");
                }
                else
                {
                    MessageBox.Show("Product not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Event handler for the 'Display' button click
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                // Display the list of products in the DataGridView
                dataGridView1.DataSource = products.Select(p => new { p.ProductCode, p.Name, p.Price }).ToList();

                // Display the total number of products
                txtNoProducts.Text = products.Count.ToString();

                // Display the average price of the products
                txtAvgProductPrice.Text = products.Average(p => p.Price).ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Event handler for the 'Exit' button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
