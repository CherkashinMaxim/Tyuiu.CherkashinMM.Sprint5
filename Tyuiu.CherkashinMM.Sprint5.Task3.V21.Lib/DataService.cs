using tyuiu.cources.programming.interfaces.Sprint5; 
 
namespace Tyuiu.CherkashinMM.Sprint5.Task3.V21.Lib;

public class DataService : ISprint5Task3V21
{
    public string SaveToFileTextData(int x)
    {
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

        using(BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Append)))
        {
            writer.Write(Math.Round((x * x + 1) / (Math.Sqrt(4 * x * x - 3)), 3));
        }

        return path;
    }
} 
