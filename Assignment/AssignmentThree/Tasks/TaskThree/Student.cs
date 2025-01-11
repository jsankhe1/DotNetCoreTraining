namespace Assignment.AssignmentThree.Tasks.TaskThree;

public class Student : Person
{
    public decimal Gpa { get; set; }
    public List<Course> Courses { get; private set; } = new List<Course>();
    private Dictionary<Course, GradePoint> Grades { get; set; } = new Dictionary<Course, GradePoint>();

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Enrolled Courses: {string.Join(",", GetEnrolledCourses())}");
    }
    

    public void EnrollCourse(Course course)
    {
        // if we are not in the course
        if (!Courses.Contains(course))
        {
            Courses.Add(course);
            course.AddStudent(this);
        }
    }

    public void DropCourse(Course course)
    {
        if (Courses.Remove(course))
        {
            course.RemoveStudent(this);
        }
        else
        {
            throw new Exception("Student is not enrolled in this course.");
        }
    }

    public void AssignGrade(Course course, GradePoint grade)
    {
        if (Courses.Contains(course))
        {
            Grades[course] = grade;
        }
        else
        {
            throw new Exception("Student is not enrolled in this course");
        }
    }

    public double CalculateGpa()
    {
        if (Grades.Count == 0)
        {
            return 0.0;
        }

        double totalPoints = 0;

        foreach (var grade in Grades.Values)
        {
            totalPoints += (int)grade;
        }

        return totalPoints / Grades.Count;
    }
    // Get list of courses

    public List<Course> GetEnrolledCourses()
    {
        return new List<Course>(Courses);
    }
    



}