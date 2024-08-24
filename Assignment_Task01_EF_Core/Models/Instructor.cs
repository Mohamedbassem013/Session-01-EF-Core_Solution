using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Task01_EF_Core.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Bonus { get; set; }
        public double Salary { get; set; }
        public double HourlyRate { get; set; }
        public int DepartmentId { get; set; }
    }
}
