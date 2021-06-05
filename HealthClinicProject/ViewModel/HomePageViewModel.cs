using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinicProject.ViewModel 
{
    public class HomePageViewModel : BindableBase
    {
        public HomePageViewModel()
        {

        }
        private static HomePageViewModel instance = null;
        private static readonly object padlock = new object();


        public static HomePageViewModel Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new HomePageViewModel();
                    }
                    return instance;
                }
            }
        }
    }
}
