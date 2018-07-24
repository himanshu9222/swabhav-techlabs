using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositaryPattern_With_UnitOfWork.EntityFramework.Repositary
{
    public abstract class Entity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
