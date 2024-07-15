using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work1.Entities;

namespace work1.Businness.Abstract
{
	public interface ICategoryManager
	{
		List<Category> GetAll();
		void Remove(Category category);
		void Update(Category category);
		void Add(Category category);
	}
}
