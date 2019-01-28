using SampleData_Movies.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleData_Movies
{
    public class MovieManager
    {
        public IEnumerable<Movie> Movies { get; private set; }


        public MovieManager()
        {
            var gl = new Person() { Name = "George Lucas" };
            var ik = new Person() { Name = "Irvin Kershner" };
            var rm = new Person() { Name = "Richard Marquand" };
            var jj = new Person() { Name = "J. J. Abrams" };
            var rj = new Person() { Name = "Rian Johnson" };

            var mh = new Person() { Name = "Mark Hamill" };
            var ls = new ActorRole() { Person = mh, RoleName = "Luke Skywalker" };

            var hf = new Person() { Name = "Harrison Ford" };
            var hs = new ActorRole() { Person = mh, RoleName = "Han Solo" };

            var cf = new Person() { Name = "Carrie Fisher" };
            var pl = new ActorRole() { Person = mh, RoleName = "Princess Leia" };

            var mg = new Person() { Name = "Ewan McGregor" };
            var obi1 = new ActorRole { Person = mg, RoleName = "Obi-Wan Kenobi" };

            var ag = new Person() { Name = "Alec Guinness" };
            var obi2 = new ActorRole { Person = ag, RoleName = "Obi-Wan Kenobi" };

            var sw1 = new Movie() { Title = "Star Wars: Episode I – The Phantom Menace", PublishedDate = new DateTime(1999, 5, 19), Revenue = 1027044677m, Director = gl };
            var sw2 = new Movie() { Title = "Star Wars: Episode II – Attack of the Clones", PublishedDate = new DateTime(2002, 5, 16), Revenue = 656695615m, Director = ik };
            var sw3 = new Movie() { Title = "Star Wars: Episode III – Revenge of the Sith", PublishedDate = new DateTime(2005, 5, 19), Revenue = 848998877m, Director = rm };
            var sw4 = new Movie() { Title = "Star Wars: Episode IV – A New Hope", PublishedDate = new DateTime(1977, 5, 25), Revenue = 786598007m, Director = gl };
            var sw5 = new Movie() { Title = "Star Wars: Episode V – The Empire Strikes Back", PublishedDate = new DateTime(1980, 5, 21), Revenue = 534161334m, Director = gl };
            var sw6 = new Movie() { Title = "Star Wars: Episode VI – Return of the Jedi", PublishedDate = new DateTime(1983, 5, 25), Revenue = 572705079m, Director = gl };
            var sw7 = new Movie() { Title = "Star Wars: Episode VII – The Force Awakens", PublishedDate = new DateTime(2015, 12, 18), Revenue = 2053311220m, Director = jj };
            var sw8 = new Movie() { Title = "Star Wars: Episode VIII – The Last Jedi", PublishedDate = new DateTime(2017, 12, 15), Revenue = 1316764784m, Director = rj };
            var sw9 = new Movie() { Title = "Star Wars: Episode IX – ???", PublishedDate = new DateTime(2019, 12, 20), Revenue = 0m, Director = jj };


            sw1.ActorRoles.Add(obi1);
            sw2.ActorRoles.Add(obi1);
            sw3.ActorRoles.Add(obi1);
            sw4.ActorRoles.Add(ls);
            sw4.ActorRoles.Add(pl);
            sw4.ActorRoles.Add(hs);
            sw4.ActorRoles.Add(obi2);
            sw5.ActorRoles.Add(ls);
            sw5.ActorRoles.Add(pl);
            sw5.ActorRoles.Add(hs);
            sw5.ActorRoles.Add(obi2);
            sw6.ActorRoles.Add(ls);
            sw6.ActorRoles.Add(pl);
            sw6.ActorRoles.Add(hs);
            sw6.ActorRoles.Add(obi2);


            Movies = new List<Movie>(new[] { sw1, sw2, sw3, sw4, sw5, sw6, sw7, sw8, sw9 });
            Movies.Where(x => x.Director == gl).ToList().ForEach(x => gl.Movies.Add(x));
            Movies.Where(x => x.Director == jj).ToList().ForEach(x => jj.Movies.Add(x));
            ik.Movies.Add(sw2);
            rm.Movies.Add(sw3);
            rj.Movies.Add(sw8);

        }
    }
}
