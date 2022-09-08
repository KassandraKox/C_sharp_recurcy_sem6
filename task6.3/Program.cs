// * Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
//Парой считаем 1 и последний элемент, 2 и предпоследний и т.д. Если кол-во 
//элементов нечетное, то элемент посередине не учитывать.
//Результат сложения вывести на экран.
//1, 3, 8, 3, 2 -> 11
//8, 3, 4, 2 -> 28
Console.WriteLine("Введи количество чисел:");
Random rand = new Random();
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; //создать массив на n элементов
int i = 0;
while (i < n)
{
    int x = rand.Next(1, 10); //случайное число
    array[i] = x;
    i++;
}
int total = 0;
for (int j=0; j < n / 2; j++)
{
    int product;
    product = (array[j] * array[n-j-1]);
    total += product;
}
Console.WriteLine(string.Join(",", array)); // вывод массива
Console.WriteLine("Сумма произведений пар чисел равна: " + total);