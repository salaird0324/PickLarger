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

namespace salf22PickLarger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] arrayUno = new int[100];
        int[] randomTwo = new int[100];
        int correct;
        int incorrect;
        int arrayCounter = 0;
        Random rand = new Random();
        
        


    public MainWindow()
        {

            for (int i = 0; i <= 99; i++)
            {
                int number = rand.Next(1,100);
                arrayUno[i] = number;
              
                


            }
            for (int j = 0; j <= 99; j++) {
                int numberTwo = rand.Next(1,100);
               randomTwo[j] = numberTwo;
                
               
            }

            InitializeComponent();
        }

       

    

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (arrayCounter <= arrayUno.Length - 1)
            {
                arrayCounter++;
            }
            else if (arrayCounter == arrayUno.Length) {
                arrayCounter = 0;
            }
            int guess = arrayUno[arrayCounter];
            int guessTwo = randomTwo[arrayCounter];
            arrayOne.Text = arrayUno[arrayCounter].ToString();
            arrayTwo.Text = randomTwo[arrayCounter].ToString();

      //      int guess = arrayUno[0];
     //       int guessTwo = randomTwo[0];
     //       arrayOne.Text = arrayUno[0].ToString();
      //      arrayTwo.Text = randomTwo[0].ToString();

            if (guess >= guessTwo)
            {
                correct++;
                string correctString = correct.ToString();
                right.Text = correctString;

            }
            else if (guessTwo >= guess)
            {
                incorrect++;
                wrong.Text = incorrect.ToString();

            }
            buttonOneArray.IsEnabled = false;
            buttonTwoArray.IsEnabled = false;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            if (arrayCounter <= arrayUno.Length - 1)
            {
                arrayCounter++;
            }
            else if (arrayCounter == arrayUno.Length) {
                arrayCounter = 0;
            }
            int guess = arrayUno[arrayCounter];
            int guessTwo = randomTwo[arrayCounter];
            arrayOne.Text = arrayUno[arrayCounter].ToString();
            arrayTwo.Text = randomTwo[arrayCounter].ToString();
        //    int guess = arrayUno[0];
        //    int guessTwo = randomTwo[0];
        //    arrayOne.Text = arrayUno[0].ToString();
        //    arrayTwo.Text = randomTwo[0].ToString();

            if (guess <= guessTwo)
            {
                correct++;
                string correctString = correct.ToString();
                right.Text = correctString;

            }
            else if (guessTwo <= guess)
            {
                incorrect++;
                wrong.Text = incorrect.ToString();

            }
            buttonOneArray.IsEnabled = false;
            buttonTwoArray.IsEnabled = false;
        }

        private void Button_ClickNext(object sender, RoutedEventArgs e)
        {
            buttonOneArray.IsEnabled = true;
            buttonTwoArray.IsEnabled = true;
            arrayOne.Text = "?";
            arrayTwo.Text = "?";

        }

        private void reset(object sender, RoutedEventArgs e)
        {
            buttonOneArray.IsEnabled = true;
            buttonTwoArray.IsEnabled = true;
            correct = 0;
           incorrect = 0;
            arrayCounter = 0;
            arrayOne.Text = "?";
            arrayTwo.Text = "?";
            right.Text = "0";
            wrong.Text = "0";
        }
    }
}
