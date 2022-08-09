// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using InventeryManagment;

namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Wellcome to Object Oriented Programs");

            FetchInventoryDetails fetchInventoryDetails = new FetchInventoryDetails();


            string filepath = "D:\\repo179batch\\InventeryManagment\\InventeryManagment\\Data.json";

            Rice data = fetchInventoryDetails.Read(filepath);

            Console.WriteLine("Types of Rice");
            Console.WriteLine("--------------");

            for (int i = 0; i < data.typesofRice.Count; i++)
            {

                Console.WriteLine(data.typesofRice[i].name);
                Console.WriteLine(data.typesofRice[i].price);
                Console.WriteLine(data.typesofRice[i].weight);

                Console.WriteLine("--------------");
            }

            Console.WriteLine("Types of Pulses");
            Console.WriteLine("--------------");

            for (int i = 0; i < data.typesofPulses.Count; i++)
            {

                Console.WriteLine(data.typesofPulses[i].name);
                Console.WriteLine(data.typesofPulses[i].price);
                Console.WriteLine(data.typesofPulses[i].weight);

                Console.WriteLine("--------------");
            }

            Console.WriteLine("Types of Wheat");
            Console.WriteLine("--------------");

            for (int i = 0; i < data.typesofWheat.Count; i++)
            {

                Console.WriteLine(data.typesofWheat[i].name);
                Console.WriteLine(data.typesofWheat[i].price);
                Console.WriteLine(data.typesofWheat[i].weight);

                Console.WriteLine("--------------");
            }

        }
    }
}