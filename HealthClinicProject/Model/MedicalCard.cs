using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinicProject.Model
{
    class MedicalCard : INotifyPropertyChanged

    {
        private string medicalRecordId;
        private string patientId;
        private string firstName;
        private string lastName;
        private string parentName;
        private string dateOfBirth;
        private string healthInsuranceCarrier;
        private string cityAndCountry;
        private string streetAndNumber;
        private string phoneNumber;

        public string FullName
        {
            get { return firstName + " " + parentName + " " + lastName; }
        }

        public string Name
        {
            get { return firstName + " " + lastName; }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    RaisePropertyChanged("FirstName");
                    RaisePropertyChanged("FullName");
                    RaisePropertyChanged("Name");
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    RaisePropertyChanged("LastName");
                }
            }
        }

        public string MedicalRecordId
        {
            get { return medicalRecordId; }
            set
            {
                if (medicalRecordId != value)
                {
                    medicalRecordId = value;
                    RaisePropertyChanged("MedicalRecordId");
                }
            }
        }

        public string PatientId
        {
            get { return patientId; }
            set
            {
                if (patientId != value)
                {
                    patientId = value;
                    RaisePropertyChanged("PatientId");
                }
            }
        }
        public string ParentName
        {
            get { return parentName; }
            set
            {
                if (parentName != value)
                {
                    parentName = value;
                    RaisePropertyChanged("ParentName");

                }
            }
        }
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                if (dateOfBirth != value)
                {
                    dateOfBirth = value;
                    RaisePropertyChanged("DateOfBirth");

                }
            }
        }

        public string HealthInsuranceCarrier
        {
            get { return healthInsuranceCarrier; }
            set
            {
                if (healthInsuranceCarrier != value)
                {
                    healthInsuranceCarrier = value;
                    RaisePropertyChanged("HealthInsuranceCarrier");

                }
            }
        }

        public string StreetAndNumber
        {
            get { return streetAndNumber; }
            set
            {
                if (streetAndNumber != value)
                {
                    streetAndNumber = value;
                    RaisePropertyChanged("StreetAndNumber");

                }
            }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (phoneNumber != value)
                {
                    phoneNumber = value;
                    RaisePropertyChanged("PhoneNumber");

                }
            }
        }

        public string CityAndCountry
        {
            get { return cityAndCountry; }
            set
            {
                if (cityAndCountry != value)
                {
                    cityAndCountry = value;
                    RaisePropertyChanged("CityAndCountry");

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


