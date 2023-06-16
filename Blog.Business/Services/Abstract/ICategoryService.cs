﻿using Blog.Data.Entity;

namespace Blog.Business.Services.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int id);
        void Insert(Category category);
        void Update(Category category);
        void DeleteById(int id);
    }
}
