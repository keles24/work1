using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work1.Entities;

namespace work1.Businness.Abstract
{
	public interface IinstructorManager
	{
		List<Instructor> GetAll();
		void Add(Instructor ıns);
		void Remove(Instructor ıns);
		void Update(Instructor ıns);
	}
}
