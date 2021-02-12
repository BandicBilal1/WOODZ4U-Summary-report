using System.Collections.Generic;

namespace Warehouse
{
    //Representation of Item object with properties from JSON file
    public class Item
    {
       public string Name {get; set;}
       public string Material {get; set;}
       public string Quantity {get; set;}
       public string Price {get; set;}
    }

    public class Root
    {
        public List<Item> item;

        public Root ()
        {
            item = new List<Item>();
        }

    }


}