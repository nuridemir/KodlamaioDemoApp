using KodlamaioApp.DataAccess.Abstracts;
using KodlamaioApp.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioApp.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {

        private List<Category> _categories;

        public CategoryDal()
        {
            _categories = new List<Category>
            {
                new Category { Id = 1, Name = "Front-end", Description = "Front-end kategorisi açıklaması" },
                new Category { Id = 2, Name = "Back-end", Description = "Back-end kategorisi açıklaması" },
                new Category { Id = 3, Name = "DevOps", Description = "DevOps kategorisi açıklaması" },
            };
        }


        public void Add(Category t)
        {
            try
            {
                _categories.Add(t);
                Console.WriteLine(t.Name + " Kategorisi başarılı bir şekilde eklendi");
            }
            catch (Exception)
            {

                Console.WriteLine("Kategori eklenmesinde bir hata oluştu: "+ Exception.Equals);
            }
        }

        public void Delete(int Id)
        {
            var result = _categories.Remove(_categories.SingleOrDefault(item => item.Id == Id));
            if (result) Console.WriteLine("Kategorisi başarıyla silindi");
            else Console.WriteLine("Kategori silinemedi veya böyle bir kategori bulunamadı.");
        }

        public List<Category> GetAll()
        {
             foreach (var category in _categories)
            {
                Console.WriteLine("Kategori Adı " + category.Name);
            }

            return _categories;
        }

        public void Update(Category t)
        {
            var result = _categories.FirstOrDefault(item => item.Id == t.Id);
            if (result != null)
            {
                result.Id = t.Id;
                result.Name = t.Name;
                result.Description = t.Description;
                Console.WriteLine(result.Name + " Kategorisi başarılı bir şekilde güncellendi.");
            }
            else
            {
                Console.WriteLine("Kategori güncellenmesinde bir hata oluştu");
            }
        }
    }
}
