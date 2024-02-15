HashSet<int> numbers = new();
int number;

while (true)
{
    Console.WriteLine("Введите число которое хотите добавить.");
    number = Convert.ToInt32(Console.ReadLine());
    if (CheckNumber(number))
    {
        numbers.Add(number)

            Console.WriteLine("Число успешно сохранено");
    }
    else
    {
        Console.WriteLine("Число уже вводилось ранее");
    }
}

bool CheckNumber(int number)
{
    return numbers.Contains(number);
}