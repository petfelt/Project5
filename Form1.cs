using System;
using System.Windows.Forms;

namespace Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTotalPrice_Click(object sender, EventArgs e)
        {
            // Introduce decimal variables for manipulation.
            const decimal ICE_CREAM_FLAVOR_CHOCOLATE = 4.00M;
            const decimal ICE_CREAM_FLAVOR_VANILLA = 4.00M;
            const decimal ICE_CREAM_FLAVOR_STRAWBERRY = 4.00M;

            const decimal TOPPING_SPRINKLES = 0.50M;
            const decimal TOPPING_CHOPPED_NUTS = 1.75M;
            const decimal TOPPING_CHERRY = 1.00M;

            decimal totalPrice = 0;

            // radioButton & checkBox variable attachment & check.
            if (radioButtonChocolate.Checked == true)
            {
                totalPrice = ICE_CREAM_FLAVOR_CHOCOLATE;
            }
            else if(radioButtonVanilla.Checked ==  true)
            {
                totalPrice = ICE_CREAM_FLAVOR_VANILLA;
            }
            else
            {
                totalPrice = ICE_CREAM_FLAVOR_STRAWBERRY;
            }

            if (checkBoxSprinkles.Checked == true)
            {
                totalPrice += TOPPING_SPRINKLES;
            }

            if (checkBoxChoppedNuts.Checked == true)
            {
                totalPrice += TOPPING_CHOPPED_NUTS;
            }

            if (checkBoxCherry.Checked == true)
            {
                totalPrice += TOPPING_CHERRY;
            }

            // Setting label price.
            labelTotalPrice.Text = "$" + totalPrice.ToString();
        }

        private void groupBoxFlavor_Enter(object sender, EventArgs e)
        {

        }
    }
}
