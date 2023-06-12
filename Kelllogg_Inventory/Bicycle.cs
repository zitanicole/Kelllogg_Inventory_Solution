using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelllogg_Inventory
{
	internal class Bicycle : IShippable	
	{
		public decimal ShipCost { get; } = 9.5M; 
		public string Product { get; } = "Bicycle";
	}
}
