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
    public class InstructorManager:IinstructorManager
    {
        private readonly IınstructorDal _ınstructorDal;
        public InstructorManager(IınstructorDal ıınstructorDal)
        {
            _ınstructorDal = ıınstructorDal;
        }
        public List<Instructor> GetAll()
        {
            return _ınstructorDal.GetAll();
        }
        public void Remove(Instructor ıns)
        {
            _ınstructorDal.Remove(ıns);
        }
        public void Update(Instructor ıns)
        {
            _ınstructorDal.Update(ıns);
        }
        public void Add(Instructor ıns)
        {
            _ınstructorDal.Add(ıns);
        }
    }
}
