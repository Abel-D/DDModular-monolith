using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Excellerent.Standard.Advanced.Shared.Infrastructure.Database
{
    public class BaseContext<T> : DbContext where T: class
    {
        public BaseContext()
        {

        }

        public BaseContext(DbContextOptions<BaseContext<T>> options) : base(options)
        {

        }
        protected BaseContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Type T is added as a DbSet to the context, but without a Key. 
            // A key is not required as this will be used only for data 
            // retrieval and with AsNoTracking
            var t = modelBuilder.Entity<T>().HasNoKey();

            // Using reflection, the relevant properties of type T 
            // are added to the DbSet entity
            foreach (var prop in typeof(T)
                .GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                if (!prop.CustomAttributes
                    .Any(a => a.AttributeType == typeof(NotMappedAttribute)))
                {
                    t.Property(prop.Name);
                }
            }

            base.OnModelCreating(modelBuilder);
        }

    }
}
