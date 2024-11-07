using System.Linq;
using System.Windows;
using System.IO;

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

            /// <summary>
            /// Initialize the characters.txt file and read it into an array.
            /// </summary>
            try
            {
                string[] characters = File.ReadAllLines(".\\characters.txt").ToArray();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The characters.txt file does not exist", "Fatal Error", MessageBoxButton.OK);
                this.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
