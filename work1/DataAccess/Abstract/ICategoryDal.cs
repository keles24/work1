using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work1.Entities;

namespace work1.DataAccess.Abstract
{
	public interface ICategoryDal
	{
		List<Category> GetAll();
		void Add(Category category);
		void Update(Category category);
		void Remove(Category category);

	}
}
