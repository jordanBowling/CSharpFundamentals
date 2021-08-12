using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public bool IsFamilyFriendly { get 
            {
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.PG13:
                    case MaturityRating.TVG:
                    case MaturityRating.TVY:
                        return true;
                    //case MaturityRating.R:
                    //case MaturityRating.NC17:      //  Not needed
                    //case MaturityRating.TVMA:
                    //    return false;
                    default:
                        return false;
                    
                }
            } }
        public GenreType GenreType { get; set; }
        public StreamingContent() { }
        public StreamingContent(string title, string description, MaturityRating maturityRating, double stars, GenreType genre)
        {
          
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = stars;
            //IsFamilyFriendly = familyFriendly;  // We got rid oif the setter so we do not need this anymore
            GenreType = genre;
        }   

        // Refactor the class so that IsFamilyFriendly always gives the right answer
    }
}
//public enum FamilyFriendlyRatings {G, PG, TVG }

public enum MaturityRating { G, PG, PG13, R, NC17, TVMA, TVG, TVY }

public enum GenreType { SciFi = 1, Comedy, Horror, RomCom, Documentary, Western, Action}