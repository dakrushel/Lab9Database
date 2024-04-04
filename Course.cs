using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Database
{
    public class Course
    {
        [Required, PrimaryKey]
        public int CourseId { get; set; }

        [Required]
        public string Name { get; set; }

        public int Credits { get; set; }

        public Course() { }
        public Course(int courseId, string name, int credits)
        {
            CourseId = courseId;
            Name = name;
            Credits = credits;
        }

        public override string ToString()
        {
            return $"Course ID: {CourseId}\n" +
                $"Name: {Name}\n" +
                $"Credits: {Credits}\n";
        }
    }
}
