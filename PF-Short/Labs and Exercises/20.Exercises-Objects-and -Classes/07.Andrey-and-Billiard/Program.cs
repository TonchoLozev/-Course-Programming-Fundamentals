using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Student
    {
        public string Name { get; set; }
        public Dictionary<string, int> ProductAndAmount { get; set; }
        public decimal Bill { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, decimal> productAndPrice = new SortedDictionary<string, decimal>();
            int productsAmount = int.Parse(Console.ReadLine());
            for (int i = 0; i < productsAmount; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string product = input[0];
                decimal price = decimal.Parse(input[1]);
                if (!productAndPrice.ContainsKey(product))
                {
                    productAndPrice.Add(product, price);
                }
                else
                {
                    productAndPrice[product] = price;
                }
            }

            List<Student> allCustomers = new List<Student>();

            while (true)
            {
                string info = Console.ReadLine();
                if (info == "end of clients") { break; }
                string[] split = info.Split(',', '-');
                string name = split[0];
                string product = split[1];
                int quantity = int.Parse(split[2]);
                if (!productAndPrice.ContainsKey(product)) { continue; }

                Student student = new Student();
                student.Name = name;
                student.ProductAndAmount = new Dictionary<string, int>();
                student.ProductAndAmount.Add(product, quantity);             

                if (allCustomers.Any(c => c.Name == name))
                {
                    Student existingCustomer = allCustomers.First(c => c.Name == name);
                    if (existingCustomer.ProductAndAmount.ContainsKey(product))
                    {
                        existingCustomer.ProductAndAmount[product] += quantity;
                      
                    }
                    else
                    {
                        existingCustomer.ProductAndAmount[product] = quantity;
                        
                    }
                }
                else
                {
                    allCustomers.Add(student);
                }
            }

            foreach (var customer in allCustomers)
            {
                foreach (var item in customer.ProductAndAmount)
                {

                    foreach (var product in productAndPrice)
                    {
                        if (item.Key == product.Key) { customer.Bill += item.Value * product.Value; }
                    }
                }
            }

            decimal sum = 0;
            foreach (var item in allCustomers.OrderBy(x => x.Name).ThenBy(x => x.Bill))
            {
                Console.WriteLine(item.Name);
                foreach (KeyValuePair<string, int> kvp in item.ProductAndAmount)
                {
                    Console.WriteLine($"-- {kvp.Key} - {kvp.Value}");
                    Console.WriteLine($"Bill: {item.Bill:F2}");
                    sum += item.Bill;
                }

            }
            Console.WriteLine($"Total bill: {allCustomers.Sum(x=>x.Bill):f2}");
        }
    }
}
