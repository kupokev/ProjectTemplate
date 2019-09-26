using Microsoft.AspNetCore.Identity;

namespace ProjectTemplate.Data.Models.Entity
{
    public class ApplicationUserRole : IdentityUserRole<int>
    {
        public virtual ApplicationUser User { get; set; }

        public virtual ApplicationRole Role { get; set; }
    }
}
