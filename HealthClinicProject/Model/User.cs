using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinicProject.Model
{
    class User : ValidationBase
    {
        public String Username { get; set; }
        public String Password { get; set; }

        protected override void ValidateSelf()
        {
            throw new NotImplementedException();
        }
    }
}
