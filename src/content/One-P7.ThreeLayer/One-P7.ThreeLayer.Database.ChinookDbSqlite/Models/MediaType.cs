namespace One_P7.ThreeLayer.Database.ChinookDbSqlite.Models;

public partial class MediaType
{
    public int MediaTypeId { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Track> Tracks { get; set; } = new List<Track>();
}