using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work1.DataAccess.Abstract;
using work1.Entities;

namespace work1.DataAccess.Concretes
{
	public class CategoryDal:ICategoryDal
	{
		List<Category> _categories;
        public CategoryDal()
        {
            Category category1 = new Category();
            category1.Id = 1;
            category1.Name = "Programlama";

            _categories = new List<Category>();
        }
        public List<Category> GetAll()
        {
            return _categories;
        }
        public void Add(Category category) 
        {
            _categories.Add(category);
        }

        public void Remove(Category category) 
        {
            _categories.Remove(category);
        }
        public void Update(Category category) 
        {
           var existingCategory = _categories.FirstOrDefault(x=>x.Id == category.Id);
            if (existingCategory != null) 
            {
                existingCategory.Name = category.Name;
            }
            else
            {
                throw new ArgumentException("Category not found.");  
            }
        }
    }
}
