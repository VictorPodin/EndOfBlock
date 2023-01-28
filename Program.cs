// Инициализируем и вводим массив через пробел
Console.WriteLine("Введите элементы массива через пробел");
string[] words = Console.ReadLine().Split(' ');
// Считаем количество элементов в массиве, удовлетворяющих условию задачи, чтобы в новом массиве выделить только нужную память
int countNewElements = 0;
// Также, если пользователь случайно нажмет два пробела при вводе, получим пустые элементы. Используем условие word != string.Empty
foreach (string word in words)
{
    if (word.Length < 4 && word != string.Empty) countNewElements++;
}
// Делаем новый массив известной длины
string[] newwords = new string[countNewElements];
int i = 0;
// И заполняем его новыми элементами по условию задачи
foreach (string word in words)
{
    if (word.Length < 4 && word != string.Empty) { newwords[i] = word; i++; }
}
foreach (string newword in newwords)
{
    Console.WriteLine(newword);
}
