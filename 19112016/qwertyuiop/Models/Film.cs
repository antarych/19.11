using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace qwertyuiop.Models
{
    public class Film
    {
        public Film(string name, string director, string genre)
        {
            Name = name;
            Director = director;
            Genre = genre;
        }

        public string Name { get; private set; }

        public string Director { get; private set; }

        public string Genre { get; private set; }
    }
}