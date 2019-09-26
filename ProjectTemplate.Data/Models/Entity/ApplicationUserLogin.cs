using Microsoft.AspNetCore.Identity;

namespace ProjectTemplate.Data.Models.Entity
{
    public class ApplicationUserLogin : IdentityUserLogin<int>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
