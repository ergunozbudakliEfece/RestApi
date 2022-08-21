using Microsoft.EntityFrameworkCore;
using RestApi.Models;

namespace RestApi.Contexts
{
    
    public  class Test2021Context : DbContext
    {
        public Test2021Context(DbContextOptions<Test2021Context> options)
    : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
       
        public DbSet<UserModel> TBL_USERS { get; set; }
        public DbSet<TicketModel> TBL_TICKETS { get; set; }
    }
}
