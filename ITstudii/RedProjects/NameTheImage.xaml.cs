using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238


// Time spent on code = ~2h

namespace ITstudii.RedProjects
{
    // stuck at the moment, haven't figured out xaml DataTemplate yet
    
    // I would like to create a system that reads the NameTheImage folder and creates a game-category for every folder found therein
    // And read the png files in those folders, so that they can be used in the guessing game
    // This would allow you to create a new folder with its own new png images and use in the game without any alterations

    public class ChoiceButton
    {
        public ChoiceButton()
        {

        }

    }

    /// <summary>
    /// A game in which you guess the name that belongs to the image shown.
    /// </summary>

    public sealed partial class NameTheImage : Page
    {
        public NameTheImage()
        {
            this.InitializeComponent();
        }

        private void StartGuessing()
        {

        }




        private void StartGuessingButton_Click(object sender, RoutedEventArgs e)
        {
            StartGuessing();
        }
    }
}
