using System;
using System.Collections.Generic;
using System.Text;

namespace Projection_Operation
{
    class EmployeeDto
    {
        public string Name { get; set; }
        public int TotalSkills { get; set; }
        public override string ToString()
        {
            return $"{Name}\t {TotalSkills}";
        }
    }
}
