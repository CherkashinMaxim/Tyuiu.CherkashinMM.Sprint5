using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
 
namespace Tyuiu.CherkashinMM.Sprint5.Task0.V19.Lib;

public class DataService : ISprint5Task0V19
{
    public string SaveToFileTextData(int x)
    {
        string path = $@"{Directory.GetCurrentDirectory()}\..\..\..\..\OutPutFileTask0.txt";

        double y = Math.Round((2 * x * x - 1) / Math.Sqrt(x * x - 2), 3);

        File.WriteAllText(path, Convert.ToString(y));
        FileInfo fileInfo = new FileInfo(path);

        return fileInfo.FullName;
    }
} 
