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
using RadioApp;

namespace RadioAppInterface
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



        Radio radio = new Radio();

        private void OnOff_Button_Click(object sender, RoutedEventArgs e)
        {
            string x;

            if (radio._on == true)
            {
                radio.TurnOn();
                x = "Turning on...";
            }
            else
            {
                radio.TurnOff();
                x = "Turning off...";
            }
            TextBox.Text
        }

        private void Play_Button_Click(object sender, RoutedEventArgs e)
        {
            var x = radio.Play();
            DisplayBox.Text = x;
        }

        //private void Channel_Button_Click(object sender , RoutedEventArgs e)
        //{
        //    var x = (sender as Button).Content.ToString();

        //    if (radio._on == true)
        //    {
        //        switch (x)
        //        {
        //            case ("1"):
        //                radio.Channel = 1;
        //                break;
        //            case ("2"):
        //                radio.Channel = 2;
        //                break;
        //            case ("3"):
        //                radio.Channel = 3;
        //                break;
        //            case ("4"):
        //                radio.Channel = 4;
        //                break;
        //            default:
        //                break;
        //        }
        //        DisplayBox.Text = $"Switching Channel. {radio.Play()}";
        //    }
        //    else
        //    {
        //        DisplayBox.Text = "Radio is off.";
        //    }

        //}


    }
}
