using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany_EF_Relation
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string ActorName { get; set; }
        public float Salary { get; set; }
        public List<Movie> MovieList { get; set; }

        public Actor()
        {
            MovieList = new List<Movie>();
        }
    }
}
