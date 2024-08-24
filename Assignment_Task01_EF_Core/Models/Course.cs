using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Task01_EF_Core.Models
{
    internal class Course
    {

        public int Id { get; set; }
        public string Name { get; set; }
        // Duration of the course represented as a TimeSpan
        public TimeSpan Duration { get; set; }
        public string Description { get; set; }
        public int TopicId { get; set; }
    }
}
