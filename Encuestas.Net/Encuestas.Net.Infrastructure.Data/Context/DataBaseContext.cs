
using Encuestas.Net.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace Encuestas.Net.Infrastructure.Data.Contexts
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			base.OnModelCreating(modelBuilder);
			var entitiesAssembly = typeof(EntityBase).Assembly;
			modelBuilder.RegisterAllEntities<EntityBase>(entitiesAssembly);
		}
    }
}
