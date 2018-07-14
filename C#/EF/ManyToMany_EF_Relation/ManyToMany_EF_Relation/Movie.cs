using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany_EF_Relation
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Director { get; set; }
        public List<Actor> ActorList { get; set; }

        public Movie()
        {
            ActorList = new List<Actor>();
        }
    }
}
