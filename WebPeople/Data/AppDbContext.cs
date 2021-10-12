using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPeople.Models;

namespace WebPeople.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<Person> People { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options) //Enlaza nuestra base de datos con nuestro EntityFrameWork
        {
               
        }
    }
}
