﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Author
    {
        public Author(int idAuthor, string name, string affiliation)
        {
            IdAuthor = idAuthor;
            Name = name;
            Affiliation = affiliation;
        }
        public int IdAuthor { get; set; }
        public string Name { get; set; }
        public string Affiliation { get; set; }
    }
}
