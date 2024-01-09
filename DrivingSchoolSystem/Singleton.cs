using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchoolSystem
{
    class Singleton
    {
        static List<Student> students = new List<Student>
        {
            new Student(1234, "John Doe", "john@mail.com", "123456789", "Male", new DateTime(2000, 5, 15)),
            new Student(2345, "Max Smith", "smith@mail.com", "987654321", "Female", new DateTime(1999, 8, 22)),
            new Student(3456, "Kelly Johnson", "kelly@mail.com", "456123789", "Female", new DateTime(2001, 10, 10)),
            new Student(4567, "Bobby Williams", "bobby@mail.com", "789456123", "Male", new DateTime(2002, 4, 5)),
            new Student(5678, "Eva Brown", "eva@mail.com", "369852147", "Female", new DateTime(2003, 7, 18))
        };

        public static List<Student> Students { get => students; set => students = value; }


        static List<Course> courses = new List<Course>
        {
            new Course(1, "Introductory", 50.00m),
            new Course(2, "Standard", 70.00m),
            new Course(3, "Pass Plus", 90.00m),
            new Course(4, "Driving Test", 100.00m)
        };

        public static List<Course> Courses { get => courses; set => courses = value; }

        static List<Instructor> instructors = new List<Instructor>
        {
            new Instructor(1, "Alex Smith", "john@mail.com", "123-456-7890", "Emergency Maneuvers"),
            new Instructor(2, "Alice Johnson", "alice@mail.com", "987-654-3210", "Parallel Parking Techniques"),
            new Instructor(3, "Michael Davis", "michael@mail.com", "456-789-1230", "Highway Driving Skills"),
            new Instructor(4, "Sara Brown", "sara@mail.com", "789-123-4560", "Night Time Driving"),
            new Instructor(5, "David Wilson", "david@mail.com", "369-852-1470", "City Driving Expert"),
            new Instructor(6, "Emily Garcia", "emily@mail.com", "951-753-8520", "Emergency Maneuvers"),
            new Instructor(7, "Andrew Miller", "andrew@mail.com", "258-963-7410", "Road Safety"),
            new Instructor(8, "Olivia Martinez", "olivia@mail.com", "753-951-8520", "Parking Techniques"),
            new Instructor(9, "Daniel Thompson", "daniel@mail.com", "159-357-8520", "Road Safety"),
            new Instructor(10, "Sophia Clark", "sophia@mail.com", "852-369-1470", "Road Safety")
        };

        public static List<Instructor> Instructors { get => instructors; set => instructors = value; }


    }
}
