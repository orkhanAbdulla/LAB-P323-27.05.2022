using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_P323_27._05._2022
{
    class Group
    {
        public string No { get; set; }
        public Student[] students;
        public Group()
        {
            students = new Student[0];
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
    }
}
