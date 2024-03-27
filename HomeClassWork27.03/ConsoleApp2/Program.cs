

using ConsoleApp2.Models;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Layihe
            //string[] words = { "Samuray", "Garib", "Rauf", "Shahin" };
            //int choice;
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("1.Siyahiya bax\n2.Siyahiya add elave et\n3.Siyahida adi yoxla\n4.Daxil edilmis indexdeki adi goster\n0.Menudan cix");
            //    choice = int.Parse(Console.ReadLine());
            //    switch (choice)
            //    {
            //        case 1:
            //            Console.Clear();
            //            ShowAllNames(words);
            //            Console.ReadKey();

            //            break;
            //        case 2:
            //            Console.Clear();
            //           AddName(ref words);
            //            break;
            //        case 3:
            //            Console.Clear();
            //            Console.WriteLine("Please enter searched name:");
            //            string search=Console.ReadLine();
            //            Console.Clear();
            //            if (SearchValue(words,search))
            //            {
            //                Console.WriteLine($"{search} is exist");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{search} is not exist");
            //            }

            //            Console.WriteLine("\n\n\n\n\n\npress \"f\" pay respect" );
            //            Console.ReadKey();
            //            break;
            //        case 4:
            //            Console.Clear();
            //            Console.WriteLine("Please enter index of name:");
            //            int index= int.Parse(Console.ReadLine());
            //            if (index<words.Length)
            //            {
            //                Console.WriteLine(words[index]);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Wrong input");
            //            }
            //            Console.ReadKey();
            //            break;
            //        default:
            //            break;
            //    }

            //} while (choice != 0); 
            #endregion



            Product product=new Product("Cola",2.0m,1.5m,30);
            Product product2=new Product("Fanta",2.2m,1.3m,50);

            product.Sell();
            product.FillStock(5);

            product2.Sell();
            product2.FillStock(5);
            

            Console.WriteLine(product.Stock);
            Console.WriteLine(product.Income);

            Console.WriteLine(product2.Stock);
            Console.WriteLine(product2.Income);
            //Console.WriteLine(product.Stock);

            //product.FillStock(5);


            //Console.WriteLine(product.Stock);

        }
        #region Layihe Methodlari
        static void ShowAllNames(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i}.{arr[i]}");
            }
        }
        static void AddName(ref string[] arr)
        {
            Console.WriteLine("Plase enter name:");
            string name = Console.ReadLine();
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = name;
        }
        static bool SearchValue(string[] arr, string search)
        {
            foreach (string name in arr)
            {
                if (name == search)
                {
                    return true;
                }
            }
            return false;
        } 
        #endregion
    }



}