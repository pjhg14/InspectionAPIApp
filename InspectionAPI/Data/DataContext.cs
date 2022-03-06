using InspectionAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InspectionAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Inspection> Inspections { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<InspectionAPI.Models.InspectionType> InspectionType { get; set; }
    }
}
