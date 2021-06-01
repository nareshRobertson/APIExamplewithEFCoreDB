using System;
using System.Collections.Generic;

#nullable disable

namespace APIExamplewithEFCoreDB.Models
{
    public partial class Course
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}
