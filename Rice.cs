using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Rice
    {
        public List<TypesofRice> typesofRice;
        public List<TypesofRice> typesofPulses;
        public List<TypesofRice> typesofWheats;
    }

    public class TypesofRice
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypesofPulses
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypesofWheats
    {
        public string name;
        public int weight;
        public int price;
    }
}