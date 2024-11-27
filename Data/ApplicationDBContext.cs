using egorMessenger.Models;
using Microsoft.EntityFrameworkCore;

namespace egorMessenger.Data;


public class ApplicationDBContext : DbContext
{

    public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {

    }


    public DbSet<Message> Messages { get; set; }

}