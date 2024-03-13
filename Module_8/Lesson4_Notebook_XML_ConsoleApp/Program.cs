int menu;
bool exit = false;

PersonsStorage departmentLogistics = new();
    List<Person> persons = new();

if (FileExplorer.CheckFile(departmentLogistics.path))
{
    persons = FileExplorer.DeserializationPersons(departmentLogistics.path);
}

while (!exit)
{
    Console.WriteLine("Выберите действие\n1.Добаить запись\n2.Посмотреть записи\n3.Удалить запись\n4.Завершить работу");
    menu = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch (menu)
    {
        case 1:
            string[] tempDataPerson = new string[7];
            Console.WriteLine("Давайте начнем вводить данные\nВсе данные вводятся с новой строки!\nВведите Имя\nФамилию");
            tempDataPerson[0] = Console.ReadLine();
            tempDataPerson[1] = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Теперь адрес \nНазвание улицы\nНоммер дома\nНомер квартиры");
            tempDataPerson[2] = Console.ReadLine();
            tempDataPerson[3] = Console.ReadLine();
            tempDataPerson[4] = Console.ReadLine();
            Console.WriteLine();


            Console.WriteLine("Остался телефон. Если какого-то телефона нет, вводи пустую строку" +
                "\nНомер состового телефона (11 цифр)\nНоммер домашнего телефона (7 цифр)");

            tempDataPerson[5] = Console.ReadLine();

            //while (!Phones.CheckPhone(tempDataPerson[5], 11))
            //{
            //    tempDataPerson[5] = Console.ReadLine();
            //    Console.WriteLine();
            //}

            tempDataPerson[6] = Console.ReadLine();

            persons.Add(departmentLogistics.AddPerson(tempDataPerson));

            FileExplorer.SerializationPersons(departmentLogistics.path, persons);
            break;

        case 2:
            if (FileExplorer.CheckFile(departmentLogistics.path))
            {
                departmentLogistics.ShowPersons(); break;
            }
            else
            {
                Console.WriteLine("Записей нет");
                Console.WriteLine();
                break;
            }
        case 3: Console.WriteLine("3"); break;
        case 4:
            exit = true; break;
    }
}
