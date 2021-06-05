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
using System.Windows.Shapes;
using HealthClinicProject.ViewModel;

namespace HealthClinicProject.View
{
    /// <summary>
    /// Interaction logic for ScheduleNewAppointmentView.xaml
    /// </summary>
    public partial class ScheduleNewAppointmentView : UserControl
    {
        public ScheduleNewAppointmentView()
        {
            InitializeComponent();
            this.DataContext = new ScheduleNewAppointmentViewModel(); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
