namespace HelloWorld.Models
{
    // complete domain model which means that there is nothing to do with "presentation"
    public class Playlist 
    {
        public string Title { get; set; }       
        public bool IsFavorite { get; set; }
    }
}
