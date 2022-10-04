using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
	/// <summary>
	/// class
	/// </summary>
	public class Item : BaseClass
	{
		private string _name;
		/// <summary>
		/// proprty
		/// </summary>
		public string name
		{
			get { return _name; }
			set
			{
				_name = value;
			}
		}
		/// <summary>
		/// proprty
		/// </summary>
		public string _descrption;
		/// <summary>
		/// proprty
		/// </summary>
		public string descrption
		{
			get { return _descrption; }
			set
			{
				_descrption = value;
			}
		}
		private float _price;
		/// <summary>
		///  proprty
		/// </summary>
		public float price
		{
			get { return _price; }
			set
			{
				_price = (float)Math.Round(value * 100) / 100f;
			}
		}
	}
}