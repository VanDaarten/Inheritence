using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Van";
            person.Age = 20;
            person.GetNameAndAge();

            Teacher teacher = new Teacher();
            teacher.Name = " Daarten";
            teacher.Age = 21;
            teacher.TeacherId = "2278";
            teacher.Subject = "IPA";
            teacher.GetNameAndAge();

            Student student = new Student();
            student.Name = "Pandiangan";
            student.Age = 22;
            student.StudentId = "18.11.2278";
            student.Email = "pandiangan19@amikom.ac.id";
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
