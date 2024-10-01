namespace FashionStore.Domain.Entities;

public class User : BaseEntity
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; } 

    public ICollection<UserPromotion>? UserPromotions { get; set; }
    public ICollection<Review>? Reviews { get; set; }

    public User(string username, string password, string email, string firstName, string lastName)
    {
        Username = username;
        Password = password;
        Email = email;
        FirstName = firstName;
        LastName = lastName;
    }
}