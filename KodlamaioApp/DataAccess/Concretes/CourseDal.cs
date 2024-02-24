using KodlamaioApp.DataAccess.Abstracts;
using KodlamaioApp.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioApp.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        private List<Course> _courses;

        public CourseDal()
        {
            _courses = new List<Course>
            {
                new Course { Id = 1, Name = "React", Description = "React kategorisi açıklaması", PercentComplete = 20 },
                new Course { Id = 2, Name = "C#", Description = "C# kategorisi açıklaması", PercentComplete = 60 },
                new Course { Id = 3, Name = "Java", Description = "Java kategorisi açıklaması", PercentComplete = 80 },
            };
        }

        public void Add(Course t)
        {
            try
            {
                _courses.Add(t);
                Console.WriteLine(t.Name + " Kursu başarılı bir şekilde eklendi");
            }
            catch (Exception)
            {

                Console.WriteLine("Kurs eklenmesinde bir hata oluştu: " + Exception.Equals);
            }
        }

        public void Delete(int Id)
        {
            var result = _courses.Remove(_courses.SingleOrDefault(item => item.Id == Id));
            if (result) Console.WriteLine("Kursu başarıyla silindi");
            else Console.WriteLine("Kurs silinemedi veya böyle bir kategori bulunamadı.");
        }

        public List<Course> GetAll()
        {
            foreach (var course in _courses)
            {
                Console.WriteLine("Kurs Adı " + course.Name);
            }

            return _courses;
        }

        public void Update(Course t)
        {
            var result = _courses.FirstOrDefault(item => item.Id == t.Id);
            if (result != null)
            {
                result.Id = t.Id;
                result.Name = t.Name;
                result.Description = t.Description;
                result.PercentComplete = t.PercentComplete;
                result.Image = t.Image;
                Console.WriteLine(result.Name + " Kursu başarılı bir şekilde güncellendi.");
            }
            else
            {
                Console.WriteLine("Kurs güncellenmesinde bir hata oluştu");
            }
        }
    }
}
