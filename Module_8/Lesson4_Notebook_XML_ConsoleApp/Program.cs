int menu;
bool exit = false;

while (!exit)
{
    Console.WriteLine("Выберите действие\n1.Добаить запись\n2.Посмотреть записи\n3.Удалить запись\n4.Завершить работу");
    menu = Convert.ToInt32(Console.ReadLine());

    switch (menu)
    {
        case 1: Console.WriteLine("1"); break;
        case 2: Console.WriteLine("2"); break;
        case 3: Console.WriteLine("3"); break;
        case 4:
            exit = true; break;
    }
}
