using Esigned.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esigned.Core.Entities
{
    public class Position : BaseEntity
    {
        public string Image { get; set; } = null!;
        public HashSet<Testimonial> Testimonials { get; set; }
        public Position()
        {
            Testimonials = new HashSet<Testimonial>();
        }
    }
}
