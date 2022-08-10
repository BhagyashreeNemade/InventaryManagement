using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    internal class InventoryFactory
    {
        public List<InventoryModel> Rice { get; set; }
        public List<InventoryModel> Wheat { get; set; }
        public List<InventoryModel> Pulses { get; set; }
    }
    public class InventoryModel
    {

        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
    }
}