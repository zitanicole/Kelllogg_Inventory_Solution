using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelllogg_Inventory
{
	internal class LawnMower : IShippable
	{
		public decimal ShipCost { get; } = 24.0M;
		public string Product { get; } = "Lawn Mower";
	}
}
