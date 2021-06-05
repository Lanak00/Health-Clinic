using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinicProject.Model.DTOs
{
    public class AppointmentDTO : INotifyPropertyChanged
    {
        private string appointmentType;
        private string appointmentDateTime;
        private string doctorFullName;

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

        public string AppointmentDateTime
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

        public string DoctorFullName
        {
            get { return doctorFullName; }
            set
            {
                if (doctorFullName != value)
                {
                    doctorFullName = value;
                    RaisePropertyChanged("DoctorFullName");
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
