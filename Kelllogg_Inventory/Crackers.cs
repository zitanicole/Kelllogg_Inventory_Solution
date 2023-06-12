using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelllogg_Inventory
{
	internal class Crackers : IShippable
	{/*
		private decimal _price = 0.57M;
		private string _product = "Crackers";
		decimal IShippable.ShipCost
		{
			get { return _price; }
			set { _price = value; }
		}
		string IShippable.Product
		{
			get { return _product; }
			set { _product = value; }	
		}*/

		public decimal ShipCost { get; } = 0.57M;
		public string Product { get; } = "Crackers";
	}
}
