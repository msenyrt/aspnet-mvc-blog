using Blog.Data.Entity;

namespace Blog.Data
{
    public class DbSeeder
    {
        public static void Seed(BlogDbContext context)
        {
            if (!context.Categories.Any())
            {
                // Categories
                var categories = new Category[]
                {
                    new Category { Name = "Music", Slug = "music" },
                    new Category { Name = "Sports", Slug = "sports" },
                    new Category { Name = "Games", Slug = "games" },
                    new Category { Name = "Technology", Slug = "technology" }
                };

                context.Categories.AddRange(categories);
                context.SaveChanges();
            }
            if (!context.Users.Any())
            {
                context.Users.Add(new User { Name = "Admin", Email = "admin@dev.com", Password = "admin", Phone = "01234567890", City = "Istanbul", Role = "admin" });
                context.Users.Add(new User { Name = "User", Email = "user@email.com", Password = "user", Phone = "09876543210", City = "Izmir", Role = "user" });
                context.SaveChanges();
            }
            if (!context.Posts.Any())
            {
                // Post content
                var posts = new Post[]
                {
                    new Post { Title = "In Cursus Libero Metus", Content = "Aenean sodales purus vitae nisl posuere malesuada. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus interdum tempus tellus, vitae rhoncus eros. Quisque vel enim id metus venenatis porttitor.", Categories=new List<Category>{context.Categories.FirstOrDefault(e => e.Id == 1), context.Categories.FirstOrDefault(e => e.Id == 4) }, UserId=1},
                    new Post { Title = "Donec Eu Tristique Massa", Content = "Donec eleifend augue massa, eget egestas dui molestie pretium. Cras et dapibus ligula. Nam sed felis viverra purus aliquet ullamcorper et ut lorem.", Categories=new List<Category>{context.Categories.FirstOrDefault(e => e.Id == 2) }, UserId=1},
                    new Post { Title = "Nunc Eros Elit", Content = "Vestibulum faucibus leo non vestibulum scelerisque. Nam gravida justo nec diam ornare, in porttitor leo laoreet. In lorem ligula, lacinia vel maximus in, euismod quis nisi.", Categories=new List<Category>{context.Categories.FirstOrDefault(e => e.Id == 3) }, UserId=1},
                    new Post { Title = "Duis Vel Ex Augue", Content = "Vestibulum nisl tellus, bibendum id lobortis eu, congue quis dolor. Curabitur non auctor erat. Integer hendrerit est tellus. Pellentesque imperdiet nibh et odio tincidunt facilisis.", Categories=new List<Category>{context.Categories.FirstOrDefault(e => e.Id == 4) }, UserId=1}
                };

                context.Posts.AddRange(posts);
                context.SaveChanges();
            }
            if (!context.Pages.Any())
            {
                var pages = new Page[]
                {
                    new Page { Title = "Page Name"}
                };

                context.Pages.AddRange(pages);
                context.SaveChanges();
            }

        }


    }
}
