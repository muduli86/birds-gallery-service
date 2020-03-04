using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace birds_gallery_service.Models
{
    public class BirdsModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string[] Images { get; set; }
    }
}
