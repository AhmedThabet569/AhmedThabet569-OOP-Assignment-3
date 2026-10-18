using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class _coursestore
    {
        private readonly List<Course> _courses;
        public void Addcourse(Course _course)
        {
            _courses.Add(_course);
        }

        public Course GetById(int id)
        {
            foreach (Course course in _courses)
            {
                if (course.Id == id)
                {
                    return course;
                }

            }
            return null;
        }
        public List<Course> GetAll()
        {
            return _courses;
        }
        public void remove(int id)
        {
            foreach (Course course in _courses)
            {
                if (course.Id == id)
                    _courses.Remove(course);
            }
        }
    }
}
