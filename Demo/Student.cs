using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public enum Specialty
    {
        None = 0,
        Programming = 1,
        It = 2,
        Design = 3,
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Specialty Specialty { get; set; }

        public Student(int id, string name, string surname, Specialty specialty)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Specialty = specialty;
        }

        //public override string ToString()
        //{
        //    return $"Id:{Id}\nName:{Name}\nSurname:{Surname}\nSpecialty:{Specialty}";
        //}


        public override string ToString()
            => $"Id:{Id}\nName:{Name}\nSurname:{Surname}\nSpecialty:{Specialty}";

    }
}
