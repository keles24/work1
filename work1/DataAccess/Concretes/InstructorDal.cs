using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work1.DataAccess.Abstract;
using work1.Entities;

namespace work1.DataAccess.Concretes
{
	public class InstructorDal:IınstructorDal
	{
		List<Instructor> ınstructors;
        public InstructorDal()
        {
            Instructor ınstructor1 = new Instructor();
            ınstructor1.Id = 1;
            ınstructor1.FirstName = "Engin";
            ınstructor1.LastName = "Demiroğ";
            
            Instructor ınstructor2 = new Instructor();
            ınstructor2.Id = 2;
            ınstructor2.FirstName = "Halit Enes";
            ınstructor2.LastName = "Kalayci";

            ınstructors = new List<Instructor>();  
        }
        public List<Instructor> GetAll()
        {
            return ınstructors;
        }
        public void Add(Instructor ins)
        {
            ınstructors.Add(ins);
        }

        public void Remove(Instructor ins)
        {
           ınstructors.Remove(ins);
        }

        public void Update(Instructor ins) 
        {
            var existingIns = ınstructors.FirstOrDefault(x => x.Id == ins.Id);
            if (existingIns != null) 
            {
                existingIns.FirstName = ins.FirstName;
                existingIns.LastName = ins.LastName;
            }
            else
            {
                throw new ArgumentException("Instructor not found.");
            }
        }

    }
}
