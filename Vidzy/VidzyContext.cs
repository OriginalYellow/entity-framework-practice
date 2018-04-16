using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidzy.Models;

namespace Vidzy
{
    class VidzyContext: DbContext 
    {
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre>  Genres { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Videos table  
            // • Name column cannot be NULL and its length should be maximum 255  characters.  
            // • Genre_Id column should be renamed to GenreId, and it cannot be NULL.  
            // • Classification column should be a tinyint.  
            // Genres table  
            // • Name column cannot be NULL and its length should be maximum 255  characters.

            //modelBuilder.Entity<Video>().Property(t => t.Name).HasMaxLength(255).IsRequired();
            //modelBuilder.Entity<Video>().Property(t => t.)
        }
    }

}
