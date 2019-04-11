using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            /* XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
             BinaryFormater serializer = new BinaryFormater();
             using (var stream = File.Open(@"Z:\zapis\zapisposhla.", FileMode.Truncate))
             {
                 var product = new Product
                 {
                     Id = 1,
                     ProductName = "Car",
                     ProductCount = 15,
                     ProductPrice = "15 mln.tenge"
                 };
                 var secondproduct = new Product
                 {
                     Id = 2,
                     ProductName = "Motobyke",
                     ProductCount = 20,
                     ProductPrice = "5 mln.tenge"
                 };
                 var thirdProduct = new Product
                 {
                     Id = 3,
                     ProductName = "Byke",
                     ProductCount = 10,
                     ProductPrice = "400000 tenge"
                 };
                 xmlSerializer.Serialize(stream, product);
             }*/

            Product product = new Product();
            Console.WriteLine("Enter product name");
            product.ProductName = Console.ReadLine();
            Console.WriteLine("Enter the price of the product");
            product.ProductPrice = Console.ReadLine();


            if (Console.ReadKey(true).Key == ConsoleKey.Tab)
            {
                using (FileStream fstream = new FileStream(@"Z:\zapis\zapisposhla.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {

                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product),
                     new Type[]{typeof (string), typeof (DateTime), typeof (List<string>),
                         typeof(List<string>), typeof(List<string>), typeof(string)});
                    xmlSerializer.Serialize(fstream, product);
                }
            }
        }
    }
}