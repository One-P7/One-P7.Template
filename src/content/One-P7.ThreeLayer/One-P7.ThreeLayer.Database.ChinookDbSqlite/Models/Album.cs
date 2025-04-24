namespace One_P7.ThreeLayer.Database.ChinookDbSqlite.Models;

public partial class Album
{
    public int AlbumId { get; set; }

    public string Title { get; set; }

    public int ArtistId { get; set; }

    public virtual Artist Artist { get; set; }

    public virtual ICollection<Track> Tracks { get; set; } = new List<Track>();
}