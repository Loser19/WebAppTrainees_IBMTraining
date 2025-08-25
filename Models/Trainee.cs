using System.ComponentModel.DataAnnotations; // Needed for data annotations

namespace WebAppTrainees.Models
{
    public class Trainee
    {
        [Key] // This attribute indicates that this property is the primary key
        public int Id { get; set; } 

        [Required] // This attribute indicates that this property is required and is not null
        public string Name { get; set; } = string.Empty;

        [EmailAddress] // This attribute validates that the string is a valid email address
        public string Email { get; set; } = string.Empty;

        // not adding anything means it can take null
        public string Address { get; set; } = string.Empty;
        public Trainee() { }
        public Trainee(int id, string name, string email, string address)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Email: {Email}, Address: {Address}";
        }
    }
}

