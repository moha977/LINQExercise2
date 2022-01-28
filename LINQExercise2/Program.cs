using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    using method syntax, create a list of video games of your choice…
            var VideoGames = new List<string> { "GTA", "Fifa", "Call Of Duty", "Commandos", "PUPG" };

            //order the list of games by the length of the game’s names...
            //be sure to use the lambda expression in this exercise!

            var byName = VideoGames.OrderBy(x => x.Length);
           foreach(var game in byName)
            Console.WriteLine(game);
            Console.WriteLine();
            Console.WriteLine();

            //bonus - try to use each of these methods on your list of video games
            //use the list of linq methods for help

           var usingWhere = VideoGames.Where(x => x.Length > 4);
            foreach(var game2 in usingWhere)
                Console.WriteLine(game2);
                Console.WriteLine();
                Console.WriteLine();

            var usingSum = VideoGames.Sum(x => x.Length);

                Console.WriteLine(usingSum);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var usingSelect = VideoGames.Select(x => x.Length);
            foreach (var game3 in usingSelect)
            Console.WriteLine(game3);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var usingAverage = VideoGames.Average(x => x.Length);
            Console.WriteLine(usingAverage);
          

        }

    }

}



