using KodlamaioApp.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioApp.Entities.Concretes
{
    public class Course : IEntitiy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int PercentComplete { get; set; }
        public string Image { get; set; }
    }
}
