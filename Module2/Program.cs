// See https://aka.ms/new-console-template for more information

using Module2;
//Steps 4-7 below 
var zach = new Student { ID = 001 };
zach.Name = "Zach";
zach.AddGrade(94);
zach.AddGrade(95, 96, 100, 93.5);

var john = new Student { ID = 002 };
john.Name = "John";
john.AddGrade(74);
john.AddGrade(75, 76, 100, 73.5);


var frank = new Student { ID = 003 };
frank.Name = "Frank";
frank.AddGrade(84);
frank.AddGrade(85, 86, 100, 83.5);


var tom = new Student { ID = 004 };
tom.Name = "Tom";
tom.AddGrade(64);
tom.AddGrade(65, 66, 100, 63.5);


var joey = new Student { ID = 005 }; //Added a ID for the students 
joey.Name = "Joey";
joey.AddGrade(95);
joey.AddGrade(95, 96, 100, 93.5);

var students = new List<Student> { zach, john, frank, tom, joey };

foreach (var student in students) //Here is step 8. I choose the foreach because I am working on getting better at using them. 
{
    Console.WriteLine($"Student ID: {student.ID}");
    Console.WriteLine($"Name: {student.Name}");
    
    Console.Write("Grades: ");
    foreach (var grade in student.Grades)
    {
        Console.Write($"{grade} ");
    }
    Console.WriteLine();
    
    Console.WriteLine($"Average Grade: {student.CalculateAverageGrade():F2}");
    Console.WriteLine();
}

var course = new Course
{
    CourseName = "Advanced C# Programming",
    CourseCode = "CSharp 71"
};

course.EnrollStudent(zach);
course.EnrollStudent(john);
course.EnrollStudent(frank);
course.EnrollStudent(tom);
course.EnrollStudent(joey);

// Making sure it picks up the same names 
course.EnrollStudent(zach);
course.EnrollStudent(frank);

Console.WriteLine("--- Course Information ---");
Console.WriteLine($"Course Name: {course.CourseName}");
Console.WriteLine($"Course Code: {course.CourseCode}");
Console.WriteLine();
Console.WriteLine("Enrolled Students:");

foreach (var student in course.EnrolledStudents)
{
    Console.WriteLine($"- {student.Name} (ID: {student.ID})");
}

//Committed and pushed to GitHub so save my work 
