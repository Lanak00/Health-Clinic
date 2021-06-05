using HealthClinicProject.View;
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
using HealthClinicProject.Model.DTOs;
using System.Collections.ObjectModel;

namespace HealthClinicProject.ViewModel
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class AppointmentHistoryViewModel : BindableBase
    {
        public ObservableCollection<AppointmentDTO> UserAppointments { get; set; }
        public AppointmentHistoryViewModel()
        {
            ObservableCollection<AppointmentDTO> userAppointments =
                new ObservableCollection<AppointmentDTO>();

            userAppointments.Add(new AppointmentDTO()
            {
                AppointmentType = "Neurologic Examination",
                AppointmentDateTime = "12.3.2021. 18:56",
                DoctorFullName = "Dr Mladen Stojanovic"
            });
            userAppointments.Add(new AppointmentDTO()
            {
                AppointmentType = "Blood analysis",
                AppointmentDateTime = "10.3.2021. 19:20",
                DoctorFullName = "Dr Ivana Markovic"
            });
            userAppointments.Add(new AppointmentDTO()
            {
                AppointmentType = "Examination",
                AppointmentDateTime = "12.6.2020. 16:00",
                DoctorFullName = "Dr Mladen Stojanovic"
            });
            userAppointments.Add(new AppointmentDTO()
            {
                AppointmentType = "Blood analysis",
                AppointmentDateTime = "11.6.2020. 10:00",
                DoctorFullName = "Dr Mladen Stojanovic"
            });
            userAppointments.Add(new AppointmentDTO()
            {
                AppointmentType = "Examination",
                AppointmentDateTime = "10.1.2020. 16:00",
                DoctorFullName = "Dr Dr Ivana Markovic"
            });
            UserAppointments = userAppointments;
        }
    }

}

       