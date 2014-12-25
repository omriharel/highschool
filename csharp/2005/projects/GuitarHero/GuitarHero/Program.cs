using System;

namespace GuitarHero
{
    class Program
    {
        static ConsoleKeyInfo cki = new ConsoleKeyInfo();
        static string version = "v0.2";
        static int numOfSongs;
        static int numOfPlayers;
        static string userInput;
        static Song[,] songs;
        static Player[] players;
        static bool quit = false;

        static void Main(string[] args)
        {
            initialize();
            do
            {
                mainScreen();
            }
            while (quit == false);
        }

        static void initialize()
        {
            Console.Title = "Guitar Hero Score Manager " + version;
            Console.WriteLine("Guitar Hero Score Manager " + version + " by Omri Harel and Roy Ovadia.");
            do
            {
                Console.WriteLine("Please enter the number of players: (1 or more)");
                try
                {
                    numOfPlayers = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid value, please try again.");
                    continue;
                }
                if (numOfPlayers < 1)
                {
                    Console.WriteLine("You can't have zero or less players. Try again.");
                    numOfPlayers = 0;
                }
            }
            while (numOfPlayers < 1);
            do
            {
                Console.WriteLine("Please enter the number of songs each player would play: (1 or more)");
                try
                {
                    numOfSongs = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid value, please try again.");
                    continue;
                }
                if (numOfSongs < 1)
                {
                    Console.WriteLine("You can't have zero or less songs. Try again.");
                    numOfSongs = 0;
                }
            }
            while (numOfSongs < 1);

            songs = new Song[numOfPlayers, numOfSongs];
            players = new Player[numOfPlayers];

            for (int i = 0; i < players.Length; i++)
            {
                Console.WriteLine("Enter the name of player number " + (i+1) + ":");
                players[i] = new Player();
                players[i].playerId = i;
                players[i].name = Console.ReadLine();
                players[i].playedSongs = 0;
            }

            Console.Clear();
        }

        static void mainScreen()
        {
            Console.WriteLine("This is the main screen, follow the instructions to proceed.");
            Console.WriteLine("The current players are:");
            for (int i = 0; i < players.Length; i++)
            {
                Console.WriteLine("(" + (i + 1) + ") " + players[i].name);
            }
            Console.WriteLine("To add a new song, press N.");
            Console.WriteLine("To display the results, press D.");
            Console.WriteLine("To exit, press Esc.");
            cki = Console.ReadKey();
            switch (cki.Key)
            {
                case ConsoleKey.N:
                    addSong();
                    break;
                case ConsoleKey.D:
                    displayResults();
                    break;
                case ConsoleKey.Escape:
                    quit = true;
                    break;
            }
            Console.Clear();
        }

        static void addSong()
        {
            Console.Clear();
            Console.WriteLine("Who plays the song? (Enter the corresponding number)");
            for (int i = 0; i < players.Length; i++)
            {
                Console.WriteLine("(" + (i + 1) + ") " + players[i].name);
            }
            int playerId = 0;
            do
            {
                try
                {
                    playerId = int.Parse(Console.ReadLine()) - 1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number. Please try again.");
                    continue;
                }
                if (playerId < 0 || playerId >= players.Length)
                {
                    Console.WriteLine("Enter a number between 1 and " + players.Length + ".");
                    continue;
                }
            }
            while (playerId < 0 || playerId >= players.Length);

            if (!(players[playerId].playedSongs >= numOfSongs))
            {
                songs[playerId, (players[playerId].playedSongs)] = new Song();
                Console.WriteLine("Enter the song's name:");
                songs[playerId, (players[playerId].playedSongs)].name = Console.ReadLine();
                Console.WriteLine("Which difficulty? (Enter the corresponding number)\n(1) Easy\n(2) Medium\n(3) Hard \n(4) Expert");
                int difficulty = 0;
                do
                {
                    try
                    {
                        difficulty = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid number. Please try again.");
                        continue;
                    }
                    if (difficulty < 1 || difficulty > 4)
                    {
                        Console.WriteLine("Enter a number between 1 and 4.");
                        continue;
                    }
                    songs[playerId, (players[playerId].playedSongs)].difficultyInt = difficulty;
                }
                while (difficulty < 1 || difficulty > 4);
                Console.WriteLine("Succeeded? (y/n)");
                cki = Console.ReadKey(true);
                bool succeeded = ((cki.Key == ConsoleKey.Y) ? true : false);
                if (succeeded)
                {
                    Console.WriteLine("How many stars did " + players[playerId].name + " get? (3-5)");
                    int stars = 0;
                    do
                    {
                        try
                        {
                            stars = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid number. Please try again.");
                            continue;
                        }
                        if (stars < 3 || stars > 5)
                        {
                            Console.WriteLine("Enter a number between 3 and 5.");
                            continue;
                        }
                    }
                    while (stars < 3 || stars > 5);
                    songs[playerId, (players[playerId].playedSongs)].stars = stars;
                    Console.WriteLine("How many percent?");
                    int percent = 0;
                    do
                    {
                        try
                        {
                            percent = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid number. Please try again.");
                            continue;
                        }
                        if (percent < 70 || percent > 100)
                        {
                            Console.WriteLine("You can't get less than 70% without failing, or more than 100%.");
                            continue;
                        }
                    }
                    while (percent < 70 || percent > 100);
                    songs[playerId, (players[playerId].playedSongs)].percent = percent;
                    int songScore = 0;
                    songScore += ((stars - 1) * 100);
                    songScore += ((percent - 70) * 20);
                    players[playerId].playerScore += songScore;
                    songs[playerId, (players[playerId].playedSongs)].songScore = songScore;
                }
                else
                {
                    songs[playerId, (players[playerId].playedSongs)].songScore = 0;
                    players[playerId].playerScore += 0;
                }
                Console.WriteLine("Song had been successfully added, score is " + songs[playerId, (players[playerId].playedSongs)].songScore + "/1000.");
                cki = Console.ReadKey();
                Console.Clear();
                songs[playerId, (players[playerId].playedSongs)].playerId = playerId;
                players[playerId].playedSongs++;
            }
            else
            {
                Console.WriteLine("This player had used up all of their songs. Press any key to continue.");
                cki = Console.ReadKey();
                Console.Clear();
            }
        }

        static void displayResults()
        {
            Console.Clear();
            Console.WriteLine("Type B to go back or a player's number to access more details.");
            for (int i = 0; i < players.Length; i++)
            {
                Console.WriteLine("(" + (i + 1) + ") " + players[i].name + " - " + players[i].playedSongs + "/" + numOfSongs + " songs played. Total score: " + players[i].playerScore + "/" + (numOfSongs*1000) + " points.");
            }
            int identifier = 0;
            do
            {
                userInput = Console.ReadLine();
                switch (userInput[0])
                {
                    case 'B':
                    case 'b':
                        return;
                    default:
                        {
                            try
                            {
                                identifier = int.Parse(userInput);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid number, please try again.");
                                continue;
                            }
                            if (identifier < 1 || identifier > numOfPlayers)
                            {
                                Console.WriteLine("Enter a number between 1 and " + numOfPlayers);
                                continue;
                            }
                        }
                        break;
                }
            }
            while (identifier < 1 || identifier > numOfPlayers);
            Console.Clear();
            if (players[identifier-1].playedSongs == 0)
                Console.WriteLine(players[identifier-1].name + " did not play any songs.");
            else
            {
                Console.WriteLine(players[identifier-1].name + " played the following songs:\n");
                for (int i = 0; i < players[identifier-1].playedSongs; i++)
                {
                    Console.WriteLine("   (" + (i + 1) + ") " + songs[identifier-1, i].name + " on " + songs[identifier-1, i].difficultyToStr + ": " + songs[identifier-1, i].songScore + "/1000 points.");
                }
                Console.WriteLine("\n" + players[identifier-1].name + "'s total score is " + players[identifier-1].playerScore + " out of a possible " + (numOfSongs * 1000) + " points.");
            }
            Console.WriteLine("Press any key to continue.");
            cki = Console.ReadKey(true);
            Console.Clear();
        }
    }
}
