using Microsoft.AspNetCore.Identity;

namespace FashionStore.Domain.Entities;

public class AppUser : IdentityUser
{
    //public string ?FirstName { get; set; }
    //public string ?LastName { get; set; } 

    public ICollection<UserPromotion>? UserPromotions { get; set; }
    public ICollection<Review>? Reviews { get; set; }
}