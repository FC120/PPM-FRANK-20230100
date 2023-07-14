using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lidbPrueba19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Open database (or create if doesn't exist)
            using (var db = new LiteDatabase(@"C:\Programación\Programación para Mecatrónicos\PPM\Tarea 8\lidbPrueba19\LiteDB.Studio-1.0.3\LiteDB.Studio-1.0.3\LiteDB\MyData.db"))
            {
                // Get a collection (or create, if doesn't exist)
                var col = db.GetCollection<Customer>("customers");

                // Create your new customer instance
                var customer = new Customer
                {
                    Name = "Joe Doe",
                    Phones = new string[1] { "829-425-7789" },
                    IsActive = true
                };

                // Insert new customer document (Id will be auto-incremented)
                col.Insert(customer);

                // Update a document inside a collection
                customer.Name = "Xavier Peña";

                col.Update(customer);

                // Index document using document Name property
                col.EnsureIndex(x => x.Name);

                // Use LINQ to query documents (filter, sort, transform)
                var results = col.Query()
                    .Where(x => x.Name.StartsWith("F"))
                    .OrderBy(x => x.Name)
                    .Select(x => new { x.Name, NameUpper = x.Name.ToUpper() })
                    .Limit(10)
                    .ToList();

                // Let's create an index in phone numbers (using expression). It's a multikey index
                col.EnsureIndex(x => x.Phones);

                // and now we can query phones
                var r = col.FindOne(x => x.Phones.Contains("8888-5555"));
            }
        }
    }

    // Create your POCO class entity
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string[] Phones { get; set; }
        public bool IsActive { get; set; }
    }
}
