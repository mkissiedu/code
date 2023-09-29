public class ContactBook
{
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public void AddContact(string name, string phoneNumber, string email)
    {
        this.Name = name;
        this.PhoneNumber = phoneNumber;
        this.Email = email;
    }
    public void DisplayContact()
    {
        Console.WriteLine("Name: " + this.Name);
        Console.WriteLine("Phone Number: " + this.PhoneNumber);
        Console.WriteLine("Email: " + this.Email);
    }
}