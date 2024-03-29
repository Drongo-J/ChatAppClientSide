﻿using ChatAppClientSide.Services.NetworkServices;
using ChatAppClientSide.ViewModels;
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

namespace ChatAppClientSide
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var mainWindowViewModel = new MainWindowViewModel();
            App.MainWindowViewModel= mainWindowViewModel;
            mainWindowViewModel.ScrollViewer = ScrollViewer;
            this.DataContext = mainWindowViewModel;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            NetworkServices.Message = "exit";   
        }
    }
}
