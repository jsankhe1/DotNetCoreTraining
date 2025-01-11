namespace Assignment.AssignmentThree.Tasks.TaskThree;

public class Course
{
    public string Name { get; set; }
    private List<Student> Students { get; set; } = new List<Student>();

    public override string ToString()
    {
        return Name;
    }

    public void AddStudent(Student student)
    {
        if (!Students.Contains(student))
        {
            Students.Add(student);
            student.EnrollCourse(this);
        }
    }

    public void RemoveStudent(Student student)
    {
        if (Students.Remove(student)) // Succesfylly found and removed 
        {
            student.DropCourse(this);
            
        } 
        else
        {
            throw new Exception("Student is not enrolled in this course.");
        }
    }
    
    
}