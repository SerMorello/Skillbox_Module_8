List<int> numbers = new(100);

AddNumbers();
ShowNumbers();

Console.WriteLine();

RemoveNumber();
ShowNumbers();

Console.ReadKey();

int GetRandomNumber()
{
    Random rndm = new Random();
    int num = rndm.Next(0, 100);
    return num;
}
void RemoveNumber()
{
    for (int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] > 25 && numbers[i] < 50)
        {
            numbers.Remove(numbers[i]);
        }
    }

}
void ShowNumbers()
{
    for (int i = 0; i < numbers.Count; i++)
    {
        if (i % 10 == 0)
        {
            Console.WriteLine();
        }
        Console.Write($"{numbers[i]} ");
    }
}
void AddNumbers()
{
    for (int i = 0; i < numbers.Capacity; i++)
    {
        numbers.Add(GetRandomNumber());
    }
}