using Tyuiu.CherkashinMM.Sprint5.Task3.V21.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint5.Task3.V21; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #5                                                            *"); 
        Console.WriteLine("* Тема: Файлы                                                          *"); 
        Console.WriteLine("* Задание #3                                                           *"); 
        Console.WriteLine("* Вариант #21                                                          *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("* Дано выражение вычислить его значение, результат сохранить в         *"); 
        Console.WriteLine("* бинарный файл OutPutFileTask3.bin и вывести на консоль.              *"); 
        Console.WriteLine("* Округлить до трёх знаков после запятой.                              *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");

        int x = 3;
        Console.WriteLine($"x = {x}");

        string path = ds.SaveToFileTextData(x);
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************");

        using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
        {
            Console.WriteLine(reader.Read());
        }
    } 
} 
