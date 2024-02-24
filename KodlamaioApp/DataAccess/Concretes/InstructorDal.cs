using KodlamaioApp.DataAccess.Abstracts;
using KodlamaioApp.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioApp.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        private List<Instructor> _instructors;

        public InstructorDal()
        {
            _instructors = new List<Instructor>
            {
                new Instructor { Id = 1, Name = "Nuri", Description = "Nuri eğitmeni açıklaması", LastName = "Demir", Title = "Front-end Developer" },
                new Instructor { Id = 2, Name = "Ahmet", Description = "Ahmet eğitmeni açıklaması", LastName = "Demir", Title = "Back-end Developer" },
                new Instructor { Id = 3, Name = "Demir", Description = "Demir eğitmeni açıklaması", LastName = "Demir", Title = "DevOps" },
            };
        }

        public void Add(Instructor t)
        {
            try
            {
                _instructors.Add(t);
                Console.WriteLine(t.Name + " Eğitmeni başarılı bir şekilde eklendi");
            }
            catch (Exception)
            {

                Console.WriteLine("Eğitmen eklenmesinde bir hata oluştu: " + Exception.Equals);
            }
        }

        public void Delete(int Id)
        {
            var result = _instructors.Remove(_instructors.SingleOrDefault(item => item.Id == Id));
            if (result) Console.WriteLine("Eğitmeni başarıyla silindi");
            else Console.WriteLine("Eğitmen silinemedi veya böyle bir kategori bulunamadı.");
        }

        public List<Instructor> GetAll()
        {
            foreach (var instructor in _instructors)
            {
                Console.WriteLine("Kategori Adı " + instructor.Name);
            }

            return _instructors;
        }

        public void Update(Instructor t)
        {
            var result = _instructors.FirstOrDefault(item => item.Id == t.Id);
            if (result != null)
            {
                result.Id = t.Id;
                result.Name = t.Name;
                result.Description = t.Description;
                result.LastName = t.LastName;
                result.Title = t.Title;
                result.Avatar = t.Avatar;
                Console.WriteLine(result.Name + " Eğitmeni başarılı bir şekilde güncellendi.");
            }
            else
            {
                Console.WriteLine("Eğitmen güncellenmesinde bir hata oluştu");
            }
        }
    }
}
