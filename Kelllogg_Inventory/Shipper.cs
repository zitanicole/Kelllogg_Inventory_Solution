namespace Kelllogg_Inventory
{
	internal class Shipper
	{
		IShippable[] _cart = new IShippable[10];
		int counter = -1;
		int crackers = 0;
		int gloves = 0;
		int mowers = 0;
		int bikes = 0;

		public string FullCart()
		{
			return "Cart is full. Please continue to checkout.";
		}

		public void Add(IShippable ship) 
		{
			if (counter < 9)
			{
				 counter++;
				_cart[counter] = ship;

				if (ship.Product == "Crackers")
					crackers++;
				if (ship.Product == "Baseball Glove")
					gloves++;
				if (ship.Product == "Lawn Mower")
					mowers++;
				if (ship.Product == "Bicycle")
					bikes++;
			}
			if (counter == 9) 
			{
				FullCart();
			}			
		}

		public string ListShipmentItems()
		{
			string list = string.Empty;
			if (crackers > 0)
				list += crackers + " Crackers\n";

			if (gloves == 1)
				list += gloves + " Baseball Glove\n";
			if (gloves > 1)
				list += gloves + " Baseball Gloves\n";

			if (mowers == 1)
				list += mowers + " Lawn Mower\n";
			if (mowers > 1)
				list += mowers + " Lawn Mowers\n";

			if (bikes == 1)
				list += bikes + " Bicycle\n";
			if (bikes > 1)
				list += bikes + " Bicycles\n";

			return list;
		}

		public decimal ComputeShippingCharges()
		{
			decimal totalCost = 0;
			for (int i = 0; i <= counter; i++)
			{
				totalCost += _cart[i].ShipCost;
			}

			return totalCost;
		}

		public int count
		{ get { return counter; } }
	}
}
