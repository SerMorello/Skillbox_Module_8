HashSet<int> numbers = new();
int number;

while (true)
{
    Console.WriteLine("Введите число которое хотите добавить.");
    //number = 
    //bool result =
    if (int.TryParse(Console.ReadLine(), out number))
    {
        if (!CheckNumber(number))
        {
            numbers.Add(number);

            Console.WriteLine("Число успешно сохранено");
        }
        else
        {
            Console.WriteLine("Число уже вводилось ранее");
        }
    }
    else
    {
        break;
    }
}

bool CheckNumber(int number)
{
    return numbers.Contains(number);
}