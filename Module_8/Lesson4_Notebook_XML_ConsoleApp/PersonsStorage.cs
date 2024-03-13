using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
public class PersonsStorage
{
    static string path = "People";
    static public List<Person> persons = new();

    static public void AddPerson(string[] person)
    {
        Person tempPerson = new Person();
        Address tempAddress = new();
        Phones tempPhones = new();

        tempPerson.FirstName = person[0];
        tempPerson.LastName = person[1];
        //tempPerson.Address.Street = person[2];
        //tempPerson.Address.HouseNumber = person[3];
        //tempPerson.Address.FlatNumber = person[4];
        tempAddress.Street = person[2];
        tempAddress.HouseNumber = person[3];
        tempAddress.FlatNumber = person[4];
        tempPerson.Phones.MobilePhone = person[5];
        tempPerson.Phones.FlatPhone = person[6];
        //tempPhones.MobilePhone = Convert.ToUInt64(person[5]);
        //tempPhones.FlatPhone = Convert.ToUInt32(person[6]);

        tempPerson.Address = tempAddress;
        tempPerson.Phones = tempPhones;

        persons.Add(tempPerson);
    }
    static public void RemovePerson(int i)
    {
        persons.RemoveAt(i - 1);
    }
    static public void SerializationPersons()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));

        XmlWriterSettings settings = new XmlWriterSettings { Indent = true, IndentChars = " " };

        using (XmlWriter writer = XmlTextWriter.Create(path, settings))
        {
            serializer.Serialize(writer, persons);
        }

        //using (FileStream fStream = new FileStream(path, FileMode.Append, FileAccess.Write))
        //{  
        //    serializer.Serialize(fStream, persons);

        //    Console.WriteLine("Данные сохранены");
        //}
    }
    static public List<Person> DeserializationPersons()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
        List<Person> tempListPerson = new List<Person>();

        using (FileStream fstream = new FileStream(path, FileMode.Open))
        {
            tempListPerson = serializer.Deserialize(fstream) as List<Person>;
        }
        return tempListPerson;
    }
    static public void ShowPersons()
    {

        List<Person> tempPersons = new List<Person>();

        tempPersons = DeserializationPersons();
        string head = $"|ФИО                  |Адрес                 |Тел. мобильный    |Т.домашний|";
        foreach (var person in tempPersons)
        {
            Console.WriteLine(head);
            Console.WriteLine($"|{person.FirstName,-7} {person.LastName,-13}|" +
                $"{person.Address.Street,-12} {person.Address.HouseNumber,-4} {person.Address.FlatNumber,-4}|" +
                $"{person.Phones.MobilePhone.ToString("+# (###) ###-##-##"),-18}" +
                $"|{person.Phones.FlatPhone.ToString("###-##-##"),-10}|");
        }

        Console.WriteLine();
    }
    static public bool CheckFile()
    {
        if (File.Exists(path))
        {
            return true;
        }
        return false;
    }
}