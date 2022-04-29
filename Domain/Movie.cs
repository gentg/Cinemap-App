using System;
namespace Domain{
    public class Movie{

    public Guid Id { get; set; }
    public string MovieTitle { get; set; }

    public string MovieQuality { get; set; }

    public DateTime MovieReleaseDate { get; set; }

    public string MovieDuration { get; set; }

    public int MovieUserVote { get; set; }

    public string MoviePhoto { get; set; }

    public string MovieCover { get; set; }

    public string MovieTrailer { get; set; }

    public string MovieDescription { get; set; }

    public string MovieGenre { get; set; }

    public double MovieIMDB { get; set; }

    public Boolean isTvSHow { get; set; }


    
    }
}