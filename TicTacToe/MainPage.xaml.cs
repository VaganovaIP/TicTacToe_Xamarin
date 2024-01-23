using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Button = Xamarin.Forms.Button;

namespace TicTacToe
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            BindingContext = new GameViewModel();
        }

        private void case3x3_Clicked(object sender, EventArgs e)
        {
            Board1.IsVisible = true;
            Board2.IsVisible = false;
            Board3.IsVisible = false;
        }

        private void case4x4_Clicked(object sender, EventArgs e)
        {
            Board1.IsVisible = false;
            Board2.IsVisible = true;
            Board3.IsVisible = false;
        }

        private void case5x5_Clicked(object sender, EventArgs e)
        {
            Board1.IsVisible = false;
            Board2.IsVisible = false;
            Board3.IsVisible = true;
        }
    }
}
