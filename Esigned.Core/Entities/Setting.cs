using Esigned.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esigned.Core.Entities
{
    public class Setting : BaseEntity
    {
        public string AboutImage { get; set; } = null!;
        public string AboutTitle { get; set; } = null!;
        public string AboutDescription { get; set; } = null!;
        public int YearsOfBusiness { get; set; }
        public int Projects { get; set; }
        public int Satisfied { get; set; }
        public int Cofee { get; set; }
        public string Adress { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
