using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthClinicProject;

namespace HealthClinicProject.Model
{

    public class Appointment : INotifyPropertyChanged
    {
        private string appointmentType;
        private DateTime appointmentDateTime;
        private DateTime timestamp;
        private string hall;
        private string doctor;
        private string clinic;

        public string AppointmentType
        {
            get { return appointmentType; }
            set
            {
                if (appointmentType != value)
                {
                    appointmentType = value;
                    RaisePropertyChanged("AppointmentType");
                }
            }
        }

        public DateTime AppointmentDateTime
        {
            get { return appointmentDateTime; }
            set
            {
                if (appointmentDateTime != value)
                {
                    appointmentDateTime = value;
                    RaisePropertyChanged("AppointmentDateTime");
                }
            }
        }

        public DateTime Timestamp
        {
            get { return timestamp; }
            set
            {
                if (timestamp != value)
                {
                    timestamp = value;
                    RaisePropertyChanged("Timestamp");
                }
            }
        }

        public string Hall
        {
            get { return hall; }
            set
            {
                if (hall != value)
                {
                    hall = value;
                    RaisePropertyChanged("Hall");
                }
            }
        }

        public string Doctor
        {
            get { return doctor; }
            set
            {
                if (doctor != value)
                {
                    doctor = value;
                    RaisePropertyChanged("Doctor");
                }
            }
        }

        public string Clinic
        {
            get { return clinic; }
            set
            {
                if (clinic != value)
                {
                    clinic = value;
                    RaisePropertyChanged("Clinic");
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

    }
}
