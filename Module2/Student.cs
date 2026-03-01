using System.Linq;

namespace Module2;

public class Student
{
    public string Name { get; set; } //Property called Name
    public int ID { get; set; } //Property called ID
    public List<double> Grades { get; set; } = new(); //List Property called Grades

    public void AddGrade(double grade) //The first method for grade
    {
        Grades.Add(grade);
    }

public void AddGrade(params double[] grades) //This method is for grades 
    {
        Grades.AddRange(grades);
    }

    public double CalculateAverageGrade()//The method with no parameters that will return the avg or 0
    {
        if (Grades.Count == 0)
        {
            return 0;
        }

        return Grades.Average();
    }
}
