using System;
using System.Collections.Generic;

// Base class for Person
public class Person
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
}

// Derived class for Student
public class Student : Person
{
    public int StudentID { get; set; }
    public List<Course> Courses { get; set; }

    public void EnrollCourse(Course course)
    {
        Courses.Add(course);
    }
}

// Derived class for Teacher
public class Teacher : Person
{
    public int TeacherID { get; set; }
    public List<Course> Courses { get; set; }

    public void AssignCourse(Course course)
    {
        Courses.Add(course);
    }
}

// Course class
public class Course
{
    public string CourseName { get; set; }
    public int CourseID { get; set; }
}

// School class
public class School
{
    public List<Student> Students { get; set; }
    public List<Teacher> Teachers { get; set; }
    public List<Course> Courses { get; set; }

    public School()
    {
        Students = new List<Student>();
        Teachers = new List<Teacher>();
        Courses = new List<Course>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void AddTeacher(Teacher teacher)
    {
        Teachers.Add(teacher);
    }

    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create School
        School school = new School();

        // Create and add students
        Student student1 = new Student { StudentID = 1, Name = "John", Address = "123 Main St", Phone = "123-456-7890" };
        Student student2 = new Student { StudentID = 2, Name = "Alice", Address = "456 Elm St", Phone = "456-789-0123" };
        school.AddStudent(student1);
        school.AddStudent(student2);

        // Create and add teachers
        Teacher teacher1 = new Teacher { TeacherID = 1, Name = "Mr. Smith", Address = "789 Oak St", Phone = "789-012-3456" };
        Teacher teacher2 = new Teacher { TeacherID = 2, Name = "Ms. Johnson", Address = "345 Pine St", Phone = "234-567-8901" };
        school.AddTeacher(teacher1);
        school.AddTeacher(teacher2);

        // Create and add courses
        Course course1 = new Course { CourseID = 1, CourseName = "Math" };
        Course course2 = new Course { CourseID = 2, CourseName = "Science" };
        school.AddCourse(course1);
        school.AddCourse(course2);

        // Assign courses to teachers
        teacher1.AssignCourse(course1);
        teacher2.AssignCourse(course2);

        // Enroll students in courses
        student1.EnrollCourse(course1);
        student2.EnrollCourse(course2);

        // Example usage
        Console.WriteLine("School Management System Demo:");
        Console.WriteLine("Students:");
        foreach (var student in school.Students)
        {
            Console.WriteLine($"Student ID: {student.StudentID}, Name: {student.Name}, Courses: {string.Join(", ", student.Courses.Select(c => c.CourseName))}");
        }

        Console.WriteLine("Teachers:");
        foreach (var teacher in school.Teachers)
        {
            Console.WriteLine($"Teacher ID: {teacher.TeacherID}, Name: {teacher.Name}, Courses: {string.Join(", ", teacher.Courses.Select(c => c.CourseName))}");
        }

        Console.ReadLine();
    }
}
