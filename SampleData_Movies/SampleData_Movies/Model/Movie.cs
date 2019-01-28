using System;
using System.Collections.Generic;
using System.Text;

namespace SampleData_Movies.Model
{
    public class Movie
    {
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public HashSet<ActorRole> ActorRoles { get; set; } = new HashSet<ActorRole>();
        public decimal Revenue { get; set; }
        public Person Director { get; set; }
    }
}
