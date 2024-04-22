using FileStreamSerialize.Models;
using Newtonsoft.Json;

namespace FileStreamSerialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region File Directory Stream
        //Directory.CreateDirectory(@"C:\Users\sabir\Desktop\Test");
        //if (Directory.Exists(@"C:\Users\sabir\Desktop\Test"))
        //{
        //    Directory.Delete(@"C:\Users\sabir\Desktop\Test", true);
        //}
        //File.Create(@"C:\Users\sabir\Desktop\Test\text.txt").Close();
        //File.Delete(@"C:\Users\sabir\Desktop\Test\text.txt");

        //if (!File.Exists(@"C:\Users\sabir\Desktop\Test\text.txt"))
        //{

        //}

        //FileInfo file = new FileInfo(@"C:\Users\sabir\Desktop\Test\text.txt");
        //file.Create();
        //file.Delete();
        //Console.WriteLine(file.Exists);

        //DirectoryInfo directory = new DirectoryInfo(@"C:\Users\sabir\Desktop\Test");

        //StreamReader sr= new StreamReader(@"C:\Users\sabir\Desktop\Test\text.txt");
        //try
        //{
        //    int result=int.Parse(sr.ReadLine());
        //}
        //catch (Exception e)
        //{

        //    Console.WriteLine(e.Message);
        //}
        //finally
        //{
        //    sr.Close();
        //}




        //StreamWriter sw = new StreamWriter(@"C:\Users\sabir\Desktop\Test\text.txt", true);
        //sw.WriteLine("Rauf");
        //sw.WriteLine("PSY");
        //sw.Close();




        //using(StreamReader sr=new StreamReader(@"C:\Users\sabir\Desktop\Test\text.txt"))
        //{
        //    Console.WriteLine(sr.ReadLine());
        //}

        //using(StreamWriter sw=new StreamWriter(@"C:\Users\sabir\Desktop\Test\text.txt"))
        //{

        //    sw.WriteLine("Salam");
        //} 
        #endregion


        //Category category = new Category { Name="Mobile"};

        //Product product = new Product { Id = 1,Name="Iphone 15",Price=2000m,Category=category };
        //Product product2 = new Product { Id = 2,Name="Samsung s23",Price=2400m,Category=category };
        //Product product3 = new Product { Id = 3,Name="Xiaomi POCO 5x",Price=1000m,Category=category };

        //List<Product> products = new List<Product> { product,product2, product3 };

        //string json=JsonConvert.SerializeObject(products);

        //using(StreamWriter sw = new StreamWriter(@"C:\Users\sabir\OneDrive\Рабочий стол\FileStreamSerialize\FileStreamSerialize\Files\Products.json"))
        //{
        //    sw.Write(json);
        //}

            Console.WriteLine(Directory.GetCurrentDirectory());
            string result;
            using(StreamReader sr=new StreamReader(@"C:\Users\sabir\OneDrive\Рабочий стол\FileStreamSerialize\FileStreamSerialize\Files\Products.json"))
            {
               result= sr.ReadToEnd();
            }

            List<Product> objects=JsonConvert.DeserializeObject<List<Product>>(result);

            //foreach (Product product in objects)
            //{
            //    product.Price += 100;
            //    Console.WriteLine(product.Price);
            //}

        }
    }
}
