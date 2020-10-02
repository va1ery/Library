/* using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
*/
using System;
using System.Linq;

namespace Library.Models
{
    class Program
    {
        static void Main()
        {
            using (var db = new LibraryContext())
            {
                // Create
                Console.WriteLine("Inserting a new Position");
                db.Add(new Position { PositionName = "Manager" });
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a Position");
                var position = db.Positions
                    .OrderBy(b => b.ID)
                    .First();

                // Update
                Console.WriteLine("Updating the position and adding a employee");
                position.PositionName = "Manager";
        /*        position.Employee.Add(
                    new Employee
                    {
                        LastName = "Sidorov",
                        FirstName = "Peter",
        //                BirthDate = 10-10-2010,
                        //PositionID = 
                    });
                db.SaveChanges();

                /* Delete
                Console.WriteLine("Delete the blog");
                db.Remove(blog);
                db.SaveChanges();*/
            }
        }
    }
}