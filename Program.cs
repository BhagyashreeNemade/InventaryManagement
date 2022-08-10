using InventoryManagement;

namespace Inventarymanagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            FetchInventoryDetails fetchInventoryDetails = new FetchInventoryDetails();


            string filepath = "C:\\Users\\admin1\\BridgeLab\\c sharp\\InventoryManagement\\InventoryManagement\\data.json";

            Rice data = fetchInventoryDetails.Read(filepath);
            Console.WriteLine("For Rice");
            Console.WriteLine("--------------------------");

            for (int i = 0; i < data.typesofRice.Count; i++)
            {

                Console.WriteLine(data.typesofRice[i].name);
                Console.WriteLine(data.typesofRice[i].price);
                Console.WriteLine(data.typesofRice[i].weight);
                Console.WriteLine("Price : " + data.typesofRice[i].price * data.typesofRice[i].weight);


                Console.WriteLine("--------------");
            }
        
             Console.WriteLine("For Pulses");
             Console.WriteLine("--------------------------"); ;
             for (int i = 0; i<data.typesofPulses.Count; i++)
             {
                Console.WriteLine("Name : " + data.typesofPulses[i].name);
                Console.WriteLine("Price per Kg : " + data.typesofPulses[i].price);
                Console.WriteLine("Weight : " + data.typesofPulses[i].weight);
                Console.WriteLine("Price : " + data.typesofPulses[i].price* data.typesofPulses[i].weight);
                Console.WriteLine("--------------------------");
             }
             Console.WriteLine("For Wheat");
            Console.WriteLine("--------------------------");
            for (int i = 0; i<data.typesofWheats.Count; i++)
            {
                Console.WriteLine("Name : " + data.typesofWheats[i].name);
                Console.WriteLine("Price per Kg : " + data.typesofWheats[i].price);
                Console.WriteLine("Weight : " + data.typesofWheats[i].weight);
                Console.WriteLine("Price : " + data.typesofWheats[i].price* data.typesofWheats[i].weight);
                 Console.WriteLine("--------------------------");
            }

        }
    }
}