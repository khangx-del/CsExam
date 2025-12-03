using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.cs
{
    internal class Program
    {
        class Game 
        { 
            private string name;
            private string publisher;
            private int Years;
            private string genre;
            public Game(string name, string publisher, int Years, string genre) 
            { 
                this.name = name;
                this.publisher = publisher;
                this.Years = Years;
                this.genre = genre;
            }
            public void SetName (string name)
            { 
                this.name = !string.IsNullOrEmpty(name) ? name : "Invalid game name";   
            }
            public string GetName()
            {
                return name;
            }
            public void SetPublisher(string publisher)
            {
                this.publisher = !string.IsNullOrEmpty(publisher) ? publisher : "Invalid publisher name";
            }
            public string GetPublisher()
            {
                return publisher;
            }
            public void SetYears(int Years)
            {
                this.Years = (Years > 1950 && Years <= DateTime.Now.Year) ? Years : 0;
            }
            public int GetYears()
            {
                return Years;
            }
            public void SetGenre(string genre)
            {
                this.genre = !string.IsNullOrEmpty(genre) ? genre : "Invalid genre";
            }
            public string GetGenre()
            {
                return genre;
            }
            public string GetGameInfo()
            {
                return $"Name: {name}, Publisher: {publisher}, Year: {Years}, Genre: {genre}";
            }   
        }
                    
        static void Main(string[] args)
        {
            List<Game> games = new List<Game>
            {
                new Game ("Bloons 6", "Ninja Kiwi",2018, "Tower Defense"),
                new Game("The Legend of Zelda: Breath of the Wild", "Nintendo", 2017, "Action-adventure") 
               
            };           
        }
    }
}
