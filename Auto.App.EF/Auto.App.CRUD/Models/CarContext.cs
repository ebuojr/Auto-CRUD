using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Auto.App.CRUD.Models
{
    public class CarContext : DbContext
    {
        public CarContext (DbContextOptions<CarContext> options) 
            : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
    }
}
