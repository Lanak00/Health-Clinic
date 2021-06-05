using HealthClinicProject.Model;
using HealthClinicProject.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HealthClinicProject.ViewModel
{
    public class ScheduledAppointmentsViewModel : BindableBase
    {
        public ObservableCollection<AppointmentDTO> UserAppointments { get; set; }
        public ScheduledAppointmentsViewModel()
        {
            ObservableCollection<AppointmentDTO>  userAppointments = 
                new ObservableCollection<AppointmentDTO>();

            userAppointments.Add(new AppointmentDTO()
            {
                AppointmentType = "Examination",
                AppointmentDateTime = "12.3.2021. 18:56",
                DoctorFullName = "Dr Mladen Stojanovic"
            });
            userAppointments.Add(new AppointmentDTO()
            {
                AppointmentType = "Blood analysis",
                AppointmentDateTime = "12.3.2021. 19:20",
                DoctorFullName = "Dr Ivana Markovic"
            });
            userAppointments.Add(new AppointmentDTO()
            {
                AppointmentType = "Examination",
                AppointmentDateTime = "12.6.2021. 16:00",
                DoctorFullName = "Dr Mladen Stojanovic"
            });
            UserAppointments = userAppointments;
        }

    }
}


