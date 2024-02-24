﻿using KodlamaioApp.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioApp.Entities.Concretes
{
    public class Instructor : IEntitiy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string LastName { get; set; }
        public string Title { get; set; }
        public string Avatar { get; set; }
    }
}
