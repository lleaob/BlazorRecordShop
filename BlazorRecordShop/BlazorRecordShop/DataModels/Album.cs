namespace BlazorRecordShop.DataModels
{
    public class Album (int id, string artist, string title, int releaseYear)
    {
        public int Id { get; set; } = id;
        public string Artist { get; set; } = artist;
        public string Title { get; set; } = title;
        public int ReleaseYear { get; set; } = releaseYear;
        public List<string> Tracklist { get; set; } = new List<string>();
        public MusicGenre Genre { get; set; } = MusicGenre.Unkown;
    };
}
