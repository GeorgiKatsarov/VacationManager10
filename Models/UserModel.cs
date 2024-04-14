public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }  // First name of the user
    public string LastName { get; set; }   // Last name of the user

    public int RoleId { get; set; }        // Foreign key for Role
    public virtual Role Role { get; set; } // Navigation property for Role

    public int TeamId { get; set; }        // Foreign key for Team
    public virtual Team Team { get; set; } // Navigation property for Team

    // Navigation property for vacation requests made by the user
    public virtual ICollection<Vacation> Vacations { get; set; }
}
