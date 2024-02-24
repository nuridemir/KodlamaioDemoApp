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
    public class CourseManager : ICourseService
    {

        private ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course t)
        {
            _courseDal.Add(t);
        }

        public void Delete(int Id)
        {
            _courseDal.Delete(Id);
        }

        public void Update(Course t)
        {
            _courseDal.Update(t);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }
    }
}
