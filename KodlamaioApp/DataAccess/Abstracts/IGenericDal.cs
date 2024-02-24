using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioApp.DataAccess.Abstracts
{
    public interface IGenericDal<T> where T : class
    {
        void Add(T t);
        void Update(T t);
        void Delete(int Id);
        List<T> GetAll();
    }
}
