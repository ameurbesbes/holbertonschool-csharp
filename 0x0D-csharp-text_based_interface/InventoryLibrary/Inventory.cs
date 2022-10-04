using System;

namespace InventoryLibrary
{
    /// <summary>
    /// class
    /// </summary>
    public class Inventory: BaseClass
    {
        private string _user_id;
        /// <summary>
        /// get/ set 
        /// </summary>
        public string user_id
        {
            get { return _user_id; }
            set
            {
                _user_id = value;
            }
        }

        private string _item_id;
        /// <summary>
        /// get/set
        /// get/set
        /// </summary>
        public string item_id
        {
            get { return _item_id; }
            set
            {
                _item_id = value;
            }
        }
        private int _quantity;
        public int quantity
        {
            get { return _quantity; }
            set
            {
                if (value < 0) value = 0;
                _quantity = value;
            }
        }
    }
}