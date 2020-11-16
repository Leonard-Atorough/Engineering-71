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
using Calculator;

namespace Calculator_Frontend
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

        // Initial variable delcaration
        string x = "";
        string y;
        char symbol = '0';


        // Method object handlers
        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            var tag = (button).Content.ToString();

            symbol = Char.Parse(tag);
            displayBox.Text += symbol;
        }

        // Calculation initialize object handler - Runs the calculation and displays the result
        private void Calculate_Click(object sender, RoutedEventArgs e)
        {

            double num1 = double.Parse(x);
            double num2 = double.Parse(y);
            double output = 0;

            switch (symbol)
            {
                case ('+'):
                    output = CalculatorMethods.Add(num1, num2);
                    break;
                case ('-'):
                    output = CalculatorMethods.Subtract(num1, num2);
                    break;
                case ('/'):
                    output = CalculatorMethods.Quotient(num1, num2);
                    break;
                case ('x'):
                        output = CalculatorMethods.Product(num1, num2);
                        break;
                default:
                    x = "";
                    output = 0;
                    break;
            }
            displayBox.Text = output.ToString();
            x = output.ToString();
            y = "";
        }


        // Number button click handlers - assigns values to variables and prints to screen
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            var tag = (button).Content.ToString();

            if (symbol == '0')
            {
                x += tag;
                displayBox.Text = x;
            }

            else
            {
                y += tag;
                displayBox.Text = ($"{x}{symbol}{y}");
            }
        }

        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            x = "";
            y = "";
            symbol = '0';
            displayBox.Text = "";
        }

        //private void Minus_Button_Click(object sender, RoutedEventArgs e)
        //{
        //    if (symbol == 0 && x.Contains("-") == false)
        //    {

        //    }

        //    else if (symbol == 0 && x.Contains("-") == true)
        //    {

        //    }
            
        //    else if
        //}
    }
}
