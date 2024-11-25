using tyuiu.cources.programming.interfaces.Sprint5; 
 
namespace Tyuiu.CherkashinMM.Sprint5.Task5.V10.Lib;

public class DataService : ISprint5Task5V10
{
    public double LoadFromDataFile(string path)
    {
        int res = 0;
        foreach(var num in File.ReadAllLines(path)) 
        {
            if(int.TryParse(num, out int number) && number % 2 == 0)
            {
                res += number;
            }
        }
        return res;
    }
} 
