using System;
using System.IO;
namespace MilkFarmLogic

 
{
    public class Cheese
    {
        public string Chs_Brand;
        public string Chs_Name;
        public int Chs_Fat;

        public Cheese(string chs_brand, string chs_name, int chs_fat)
        {
                    
            Chs_Brand = chs_brand;
            Chs_Name = chs_name;
            Chs_Fat = chs_fat;
            
        }
    }

    public class MilkFarm
    {
        private Cheese[] cheeses;

        public MilkFarm(int size)
        {
            cheeses = new Cheese[size];
        }

        public void AddCheese(int index, Cheese cheese)
        {
            cheeses[index] = cheese;
        }

        public void SortCheeses()
        {
            Array.Sort(cheeses, (a, b) =>
            {
                int compare = string.Compare(a.Chs_Brand, b.Chs_Brand);
                if (compare != 0)
                {
                    return compare;
                }
                return a.Chs_Fat.CompareTo(b.Chs_Fat);
            });
        }

        public void SaveToFile(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (Cheese cheese in cheeses)
                {
                    writer.WriteLine("{0};{1};{2}", cheese.Chs_Brand, cheese.Chs_Name, cheese.Chs_Fat);
                }
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number of cheeses:");
            int size = int.Parse(Console.ReadLine());

            MilkFarm milkFarm = new MilkFarm(size);

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the details for cheese {0}:", i + 1);
                Console.Write("Brand: ");
                string chs_brand = Console.ReadLine();
                Console.Write("Name: ");
                string chs_name = Console.ReadLine();
                Console.Write("Fat: ");
                int chs_fat = int.Parse(Console.ReadLine());

                Cheese cheese = new Cheese(chs_brand, chs_name, chs_fat);
                milkFarm.AddCheese(i, cheese);
            }

            milkFarm.SortCheeses();
            milkFarm.SaveToFile("cheeses.txt");
        }
    }
}
