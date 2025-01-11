namespace Assignment.AssignmentThree.Tasks.TaskThree;

public class ObjectOrientedPractice
{
    public void Run()
    {
        var csDepartment = new Department("Computer Science", 5000000m); // m denotes decimal
        var litDepartment = new Department("Literature", 300000m);

        var csDepartmentHead = new Instructor(10000m)
        {
            Name = "Leslie Lander",
            DateOfBirth = new DateTime(1980, 3, 22),
            JoinDate = new DateTime(2005, 6, 12)

        };
        csDepartmentHead.Addresses.Add("Binghamton Professor Lodge");
        csDepartment.AssignHOD(csDepartmentHead);

        var litDepartmentHead = new Instructor(100000m)
        {
            Name = "Hena Sarkar",
            DateOfBirth = new DateTime(1997, 10, 31),
            JoinDate = new DateTime(2022, 08, 17)
        };
            litDepartmentHead.Addresses.Add("Grand Boulevard Ave");
            litDepartment.AssignHOD(litDepartmentHead);
            
            
        
        
        // course creation

        var programmingCourse = new Course { Name = "Programming Languages" };
        var writingCourse = new Course { Name = "Creative Writing" };
        
        csDepartment.AddCourse(programmingCourse);
        litDepartment.AddCourse(writingCourse);
        
        // Create Students

        var student1 = new Student
        {
            Name = "Jay Sankhe",
            DateOfBirth = new DateTime(1997, 6,24),
            
        };

        var student2 = new Student
        {
            Name = "Sowmyadeep Guha",
            DateOfBirth = new DateTime(1997, 7, 23)
        };
        
        programmingCourse.AddStudent(student1);
        writingCourse.AddStudent(student2);
        
        student1.DisplayInfo();
        student2.DisplayInfo();
        
    }
}