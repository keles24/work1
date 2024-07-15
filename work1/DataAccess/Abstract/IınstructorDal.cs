using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work1.Entities;

namespace work1.DataAccess.Abstract
{
	public interface IınstructorDal
	{
		List<Instructor> GetAll();
		void Add(Instructor ınstructor);
		void Remove(Instructor ınstructor);
		void Update(Instructor ınstructor);
	}
}
