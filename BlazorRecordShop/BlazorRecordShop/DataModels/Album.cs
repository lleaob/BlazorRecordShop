using System.ComponentModel.DataAnnotations;
namespace BlazorRecordShop.DataModels
{
    public class Album (int id, string artist, string title, int releaseYear)
    {
        public int Id { get; set; } = id;
        [Required]
        public string Artist { get; set; } = artist;
        [Required]
        public string Title { get; set; } = title;
        [Required]
        [Range(1948,2200)]
        public int ReleaseYear { get; set; } = releaseYear;
        public List<string> Tracklist { get; set; } = new List<string>();
        public MusicGenre Genre { get; set; } = MusicGenre.Unkown;
    };
}
