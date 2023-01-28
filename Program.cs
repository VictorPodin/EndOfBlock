// Инициализируем и вводим массив через пробел
Console.WriteLine("Введите элементы массива через пробел");
string[] words = Console.ReadLine().Split(' ');
// Считаем количество элементов в массиве, удовлетворяющих условию задачи, чтобы в новом массиве выделить только нужную память
int countNewElements = 0;
foreach (string word in words)
{
    if (word.Length < 4) countNewElements++;
}
// Делаем новый массив известной длины
string[] newwords = new string[countNewElements];
int i = 0;
// И заполняем его новыми элементами по условию задачи
foreach (string word in words)
{
    if (word.Length < 4) { newwords[i] = word; i++; }
}
foreach (string newword in newwords)
{
    Console.WriteLine(newword);
}
