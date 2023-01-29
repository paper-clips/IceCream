using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceCream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Add to ComboBox for Cone
            comBox_Cone.Items.Add("Regular");
            comBox_Cone.Items.Add("Sugar");
            comBox_Cone.Items.Add("Waffle");

            // Add to ComboBox for Icecream
            comBox_Icecream.Items.Add("Vanilla");
            comBox_Icecream.Items.Add("Chocolate");

            // Add to ComboBox for Toppings
            comBox_Topping.Items.Add("Chocolate");
            comBox_Topping.Items.Add("Caramel");

            // Add to CheckedListBox for Sprinkles
            checkListBox_Sprinkles.Items.Add("Chocolate Chip");
            checkListBox_Sprinkles.Items.Add("Colored Sprinkles");
            checkListBox_Sprinkles.Items.Add("Marshmallows");
        }


        // Keep track of each order
        int count = 1;

        /* Starting inventory */
        // Cones
        int regularCones = 50;
        int sugarCones = 25;
        int waffleCones = 10;

        // Icecream
        double vanillaIC = 50;
        double chocolateIC = 20;

        // Toppings
        double chocolateToppings = 5;
        double caramelToppings = 2;

        // Sprinkles
        double chocolateSprinkles = 1;
        double coloredSprinkles = 1;
        double marshmallows = 1;
        

        // Method for updating cones in inventory
        int Cones(string coneType)
        {
            int numLeft = 0;

            // Update number of regular cones
            if (coneType == "regular")
            {
                numLeft = regularCones - 1;
                if (numLeft < 0)        // No more regular cones
                {
                    lstbox_Confirmation.Items.Add("No more regular cones.");
                    return -1;
                }
                return numLeft;
            }
            // Update number of sugar cones
            else if (coneType == "sugar")
            {
                numLeft = sugarCones - 1;
                if (numLeft < 0)        // No more sugar cones
                {
                    lstbox_Confirmation.Items.Add("No more sugar cones.");
                    return -1;
                }
                return numLeft;
            }
            // Update number of waffle cones
            else
            {
                numLeft = waffleCones - 1;
                if (numLeft < 0)        // No more waffle cones
                {
                    lstbox_Confirmation.Items.Add("No more waffle cones.");
                    return -1;
                }
                return numLeft;
            }
        }

        // Method for updating icecream in inventory
        double Icecream(string icType)
        {
            double numLeft = 0;

            // Update vanilla icecream left
            if (icType == "vanilla")
            {
                numLeft = vanillaIC - (8 / 128.0);   // Convert to gallons
                if (numLeft < 0)        // No more vanilla icecream left
                {
                    lstbox_Confirmation.Items.Add("No more vanilla icecream.");
                    return -1;
                }
                return numLeft;
            }
            // Update chocolate icecream left
            else
            {
                numLeft = chocolateIC - (8 / 128.0);     // Convert to gallons
                if (numLeft < 0)        // No more chocolate icecream left
                {
                    lstbox_Confirmation.Items.Add("No more chocolate icecream.");
                    return -1;
                }
                return numLeft;
            }
        }

        // Method for updating toppings in inventory
        double Toppings(string toppingsType)
        {
            double numLeft = 0;

            // Update chocolate toppings left
            if (toppingsType == "chocolate")
            {
                numLeft = chocolateToppings - (4 / 128.0);     // Convert to gallons
                if (numLeft < 0)        // No more chocolate toppings left
                {
                    lstbox_Confirmation.Items.Add("No more chocolate toppings.");
                    return -1;
                }
                return numLeft;
            }
            // Update caramel toppings left
            else
            {
                numLeft = caramelToppings - (4 / 128.0);     // Convert to gallons
                if (numLeft < 0)        // No more caramel toppings left
                {
                    lstbox_Confirmation.Items.Add("No more caramel toppings.");
                    return -1;
                }
                return numLeft;
            }
        }

        // Method for updating sprinkles in inventory
        double Sprinkles(string sprinklesType)
        {
            double numLeft = 0;

            // Update chocolate chip sprinkles left
            if (sprinklesType == "chocolate")
            {
                numLeft = chocolateSprinkles - (2 / 16.0);     // Convert to pounds
                if (numLeft < 0)        // No more chocolate chip sprinkles left
                {
                    lstbox_Confirmation.Items.Add("No more chocolate chip sprinkles.");
                    return -1;
                }
                return numLeft;
            }
            // Update colored sprinkles left
            else if (sprinklesType == "colored")
            {
                numLeft = coloredSprinkles - (2 / 16.0);     // Convert to pounds
                if (numLeft < 0)        // No more colored sprinkles left
                {
                    lstbox_Confirmation.Items.Add("No more colored sprinkles.");
                    return -1;
                }
                return numLeft;
            }
            // Update marshmallows left
            else
            {
                numLeft = marshmallows - (2 / 16.0);     // Convert to pounds
                if (numLeft < 0)        // No more marshmallows left
                {
                    lstbox_Confirmation.Items.Add("No more marshmallows.");
                    return -1;
                }
                return numLeft;
            }
        }
        
        // When the user clicks the "Add to Order" button, prints out order selections
        private void btn_AddToOrder_Click(object sender, EventArgs e)
        {
            lstbox_Confirmation.Items.Clear();

            // Order selection starts
            string orderNumber = "---Ice Cream Selection " + count + "---";
            lstbox_Order.Items.Add(orderNumber);
            count++;

            // Cone type
            if (comBox_Cone.SelectedItem.ToString() == "Regular")
                lstbox_Order.Items.Add("#00# - Regular Cone");
            else if (comBox_Cone.SelectedItem.ToString() == "Sugar")
                lstbox_Order.Items.Add("#01# - Sugar Cone");
            else 
                lstbox_Order.Items.Add("#02# - Waffle Cone");

            // Icecream type
            if (comBox_Icecream.SelectedItem.ToString() == "Vanilla")
                lstbox_Order.Items.Add("#10# - Vanilla Icecream");
            else if (comBox_Icecream.SelectedItem.ToString() == "Chocolate")
                lstbox_Order.Items.Add("#11# - Chocolate Icecream");

            // Toppings
            if (comBox_Topping.SelectedItem.ToString() == "Chocolate")
                lstbox_Order.Items.Add("#20# - Chocolate Toppings");
            else if (comBox_Topping.SelectedItem.ToString() == "Caramel")
                lstbox_Order.Items.Add("#21# - Caramel Toppings");

            //Sprinkles
            if (checkListBox_Sprinkles.CheckedItems.Contains("Chocolate Chip"))
                lstbox_Order.Items.Add("#30# - Chocolate Chip Sprinkles");
            if (checkListBox_Sprinkles.CheckedItems.Contains("Colored Sprinkles"))
                lstbox_Order.Items.Add("#31# - Colored Sprinkles");
            if (checkListBox_Sprinkles.CheckedItems.Contains("Marshmallows"))
                lstbox_Order.Items.Add("#32# - Marshmallows");

            // Order selection ends
            lstbox_Order.Items.Add("+++++++++++++++++++++++++");
        }
        
        // When the user clicks the "Confirm Order" button, prints out inventory and whether order was confirmed or not
        private void btn_ConfirmOrder_Click(object sender, EventArgs e)
        {
            bool isEmpty = false;           // Used to check if any of the ingredients are empty for each order
            string temp = null;
            int counter = 1;

            // If user does not make a selection
            if (lstbox_Order.Items.Count == 0)
            {
                lstbox_Confirmation.Items.Add("Please select \"Add to Order\" first before confirming order.");
            }
            else 
            { 
                lstbox_Order.Items.Add("Order Placed!");
                lstbox_Confirmation.Items.Clear();

                // Iterate throughout each line in the listbox with the orders
                foreach (object item in lstbox_Order.Items)
                {
                    // New order
                    if (item.ToString().ElementAt(0) == '-')
                        isEmpty = false;

                    // Cones
                    if (item.ToString().ElementAt(1) == '0' && isEmpty == false)
                    {
                        // Regular cones
                        if (item.ToString().ElementAt(2) == '0')
                        {
                            regularCones = Cones("regular");        // Call method to update inventory
                            if (regularCones == -1)     // No more regular cones
                            {
                                isEmpty = true;
                                regularCones = 0;
                            }
                        }
                        // Sugar cones
                        else if (item.ToString().ElementAt(2) == '1')
                        {
                            sugarCones = Cones("sugar");        // Call method to update inventory
                            if (sugarCones == -1)       // No more sugar cones
                            {
                                isEmpty = true;
                                sugarCones = 0;
                            }
                        }
                        // Waffle cones
                        else
                        {
                            waffleCones = Cones("waffle");        // Call method to update inventory
                            if (waffleCones == -1)      // No more waffle cones
                            {
                                isEmpty = true;
                                waffleCones = 0;
                            }
                        }
                    }

                    // Icecream
                    if (item.ToString().ElementAt(1) == '1' && isEmpty == false)
                    {
                        // Vanilla icecream
                        if (item.ToString().ElementAt(2) == '0')
                        {
                            vanillaIC = Icecream("vanilla");        // Call method to update inventory
                            if (vanillaIC == -1)        // No more vanilla icecream
                            {
                                isEmpty = true;
                                vanillaIC = 0;
                            }
                        }
                        // Chocolate icecream
                        else
                        {
                            chocolateIC = Icecream("chocolate");        // Call method to update inventory
                            if (chocolateIC == -1)      // No more chocolate icecream
                            {
                                isEmpty = true;
                                chocolateIC = 0;
                            }
                        }
                    }

                    // Toppings
                    if (item.ToString().ElementAt(1) == '2' && isEmpty == false)
                    {
                        // Chocolate toppings
                        if (item.ToString().ElementAt(2) == '0')
                        {
                            chocolateToppings = Toppings("chocolate");        // Call method to update inventory
                            if (chocolateToppings == -1)        // No more chocolate toppings
                            {
                                isEmpty = true;
                                chocolateToppings = 0;
                            }
                        }
                        // Caramel toppings
                        else
                        {
                            caramelToppings = Toppings("caramel");        // Call method to update inventory
                            if (caramelToppings == -1)      // No more caramel toppings
                            {
                                isEmpty = true;
                                caramelToppings = 0;
                            }
                        }
                    }

                    // Sprinkles
                    if (item.ToString().ElementAt(1) == '3' && isEmpty == false)
                    {
                        // Chocolate chip sprinkles
                        if (item.ToString().ElementAt(2) == '0')
                        {
                            chocolateSprinkles = Sprinkles("chocolate");        // Call method to update inventory
                            if (chocolateSprinkles == -1)       // No more chocolate chip sprinkles
                            {
                                isEmpty = true;
                                chocolateSprinkles = 0;
                            }
                        }
                        // Colored sprinkles
                        else if (item.ToString().ElementAt(2) == '1')
                        {
                            coloredSprinkles = Sprinkles("colored");        // Call method to update inventory
                            if (coloredSprinkles == -1)     // No more colored sprinkles
                            {
                                isEmpty = true;
                                coloredSprinkles = 0;
                            }
                        }
                        // Marshmallows
                        else
                        {
                            marshmallows = Sprinkles("marshmallows");        // Call method to update inventory
                            if (marshmallows == -1)     // No more marshmallows
                            {
                                isEmpty = true;
                                marshmallows = 0;
                            }
                        }
                    }

                    // Order not completed
                    if (item.ToString().ElementAt(0) == '+' && isEmpty == true)
                    {
                        temp = "Ice Cream Selection " + counter + " could not be completed";
                        lstbox_Confirmation.Items.Add(temp);
                        lstbox_Confirmation.Items.Add("+++++++++++++++++++++++++");
                        counter++;
                    }

                    // Order completed, print ingredients left
                    if (item.ToString().ElementAt(0) == '+' && isEmpty == false)
                    {
                        temp = "---Ice Cream Selection " + counter + " completed--";
                        lstbox_Confirmation.Items.Add(temp);
                        lstbox_Confirmation.Items.Add("Inventory left:");
                        temp = "Regular cones: " + regularCones + " | Sugar cones: " + sugarCones + " | Waffle cones: " + waffleCones;
                        lstbox_Confirmation.Items.Add(temp);
                        temp = "Vanilla icecream: " + string.Format("{0:0.00}", vanillaIC) + "gal | Chocolate icecream: " + string.Format("{0:0.00}", chocolateIC) + "gal";
                        lstbox_Confirmation.Items.Add(temp);
                        temp = "Chocolate toppings: " + string.Format("{0:0.00}", chocolateToppings) + "gal | Caramel toppings: " + string.Format("{0:0.00}", caramelToppings) + "gal";
                        lstbox_Confirmation.Items.Add(temp);
                        temp = "Chocolate chip: " + string.Format("{0:0.00}", chocolateSprinkles) + "lbs | Colored sprinkles: " + string.Format("{0:0.00}", coloredSprinkles) + "lbs | Marshmallows: " + string.Format("{0:0.00}", marshmallows) + "lbs";
                        lstbox_Confirmation.Items.Add(temp);
                        lstbox_Confirmation.Items.Add("+++++++++++++++++++++++++");
                        counter++;
                    }
                }
            }
        }

        // When the user clicks the "Clear Order" button, resets every output and inventory
        private void btn_ClearOrder_Click(object sender, EventArgs e)
        {
            lstbox_Order.Items.Clear();
            lstbox_Confirmation.Items.Clear();

            count = 1;

            /* Starting inventory */
            // Cones
            regularCones = 50;
            sugarCones = 25;
            waffleCones = 10;

            // Icecream
            vanillaIC = 50;
            chocolateIC = 20;

            // Toppings
            chocolateToppings = 5;
            caramelToppings = 2;

            // Sprinkles
            chocolateSprinkles = 1;
            coloredSprinkles = 1;
            marshmallows = 1;
        }
    }
}
