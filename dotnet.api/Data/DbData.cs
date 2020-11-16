using dotnet.api.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace dotnet.api.Data
{
    public class DbData:DbContext
    {
        public DbData(DbContextOptions<DbData> options):base(options){}

        public DbSet<Value> Values { get; set; }
    }
}