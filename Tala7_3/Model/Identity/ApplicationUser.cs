

using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using Tala7_3.Model.Profile;

namespace Tala7_3.Model
{

public class ApplicationUser : IdentityUser
{
    public string Fullname { get; set; }

    //public ICollection<Applicant> Applicants { get; protected set; }
 
}




}
