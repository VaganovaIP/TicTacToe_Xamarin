using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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
using static Xamarin.Essentials.Permissions;
using Button = Xamarin.Forms.Button;

namespace TicTacToe.ViewModel
{
    public partial class GameViewModel : GameModel 
    {

        private int count = 0;
        string player1 = "X";
        string player2 = "O";
        public bool winnerPlayer = true;
        public static int mode;

        private int[,] row_winner3x3 = new int[,]{
            {0,1,2},
            {3,4,5},
            {6,7,8},
            {0,3,6},
            {1,4,7},
            {2,5,8},
            {0,4,8},
            {2,4,6}
        };

        private int[,] row_winner4x4 = new int[,]{
            {0,1,2,3},
            {4,5,6,7},
            {8,9,10,11},
            {12,13,14,15},
            {0,4,8,12},
            {1,5,9,13},
            {2,6,10,14},
            {3,7,11,15},
            {0,5,10,15},
            {3,6,9,12}
        };

        private int[,] row_winner5x5 = new int[,]{
            {0,1,2,3,4},
            {5,6,7,8,9},
            {10,11,12,13,14},
            {15,16,17,18,19},
            {20,21,22,23,24},
            {0,5,10,15,20},
            {1,6,11,16,21},
            {2,7,12,17,22},
            {3,8,13,18,23},
            {4,9,14,19,24},
            {0,6,12,18,24},
            {4,8,12,16,20}
        };

        public List<string> Fields
        {
            get { return field; }
            set
            {
                field = value;
                OnPropertyChanged(nameof(Fields));
            }
        }
        public static ObservableCollection<string> Result = new ObservableCollection<string>();

        public ObservableCollection<string> Results
        {
            get { return Result; }
            set
            {
                Result = value;
                OnPropertyChanged(nameof(Results));
            }
        }


        public ObservableCollection<Winner> Winners { get; set; }
        private Winner modelWinner;     

        public ICommand newGame;

        public ICommand NewGame{ get {
                return newGame = new Command(NewGame_);
            } }


        public string Id
        {
            get { return modelWinner.Id; }
            set
            {
                modelWinner.Id = value;
                OnPropertyChanged("Id");
            }
        }
        public void NewGame_() 
        {
            modelWinner.Id += 1;
            //Winners.Add(new Winner { Id = "1", Name="2"});
            winnerPlayer = true;
            count = 1;
            Fields = new List<string>() { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            clearCellField();
        }

        private ICommand winner { get; set; }

        private void changePlayer() 
        {
            if (count % 2 == 0) CurrentPlayer = player1;
            else CurrentPlayer = player2;
        }

        public Command modeGame { get; set; } 

        public Command btnClick { get; set; }

        public GameViewModel()
        {
            btnClick = new Command<string>(ButtonClick);
            modeGame = new Command<string>(onGameMode);
            modelWinner = new Winner(); 
                
        }

        public void onGameMode(string value) { 
            switch (value)
            {
                case "case3x3":
                    mode = 1;
                    NewGame_();
                    break;
                case "case4x4":
                    mode = 2;
                    NewGame_();
                    break;
                case "case5x5":
                    mode = 3;
                    NewGame_();
                    break;
            }
        
        }


        public void CellField() {
            Button1 = Fields[0];
            Button2 = Fields[1];
            Button3 = Fields[2];
            Button4 = Fields[3];
            Button5 = Fields[4];
            Button6 = Fields[5];
            Button7 = Fields[6];
            Button8 = Fields[7];
            Button9 = Fields[8];
            Button10 = Fields[9];
            Button11 = Fields[10];
            Button12 = Fields[11];
            Button13 = Fields[12];
            Button14 = Fields[13];
            Button15 = Fields[14];
            Button16 = Fields[15];
            Button17 = Fields[16];
            Button18 = Fields[17];
            Button19 = Fields[18];
            Button20 = Fields[19];
            Button21 = Fields[20];
            Button22 = Fields[21];
            Button23 = Fields[22];
            Button24 = Fields[23];
            Button25 = Fields[24];                       
        }
        public void clearCellField()
        {
            Button1 = "";
            Button2 = "";
            Button3 = "";
            Button4 = "";
            Button5 = "";
            Button6 = "";
            Button7 = "";
            Button8 = "";
            Button9 = "";
            Button10 = "";
            Button11 = "";
            Button12 = "";
            Button13 = "";
            Button14 = "";
            Button15 = "";
            Button16 = "";
            Button17 = "";
            Button18 = "";
            Button19 = "";
            Button20 = "";
            Button21 = "";
            Button22 = "";
            Button23 = "";
            Button24 = "";
            Button25 = "";
        }


        public void ButtonClick(string value)
        {
            if (!winnerPlayer) { return; }
                count++;
            int v = int.Parse(value) -1;
            if (field[v] == "")
            {
                Fields[v] = CurrentPlayer;
            }
            CellField();
            onCheckField();
            changePlayer();
        }

        public void onCheckField() { 
            if (mode == 1) { 
            if (RowWinner3x3(Fields)){
                winnerPlayer = false;
                Results.Add("Игрок " + CurrentPlayer + "               " + DateTime.Now);
            }                
            } else if (mode == 2) {
                if (RowWinner4x4(Fields))
                {
                    winnerPlayer = false;
                    Results.Add("Игрок " + CurrentPlayer + "               " + DateTime.Now);
                }
            }
            else if (mode == 3) {
                if (RowWinner5x5(Fields))
                {
                    winnerPlayer = false;
                    Results.Add("Игрок " + CurrentPlayer + "               " + DateTime.Now);
                }
            }
        
        }


        public bool RowWinner3x3(List<string> field)
        {
            int place1, place2, place3;

            for (int i = 0; i < 8; i++)
            {
                place1 = row_winner3x3[i, 0]; place2 = row_winner3x3[i, 1]; place3 = row_winner3x3[i, 2];

                if (field[place1] == "" || field[place2] == "" || field[place2] == "") continue;

                if (field[place1] == field[place2] && field[place2] == field[place3])
                {

                    return true;
                }

            }
            return false;
        }

        public bool RowWinner4x4(List<string> field)
        {
            int place1, place2, place3, place4;

            for (int i = 0; i < 10; i++)
            {
                place1 = row_winner4x4[i, 0]; place2 = row_winner4x4[i, 1]; place3 = row_winner4x4[i, 2]; place4 = row_winner4x4[i, 3];

                if (field[place1] == "" || field[place2] == "" || field[place3] == "" || field[place4] == "") continue;

                if (field[place1] == field[place2] && field[place2] == field[place3] && field[place3] == field[place4])
                {

                    return true;
                }

            }
            return false;
        }

        public bool RowWinner5x5(List<string> field)
        {
            int place1, place2, place3, place4, place5;

            for (int i = 0; i < 12; i++)
            {
                place1 = row_winner5x5[i, 0]; place2 = row_winner5x5[i, 1]; place3 = row_winner5x5[i, 2]; place4 = row_winner5x5[i, 3]; place5 = row_winner5x5[i, 4];

                if (field[place1] == "" || field[place2] == "" || field[place3] == "" || field[place4] == "" || field[place5] == "") continue;

                if (field[place1] == field[place2] && field[place2] == field[place3] && field[place3] == field[place4] && field[place4] == field[place5])
                {

                    return true;
                }

            }
            return false;
        }

    }
}

