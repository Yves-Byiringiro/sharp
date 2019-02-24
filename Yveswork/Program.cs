using System;

namespace Yveswork
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new YvesworkContext())
            {
                Console.WriteLine("enter movie title");
                string title = Console.ReadLine();
                Console.WriteLine("enter movie category");
                string category = Console.ReadLine();
                Console.WriteLine("enter movie release uyear");
                string year = Console.ReadLine();
                db.Yvesworks.Add(new Yvesworktbl { title = title });
                db.Yvesworks.Add(new Yvesworktbl { year = year });
                db.Yvesworks.Add(new Yvesworktbl { category_name = category });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All movies in database:");
                foreach (var Yvesworktbl in db.Yvesworks)
                {
                    Console.WriteLine(" - {0}{1}{2}", Yvesworktbl.title, Yvesworktbl.year, Yvesworktbl.category_name);
                }
            }
        }
    }
}