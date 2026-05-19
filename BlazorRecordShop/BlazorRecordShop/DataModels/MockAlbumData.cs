namespace BlazorRecordShop.DataModels
{
    public class MockAlbumData
    {
        public static List<Album> sampleAlbums = new()
        {
            new Album(1, "Pink Floyd", "The Dark Side of the Moon", 1973)
            {
                Genre = MusicGenre.Rock, // Assuming Rock exists in your MusicGenre enum
                Tracklist = new List<string> { "Speak to Me", "Breathe", "Time", "Money" }
            },
            new Album(2, "Daft Punk", "Discovery", 2001)
            {
                Genre = MusicGenre.Electronic,
                Tracklist = new List<string> { "One More Time", "Aerodynamic", "Digital Love" }
            },
            new Album(3, "Miles Davis", "Kind of Blue", 1959)
            {
                Genre = MusicGenre.Jazz,
                Tracklist = new List<string> { "So What", "Freddie Freeloader", "Blue in Green" }
            }
        };
    }
}
