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
using Wpf_MVVM_App.Services;

namespace Wpf_MVVM_App
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


        private void btn_delete_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var Result = MessageBox.Show($"Är du säker att du vill ta bort {ContactService.SelectedContact.FullName} från Adressboken?", "Ta bort kontakt",   MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (Result == MessageBoxResult.Yes)
            {
                ContactService.RemoveContactFromList(ContactService.SelectedContact);
            } 
            
        }
    }
}
