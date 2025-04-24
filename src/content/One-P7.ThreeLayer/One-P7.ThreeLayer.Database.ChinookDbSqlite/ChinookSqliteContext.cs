using Microsoft.EntityFrameworkCore;
using One_P7.ThreeLayer.Database.ChinookDbSqlite.Models;

namespace One_P7.ThreeLayer.Database.ChinookDbSqlite;

public partial class ChinookSqliteContext : DbContext
{
    public ChinookSqliteContext(DbContextOptions<ChinookSqliteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Album> Albums { get; set; }

    public virtual DbSet<Artist> Artists { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceLine> InvoiceLines { get; set; }

    public virtual DbSet<MediaType> MediaTypes { get; set; }

    public virtual DbSet<Playlist> Playlists { get; set; }

    public virtual DbSet<Track> Tracks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new Models.Configurations.AlbumConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ArtistConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.EmployeeConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.GenreConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.InvoiceConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.InvoiceLineConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.MediaTypeConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.PlaylistConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.TrackConfiguration());

        this.OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
