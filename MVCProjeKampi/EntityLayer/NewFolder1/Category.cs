using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.NewFolder1
{
    class Category
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescripion { get; set; }

        public bool CategoryStatus { get; set; }

        public ICollection<Heading> Headings { get; set; }
    }
}
