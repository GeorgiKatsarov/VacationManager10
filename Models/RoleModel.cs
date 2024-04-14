public class Role
{
    public int Id { get; set; }       // Unique identifier for the role
    public string Name { get; set; }  // Name of the role (e.g., CEO, Developer, Team Lead, Unassigned)

    // Navigation property for users assigned to this role
    public virtual ICollection<User> Users { get; set; }
}
