using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using TicTacToe.Models;
using TicTacToe.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace TicTacToe.ViewModel
{
    public partial class GameViewModel : GameModel 
    {

        private int count = 0;
        string player1 = "X";
        string player2 = "O";
        public static string winnerPlayer;

        private int[,] row_winner = new int[,]
{
            {0,1,2},
            {3,4,5},
            {6,7,8},
            {0,3,6},
            {1,4,7},
            {2,5,8},
            {0,4,8},
            {2,4,6}
        };

        public ICommand newGame;

        public ICommand NewGame{ get {
                return newGame = new Command(NewGame_, () => true);
            } }

        public void NewGame_() 
        {
            count = 1;
            Field = new List<string>() { "", "", "", "", "", "", "", "", "" };
        }


        private ICommand winner { get; set; }




        private void changePlayer() 
        {
            if (count % 2 == 0) CurrentPlayer = player1;
            else CurrentPlayer = player2;
        }

        public Command btnClick { get; set; }

        public GameViewModel()
        {
            btnClick = new Command<string>(ButtonClick);
            winner = new Command<string>(winnerWho);
        }

        public void winnerWho(string value) { 
            
        }

        public void ButtonClick(string value)
        {
            Console.WriteLine("--------------------------");
            
            
            count++;
            int v = int.Parse(value) -1;
            if (Field[v] == "")
            {
                Field[v] = CurrentPlayer;
            }
            if (RowWinner(Field))
            {
                
                Console.WriteLine("winner");
            }

            changePlayer();
            for (int i = 0; i < 9; i++)
                Console.WriteLine(Field[i] + "---");
        }


        public bool RowWinner(List<string> field)
        {
            int place1, place2, place3;

            for (int i = 0; i < 8; i++)
            {
                place1 = row_winner[i, 0]; place2 = row_winner[i, 1]; place3 = row_winner[i, 2];

                if (field[place1] == "" || field[place2] == "" || field[place2] == "") continue;

                if (field[place1] == field[place2] && field[place2] == field[place3])
                {

                    return true;
                }

            }
            return false;

        }
    }
}

