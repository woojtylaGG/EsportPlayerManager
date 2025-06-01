using System.Collections.ObjectModel;

namespace EsportPlayerManager.ViewModels;

public class PlayersViewModel
{
    public ObservableCollection<Player> Players { get; set; }

    public PlayersViewModel()
    {
        Players = new ObservableCollection<Player>
        {
            new Player { Name = "Player 1" },
            new Player { Name = "Player 2" },
            new Player { Name = "Player 3" }
        };
    }
}

public class Player
{
    public string Name { get; set; }
}