/* Задача 41: 
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2 , 1, -7, 567, 89, 223-> 3 */

int[] usersArray = InputArrInt();
int[] InputArrInt()
{
    Console.WriteLine("Введите целые числовые значения");
    
    Console.WriteLine("В качестве разделителя используйте пробел");
    string[] userInput = (Console.ReadLine()).Split(new char[] { ' ' });
    int[] input = new int[userInput.Length];
    for (int i = 0; i < input.Length; i++)
    {
        bool isInt = int.TryParse(userInput[i], out int num);
        if (isInt)
        {
            input[i] = num;
        }
        else
        {
            Console.WriteLine("Вы ввели недопустимые значения. \n проверьте правильность: \n * целые числа \n * разделены пробелом \n * другие символы отсутствуют");
            return InputArrInt();
        }
    }
    return input;
}
Console.WriteLine(usersArray);
int res = PositiveNumsValue(usersArray);
Console.WriteLine($"Введено {res} чисел больше 0");

int PositiveNumsValue(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}




