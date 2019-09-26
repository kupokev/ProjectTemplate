using Microsoft.AspNetCore.Identity;

namespace ProjectTemplate.Data.Models.Entity
{
    public class ApplicationUserToken : IdentityUserToken<int>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
