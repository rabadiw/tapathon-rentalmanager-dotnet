using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentalManager.Rental;

public class RentalDbContext : DbContext
{
    public RentalDbContext(DbContextOptions<RentalDbContext> options) : base(options)
    {
        
    }
    public DbSet<RentalEntity>? RentalData { get; set; }
}

public class RentalEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    public RentalState State { get; set; }
}

public enum RentalState
{
    Available = 0,
    Reserved,
    PickedUp,
    DroppedOff
}