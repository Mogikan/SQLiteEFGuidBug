using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SQLiteSample
{
    public class SqliteDbContext : DbContext
    {
        private string _dbPath = @"data.db";
        public SqliteDbContext(string dbPath)
        {
            _dbPath = dbPath;
        }
        //ctor for migration
        public SqliteDbContext(DbContextOptions<SqliteDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = $"Data Source=\"{_dbPath}\"";
            optionsBuilder.UseSqlite(path);//
#if DEBUG
            optionsBuilder.EnableSensitiveDataLogging(true);
            optionsBuilder.LogTo(s=>System.Diagnostics.Debug.WriteLine(s));
#endif
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserReferencesData>()
                .HasOne<UserReferencesMetadata>()
                .WithMany()
                .HasForeignKey(d => d.MetadataId);
        }

        public virtual DbSet<UserReferencesData> UserReferencesData
        {
            get;
            set;
        }

        public virtual DbSet<UserReferencesMetadata> UserReferencesMetadata
        {
            get;
            set;
        }
    }
}
