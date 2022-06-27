using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Collections.Generic;


namespace C_Sharp_Exam
{
    class Program
    {
        static List<Product> productList = new List<Product>();
        static void Main(string[] args)
        {
            
            try
            {
                int choice = 0;
                do
                {
                    Console.WriteLine("==========Menu==========");
                    Console.WriteLine("1.Add Product");
                    Console.WriteLine("2.Display Product");
                    Console.WriteLine("3.Delete Product");
                    Console.WriteLine("4.End ");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            AddProduct();
                            break;
                        case 2:
                            DisplayProduct();
                            break;
                        case 3:
                            DeleteProduct();
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("Please check your selection!");
                            break;
                    }
                } while (choice != 4);
                Console.WriteLine("Thank you for using the services");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            

        }

        public static void AddProduct()
        {
            Console.WriteLine("Please add your Product ID:");
            string ID = Console.ReadLine();
            Console.WriteLine("Please add your Product Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Please add your Product Price:");
            Double Price = Double.Parse(Console.ReadLine());

            Product product = new Product(ID, Name, Price);
            productList.Add(product);
        }
        
        public static void DisplayProduct()
        {
            foreach (Product item in productList)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void DeleteProduct()
        {
            Console.WriteLine("Enter the ID you want to delete: ");
            string idDelete = Console.ReadLine();
            productList.RemoveAll(item => idDelete.Contains(item.GetId()));
            Console.WriteLine("Delete Success");
        }
    }
}

       