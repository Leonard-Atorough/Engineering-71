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

            if (radio.On == false)
            {
                radio.TurnOn();
                DisplayBox.Text = "Turning on...";
            }
            else
            {
                radio.TurnOff();
                DisplayBox.Text = "Turning off...";
                radioPlayer.Pause();
            }
            
        }

        private void Play_Button_Click(object sender, RoutedEventArgs e)
        {
            var x = radio.Play();
            DisplayBox.Text = x;
            if (radio.On == true)
            {
                radioPlayer.Play();
            }

            switch (radio.Channel)
            {
                case (1):
                    radioPlayer.Source = new Uri("C:/github/Engineering-71/homework/RadioAppStarterCode/RadioAppInterface/Audio/bensound-birthofahero.mp3");
                    break;
                case (2):
                    radioPlayer.Source = new Uri("C:/github/Engineering-71/homework/RadioAppStarterCode/RadioAppInterface/Audio/bensound-epic.mp3");
                    break;
                case (3):
                    radioPlayer.Source = new Uri("C:/github/Engineering-71/homework/RadioAppStarterCode/RadioAppInterface/Audio/bensound-evolution.mp3");
                    break;
                case (4):
                    radioPlayer.Source = new Uri("C:/github/Engineering-71/homework/RadioAppStarterCode/RadioAppInterface/Audio/bensound-theduel.mp3");
                    break;
                default:
                    break;
            }
        }

        private void Pause_Button_Click(object sender, RoutedEventArgs e)
        {
            var x = radio.Pause();
            DisplayBox.Text = x;
            if (radio.On)
            {
                radioPlayer.Pause();
            }
        }

        private static int x = 1;
        private void Next_Button_Click(object sender, RoutedEventArgs e)
        {

            if (radio.On == true)
            {
                if (x > 0 && x <= 4)
                {
                    x++;
                    radio.Channel = x;
                    DisplayBox.Text = $"Switching to channel {x}. Press Play!";
                    radioPlayer.Play();
                }
                if (x > 4)
                {
                    x = 1;
                    radio.Channel = x;
                    DisplayBox.Text = $"Switching to channel {x}. Press Play!";
                }
            }
            else
            {
                DisplayBox.Text = "";
            }
        }

        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            radioPlayer.Volume = VolumeSlider.Value;
        }

    }
}
