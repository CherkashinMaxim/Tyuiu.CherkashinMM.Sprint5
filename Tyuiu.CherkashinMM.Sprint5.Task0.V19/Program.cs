using Tyuiu.CherkashinMM.Sprint5.Task0.V19.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint5.Task0.V19; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        int x = 3;

        Console.Title = "Спринт #5 | Выполнил: Черкашин М. М. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #5                                                            *");
        Console.WriteLine("* Тема: Файлы                                                          *");
        Console.WriteLine("* Задание #0                                                           *");
        Console.WriteLine("* Вариант #19                                                          *");
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить *");
        Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.           *");
        Console.WriteLine("* Округлить до трёх знаков после запятой.                              *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine($"x = {x}");

        string res = ds.SaveToFileTextData(x);

        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
 
        Console.WriteLine($"Файл {res} сохранён.");
    } 
} 
