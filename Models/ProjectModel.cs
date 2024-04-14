public class Project
{
    public int Id { get; set; }
    public string Name { get; set; }           // Name of the project
    public string Description { get; set; }    // Description of the project

    // Navigation property for teams working on this project
    public virtual ICollection<Team> Teams { get; set; }
}
