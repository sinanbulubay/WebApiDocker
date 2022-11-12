using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiDocker.Model;

[Table("film")]
public class Film
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("title")]
    public string Title { get; set; } = string.Empty;

    [Required]
    [Column("durationtime")]
    public int DurationTime { get; set; }

    [Required]
    [Column("releaseyear")]
    public int ReleaseYear { get; set; }

    [Required]
    [Column("genreid")]
    public int GenreId { get; set; }

    [Column("genre")]
    public Genre Genre { get; set; } = new();
}