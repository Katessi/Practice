﻿using System.Windows;
using System.Windows.Controls;

namespace Practice.Pages.Lesson5
{
    /// <summary>
    /// Interaction logic for Example1.xaml
    /// </summary>
    public partial class Example1 : Page
    {
        public Example1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button is clicked");
        }
    }
}
