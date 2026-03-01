using System.Linq;

namespace Module2;

public class Course
{
    public Course()
    {
        EnrolledStudents = new List<Student>();
    }

    public string CourseName { get; set; }
    public string CourseCode { get; set; }
    
    
    public List<Student> EnrolledStudents { get; set; }

    public void EnrollStudent(Student student)
    {
        if (!EnrolledStudents.Any(s => s.ID == student.ID))
        {
            EnrolledStudents.Add(student);
        }
    }
}
