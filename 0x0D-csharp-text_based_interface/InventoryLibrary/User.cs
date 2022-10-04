using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
	/// <summary>
	/// class 
	/// </summary>
	public class User : BaseClass
	{
		private string _name;
		/// <summary>
		/// proprtie 
		/// </summary>
		public string name
		{
			get { return _name; }
			set
			{
				_name = value;
			}
		}
	}
}