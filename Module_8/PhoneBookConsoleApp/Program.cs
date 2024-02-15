var PhoneBook = new Dictionary<string, string>();
var exit = false;
string number;
string name;


while (!exit)
{
    Console.WriteLine("Выберите что делать\n1.Добавить запись.\n2.Найти запись.\n3.Завершить работу.");
    int menu = Convert.ToInt32(Console.ReadLine());

    switch (menu)
    {
        case 1:
            Console.WriteLine("В первой строке введите номер телефона, во второй имя\nДля завершения введитепустую строку.");
            AddNotes();
            break;

        case 2:
            Console.WriteLine("Введите номер кого ищем");
            number = Console.ReadLine();
            Console.WriteLine($"Владелец номера {number} {SearchNote()}");
            break;
        case 3:
            exit = true;
            break;
    }
}

void AddNotes()
{
    while (true)
    {
        number = Console.ReadLine();
        if (number == String.Empty)
        {
            break;
        }
        name = Console.ReadLine();

        PhoneBook.Add(number, name);
    }
}

string SearchNote()
{
    if (PhoneBook.TryGetValue(number, out string name))
    {
        return name;
    }

    return "не зарегистрирован";
}
