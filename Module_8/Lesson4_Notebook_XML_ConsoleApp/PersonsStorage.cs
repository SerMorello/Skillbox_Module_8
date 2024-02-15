public class PersonsStorage
{
    static public List<Person> persons = new();

    static public void AddPerson(string[] person)
    {
        Person tempPerson = new() { }
        persons.Add(person);
    }
    static public void RemovePerson(int i)
    {
        persons.RemoveAt(i - 1);
    }
    
}