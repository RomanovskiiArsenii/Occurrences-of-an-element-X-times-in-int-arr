/*
Given a list and a number, create a new list that contains each number 
of list at most N times, without reordering.
For example if the input number is 2, and the input list is [1,2,3,1,2,1,2,3], 
you take [1,2,3,1,2], drop the next [1,2] since this would lead to 1 and 2 being 
in the result 3 times, and then take 3, which leads to [1,2,3,1,2,3].
With list [20,37,20,21] and number 1, the result would be [20,37,21].
*/

class Program
{
    /// <summary>
    /// Метод принимает массив и проверяет его на количество повторений.
    /// Допустимо x повторений для каждого значения.
    /// </summary>
    /// <param name="arr">массив целых чисел</param>
    /// <param name="x">допустимое количество повторений значения</param>
    /// <returns>массив, в котором каждое значение повторяется не более x раз</returns>
    public static int[] DeleteNth(int[] arr, int x)
    {
        List<int> temp = new List<int>();                           //вспомогательный лист
        foreach (var e in arr)                                      //перебор элементов массива
        {
            if (temp.Count(item => item == e) < x) temp.Add(e);     //если в листе содержится менее x значений равных 
        }                                                           //текущему элементу массива, добавляем его в лист
        int[] corrected = temp.ToArray();                           //скорректированный массив     
        return corrected;
    }
    static void Main(string[] args)
    {
        int[] test = { 1, 2, 3, 1, 2, 1, 2, 3 };
        int[] test2 = DeleteNth(test, 1);
        int[] test3 = DeleteNth(test, 2);
        int[] test4 = { 20, 37, 20, 21 };
        int[] test5 = DeleteNth(test4, 1);

        foreach (var item in test) Console.Write($"{item} "); Console.WriteLine();
        foreach (var item in test2) Console.Write($"{item} "); Console.WriteLine();
        foreach (var item in test3) Console.Write($"{item} "); Console.WriteLine();
        foreach (var item in test4) Console.Write($"{item} "); Console.WriteLine();
        foreach (var item in test5) Console.Write($"{item} "); Console.WriteLine();
    }
}
/*
1 2 3 1 2 1 2 3
1 2 3
1 2 3 1 2 3
20 37 20 21
20 37 21
*/