﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelllogg_Inventory
{
	internal class BaseballGlove : IShippable
	{
		public decimal ShipCost { get; } = 3.23M;
		public string Product { get; } = "Baseball Glove";
	}
}
