using System.Globalization;

namespace Lab02
{
    public partial class Form1 : Form
    {
        private int price;
        private string payment;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            price = 250;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            price = 75;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            price = 180;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            payment = "VISA";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            payment = "MasterCard";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = "Total Price: " + (price * Convert.ToInt32(txtQty.Text)).ToString("C", CultureInfo.CreateSpecificCulture("en-US")) + "\nPayment: " + payment;
            }catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid quantity");
            }
        }
    }
}
