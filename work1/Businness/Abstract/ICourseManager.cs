using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work1.Entities;

namespace work1.Businness.Abstract
{
	public interface ICourseManager
	{
		List<Course> GetAll();
		void Add(Course course);
		void Remove(Course course);
		void Update(Course course);
	}
}
