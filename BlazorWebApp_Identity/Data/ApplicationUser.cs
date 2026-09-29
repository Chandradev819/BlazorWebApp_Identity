using Microsoft.AspNetCore.Identity;

namespace BlazorWebApp_Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        // Optional: add first and last name for profile
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
    }

}
