using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tets.Models
{
    public class PersonDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
    }
}