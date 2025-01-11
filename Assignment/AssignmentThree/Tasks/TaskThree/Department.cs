namespace Assignment.AssignmentThree.Tasks.TaskThree;

public class Department
{
    public string Name { get; private set; }
    public Instructor HeadOfDepartment { get; set; }
    public DateTime SchoolStartYear { get; set; }
    public DateTime SchoolEndYear { get; set; }
    
    private decimal Budget { get;  set; }
    private List<Course> Courses { get; set; } = new List<Course>();

    public Department(string name, decimal initialBudget)
    {
        Name = name;
        Budget = initialBudget >= 0 ? initialBudget : throw new ArgumentException("intial budget can't be negative");
    }

    public void AssignHOD(Instructor instructor)
    {
        if (instructor == null)
        {
            throw new ArgumentNullException(nameof(instructor), "Head of Department can't be null");
        }

        HeadOfDepartment = instructor;
    }

    public void AddCourse(Course course)
    {
        if (course == null)
        {
            throw new ArgumentNullException(nameof(course), "Course can't be null");
        }
        Courses.Add(course);
        
    }

    public void RemoveCourse(Course course)
    {
        if (!Courses.Remove(course))
        {
            throw new ArgumentException("Course isn't part of the department, can't remove what doesn't exist");
        }
    }

    public void UpdateBudget(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Budget can't be below zero, wow, you're tryna be cheap");
        }
    }
    
    

}