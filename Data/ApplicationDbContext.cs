using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace VacationManager_.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Vacation> Vacations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure User-Role relationship
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)                  // Each user has one role
                .WithMany(r => r.Users)               // One role can have many users
                .HasForeignKey(u => u.RoleId);       // Foreign key property in the User table

            // Configure Team-Project relationship
            modelBuilder.Entity<Team>()
                .HasOne(t => t.Project)               // Each team belongs to one project
                .WithMany(p => p.Teams)               // One project can have many teams
                .HasForeignKey(t => t.ProjectId);     // Foreign key property in the Team table

            // Configure Team-User (Team Lead) relationship
            modelBuilder.Entity<Team>()
                .HasOne(t => t.TeamLead)              // Each team has one team lead
                .WithMany()                           // Team lead can lead multiple teams
                .HasForeignKey(t => t.TeamLeadId);   // Foreign key property in the Team table

            // Configure User-Team (Developers) relationship
            modelBuilder.Entity<User>()
                .HasOne(u => u.Team)                  // Each user belongs to one team
                .WithMany(t => t.Developers)          // One team can have many developers
                .HasForeignKey(u => u.TeamId);       // Foreign key property in the User table

            // Configure User-Vacation relationship
            modelBuilder.Entity<Vacation>()
                .HasOne(v => v.User)                  // Each vacation belongs to one user
                .WithMany(u => u.Vacations)           // One user can have many vacations
                .HasForeignKey(v => v.UserId);       // Foreign key property in the Vacation table

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserLogin<string>>()
                    .HasKey(l => new { l.LoginProvider, l.ProviderKey });

            modelBuilder.Entity<Project>()
           .HasKey(p => p.Id);
        }
    }


}