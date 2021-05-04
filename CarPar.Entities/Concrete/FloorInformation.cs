using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarPar.Entities.Concrete
{
    public class FloorInformation : BaseModel
    {
        public int Number { get; set; }
        public ICollection<SlotInformation> Slots { get; set; }
    }
}
