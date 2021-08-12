using _07_RepositoryPattern_Repository;
using _08_StreamingContent_Inheritance;
using _11_StreamingContent_UIRefactor.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11_StreamingContent_UIRefactor.UI
{
    class ProgramUI
    {
        private readonly StreamingRepository _repo = new StreamingRepository();

        private IConsole _console;
        
        public ProgramUI(IConsole console)
        {
            _console = console;
        }

        public void Run()
        {
            SeedContent();
            Menu();

        }

        public void SeedContent()
        {
            _console.WriteLine("Seeding contents...");
        }

        public void Menu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                _console.Clear();
                // \n = new line = cr + LF
                // CR = Carriage Return
                // LF = Line Feed
                _console.WriteLine("Menu:\n" + 
                    "1. Show all streaming content\n" + 
                    "2. Find streaming content by title\n" + 
                    "3. Add new streaming content\n" + 
                    "4. Remove Streaming content\n" + 
                    "5. Exit");

                string userInput = _console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        // Show all content
                        break;
                    case "2":
                        // Find by title
                        break;
                    case "3":
                        // Add new content
                        AddNewContent();
                        break;
                    case "4":
                        // Remove content
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        _console.WriteLine("Please enter a valid selection/n" +
                            "Press any key to continue...");
                        _console.ReadKey();
                        break;

                }
            }

            _console.Clear();
            _console.WriteLine("Goodbye!");
            Thread.Sleep(2000);

            //_console.WriteLine("Press any key to exit the program, dude...");
            
            //_console.ReadKey();
        }

        public void AddNewContent()
        {
            _console.Clear();

            StreamingContent content = new StreamingContent();

            bool isValidTitle = false;

            while (!isValidTitle)
            {
                _console.Write("Title: ");
                string title = _console.ReadLine();

                //_console.Title = string.IsNullOrWhiteSpace(title) ? "Untitled" : title;
                if (string.IsNullOrWhiteSpace(title))
                {
                    _console.WriteLine("Please enter a valid title (Press any key to continue)");
                    _console.ReadKey();
                }
                else
                {
                    content.Title = title;
                    isValidTitle = true;
                }

            }
            // Description
            _console.Write("Description: ");
            string description = _console.ReadLine();
            content.Description = string.IsNullOrWhiteSpace(description) ? "(No Description)" : description;

            // Star Rating
            _console.Write("Star Rating (1-5): ");
            double stars = double.Parse(_console.ReadLine());
            if (stars > 5)
            {
                content.StarRating = 5;
            }
            else if (stars < 0)
            {
                content.StarRating = 0;
            }
            else
            {
                content.StarRating = stars;
            }

            // Maturity
            _console.WriteLine("1. G\n" +
                "2. PG\n" +
                "3. PG13\n" +
                "4. R\n" +
                "5. NC17\n" +
                "6. TVMA\n" +
                "7. TVG\n" +
                "8. TVY");
            _console.Write("Maturity Rating: ");
            string maturityInput = _console.ReadLine();
            int maturityId = int.Parse(maturityInput);
            content.MaturityRating = (MaturityRating)maturityId;

            // compile time error gives you a red line, won't build or run
            // run-time error doesn't happen until the code builds and runs

            // Genre
            _console.WriteLine("1. SciFi\n" +
                "2. Comedy\n" +
                "3. Horror\n" +
                "4. RomCom\n" +
                "5. Documentary\n" +
                "6. Western\n" +
                "7. Action");
            _console.Write("Genre: ");
            string genreInput = _console.ReadLine();

            switch (genreInput)
            {
                case "Sci-Fi":
                case "scifi":
                case "1":
                    content.GenreType = GenreType.SciFi;
                    break;
                case "2":
                    content.GenreType = GenreType.Comedy;
                    break;
                case "3":
                    content.GenreType = GenreType.Horror;
                    break;
                case "4":
                    content.GenreType = GenreType.RomCom;
                    break;
                case "5":
                    content.GenreType = GenreType.Documentary;
                    break;
                case "6":
                    content.GenreType = GenreType.Western;
                    break;
                case "7":
                    content.GenreType = GenreType.Action;
                    break;
                default:
                    content.GenreType = 0;
                    break;
            }

            _repo.AddContentToDirectory(content);

        }
    }
}
