using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class StudentStore
    {
        private readonly List<Student> students = new();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public Student GetById(int id)
        {
            foreach(Student student in students)
            {
                if(student.Id == id)
                {
                    return student;
                }
               
            }
            return null;
        }
        public List<Student>  GetAll()
        {
            return students;
        }
        public void remove(int id)
        {
            foreach (Student student in students)
            {
                if (student.Id == id)
                    students.Remove(student);
            }
        }
    }
}
