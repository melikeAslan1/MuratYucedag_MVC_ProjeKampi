using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.NewFolder1
{
    class Writer
    {
        [Key]
        public int WriterID { get; set; }

        public string WriterName { get; set; }

        public string Writersurname { get; set; }

        public string WriterMail { get; set; }

        public string writerPassword { get; set; }

        public ICollection<Heading> Headings { get; set; }

        public ICollection<Content> Contents { get; set; }

    }
}
