using BlazingShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Services
{
    public class CategoryService
    {
        private readonly ApplicationDbContext _db;

        public CategoryService(ApplicationDbContext db)
        {
            _db = db;
        }

        public Category GetCategory(int categoryId)
        {
            return _db.Categories.FirstOrDefault(c => c.Id == categoryId);
        }

        public List<Category> GetCategories()
        {
            return _db.Categories.ToList();
        }

        public bool CreateCategory(Category categoryObj)
        {
            try
            {
                _db.Categories.Add(categoryObj);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCategory(Category categoryObj)
        {
            bool updated = false;

            try
            {
                var existingCategory = GetCategory(categoryObj.Id);

                if (existingCategory != null)
                {
                    existingCategory.Name = categoryObj.Name;
                    _db.SaveChanges();

                    updated = true;
                }
            }
            catch
            {
            }

            return updated;
        }

        public bool DeleteCategory(Category categoryObj)
        {
            bool deleted = false;

            try
            {
                var existingCategory = GetCategory(categoryObj.Id);

                if (existingCategory != null)
                {
                    _db.Categories.Remove(existingCategory);
                    _db.SaveChanges();

                    deleted = true;
                }
            }
            catch
            {
            }

            return deleted;
        }
    }
}
