using Tyuiu.CherkashinMM.Sprint5.Task2.V1.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint5.Task2.V1; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #5                                                            *"); 
        Console.WriteLine("* Тема: Файлы                                                          *"); 
        Console.WriteLine("* Задание #2                                                           *"); 
        Console.WriteLine("* Вариант #1                                                           *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный     *"); 
        Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.    *"); 
        Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль. *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine("6; 9; 4\n7; 2; 4\n4; 8; 3");

        int[,] matrix = { { 6, 9, 4 }, { 7, 2, 4 }, { 4, 8, 3 } };

        string path = ds.SaveToFileTextData(matrix);
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        foreach (string s in File.ReadAllLines(path))
        {
            Console.WriteLine(s);
        }
    } 
} 
