namespace Tasks.EFCore.Models;

public class Pupil
{
    public int PupilID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public int Class { get; set; }
    public ICollection<TeacherPupil> TeacherPupils { get; set; }
}