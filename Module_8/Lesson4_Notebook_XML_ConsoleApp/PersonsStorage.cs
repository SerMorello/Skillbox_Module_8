using System.Xml.Linq;
public partial class PersonsStorage
{
    public string path = "People";

    public Person AddPerson(string[] person)
    {
        Person tempPerson = new();
        Address tempAddress = new();
        Phones tempPhones = new();

        tempPerson.FirstName = person[0];
        tempPerson.LastName = person[1];

        tempAddress.Street = person[2];
        tempAddress.HouseNumber = person[3];
        tempAddress.FlatNumber = person[4];

        tempPhones.MobilePhone = person[5];
        tempPhones.FlatPhone = person[6];

        tempPerson.Address = tempAddress;
        tempPerson.Phones = tempPhones;

        return tempPerson;
    }
    public void RemovePerson(int i, List<Person> persons)
    {
        persons.RemoveAt(i - 1);
    }
    public void ShowPersons()
    {

        List<Person> tempPersons = new List<Person>();

        tempPersons = FileExplorer.DeserializationPersons(path);
        string head = $"|ФИО                  |Адрес                 |Тел. мобильный     |Т.домашний|";
        foreach (var person in tempPersons)
        {
            Console.WriteLine(head);
            Console.WriteLine($"|{person.FirstName,-7} {person.LastName,-13}|" +
                $"{person.Address.Street,-12} {person.Address.HouseNumber,-4} {person.Address.FlatNumber,-4}|" +
                $"{person.Phones.MobilePhone,-18} | {person.Phones.FlatPhone,-9}|");
        }

        Console.WriteLine();
    }
    
}