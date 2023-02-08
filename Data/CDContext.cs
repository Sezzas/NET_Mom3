using NET_Mom3.Models;
using Microsoft.EntityFrameworkCore;

namespace NET_Mom3.Data {

    public class CDContext : DbContext {

        public CDContext(DbContextOptions<CDContext> options) : base(options) { 

        }

        public DbSet<CD> CD { get; set; }

    }

}