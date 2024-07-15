using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work1.Businness.Abstract;
using work1.DataAccess.Abstract;
using work1.Entities;

namespace work1.Businness.Concretes
{
    public class CategoryManager:ICategoryManager
    {
        private readonly ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }
        public List<Category> GetAll()
        {
            return _categorydal.GetAll();
        }
        public void Remove(Category category)
        {
            _categorydal.Remove(category);
        }
        public void Update(Category category)
        {
            _categorydal.Update(category);
        }
        public void Add(Category category)
        {
            _categorydal.Add(category);
        }
    }
}
