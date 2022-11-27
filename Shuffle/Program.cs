// 7. Написать функцию Shuffle, которая перемешивает элементы массива в случайном порядке.

Console.WriteLine("Введите желаемую длину массива");
int size = Convert.ToInt32(Console.ReadLine());

int minValue = -99;
int maxValue = 99;
int additionalValue = maxValue + 1; // создаю доп число, которого точно не будет в массиве

int[] numbers = new int[size];
numbers = FillArrayRandom(numbers, minValue, maxValue);

int[] numbersShuffled = new int[size];

for(int i = 0; i < size; i++)
{
    while(true)
    {
        numbersShuffled[i] = new Random().Next(minValue, maxValue+1);
        for (int j = 0; j < size; j++)
        {
            if (numbersShuffled[i] == numbers[j])
            {
                numbers[j] = additionalValue;
                break;
            }
        }
    }
}

Console.Write("["+String.Join(", ", numbers)+ "] -> "+"["+String.Join(", ", numbersShuffled)+ "]");
Console.WriteLine();

int[] FillArrayRandom(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

