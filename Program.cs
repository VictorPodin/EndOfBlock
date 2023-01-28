// Инициализируем и вводим массив через пробел
Console.WriteLine("Введите элементы массива через пробел");
string[] words = Console.ReadLine().Split(' ');
foreach (string word in words)
{
    Console.WriteLine(word + " ");
}

