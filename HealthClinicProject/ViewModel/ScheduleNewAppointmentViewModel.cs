using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthClinicProject.Model;

namespace HealthClinicProject.ViewModel
{
    class ScheduleNewAppointmentViewModel : BindableBase
    {
        public ObservableCollection<Appointment> Appointments { get; set; }
        public Appointment SelectedDoctor { get; set; }
        public ScheduleNewAppointmentViewModel()
        {
            ObservableCollection<Appointment> appointments =
                new ObservableCollection<Appointment>();

            appointments.Add(new Appointment { Doctor = " Dr Mladen Stojanovic" });
            appointments.Add(new Appointment { Doctor = " Dr Ivana Markovic" });
            appointments.Add(new Appointment { Doctor = " Dr Nenad Vukasinovic" });

            Appointments = appointments;
        } 
    }
}
