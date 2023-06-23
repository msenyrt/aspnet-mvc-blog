using Blog.Data.Entity;
using Blog.Business.DtoData;

namespace Blog.Business
{
    public static class DtoConvertions
    {

        //Post conversions
        public static PostDto PostToDto(this Post p)
        {
            return new PostDto { Id = p.Id, Categories = p.Categories.CategoryListToDtoList(), Content = p.Content, CreatedAt = p.CreatedAt, DeletedAt = p.DeletedAt, Title = p.Title, UpdatedAt = p.UpdatedAt, UserId = p.UserId, User = p.User };
        }

        public static List<PostDto> PostListToDtoList(this List<Post> p)
        {
            List<PostDto> dtoData = new List<PostDto>();
            if (p != null)
            {
                foreach (var item in p)
                {
                    dtoData.Add(item.PostToDto());
                }
            }
            return dtoData;
        }
        public static Post DtoToPost(this PostDto p)
        {
            return new Post { Id = p.Id, Categories = p.Categories.DtoListToCategoryList(), Content = p.Content, CreatedAt = p.CreatedAt, DeletedAt = p.DeletedAt, Title = p.Title, UpdatedAt = p.UpdatedAt, UserId = p.UserId, User = p.User };
        }

        public static List<Post> DtoListToPostList(this List<PostDto> p)
        {
            List<Post> dtoData = new List<Post>();
            foreach (var item in p)
            {
                dtoData.Add(item.DtoToPost());
            }
            return dtoData;
        }



        //User conversions
        public static UserDto UserToDto(this User u)
        {
            return new UserDto { City = u.City, Email = u.Email, Id = u.Id, Name = u.Name, Password = u.Password, Phone = u.Phone };
        }

        public static List<UserDto> UserListToDtoList(this List<User> p)
        {
            List<UserDto> dtoData = new List<UserDto>();
            foreach (var item in p)
            {
                dtoData.Add(item.UserToDto());
            }
            return dtoData;
        }
        public static User DtoToUser(this UserDto u)
        {
            return new User { City = u.City, Email = u.Email, Id = u.Id, Name = u.Name, Password = u.Password, Phone = u.Phone };

        }



        //Category conversions
        public static CategoryDto CategoryToDto(this Category c)
        {
            return new CategoryDto { Description = c.Description, Name = c.Name, Id = c.Id, Posts = c.Posts.PostListToDtoList(), Slug = c.Slug };
        }

        public static List<CategoryDto> CategoryListToDtoList(this List<Category> p)
        {
            List<CategoryDto> dtoData = new List<CategoryDto>();
            foreach (var item in p)
            {
                dtoData.Add(item.CategoryToDto());
            }
            return dtoData;
        }
        public static Category DtoToCategory(this CategoryDto c)
        {
            return new Category { Description = c.Description, Name = c.Name, Id = c.Id, Posts = c.Posts.DtoListToPostList(), Slug = c.Slug };

        }
        public static List<Category> DtoListToCategoryList(this List<CategoryDto> p)
        {
            List<Category> dtoData = new List<Category>();
            foreach (var item in p)
            {
                dtoData.Add(item.DtoToCategory());
            }
            return dtoData;
        }



        //Page conversions
        public static PageDto PageToDto(this Page p)
        {
            return new PageDto { Content = p.Content, CreatedAt = p.CreatedAt, DeletedAt = p.DeletedAt, Id = p.Id, IsActive = p.IsActive, Slug = p.Slug, Title = p.Title, UpdatedAt = p.UpdatedAt };
        }

        public static List<PageDto> PageListToDtoList(this List<Page> p)
        {
            List<PageDto> dtoData = new List<PageDto>();
            foreach (var item in p)
            {
                dtoData.Add(item.PageToDto());
            }
            return dtoData;
        }
        public static Page DtoToPage(this PageDto p)
        {
            return new Page { Content = p.Content, CreatedAt = p.CreatedAt, DeletedAt = p.DeletedAt, Id = p.Id, IsActive = p.IsActive, Slug = p.Slug, Title = p.Title, UpdatedAt = p.UpdatedAt };

        }



        //Setting conversions
        public static SettingDto SettingToDto(this Setting s)
        {
            return new SettingDto { Id = s.Id, Name = s.Name, UserId = s.UserId, Value = s.Value };
        }

        public static List<SettingDto> SettingListToDtoList(this List<Setting> s)
        {
            List<SettingDto> dtoData = new List<SettingDto>();
            foreach (var item in s)
            {
                dtoData.Add(item.SettingToDto());
            }
            return dtoData;
        }
        public static Setting DtoToSetting(this SettingDto s)
        {
            return new Setting { Id = s.Id, Name = s.Name, UserId = s.UserId, Value = s.Value };

        }
    }
}
