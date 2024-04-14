public class Vacation
{
    public int Id { get; set; }
    public DateTime FromDate { get; set; }     // Start date of the vacation
    public DateTime ToDate { get; set; }       // End date of the vacation
    public bool IsHalfDay { get; set; }        // Indicates if it's a half-day vacation
    public bool IsApproved { get; set; }       // Indicates if the request is approved
    // File path to the medical certificate for sick leave requests
    public string MedicalCertificate { get; set; }

    public int UserId { get; set; }       // Foreign key for User
    public virtual User User { get; set; } // Navigation property for User
}
