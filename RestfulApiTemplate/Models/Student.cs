﻿namespace RestfulApiTemplate.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public ICollection<StudentCourse> studentcourse { get; set; }


    }
}
