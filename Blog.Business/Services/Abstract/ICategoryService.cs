using Blog.Business.DtoData;

namespace Blog.Business.Services.Abstract
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDto> GetAll();
        CategoryDto GetById(int id);
        CategoryDto GetBySlug(string slug);
        void Insert(CategoryDto category);
        void Update(CategoryDto category);
        void DeleteById(int id);
    }
}
