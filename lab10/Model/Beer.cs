using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab10.Model
{
    public class Beer
    {
        public int BeerId { get; set; }

        public string Title { get; set; }

        public float Average_price { get; set; }

        public virtual Сompany Сompany { get; set; }
    }
}
