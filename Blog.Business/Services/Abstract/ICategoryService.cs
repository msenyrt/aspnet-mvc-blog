using Blog.Business.DtoData;

namespace Blog.Business.Services.Abstract
{
    public interface ICategoryService
    {
        List<CategoryDto> GetAll();
        CategoryDto GetById(int id);
        void Insert(CategoryDto category);
        void Update(CategoryDto category);
        void DeleteById(int id);
    }
}
