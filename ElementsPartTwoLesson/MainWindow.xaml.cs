﻿using System;
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

namespace ElementsPartTwoLesson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            contentContainer.Content = new FirstContent();
            adMediaElement.LoadedBehavior = MediaState.Manual;
            adMediaElement.Play();
        }

        private void MenuItemClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ShowFirstContent(object sender, RoutedEventArgs e)
        {
            contentContainer.Content = new FirstContent();
        }

        private void ShowSecondContent(object sender, RoutedEventArgs e)
        {
            contentContainer.Content = new SecondContent();
        }
    }
}
