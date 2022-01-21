using System;
using System.Collections.Generic;

namespace As1KubraBas
{
    class Program
    {

        static List<Player> playerList = new List<Player>();
        static bool keepGoing = true;
        static int playerId = 0;

        static void Main(string[] args)
        {

            int choice = 0;
            string input;
            bool valid;

            DisplayHeader();

            while (keepGoing)
            {
                Console.WriteLine("\n\nMenu");
                Console.WriteLine("1- Add Player");
                Console.WriteLine("2- Edit Player");
                Console.WriteLine("3- Delete Player");
                Console.WriteLine("4- View Players");
                Console.WriteLine("5- Search Player");
                Console.WriteLine("6- Exit");
                input = Console.ReadLine();

                valid = IsValid(input);

                if (!valid)
                {
                    Console.WriteLine("\nInvalid input please try again");
                    keepGoing = true;
                }
                else
                {
                    choice = int.Parse(input);
                    if (choice == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("which sports player is being added?");
                        Console.WriteLine("1- Add Hockey Player");
                        Console.WriteLine("2- Add Basketball Player");
                        Console.WriteLine("3- Add Baseball Player");
                        Console.WriteLine("4- Back to Main Menu");

                        input = Console.ReadLine();
                        valid = IsValid2(input);

                        if (!valid)
                        {
                            Console.WriteLine("\nInvalid input please try again");
                            keepGoing = true;
                        }
                        else
                        {
                            choice = int.Parse(input);
                            if (choice == 4)
                                keepGoing = true;
                            else
                                AddPlayer(choice);
                        }
                    }
                    else if (choice == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("which sports player is being edited?");
                        Console.WriteLine("1- Edit Hockey Player");
                        Console.WriteLine("2- Edit Basketball Player");
                        Console.WriteLine("3- Edit Baseball Player");
                        Console.WriteLine("4- Back to Main Menu");
                        input = Console.ReadLine();
                        valid = IsValid2(input);

                        if (!valid)
                        {
                            Console.WriteLine("\nInvalid input please try again");
                            keepGoing = true;
                        }
                        else
                        {
                            choice = int.Parse(input);
                            if (choice == 4)
                                keepGoing = true;
                            else
                                EditPlayer(choice);
                        }

                    }
                    else if (choice == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("which sports player is being Deleted?");
                        Console.WriteLine("1- Delete Hockey Player");
                        Console.WriteLine("2- Delete Basketball Player");
                        Console.WriteLine("3- Delete Baseball Player");
                        Console.WriteLine("4- Back to Main Menu");
                        input = Console.ReadLine();
                        valid = IsValid2(input);


                        if (!valid)
                        {
                            Console.WriteLine("\nInvalid input please try again");
                            keepGoing = true;
                        }
                        else
                        {
                            choice = int.Parse(input);
                            if (choice == 4)
                                keepGoing = true;
                            else
                                DeletePlayer(choice);
                        }

                    }
                    else if (choice == 4)
                    {
                        DisplayPlayerList();
                    }
                    else if (choice == 5)
                    {
                        SearchPlayer();
                    }
                    else if (choice == 6)
                    {
                        Console.Clear();
                        Console.Write("\nYou chose to exit! Do you really want to exit (y/n): ");
                        input = Console.ReadLine();
                        if (input.ToUpper().Equals("Y"))
                        {
                            Console.WriteLine("\n\nThanks for using our system! Hope to see you soon!...");
                            Environment.Exit(0);
                        }
                        else
                        {
                            keepGoing = true;
                        }
                    }

                }

            }
        }

        public static bool IsValid(string input)
        {
            if (!IsValid1(input))
            {
                return false;
            }
            else
            {
                int number = int.Parse(input);

                if (number < 1 || number > 6)
                {
                    return false;
                }
                else
                    return true;
            }

        }

        public static bool IsValid1(string input)
        {
            if (!int.TryParse(input, out int value))
            {
                return false;
            }
            else
                return true;
        }

        public static bool IsValid2(string input)
        {
            if (!IsValid1(input))
            {
                return false;
            }
            else
            {

                int number = int.Parse(input);

                if (number < 1 || number > 4)
                {
                    return false;
                }
                else
                    return true;
            }
        }

        public static bool IsString(string name)
        {
            foreach (char c in name)
            {
                if (char.IsLetter(c))
                    return true;
            }
            return false;
        }

        public static void AddPlayer(int number)
        {

            playerId++;

            Console.Clear();
            Console.WriteLine("Enter the details of the player:\n");
            Console.Write("\nPlayer Name: ");
            string playerName = Console.ReadLine();
            while (!IsString(playerName))
            {
                Console.Write("\nPlease enter a valid name: ");
                playerName = Console.ReadLine();
                IsString(playerName);
            }

            Console.Write("\nTeam Name: ");
            string teamName = Console.ReadLine();
            Console.Write("\nGames Played: ");
            string gp = Console.ReadLine();
            while (!IsValid1(gp))
            {
                Console.Write("\nPlease enter a valid value games played: ");
                gp = Console.ReadLine();
                IsValid1(gp);
            }
            int gamesPlayed = int.Parse(gp);

            if (number == 1)
            {
                Console.Write("\nNumber of assists: ");
                string ast = Console.ReadLine();
                while (!IsValid1(ast))
                {
                    Console.Write("\nPlease enter a valid assists value: ");
                    ast = Console.ReadLine();
                    IsValid1(ast);
                }
                int assists = int.Parse(ast);


                Console.Write("\nNumber of goals: ");
                string gls = Console.ReadLine();
                while (!IsValid1(gls))
                {
                    Console.Write("\nPlease enter a valid goals value: ");
                    gls = Console.ReadLine();
                    IsValid1(gls);
                }
                int goals = int.Parse(gls);

                Player newPlayer = new HockeyPlayer(playerId, playerName, teamName, gamesPlayed, assists, goals);
                playerList.Add(newPlayer);
            }
            if (number == 2)
            {
                Console.Write("\nNumber of threePointers: ");
                string tp = Console.ReadLine();

                while (!IsValid1(tp))
                {
                    Console.Write("\nPlease enter a valid three points value: ");
                    tp = Console.ReadLine();
                    IsValid1(tp);
                }
                int threePointers = int.Parse(tp);

                Console.Write("\nNumber of field goals: ");
                string fg = Console.ReadLine();

                while (!IsValid1(fg))
                {
                    Console.Write("\nPlease enter a valid fiels goals value: ");
                    fg = Console.ReadLine();
                    IsValid1(fg);
                }

                int fieldGoals = int.Parse(fg);

                Player newPlayer = new BasketballPlayer(playerId, playerName, teamName, gamesPlayed, threePointers, fieldGoals);
                playerList.Add(newPlayer);
            }
            if (number == 3)
            {
                Console.Write("\nNumber of runs: ");
                string r = Console.ReadLine();

                while (!IsValid1(r))
                {
                    Console.Write("\nPlease enter a runs value: ");
                    r = Console.ReadLine();
                    IsValid1(r);
                }

                int runs = int.Parse(r);


                Console.Write("\nNumber of home runs: ");

                string hr = Console.ReadLine();

                while (!IsValid1(hr))
                {
                    Console.Write("\nPlease enter a valid fiels goals value: ");
                    hr = Console.ReadLine();
                    IsValid1(hr);
                }

                int homeRuns = int.Parse(hr);

                Player newPlayer = new BaseballPlayer(playerId, playerName, teamName, gamesPlayed, runs, homeRuns);
                playerList.Add(newPlayer);
            }

            Console.Clear();
            Console.WriteLine("\nPlayer added!");
            Console.WriteLine("\nPlease select your next  request from the menu");
            keepGoing = true;
        }

        public static void DeletePlayer(int number)
        {
            Console.Clear();
            List<Player> customList = new List<Player>();


            Console.WriteLine("Player List In Selected Type:");

            switch (number)
            {

                case 1:
                    customList = playerList.FindAll(p => p.Type() == PlayerType.HockeyPlayer);
                    ListTitle("Hockey Players");
                    break;
                case 2:
                    customList = playerList.FindAll(p => p.Type() == PlayerType.BasketballPlayer);
                    ListTitle("Basketball Players");
                    break;
                case 3:
                    customList = playerList.FindAll(p => p.Type() == PlayerType.BaseBallPlayer);
                    ListTitle("Baseball Players");
                    break;
            }

            if (customList.Count == 0)
            {
                Console.WriteLine("There is no player in this category! Returning to main Menu...");
                keepGoing = true;
            }
            else
            {
                customList.ForEach(Console.WriteLine);

                Console.Write("Pleaser Enter a valid ID for the player you want to delete: ");
                string pID = Console.ReadLine();
                IsValid1(pID);

                while (!IsValid1(pID))
                {
                    Console.Write("Pleaser Enter a valid ID for the player you want to delete: ");
                    pID = Console.ReadLine();
                    IsValid1(pID);
                }

                int player = int.Parse(pID);

                if (!customList.Exists(p => p.PlayerId == player))
                {
                    Console.Write("Invalid user ID! please enter a valid ID: ");
                    DeletePlayer(number);
                }
                else
                {

                    var index = customList.IndexOf(customList.Find(found => found.PlayerId == player));
                    customList.Remove(customList[index]);

                    playerList.Remove(playerList[player - 1]);

                    Console.WriteLine($"\n\nThe player ID {player} deleted!\n");
                    playerId--;

                    if (customList.Count != 0)
                    {
                        Console.WriteLine("New Player List In Selected Type:\n\n");
                        customList.ForEach(Console.WriteLine);
                    }

                    else
                        Console.WriteLine("There is no other player in this Category\n\n");

                    keepGoing = true;
                }
            }

        }
        public static void EditPlayer(int number)
        {
            Console.Clear();
            List<Player> customList = new List<Player>();

            Console.WriteLine("Player List In Selected Type:");

            switch (number)
            {
                case 1:
                    customList = playerList.FindAll(p => p.Type() == PlayerType.HockeyPlayer);
                    ListTitle("Hockey Players");
                    break;
                case 2:
                    customList = playerList.FindAll(p => p.Type() == PlayerType.BasketballPlayer);
                    ListTitle("Basketball Players");
                    break;
                case 3:
                    customList = playerList.FindAll(p => p.Type() == PlayerType.BaseBallPlayer);
                    ListTitle("Baseball Players");
                    break;
            }
            if (customList.Count == 0)
            {
                Console.WriteLine("There is no player in this category! Returning to main Menu...");
                keepGoing = true;
            }
            else
            {
                customList.ForEach(Console.WriteLine);
                Console.Write("Please Enter a valid ID for the player you want to edit: ");
                string pId = Console.ReadLine();

                while (!IsValid1(pId))
                {
                    Console.Write("Please Enter a valid ID for the player you want to edit: ");
                    pId = Console.ReadLine();
                    IsValid1(pId);
                }

                int playerID = int.Parse(pId);


                if (!customList.Exists(p => p.PlayerId == playerID))
                {
                    Console.Clear();
                    Console.WriteLine("\n\nInvalid user ID! please enter a valid ID");
                    EditPlayer(number);
                }
                else
                {
                    var indexOfCustomList = customList.IndexOf(customList.Find(p => p.PlayerId == playerID));
                    var indexOfPlayerList = playerList.IndexOf(playerList.Find(p => p.PlayerId == playerID));

                    //enter the player details wanted to be edited
                    Console.Write("\nPlayer Name: ");
                    string playerName = Console.ReadLine();

                    while (!IsString(playerName))
                    {
                        Console.Write("\nPlease enter a valid name: ");
                        playerName = Console.ReadLine();
                        IsString(playerName);
                    }

                    Console.Write("\nTeam Name: ");
                    string teamName = Console.ReadLine();

                    Console.Write("\nGames Played: ");
                    string gp = Console.ReadLine();
                    while (!IsValid1(gp))
                    {
                        Console.Write("\nPlease enter a valid value for games played: ");
                        gp = Console.ReadLine();
                        IsValid1(gp);
                    }
                    int gamesPlayed = int.Parse(gp);

                    if (number == 1)
                    {
                        Console.Write("\nNumber of assists: ");
                        string ast = Console.ReadLine();

                        while (!IsValid1(ast))
                        {
                            Console.Write("\nPlease enter a valid assists value");
                            ast = Console.ReadLine();
                            IsValid1(ast);
                        }
                        int assists = int.Parse(ast);
                        Console.Write("\nNumber of goals: ");
                        string gls = Console.ReadLine();


                        while (!IsValid1(gls))
                        {
                            Console.Write("\nPlease enter a valid goals value");
                            gls = Console.ReadLine();
                            IsValid1(gls);
                        }
                        int goals = int.Parse(gls);

                        playerList[indexOfPlayerList] = new HockeyPlayer(playerID, playerName, teamName, gamesPlayed, assists, goals);
                        customList[indexOfCustomList] = new HockeyPlayer(playerID, playerName, teamName, gamesPlayed, assists, goals);

                    }
                    else if (number == 2)
                    {
                        Console.Write("\nNumber of threePointers: ");
                        string tp = Console.ReadLine();

                        while (!IsValid1(tp))
                        {
                            Console.Write("\nPlease enter a valid three points value");
                            tp = Console.ReadLine();
                            IsValid1(tp);
                        }
                        int threePointers = int.Parse(tp);

                        Console.Write("\nNumber of field goals: ");
                        string fg = Console.ReadLine();

                        while (!IsValid1(fg))
                        {
                            Console.Write("\nPlease enter a valid for field goals value");
                            fg = Console.ReadLine();
                            IsValid1(fg);
                        }

                        int fieldGoals = int.Parse(fg);

                        playerList[indexOfPlayerList] = new BasketballPlayer(playerID, playerName, teamName, gamesPlayed, threePointers, fieldGoals);
                        customList[indexOfCustomList] = new BasketballPlayer(playerID, playerName, teamName, gamesPlayed, threePointers, fieldGoals);
                    }
                    else if (number == 3)
                    {
                        Console.Write("\nNumber of runs: ");
                        string r = Console.ReadLine();

                        while (!IsValid1(r))
                        {
                            Console.Write("\nPlease enter a runs value");
                            r = Console.ReadLine();
                            IsValid1(r);
                        }

                        int runs = int.Parse(r);


                        Console.Write("\nNumber of home runs: ");

                        string hr = Console.ReadLine();

                        while (!IsValid1(hr))
                        {
                            Console.Write("\nPlease enter a valid fiels goals value");
                            hr = Console.ReadLine();
                            IsValid1(hr);
                        }

                        int homeRuns = int.Parse(hr);

                        playerList[indexOfPlayerList] = new BaseballPlayer(playerID, playerName, teamName, gamesPlayed, runs, homeRuns);
                        customList[indexOfCustomList] = new BaseballPlayer(playerID, playerName, teamName, gamesPlayed, runs, homeRuns);
                    }

                    Console.WriteLine("\n\nThe player edited successfully!\n\n");
                    Console.WriteLine("\nPlayer List In Selected Type:\n\n");
                    customList.ForEach(Console.WriteLine);
                    Console.WriteLine("\nPlease select your next request from the menu\n\n");
                    keepGoing = true;
                }
            }

        }
        public static void SearchPlayer()
        {
            bool search = true;

            Console.Clear();
            if (playerList.Count == 0)
            {
                Console.WriteLine("\n\nThe player list is empty! please Add new Players to the List!");
                keepGoing = true;
            }
            else
            {

                Console.Write("Enter the partial or full name of the player you want to search:  ");
                while (search)
                {


                    string name = (Console.ReadLine()).ToUpper();

                    List<Player> foundPlayers = new List<Player>();

                    List<string> nameList = new List<string>();

                    for (int i = 0; i < playerList.Count; i++)
                    {
                        if (playerList[i].PlayerName.ToUpper().Contains(name))
                            foundPlayers.Add((playerList[i]));
                    }

                    if (foundPlayers.Count != 0)
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Search Result:\n");
                        foundPlayers.ForEach(Console.WriteLine);
                        search = false;
                        Console.WriteLine("\n\nPress enter to continue...");
                        string input = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(input))
                        {

                            keepGoing = true;
                            Console.Clear();
                        }

                    }
                    else
                    {
                        Console.WriteLine("\nPlayer not in the list!\n");
                        Console.Write("\nSearch another player: ");
                        search = true;

                    }
                }
            }
        }


        public static void DisplayHeader()
        {
            Console.Clear();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("\t\t\t\tAssignment -1 by Kubra BAS");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine("Welcome to Sports player stats management system");
            Console.WriteLine("Please select your request from the menu\n");
            keepGoing = true;
        }
        public static void DisplayPlayerList()
        {
            Console.Clear();

            if (playerList.Count == 0)
            {
                Console.WriteLine("\n\nThe player list is empty! please Add new Players to the List!");
                keepGoing = true;
            }
            else
            {


                List<Player> hockeyPlayerList = new List<Player>();
                List<Player> basketballPlayerList = new List<Player>();
                List<Player> baseballPlayerList = new List<Player>();

                hockeyPlayerList = playerList.FindAll(p => p.Type() == PlayerType.HockeyPlayer);
                basketballPlayerList = playerList.FindAll(p => p.Type() == PlayerType.BasketballPlayer);
                baseballPlayerList = playerList.FindAll(p => p.Type() == PlayerType.BaseBallPlayer);


                Console.WriteLine("\nView All Players: ");

                if (hockeyPlayerList.Count != 0)
                {
                    Console.WriteLine("\n\nHockey Players:");
                    ListTitle("Hockey Players");
                    hockeyPlayerList.ForEach(Console.WriteLine);
                }
                if (basketballPlayerList.Count != 0)
                {
                    Console.WriteLine("\n\nBasketball Players:");
                    ListTitle("Basketball Players");
                    basketballPlayerList.ForEach(Console.WriteLine);
                }

                if (baseballPlayerList.Count != 0)
                {
                    Console.WriteLine("\n\nBaseball Players:");
                    ListTitle("Baseball Players");
                    baseballPlayerList.ForEach(Console.WriteLine);
                }

                Console.WriteLine("\n\nPress enter to continue...");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    keepGoing = true;
                    Console.Clear();
                }
            }

        }

        public static void ListTitle(string type)
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------\n");

            if (type.Equals("Hockey Players"))
            {
                Console.WriteLine(String.Format("{0, -16} | {1,9} | {2,-20} | {3,-15} | {4,12} | {5,10} | {6,11} | {7,8}",
                                                "Player Type", "Player ID", "Player Name", "Team Name", "Games Played",
                                                "Assists", "Goals", "Points"));

            }
            else if (type.Equals("Basketball Players"))
            {

                Console.WriteLine(String.Format("{0, -16} | {1,9} | {2,-20} | {3,-15} | {4,12} | {5,10} | {6,11} | {7,8}",
                                                 "Player Type", "Player ID", "Player Name", "Team Name", "Games Played",
                                                 "3-Pointers", "Field Goals", "Points"));
            }
            else if (type.Equals("Baseball Players"))
            {

                Console.WriteLine(String.Format("{0, -16} | {1,9} | {2,-20} | {3,-15} | {4,12} | {5,10} | {6,11} | {7,8}",
                                                 "Player Type", "Player ID", "Player Name", "Team Name", "Games Played",
                                                 "Runs", "Home Runs", "Points"));
            }

            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------------\n");
        }

    }
}








