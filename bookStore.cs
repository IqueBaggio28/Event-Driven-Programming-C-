using System.Diagnostics.Eventing.Reader;

namespace SamyBookStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal bookPrice, price, finalPrice;
        int quantity = 1, change = 0;
        string bookName;


        private void btnAdd_Click(object sender, EventArgs e)
        {
            getPrice();
            getQuantity();
            getName();



            if (bookPrice != 0 && bookName != null)
            {
                renderListView();
                displayPrices();

            }

        }

        private void nudTax_ValueChanged(object sender, EventArgs e)
        {
            displayPrices();
        }




        private void renderPrice()
        {
            txtSubtotal.Text = (bookPrice * quantity).ToString("c");
        }

        private void getPrice()
        {
            if (cbBooks.SelectedIndex == 0)
            {
                bookPrice = 199;
            }
            else if (cbBooks.SelectedIndex == 1)
            {
                bookPrice = 60;
            }
            else if (cbBooks.SelectedIndex == 2)
            {
                bookPrice = 150;
            }

        }

        private void getQuantity()
        {
            quantity = (int)nudQTY.Value;

        }

        private void getName()
        {
            bookName = cbBooks.Text.Split('(')[0].Trim();

        }

        private void renderListView()
        {

            if (string.IsNullOrEmpty(bookName)) return;


            bool bookExists = false;
            ListViewItem liv = new ListViewItem();

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text == bookName)
                {
                    int currentQTY = Convert.ToInt32(item.SubItems[1].Text);
                    int newTQY = currentQTY + (int)nudQTY.Value;

                    item.SubItems[1].Text = newTQY.ToString();
                    item.SubItems[2].Text = (newTQY * bookPrice).ToString("c");

                    bookExists = true;
                    break;
                }
            }

            if (!bookExists)
            {
                liv.Text = bookName;
                liv.SubItems.Add(nudQTY.Value.ToString());
                liv.SubItems.Add((bookPrice * quantity).ToString("c"));
                listView1.Items.Add(liv);
            }

        }

        private void displayPrices()
        {
            price = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                price += Convert.ToDecimal(item.SubItems[2].Text.Replace("$", ""));
            }

            txtSubtotal.Text = price.ToString("c");
            finalPrice = price + (price * (nudTax.Value / 100));
            txtTotal.Text = finalPrice.ToString("c");

            if (!String.IsNullOrEmpty(txtTendered.Text))
            {
                decimal tender;
                if (decimal.TryParse(txtTendered.Text.Replace("$", ""), out tender))
                {
                    decimal totalChange = tender - finalPrice;
                    txtChange.Text = totalChange.ToString("c");
                }
                else
                {
                    // Handle invalid input (show a message or clear the text box)
                    txtChange.Text = "$0.00";
                }
            }
        }


        private void txtTendered_TextChanged(object sender, EventArgs e)
        {
            displayPrices();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Nothing to erase");
            }

            else if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                listView1.Items[listView1.Items.Count - 1].Remove();

            }
            displayPrices();
        }

        private void brnReset_Click(object sender, EventArgs e)
        {
            cbBooks.Text = "";
            price = 0;
            nudQTY.Value = 1;
            listView1.Items.Clear();  // Clears only the items, not the columns
            nudTax.Value = 6.25m;
            bookPrice = 0;
            bookName = "";
            txtTendered.Text = "$0.00";
            finalPrice = 0;
            displayPrices();
        }

    }
}
