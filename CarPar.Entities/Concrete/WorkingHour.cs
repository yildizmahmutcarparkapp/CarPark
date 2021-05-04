using System;
using System.Collections.Generic;
using System.Text;

namespace CarPar.Entities.Concrete
{
    public class WorkingHour
    {
        public ICollection<Translation> Translation { get; set; }
    }
}
