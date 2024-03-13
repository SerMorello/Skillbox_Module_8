using System.Xml;
using System.Xml.Serialization;

public class FileExplorer
{
    static public void SerializationPersons(string path, List<Person> persons)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));

        XmlWriterSettings settings = new XmlWriterSettings { Indent = true, IndentChars = " " };

        using (XmlWriter writer = XmlTextWriter.Create(path, settings))
        {
            serializer.Serialize(writer, persons);

            Console.WriteLine("Данные сохранены");
        }

    }
    static public List<Person> DeserializationPersons(string path)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
        List<Person> tempListPerson = new List<Person>();

        using (FileStream fstream = new FileStream(path, FileMode.Open))
        {
            tempListPerson = serializer.Deserialize(fstream) as List<Person>;
        }
        return tempListPerson;
    }
    static public bool CheckFile(string path)
    {
        if (File.Exists(path))
        {
            return true;
        }
        return false;
    }
}