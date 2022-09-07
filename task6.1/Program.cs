// Программа запрашивает натуральное число M, пользователь вводит с клавиатуры
//M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.WriteLine("Введи количество чисел:");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M]; //создать массив на М элементов
int count = 0; // счетчик +чисел
for (int i=0; i<M; i++)
{
    Console.WriteLine("Введи число:");    // вввести М чисел
    int x = Convert.ToInt32(Console.ReadLine());
    array[i] = x;
    if (array[i] > 0)   // если число +, в count
    {
        count++;
    }
}
Console.WriteLine("Количество чисел выше 0: " + count);