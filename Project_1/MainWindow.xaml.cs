/*
 * Project_1: This program will take in the weight and height of an individual and return a color indicating how healthy their 
 *            BMI is
 * Name: Spencer Unitt
 * Module: Homework 5, Project 1
 * Problem Statement: Calculate BMI using a GUI and show the results changing the color of a canvas
 * 
 * Algorithm: 
 *  1. Create the gui with enough textboxes to take in the weight and height, two buttons (calculate BMI and exit), and textblocks
 *     that show what the textboxes below are used for. Throw in a canvas that will change colors when the button is clicked
 *  2. Inside the code block if the button is clicked do the following. 
 *     Create 3 doubles named weight, height, and BMI
 *  3. Weight and height will equal the information put into the textboxes by the user
 *  4. BMI can be calculated with the equation (weight / height / height) * 703
 *  5. Use if statements to determine the health of the individual. 
 *     if BMI < 15 then change color to blue and return below average in textblock
 *     if BMI >= 15 && BMI <=26 change color to green and return healthy average
 *     if BMI > 26 change color to red and return higher than average
 *  6. Display the results to the user.    
 * 
 */

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

namespace Project_1
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

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            // double variables used
            double weight, height, BMI;

            // sets the weight to the information in the textbox
            weight = double.Parse(weight_box.Text);

            // sets the height to equal the total in inches.
            height = (double.Parse(feet_box.Text) * 12) + double.Parse(inch_box.Text);

            BMI = (weight / height / height) * 703;
            
            // Determines what code block to use depending on the results of BMI 
            if(BMI < 15)
            {
                // changes color of the canvas in the GUI
                color.Background = Brushes.Blue;
                // Adds text to the textblock below the GUI
                results.Text = "Your BMI at " + BMI.ToString("F") + " is below average";
            }
            else if(BMI >= 15 && BMI <= 26 )
            {
                color.Background = Brushes.Green;
                results.Text = "Your BMI at " + BMI.ToString("F") + " is within a healthly range";
            }
            else if(BMI > 26)
            {
                color.Background = Brushes.Red;
                results.Text = "Your BMI at " + BMI.ToString("F") + " is above average";
            }
            else
            {
                // error message
                results.Text = "No results found.";
            }

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            // closes the program if the user clicks exit
            this.Close();
        }
    }
}
