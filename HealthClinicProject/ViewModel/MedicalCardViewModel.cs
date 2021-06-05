using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HealthClinicProject.Model;


namespace HealthClinicProject.ViewModel
{
    class MedicalCardViewModel : BindableBase
    {
        public ObservableCollection<MedicalCard> MedicalCard { get; set; }

        public MedicalCardViewModel()
        {
            ObservableCollection<MedicalCard> medicalCard =
                new ObservableCollection<MedicalCard>();

            medicalCard.Add(new MedicalCard
            {
                MedicalRecordId = "001805021",
                PatientId = "805021000805021",
                FirstName = "Ana",
                LastName = "Milanovic",
                ParentName = "Milan",
                DateOfBirth = "28.5.1995.",
                HealthInsuranceCarrier = "Milan Milanovic",
                CityAndCountry = "Novi Sad, Srbija",
                StreetAndNumber = "Kisacka 27",
                PhoneNumber = "0647895236",
            });
            MedicalCard = medicalCard;
        }
    }
}
