using Microsoft.AspNetCore.Identity;

namespace eCommerceStu.Data.Entities
{
    public class AppRole : IdentityRole<int>
    {
        public AppRole() { }
        public AppRole(string name)
        {
            Name = name;
        }
    }
}