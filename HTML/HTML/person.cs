using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HTML
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }

    }

    public class PDatabase : DbContext
    {
        public PDatabase() : base("Name=PersonsDatabase")
        {

        }
        public DbSet<Person> People { get; set; }
    }
}
