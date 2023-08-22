using Project_1;

internal class Program
{
    private static void Main(string[] args)
    {
        string op;
        OneDayTeam team = new OneDayTeam();
        do
        {
            Console.WriteLine("Enter 1:To Add Player 2:To Remove Player by Id 3.Get Player By Id 4.Get Player by Name 5.Get All Players:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {

                case 1:
                    Player player = new Player();
                    Console.WriteLine("Enter Player Id:");
                    player.PlayerId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Player Name");
                    player.PlayerName = Console.ReadLine();
                    Console.WriteLine("Enter Player Age");
                    player.PlayerAge = int.Parse(Console.ReadLine());
                    team.Add(player);
                    Console.WriteLine("Player is added successfully");
                    break;
                case 2:
                    Console.WriteLine("Enter Player Id to Remove:");
                    int id = int.Parse(Console.ReadLine());
                    team.Remove(id);
                    Console.WriteLine("Player is removed successfully");
                    break;
                case 3:
                    Console.WriteLine("Enter Player Id:");
                    int i = int.Parse(Console.ReadLine());
                    Player pdId = team.GetPlayerById(i);
                    if(pdId != null)
                    {
                        Console.WriteLine(pdId.PlayerId + " " + pdId.PlayerName + " " + pdId.PlayerAge);
                    }
                    else
                    {
                        Console.WriteLine("There is no player with that Id!!");
                    }
                    
                    break;
                case 4:
                    Console.WriteLine("Enter Player Name:");
                    string name = Console.ReadLine();
                    Player pdN = team.GetPlayerByName(name);
                    if(pdN != null)
                    {
                        Console.WriteLine(pdN.PlayerId + " " + pdN.PlayerName + " " + pdN.PlayerAge);
                    }
                    else
                    {
                        Console.WriteLine("There is no player with that Name!!");
                    }
                    break;
                case 5:
                    List<Player> list = team.GetAllPlayers();
                    if(list.Count != 0)
                    {
                        foreach (Player p in list)
                        {
                            Console.WriteLine(p.PlayerId + " " + p.PlayerName + " " + p.PlayerAge);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No players in the team!!!");
                    }
                    
                    break;
                default: 
                    Console.WriteLine("Wrong option!!");
                    break;
            }
            Console.WriteLine("Do you want to continue (yes/no)?:");
            op = Console.ReadLine();
        } while (op == "yes");
    }
}