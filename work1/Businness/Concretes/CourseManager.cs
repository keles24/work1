using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work1.Businness.Abstract;
using work1.DataAccess.Abstract;
using work1.DataAccess.Concretes;
using work1.Entities;

namespace work1.Businness.Concretes
{
    public class CourseManager:ICourseManager
    {
        private readonly ICourseDal _coursedal;
        public CourseManager(ICourseDal coursedal)
        {
            _coursedal = coursedal;
        }
        public List<Course> GetAll()
        {
            return _coursedal.GetAll();
        }
        public void Remove(Course courses)
        {
            _coursedal.Remove(courses);
        }
        public void Update(Course courses)
        {
            _coursedal.Update(courses);
        }
        public void Add(Course course)
        {
            _coursedal.Add(course);
        }
    }
}
