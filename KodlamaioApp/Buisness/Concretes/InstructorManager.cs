using KodlamaioApp.Buisness.Abstracts;
using KodlamaioApp.DataAccess.Abstracts;
using KodlamaioApp.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioApp.Buisness.Concretes
{
    public class InstructorManager : IInstructorService
    {

        private IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Add(Instructor t)
        {
            _instructorDal.Add(t);
        }

        public void Delete(int Id)
        {
            _instructorDal.Delete(Id);
        }

        public void Update(Instructor t)
        {
            _instructorDal.Update(t);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }
    }
}
