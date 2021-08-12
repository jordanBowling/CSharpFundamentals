using _07_RepositoryPattern_Repository;
using _08_StreamingContent_Inheritance.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Inheritance
{
    public class StreamingRepository : StreamingContentRepository 
    {
        public Show GetShowByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                // if (content is Show && ...
                if (content.GetType() == typeof(Show) && content.Title == title )
                {
                    return (Show) content;
                }
            }

            return null;
            // Fancy Linq way
            //return (Show)_contentDirectory.FirstOrDefault(s => s is Show && s.Title == title);
        }

        public Movie GetMovieByTitle(string title)
        {
            return (Movie)_contentDirectory.FirstOrDefault(s => s is Movie && s.Title == title);
        }

        public List<Show> GetAllShows()
        {
            List<Show> allShows = new List<Show>(); //making an empty list
            foreach(StreamingContent content in _contentDirectory)
            {
                if (content is Show)
                {
                    allShows.Add((Show)content);
                }
            }
            return allShows;

            //Linq
            // Cast = convert a type to another compatible type
            // return _contentDirectory.Where(s => s is Show).Cast<Show>().ToList();

           

        }

        public List<Movie> GetAllMovies()
        {
            return _contentDirectory.Where(s => s is Movie).Cast<Movie>().ToList();
        }

        // Challenges

        // Get Movies by Rating

        public List<Movie> GetMoviesByStarRating(double rating)
        {
            return GetAllMovies().Where(m => m.StarRating >= rating).ToList();
        }
        
        public List<Movie> GetMoviesByMaturityRating(MaturityRating rating)
        {
            return _contentDirectory.Where(s => s is Movie && s.MaturityRating == rating).Cast<Movie>().ToList();

        }

        // Get Shows by Rating
        public List<Show> GetShowsByMaturityRating(MaturityRating rating)
        {
            return _contentDirectory.Where(s => s is Show && s.MaturityRating == rating).Cast<Show>().ToList();
        }

        public List<Show> GetShowsByStarRating(double rating)
        {
            return GetAllShows().Where(m => m.StarRating >= rating).ToList();
        }

        // Get Movies by Genre
        public List<Movie> GetMoviesByGenre(GenreType genre)
        {
            return _contentDirectory.Where(s => s is Movie && s.GenreType == genre).Cast<Movie>().ToList();
        }

        // Get Shows by Genre
        public List<Show> GetShowsByGenre(GenreType genre)
        {
            return _contentDirectory.Where(s => s is Show && s.GenreType == genre).Cast<Show>().ToList();
        }

    }
}
