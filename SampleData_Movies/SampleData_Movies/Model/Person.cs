using System.Collections.Generic;

namespace SampleData_Movies.Model
{
    public class Person
    {
        public string Name { get; set; }
        public HashSet<Movie> Movies { get; set; } = new HashSet<Movie>();
    }
}
