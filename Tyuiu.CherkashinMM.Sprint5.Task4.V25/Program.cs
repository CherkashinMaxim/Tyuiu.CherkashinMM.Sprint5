using Tyuiu.CherkashinMM.Sprint5.Task4.V25.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint5.Task4.V25; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #5                                                            *"); 
        Console.WriteLine("* Тема: Файлы                                                          *"); 
        Console.WriteLine("* Задание #4                                                           *"); 
        Console.WriteLine("* Вариант #25                                                          *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt (файл взять из    *"); 
        Console.WriteLine("* архива согласно вашему варианту. Создать папку в ручную              *"); 
        Console.WriteLine("* С:\\DataSprint5\\ и скопировать в неё файл) в котором есть           *"); 
        Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить      *"); 
        Console.WriteLine("* вместо Х в формуле. Вычислить значение по формуле (Полученное        *"); 
        Console.WriteLine("* значение округлить до трёх знаков после запятой) и вернуть           *"); 
        Console.WriteLine("* полученный результат на консоль.                                     *"); 
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
