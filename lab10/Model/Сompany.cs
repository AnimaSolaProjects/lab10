using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.Model
{
    public class Сompany
    {
        public string Name { get; set; }
        public int СompanyId { get; set; }

        public int Year { get; set; }

        public virtual ICollection<Beer> Beers { get; set; }
    }
}
