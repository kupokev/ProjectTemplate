using Microsoft.AspNetCore.Identity;

namespace ProjectTemplate.Data.Models.Entity
{
    public class ApplicationUserClaim : IdentityUserClaim<int>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
