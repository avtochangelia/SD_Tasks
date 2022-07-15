namespace Tasks.EFCore.Models;

public class Teacher
{
    public int TeacherID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public string Subject { get; set; }
    public ICollection<TeacherPupil> TeacherPupils { get; set; }
}
