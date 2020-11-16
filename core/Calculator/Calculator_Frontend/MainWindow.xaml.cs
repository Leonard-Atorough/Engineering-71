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
        string x;
        string y;
        char symbol = '0';


        // Method object handlers
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            symbol = '+';
            displayBox.Text += symbol;
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            symbol = '-';
            displayBox.Text += symbol;
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            symbol = 'x';
            displayBox.Text += symbol;
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            symbol = '/';
            displayBox.Text += symbol;
        }


        // Calculation initialize object handler - Runs the calculation and displays the result
        private void Operate_Click(object sender, RoutedEventArgs e)
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

            /* if (symbol == '+')
            {
                double output = CalculatorMethods.Add(num1, num2);

                displayBox.Text = output.ToString();
                x = output.ToString();
                y = "";
            }
            else if (symbol == '-')
            {
                double output = CalculatorMethods.Subtract(num1, num2);

                displayBox.Text = output.ToString();
                x = output.ToString();
                y = "";
            }
            else if (symbol == 'x')
            {
                double output = CalculatorMethods.Product(num1, num2);

                displayBox.Text = output.ToString();
                x = output.ToString();
                y = "";
            }
           else if (symbol == '/')
            {
                double output = CalculatorMethods.Quotient(num1, num2);

                displayBox.Text = output.ToString();
                x = output.ToString();
                y = "";
            }

            else
            {
                displayBox.Text = "Error!";
                x = "";
            } */

        }


        // Number button click handlers - assigns values to variables and prints to screen
        private void One_Button_Click(object sender, RoutedEventArgs e)
        {
            if (symbol == '0')
            {
                x += '1';
                displayBox.Text = x;
            }

            else
            {
                y += '1';
                displayBox.Text = ($"{x}{symbol}{y}");
            }

        }

        private void Two_Button_Click(object sender, RoutedEventArgs e)
        {
            if (symbol == '0')
            {
                x += '2';
                displayBox.Text = x;
            }

            else
            {
                y += '2';
                displayBox.Text = ($"{x}{symbol}{y}");
            }

        }

        private void Three_Button_Click(object sender, RoutedEventArgs e)
        {
            if (symbol == '0')
            {
                x += '3';
                displayBox.Text = x;
            }

            else
            {
                y += '3';
                displayBox.Text = ($"{x}{symbol}{y}");
            }

        }

        private void Four_Button_Click(object sender, RoutedEventArgs e)
        {
            if (symbol == '0')
            {
                x += '4';
                displayBox.Text = x;
            }

            else
            {
                y += '4';
                displayBox.Text = ($"{x}{symbol}{y}");
            }

        }

        private void Five_Button_Click(object sender, RoutedEventArgs e)
        {
            if (symbol == '0')
            {
                x += '5';
                displayBox.Text = x;
            }

            else
            {
                y += '5';
                displayBox.Text = ($"{x}{symbol}{y}");
            }

        }

        private void Six_Button_Click(object sender, RoutedEventArgs e)
        {
            if (symbol == '0')
            {
                x += '6';
                displayBox.Text = x;
            }

            else
            {
                y += '6';
                displayBox.Text = ($"{x}{symbol}{y}");
            }

        }

        private void Seven_Button_Click(object sender, RoutedEventArgs e)
        {
            if (symbol == '0')
            {
                x += '7';
                displayBox.Text = x;
            }

            else
            {
                y += '7';
                displayBox.Text = ($"{x}{symbol}{y}");
            }

        }

        private void Eight_Button_Click(object sender, RoutedEventArgs e)
        {
            if (symbol == '0')
            {
                x += '8';
                displayBox.Text = x;
            }

            else
            {
                y += '8';
                displayBox.Text = ($"{x}{symbol}{y}");
            }

        }

        private void Nine_Button_Click(object sender, RoutedEventArgs e)
        {
            if (symbol == '0')
            {
                x += '9';
                displayBox.Text = x;
            }

            else
            {
                y += '9';
                displayBox.Text = ($"{x}{symbol}{y}");
            }

        }

        private void Zero_Button_Click(object sender, RoutedEventArgs e)
        {
            if (symbol == '0')
            {
                x += '0';
                displayBox.Text = x;
            }

            else
            {
                y += '0';
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

        private void Dot_Button_Click(object sender, RoutedEventArgs e)
        {
            if (symbol == '0')
            {
                x += '.';
                displayBox.Text = x;
            }

            else
            {
                y += '.';
                displayBox.Text = ($"{x}{symbol}{y}");
            }
        }
    }
}
