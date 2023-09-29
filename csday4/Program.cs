
public class Program
{
    public static void Main()
    {
        ContactBook contactBook1 = new ContactBook();
        ContactBook contactBook2 = new ContactBook();
        contactBook1.AddContact("John", "1234567890", "abc@abc.com");
        contactBook2.AddContact("Molly", "1234567890", " [email protected] ");
        contactBook1.DisplayContact();
        contactBook2.DisplayContact();
    }

 }
