using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var entities = new CitiesDBEntities())
            {
                Console.WriteLine("\nPrint for Population > 30000: ");
                entities.Districts.Where(p => p.Population > 30000).ToList().ForEach(r => Console.WriteLine(JsonConvert.SerializeObject(r)));
                entities.SaveChanges();
                object Cities = null;
                var result = from c in Cities
                             where c.Name
                             select c;
            }
        }


    }
}
