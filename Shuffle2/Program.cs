// 7. Написать функцию Shuffle, которая перемешивает элементы массива в случайном порядке.

Console.WriteLine("Введите желаемую длину массива");
int size = Convert.ToInt32(Console.ReadLine());

int minValue = 0;
int maxValue = 99;

int[] numbers = new int[size];
numbers = FillArrayRandom(numbers, minValue, maxValue);

int[] numbersShuffled = new int[size];
numbersShuffled = ShuffleArray(numbers);

Console.Write("[" + String.Join(", ", numbers) + "] -> " + "[" + String.Join(", ", numbersShuffled) + "]");
Console.WriteLine();


int[] FillArrayRandom(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] RemoveFromArrayNumber(int[] array, int removeNumber)
{
    int i = 0;
    int[] arrayNew = new int[array.Length - 1];
    int removePosIndex = IndexOf(array, removeNumber);
    for (i = 0; i < arrayNew.Length; i++)
    {
        if (i >= removePosIndex)
            arrayNew[i] = array[i + 1];
        else
            arrayNew[i] = array[i];
    }
    return arrayNew;
}

int IndexOf(int[] array, int find)
{
    int i = 0;
    int position = -1;
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] == find)
        {
            position = i;
            break;
        }
    }
    return position;
}

int[] ShuffleArray(int[] array)
{
    int[] tempArray = array;
    int[] numbersMixed = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        int randomIndex = new Random().Next(0, tempArray.Length);
        numbersMixed[i] = tempArray[randomIndex];
        tempArray = RemoveFromArrayNumber(tempArray, numbersMixed[i]);
    }
    return numbersMixed;
}

