using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public Group(int id, string name, List<Student> students)
        {
            Id = id;
            Name = name;
            Students = students;
        }
    }
}
