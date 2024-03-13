public class PersonsStorage
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
    public void RemovePerson(List<Person> persons)
    {
        Console.WriteLine("Введите номер записи которую хотите удалить");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice < 1 || choice > persons.Count)
        {
            while (choice < 1 || choice > persons.Count)
            {
                Console.WriteLine("Введите коректный номер");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }

        persons.RemoveAt(choice - 1);

        Console.WriteLine("Запись удалена");
        Console.WriteLine();
    }
    public void ShowPersons(List<Person> Persons)
    {
        int cnt = 0;

        string head = $"|№|ФИО                  |Адрес                 |Тел. мобильный     |Т.домашний|";
        Console.WriteLine(head);
        foreach (var person in Persons)
        {
            Console.WriteLine($"|{++cnt}|{person.FirstName,-7} {person.LastName,-13}|" +
                $"{person.Address.Street,-12} {person.Address.HouseNumber,-4} {person.Address.FlatNumber,-4}|" +
                $"{person.Phones.MobilePhone,-18} | {person.Phones.FlatPhone,-9}|");
        }

        Console.WriteLine();
    }

}