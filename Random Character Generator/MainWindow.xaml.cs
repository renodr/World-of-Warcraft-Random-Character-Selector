using System.Linq;
using System.Windows;
using System.IO;
using System.Windows.Media.TextFormatting;
using System.Windows.Media.Animation;
using System.Security.Cryptography;
using System;

namespace Random_Character_Generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Read in the list of characters.
                string[] characters = File.ReadAllLines(".\\characters.txt");
                int NumberOfCharacters = characters.Length;

                // Get a random number to select the character
                Random character = new Random();
                int character_number = character.Next(NumberOfCharacters);

                // Set the character name.
                string CharacterToPlay = characters.GetValue(character_number).ToString();

                CharacterName.Content = CharacterToPlay;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The characters.txt file could not be found.", "Fatal Error", MessageBoxButton.OK);
                this.Close();
            }
        }
    }
}
