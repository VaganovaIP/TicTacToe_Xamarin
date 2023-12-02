using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;

namespace TicTacToe
{
    class Game 
    {
        private int player = 1;

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

        public void NextPlayer(Button button)
        {
            if (button.Text == "") { 
                 if (player == 1){
                    button.Text = "X";
                    player = 2;
                 } else {
                        button.Text = "O";
                        player = 1;
                    }
            }
        }

        public bool RowWinner(Button[] buttons)
        {
            int place1, place2, place3;

            for (int i = 0; i < buttons.Length-1; i++)
            {
                place1 = row_winner[i, 0]; place2 = row_winner[i, 1]; place3 = row_winner[i, 2];

                if (buttons[place1].Text == "" || buttons[place2].Text == "" || buttons[place2].Text == "") continue;

                if (buttons[place1].Text == buttons[place2].Text && buttons[place2].Text == buttons[place3].Text)
                {
                    
                    return true;
                }
                
            }

            return false;

        }

        public void gameOver() { 
        }
    }
}
