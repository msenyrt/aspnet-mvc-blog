using Blog.Web.Mvc.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Mvc.Data
{
    public class DbSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasData(new List<User>
            {
                new() {
                    Id = 1,
                    Email = "admin@blog.dev",
                    Name = "admin",
                    Password = "123"
                },

               
                new() {
                    Id = 1,
                    Email = "kullanici@blog.com",
                    Name = "kullanici",
                    Password = "321",
                    City = "Istanbul"
                }
            });

        }


    }
}
