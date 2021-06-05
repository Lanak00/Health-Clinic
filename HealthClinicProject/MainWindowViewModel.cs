using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthClinicProject.ViewModel;
using System.Windows;
using System.Windows.Media;
using System.Diagnostics;

namespace HealthClinicProject
{
    public class MainWindowViewModel : BindableBase
    {
        public MyICommand<string> NavCommand { get; private set; }

        private AppointmentHistoryViewModel appointmentHistoryViewModel = new AppointmentHistoryViewModel();
        private HomePageViewModel homePageViewModel = new HomePageViewModel();
        private MedicalCardViewModel medicalCardViewModel = new MedicalCardViewModel();
        private ScheduledAppointmentsViewModel scheduledAppointmentsViewModel = new ScheduledAppointmentsViewModel();
        private TherapyViewModel therapyViewModel = new TherapyViewModel();
        private ScheduleNewAppointmentViewModel scheduleNewAppointmentViewModel = new ScheduleNewAppointmentViewModel();
        private MyProfileViewModel myProfileViewModel = new MyProfileViewModel();
        private BindableBase currentViewModel;

        //public int get_count()
        //{
        //    return homePageViewModel.MyObjects.Count;
        //}

        public MainWindowViewModel()
        {
            NavCommand = new MyICommand<string>(OnNav);
            CurrentViewModel = homePageViewModel;
        }

        public BindableBase CurrentViewModel
        {
            get { return currentViewModel; }
            set
            {
                SetProperty(ref currentViewModel, value);
            }
        }

       
        private void OnNav(string destination)
        {
            switch (destination)
            {
                case "HomePageView":
                    CurrentViewModel = homePageViewModel;
                    break;
                case "AppontmentHistoryView":
                    CurrentViewModel = appointmentHistoryViewModel;
                    break;
                case "MedicalCardView":
                    CurrentViewModel = medicalCardViewModel;
                    break;
                case "ScheduledAppointmentsView":
                    CurrentViewModel = scheduledAppointmentsViewModel;
                    break;
                case "TherapyView":
                    CurrentViewModel = therapyViewModel;
                    break;
                case "ScheduleNewAppointmentView":
                    CurrentViewModel = scheduleNewAppointmentViewModel;
                    break;
                case "MyProfileView":
                    CurrentViewModel = myProfileViewModel;
                    break;
                case "AppointmentHistoryView":
                    CurrentViewModel = appointmentHistoryViewModel;
                    break;
            }
        }
    }
}
