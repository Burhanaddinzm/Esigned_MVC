using Esigned.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esigned.Core.Entities
{
    public class Slider : BaseEntity
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
