using System.IO;
using Newtonsoft.Json;

namespace Warehouse
{
     public class WarehouseList
    {
        
        public Root getItemsFromJson()
        {
             string jsonString = File.ReadAllText("Warehouse\\warehouse.json");
             var warehouseList = JsonConvert.DeserializeObject<Root>(jsonString);
             return warehouseList;
        }
    }
}