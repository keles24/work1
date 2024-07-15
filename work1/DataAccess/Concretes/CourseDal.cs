using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work1.DataAccess.Abstract;
using work1.Entities;

namespace work1.DataAccess.Concretes
{
	public class CourseDal:ICourseDal
	{	
		List<Course> courses;	
        public CourseDal()
        {
			Course course1 = new Course();
			course1.Id = 1;
			course1.Name = "C#";
			course1.Description = "C# KURSU.";
			course1.Price = "0";


			Course course2 = new Course();
			course2.Id = 2;
			course2.Name = "JAVA";
			course2.Description = "JAVA KURSU.";
			course2.Price = "0";

			Course course3 = new Course();
			course3.Id = 3;
			course3.Name = "PYTHON";
			course3.Description = "PYTHON KURSU.";
			course3.Price = "0";
			courses = new List<Course> { course1, course2, course3 };
		}
		public List<Course> GetAll() 
		{
			return (courses);
		}
		public void Add(Course course)
		{
			courses.Add(course);
		}
		public void Remove(Course course) 
		{
			courses.Remove(course);
		}
		public void Update(Course course) 
		{
			var existingCourse = courses.FirstOrDefault(x => x.Id == course.Id);
            if (existingCourse!=null)
            {
                existingCourse.Name = course.Name;
				existingCourse.Description = course.Description;
				existingCourse.Price = course.Price;
            }
			else
			{
				throw new ArgumentException("Course Not found.");
			}
        }

    }
}
