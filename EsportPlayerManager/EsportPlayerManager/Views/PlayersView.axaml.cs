using Avalonia.Controls;
using EsportPlayerManager.ViewModels;

namespace EsportPlayerManager.Views;

public partial class PlayersView : UserControl
{
    public PlayersView()
    {
        InitializeComponent();
        DataContext = new PlayersViewModel();
    }
}