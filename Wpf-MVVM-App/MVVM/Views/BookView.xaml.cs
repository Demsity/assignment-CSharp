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
using Wpf_MVVM_App.MVVM.Models;
using Wpf_MVVM_App.MVVM.ViewModels;
using Wpf_MVVM_App.Services;

namespace Wpf_MVVM_App.MVVM.Views
{
    /// <summary>
    /// Interaction logic for BookView.xaml
    /// </summary>
    public partial class BookView : UserControl
    {
        

        public BookView()
        {
            InitializeComponent();
            
        }


        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var item = (StackPanel)sender;
            Contact contact = (Contact)item.DataContext;
            ContactService.SelectedContact = contact;
        }
    }
}

