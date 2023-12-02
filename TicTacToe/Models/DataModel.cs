using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using TicTacToe.ViewModels;
using Xamarin.Forms;

namespace TicTacToe.Models
{
    public class GameModel : BaseViewModel
    {
        public static string timenow = "0";
        public static string currentPlayer;
        public static string winnerPlayer;
        List<string> field = new List<string>() { "", "", "", "", "", "", "", "", "" };
        List<string> winner = new List<string>();
  

        public string[] story { get; set; }

        public string CurrentPlayer
        {
            get { return currentPlayer; }
            set
            {
                currentPlayer = value;
                OnPropertyChanged(nameof(CurrentPlayer));
            }
        }
        public List<string> Field
        {
            get { return field; }
            set
            {
                if (field != value)
                {
                    field = value;
                    OnPropertyChanged(nameof(Field));
                }

            }
        }

        public List<string> WinnerStory
        {
            get { return winner; }
            set
            {
                winner = value;
                OnPropertyChanged(nameof(WinnerStory));
            }
        }







    }


}
