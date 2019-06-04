using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Factory();
           
            
        }

        private static int Choice(int min , int max, string message)
        {
            int choice = 0;
            do
            {
                Console.WriteLine(message);
            } while (!int.TryParse(Console.ReadLine(), out choice) || choice < min || choice > max);

            return choice;
        }

        private static void Menu()
        {
            
                Console.WriteLine("----- MENU -----");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Exit");
                

           
        }
        
        private static void Factory()
        {
            const string newFolder = "FactoryMarekSobczynski.csv";
            
            string path = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop), newFolder);
            const bool menu = false;
            do
            {
                Console.Clear();
                Menu();
                int choice = Choice(1,4,"Choose an option");
                if (choice == 4)
                {
                    Console.WriteLine("----- EXIT -----");
                    break;
                }
                int a = Choice(int.MinValue, int.MaxValue,"Number A:");
                int b = Choice(int.MinValue, int.MaxValue, "Number B:");
                OperationFactory factory = OperationFactory.Factory(choice);
                AbstractMathematicalOperation abstractMathematicalOperation = factory.CreateProceed();
                abstractMathematicalOperation.Proceed(a,b,path); 
            } while (menu == false);

        }
    }
}