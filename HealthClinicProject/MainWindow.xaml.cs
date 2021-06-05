using HealthClinicProject.ViewModel;
using HealthClinicProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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


namespace HealthClinicProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            this.Menu.Visibility = this.Menu.Visibility == Visibility.Visible
                                        ? Visibility.Collapsed
                                        : Visibility.Visible;
        }
        private bool _canOpen = false;
        private void MenuItem_SubmenuOpened(object sender, RoutedEventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            item.IsSubmenuOpen = _canOpen;
        }

        private void MenuItem_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            _canOpen = !_canOpen;
            item.IsSubmenuOpen = _canOpen;
        }
    }
}

