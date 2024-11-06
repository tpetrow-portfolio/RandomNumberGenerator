using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Random_Number_Generator
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

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            // Try to parse the input values
            if (int.TryParse(firstNumberText.Text, out int first) && int.TryParse(lastNumberText.Text, out int last))
            {
                // Ensure that the 'first' number is less than the 'last' number
                if (first >= last)
                {
                    resultText.Text = "Base number must be smaller than top number.";
                }
                else if (first < 0 || last < 0 || first > 9999999 || last > 9999999)
                {
                    resultText.Text = "Please enter valid numbers between 0 and 9999999.";
                }
                else
                {
                    // Generate the random number
                    Random random = new Random();
                    int randomNumber = random.Next(first, last + 1); // Include the 'last' number
                    resultText.Text = $"Generated Random Number: {randomNumber}";
                }
            }
            else
            {
                resultText.Text = "Please enter valid numbers.";
            }
        }
    }
}
