namespace Kelllogg_Inventory
{
	internal interface IShippable
	{
		public decimal ShipCost { get; }
		public string Product { get; }	
	}
}
