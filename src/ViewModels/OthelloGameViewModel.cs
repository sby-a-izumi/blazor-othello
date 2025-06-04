using System.ComponentModel;
using System.Runtime.CompilerServices;
using BlazorOthello.Models;

namespace BlazorOthello.ViewModels
{
    public class OthelloGameViewModel : INotifyPropertyChanged
    {
        private OthelloGame game;

        public OthelloGameViewModel()
        {
            game = new OthelloGame();
            game.InitializeBoard();
        }

        public Player GetPlayerAt(int x, int y)
        {
            return game.GetPlayerAt(x, y);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}