public class Person
{
    string FirstName { get; set; }
    string LastName { get; set; }
    Address adress { get; set; }
    Phones phones { get; set; }
    public Person(string firstName, string lastName, Address adress, Phones phones)
    {
        FirstName = firstName;
        LastName = lastName;
        this.adress = adress;
        this.phones = phones;
    }
}