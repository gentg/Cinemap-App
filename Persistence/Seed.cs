
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context){
            if (context.Movies.Any()) return;

            var allMovies = new List<Movie>{
                new Movie{
                    
                    MovieTitle = "The Shawshank Redemption",
                    MovieQuality = "HD",
                    MovieReleaseDate = new DateTime(1994,10,14),
                    MovieDuration = "144",
                    MovieUserVote = 5,
                    MoviePhoto = "https://cdn.onebauer.media/one/empire-tmdb/films/278/images/xBKGJQsAIeweesB79KC89FpBrVr.jpg?format=jpg&quality=80&width=960&height=540&ratio=16-9&resize=aspectfill",
                    MovieCover = "https://occ-0-987-990.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABUQCmg3KKkFHVfXa_QGXW-ihQ7JcpYGwyHviLpsrg_5zzLStiFuI1eDQ5XjxnYNPWhP8wWQdS747Fn_LbVDC7U-paLWG.jpg?r=dac",
                    MovieTrailer = "https://www.youtube.com/watch?v=6hB3S9bIaco",
                    MovieDescription = "Two imprisoned",
                    MovieGenre = "Action",
                    MovieIMDB = 8.5,
                    isTvSHow = false,
                },

                new Movie{
                    
                    MovieTitle = "Room 203",
                    MovieQuality = "HD",
                    MovieReleaseDate = new DateTime(2022,04,15),
                    MovieDuration = "104",
                    MovieUserVote = 2,
                    MoviePhoto = "https://www.stagatv.com/wp-content/uploads/2022/04/1650053604-7086-t4M0n5kfToiU9TIf22bccSbNugG.jpg",
                    MovieCover = "https://variety.com/wp-content/uploads/2020/12/Room2034-cr-res.jpg",
                    MovieTrailer = "https://www.youtube.com/watch?v=6hB3S9bIaco",
                    MovieDescription = "Two female roommates were tormented by the vengeful spirits dwelling in their gothic-style, rented apartment, which contains an ornate centerpiece.",
                    MovieGenre = "Horror",
                    MovieIMDB = 5.5,
                    isTvSHow = false,
                }, 

                new Movie {
                    MovieTitle = "The Dark Knight",
                    MovieQuality = "HD",
                    MovieReleaseDate = new DateTime(2008,07,16),
                    MovieDuration = "152",
                    MovieUserVote = 5,
                    MoviePhoto = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg",
                    MovieCover = "https://hbomax-images.warnermediacdn.com/images/GXdkpqAvyDaXCPQEAADdn/tileburnedin?size=1280x720&partner=hbomaxcom&v=7f7f8054cb4fe42c3e93d57de2eb0dfb&language=en-us&host=art-gallery.api.hbo.com&w=Infinity",
                    MovieTrailer = "https://www.youtube.com/watch?v=kmJLuwP3MbY",
                    MovieDescription = "The stakes are raised by batman . With the help of Lt. Jim Gordon and District Attorney Harvey Dent, Batman sets out to dismantle the remaining criminal associations which irritate the roads. They soon are prey to your reign of insanity unleashed by a criminal mastermind known to the citizens of Gotham since the Joker, although the venture proves to be effective.",
                    MovieGenre = "Action",
                    MovieIMDB = 9.0,
                    isTvSHow = false,
                },   

                new Movie {
                    MovieTitle = "The Lord of the Rings: The Return of the King",
                    MovieQuality = "HD",
                    MovieReleaseDate = new DateTime(2003,12,01),
                    MovieDuration = "201",
                    MovieUserVote = 5,
                    MoviePhoto = "https://images.moviesanywhere.com/45bc0ec075bfc0b4d8f184a7cc5bf993/876ed805-83b1-4387-b0d0-62d08c36536d.jpg",
                    MovieCover = "https://www.sfu.ca/~omossad/fat_albert/figures/lotr.jpg",
                    MovieTrailer = "https://www.youtube.com/watch?v=co9SNfJNDN8",
                    MovieDescription = "Aragorn is revealed since Gandalf, he and the other members of the fellowship struggle to save Gondor from Sauron's forces. Meanwhile, Sam and Frodo attract into the heart of Mordor, the dark lord's domain.",
                    MovieGenre = "Fantasy",
                    MovieIMDB = 9.0,
                    isTvSHow = false,
                }, 

                new Movie {
                    MovieTitle = "Pulp Fiction",
                    MovieQuality = "SD",
                    MovieReleaseDate = new DateTime(1994,09,10),
                    MovieDuration = "154",
                    MovieUserVote = 3,
                    MoviePhoto = "https://www.miramax.com/media/assets/Pulp-Fiction1.png",
                    MovieCover = "https://i.ytimg.com/vi/pY2C98CWj8k/maxresdefault.jpg",
                    MovieTrailer = "https://www.youtube.com/watch?v=kmJLuwP3MbY",
                    MovieDescription = "His partner A struck man, also a drug-addled gangster's moll and also a washedup boxer converge in the humorous crime caper. Their experiences unfurl in three stories which ingeniously trip forward and backward in time.",
                    MovieGenre = "Crime",
                    MovieIMDB = 8.9,
                    isTvSHow = false,
                },

                new Movie {
                    MovieTitle = "Fight Club",
                    MovieQuality = "SD",
                    MovieReleaseDate = new DateTime(1999,10,15),
                    MovieDuration = "139",
                    MovieUserVote = 4,
                    MoviePhoto = "https://www.flore-maquin.com/wp-content/uploads/Fight_club_RVB_72.jpg",
                    MovieCover = "https://hotcorn-cdn.s3.amazonaws.com/wp-content/uploads/sites/5/2019/08/23093932/fight-club-59901d1c111c5.jpg",
                    MovieTrailer = "https://www.youtube.com/watch?v=BdJKm16Co6M",
                    MovieDescription = "A ticking-time-bomb insomniac and a slippery soap salesman channel primal male aggression into a shocking new form of therapy. Their concept catches on, with underground `fight clubs` forming in every town, until an eccentric has got in the way and ignites an all-star spiral toward oblivion.",
                    MovieGenre = "Drama",
                    MovieIMDB = 8.8,
                    isTvSHow = false,
                },

                new Movie {
                    MovieTitle = "One Piece: Stampede",
                    MovieQuality = "HD",
                    MovieReleaseDate = new DateTime(2019,08,09),
                    MovieDuration = "101",
                    MovieUserVote = 5,
                    MoviePhoto = "https://m.media-amazon.com/images/M/MV5BM2MxY2QwYTAtMDM1My00MTc0LWEwZjktMDdjODY2NWJiNDg2XkEyXkFqcGdeQXVyODY3ODQ2MTk@._V1_.jpg",
                    MovieCover = "https://www.denofgeek.com/wp-content/uploads/2019/10/one_piece_stampede_movie_review_anime.jpg?resize=768%2C432",
                    MovieTrailer = "https://www.youtube.com/watch?v=S8_YwFLCh4U",
                    MovieDescription = "One Piece: Stampede is a stand-alone film that celebrates the anime's 20th Anniversary and takes place outside the canon of the `One Piece` TV series. Monkey D. Luffy and his Straw Hat pirate crew are invited to a massive Pirate Festival that brings many of the most iconic characters from throughout the franchise to participate in competition with the Straw Hats to find Roger's treasure. It also pits the Straw Hats against a new enemy named Bullet, a former member of Roger's crew.",
                    MovieGenre = "Anime",
                    MovieIMDB = 7.6,
                    isTvSHow = false,
                },
        };

        await context.Movies.AddRangeAsync(allMovies);
        await context.SaveChangesAsync();

    }
}
}