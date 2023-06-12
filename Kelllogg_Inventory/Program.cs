// Nicci Kellogg
// IT112 
// NOTES: I had a good time doing this project because it was challenging to get more comfortable with getters and setters! It is really nice being able to use them to broaden the scope of variables!
// BEHAVIORS NOT IMPLEMENTED AND WHY: I believe that I implemented all of the required behaviors and I am hoping for a 100% grade on the assignment! =D Have a good summer, Dan!

namespace Kelllogg_Inventory
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Shipper cart = new Shipper();
			string input;
			decimal total = 0;
			Console.WriteLine("\nWelcome to Store!\n");

			do
			{ 
			Console.WriteLine("\nPlease enter a number to make a choice from this list:\n");
			Console.WriteLine("1.Add a Bicycle to the shipment \n2.Add a Lawn Mower to the Shipment \n3.Add a Baseball Glove to the shipment \n4.Add Crackers to the shipment \n5.List Shipment Items \n6.Compute Shipping Charges\n0.Exit Store");
			input = Console.ReadLine();

			if (input == "1")
			{
				cart.Add(new Bicycle());
				Console.WriteLine("\n1 Bicycle has been added to your cart.\n");
			}

			if (input == "2")
			{
				cart.Add(new LawnMower());
				Console.WriteLine("\n1 Lawn Mower has been added to your cart.\n");
			}

			if (input == "3")
			{
				cart.Add(new BaseballGlove());
				Console.WriteLine("\n1 Baseball Glove has been added to your cart.\n");
			}

			if (input == "4")
			{
				cart.Add(new Crackers());
				Console.WriteLine("\n1 Crackers has been added to your cart.\n");
			}

				if (input == "5")
					Console.WriteLine("\nYour cart:\n" + cart.ListShipmentItems());

				if (input == "6")
				{
					total = cart.ComputeShippingCharges();
					Console.WriteLine("\nOrder Total: " + total.ToString("C") + "\nPress any key to exit store.");
					Console.ReadKey();
					Environment.Exit(0);
				}

				if (input == "0")
					Environment.Exit(0);

			} while (cart.count < 9);

			do
			{
				Console.WriteLine("\nYour cart is now full.");
				Console.WriteLine("\nPlease enter a number to make a choice from this list:");
				Console.WriteLine("5.List Shipment Items \n6.Compute Shipping Charges\n0.Exit Store");
				input = Console.ReadLine();	

				if (input == "5")
					Console.WriteLine("\nYour cart:\n" + cart.ListShipmentItems());

				if (input == "6")
				{
					total = cart.ComputeShippingCharges();
					Console.WriteLine("\nOrder Total: " + total.ToString("C") + "\nPress any key to exit store.");
					Console.ReadKey();
					Environment.Exit(0);
				}
				
				if (input == "0")
					Environment.Exit(0);
				
			} while (cart.count == 9 && input != "6");	
		}
	}
}