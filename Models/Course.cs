using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1612360017_NguyenThanhDanh.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ApplicationUser Leturre { get; set; }
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        public Byte CategoryId { get; set; }
    }
}

