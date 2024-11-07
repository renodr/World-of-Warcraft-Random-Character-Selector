using System.Linq;
using System.Windows;
using System.IO;
using System.Windows.Media.TextFormatting;
using System.Windows.Media.Animation;

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
                string[] characters = File.ReadAllLines(".\\characters.txt");
                int NumberOfCharacters = characters.Length;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The characters.txt file could not be found.", "Fatal Error", MessageBoxButton.OK);
                this.Close();
            }
        }
    }
}
