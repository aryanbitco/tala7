
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tala7_3.Model.Profile;

namespace Tala7_3.Model
{
    public class UserProfile :Abstrackfields
    {
        public UserProfile(string userId)
        {
            //TODO:Create Guard
            UserId = userId;
            //ApplicantId = applicantId;
        }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

       

    }

}
