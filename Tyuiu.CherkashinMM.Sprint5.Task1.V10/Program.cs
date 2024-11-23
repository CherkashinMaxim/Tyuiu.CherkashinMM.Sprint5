using Tyuiu.CherkashinMM.Sprint5.Task1.V10.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint5.Task1.V10; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #5                                                            *"); 
        Console.WriteLine("* Тема: Файлы                                                          *"); 
        Console.WriteLine("* Задание #1                                                           *"); 
        Console.WriteLine("* Вариант #10                                                          *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("* Произвести табулирование функции на диапазоне с шагом 1.             *"); 
        Console.WriteLine("* Результат сохранить в текстовый файл и вывести таблицу в консоль.    *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("startValue = -5"); 
        Console.WriteLine("endValue = 5");

        string path = ds.SaveToFileTextData(-5, 5);
        string[] file = File.ReadAllLines(path);
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine($"Файл {path} сохранён.");
        Console.WriteLine("+----------+----------+");
        Console.WriteLine("|    x     |   F(x)   |");
        Console.WriteLine("+----------+----------+");
        int x = -5;
        foreach(string s in file)
        {
            Console.WriteLine($"|    {x}" + new string(' ', 6 - Convert.ToString(x).Length) + $"|  {s}" + new string(' ', 8 - s.Length) + "|");
            x++;
        }
        Console.WriteLine("+----------+----------+");
    } 
} 
