using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Cheese
    {
        public string Chs_Brand;
        public string Chs_Name;
        public int Chs_Fat;
    


        // Создаем параметрический конструктор
        public Cheese (string chs_brand, string chs_name, int chs_fat)
        {
            Chs_Brand = chs_brand;
            Chs_Name = chs_name;
            Chs_Fat = chs_fat;
        }

        public void reWrite()
        {
            Console.WriteLine("Производитель {0}\nИмя: {1}\nПроцент жира: {2}", Chs_Brand, Chs_Name, Chs_Fat);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cheese ex = new Cheese ("RosMoloko","Almette", 40);
            ex.reWrite();

            Console.ReadLine();
        }
    }
}