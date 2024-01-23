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
        public static string currentPlayer = "O";
        public static string winnerPlayer;
        public static List<string> field = new List<string>() { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };

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
        public string button1 { get; set; }
        public string button2 { get; set; }
        public string button3 { get; set; }
        public string button4 { get; set; }
        public string button5 { get; set; }
        public string button6 { get; set; }
        public string button7 { get; set; }
        public string button8 { get; set; }
        public string button9 { get; set; }
        public string button10 { get; set; }
        public string button11 { get; set; } 
        public string button12 { get; set; }
        public string button13 { get; set; }
        public string button14 { get; set; }
        public string button15 { get; set; }
        public string button16 { get; set; }
        public string button17 { get; set; }
        public string button18 { get; set; }
        public string button19 { get; set; }
        public string button20 { get; set; }
        public string button21 { get; set; }
        public string button22 { get; set; }
        public string button23 { get; set; }
        public string button24 { get; set; }
        public int button25 { get; set; }


        public static string _button1;
        public static string _button2;
        public static string _button3;
        public static string _button4;
        public static string _button5;
        public static string _button6;
        public static string _button7;
        public static string _button8;
        public static string _button9;
        public static string _button10;
        public static string _button11;
        public static string _button12;
        public static string _button13;
        public static string _button14;
        public static string _button15;
        public static string _button16;
        public static string _button17;
        public static string _button18;
        public static string _button19;
        public static string _button20;
        public static string _button21;
        public static string _button22;
        public static string _button23;
        public static string _button24;
        public static string _button25;

                
            
        public string Button1
        {
            get { return _button1; }
            set
            {
                _button1 = value;
                OnPropertyChanged(nameof(Button1));
            }
        }
        public string Button2
        {
            get { return _button2; }
            set
            {
                _button2 = value;
                OnPropertyChanged(nameof(Button2));
            }
        }
        public string Button3
        {
            get { return _button3; }
            set
            {
                _button3 = value;
                OnPropertyChanged(nameof(Button3));
            }
        }
        public string Button4
        {
            get { return _button4; }
            set
            {
                _button4 = value;
                OnPropertyChanged(nameof(Button4));
            }
        }
        public string Button5
        {
            get { return _button5; }
            set
            {
                _button5 = value;
                OnPropertyChanged(nameof(Button5));
            }
        }
        public string Button6
        {
            get { return _button6; }
            set
            {
                _button6 = value;


                OnPropertyChanged(nameof(Button6));
            }
        }
        public string Button7
        {
            get { return _button7; }
            set
            {
                _button7 = value;
                OnPropertyChanged(nameof(Button7));
            }
        }
        public string Button8
        {
            get { return _button8; }
            set
            {
                _button8 = value;
                OnPropertyChanged(nameof(Button8));
            }
        }
        public string Button9
        {
            get { return _button9; }
            set
            {
                _button9 = value;
                OnPropertyChanged(nameof(Button9));
            }
        }

        public string Button10
        {
            get { return _button10; }
            set
            {
                _button10 = value;
                OnPropertyChanged(nameof(Button10));
            }
        }

        public string Button11
        {
            get { return _button11; }
            set
            {
                _button11 = value;
                OnPropertyChanged(nameof(Button11));
            }
        }

        public string Button12
        {
            get { return _button12; }
            set
            {
                _button12 = value;
                OnPropertyChanged(nameof(Button12));
            }
        }

        public string Button13
        {
            get { return _button13; }
            set
            {
                _button13 = value;
                OnPropertyChanged(nameof(Button13));
            }
        }

        public string Button14
        {
            get { return _button14; }
            set
            {
                _button14 = value;
                OnPropertyChanged(nameof(Button14));
            }
        }

        public string Button15
        {
            get { return _button15; }
            set
            {
                _button15 = value;
                OnPropertyChanged(nameof(Button15));
            }
        }

        public string Button16
        {
            get { return _button16; }
            set
            {
                _button16 = value;
                OnPropertyChanged(nameof(Button16));
            }
        }
        public string Button17
        {
            get { return _button17; }
            set
            {
                _button17 = value;
                OnPropertyChanged(nameof(Button17));
            }
        }

        public string Button18
        {
            get { return _button18; }
            set
            {
                _button18 = value;
                OnPropertyChanged(nameof(Button18));
            }
        }

        public string Button19
        {
            get { return _button19; }
            set
            {
                _button19 = value;
                OnPropertyChanged(nameof(Button19));
            }
        }
        public string Button20
        {
            get { return _button20; }
            set
            {
                _button20 = value;
                OnPropertyChanged(nameof(Button20));
            }
        }
        public string Button21
        {
            get { return _button21; }
            set
            {
                _button21 = value;
                OnPropertyChanged(nameof(Button21));
            }
        }
        public string Button22
        {
            get { return _button22; }
            set
            {
                _button22 = value;
                OnPropertyChanged(nameof(Button22));
            }
        }

        public string Button23
        {
            get { return _button23; }
            set
            {
                _button23 = value;
                OnPropertyChanged(nameof(Button23));
            }
        }

        public string Button24
        {
            get { return _button24; }
            set
            {
                _button24 = value;
                OnPropertyChanged(nameof(Button24));
            }
        }

        public string Button25
        {
            get { return _button25; }
            set
            {
                _button25 = value;
                OnPropertyChanged(nameof(Button25));
            }
        }

    }


}
