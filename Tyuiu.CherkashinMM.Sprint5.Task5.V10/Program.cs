using Tyuiu.CherkashinMM.Sprint5.Task5.V10.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint5.Task5.V10; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #5                                                            *"); 
        Console.WriteLine("* Тема: Файлы                                                          *"); 
        Console.WriteLine("* Задание #5                                                           *"); 
        Console.WriteLine("* Вариант #10                                                          *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("* Найти сумму всех четных целых чисел в файле.                         *"); 
        Console.WriteLine("* Полученный результат вывести на консоль.                             *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");

        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V25.txt");
        Console.WriteLine($"Файл {path}");
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine(ds.LoadFromDataFile(path)); 
    } 
} 
