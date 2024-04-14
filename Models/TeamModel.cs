public class Team
{
    public int Id { get; set; }
    public string Name { get; set; }        // Name of the team

    public int ProjectId { get; set; }      // Foreign key for Project
    public virtual Project Project { get; set; } // Navigation property for Project

    public int TeamLeadId { get; set; }       // Foreign key for Team Lead
    public virtual User TeamLead { get; set; } // Navigation property for Team Lead

    // Navigation property for developers in the team
    public virtual ICollection<User> Developers { get; set; }
}
