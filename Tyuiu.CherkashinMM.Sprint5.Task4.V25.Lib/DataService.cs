using tyuiu.cources.programming.interfaces.Sprint5; 
 
namespace Tyuiu.CherkashinMM.Sprint5.Task4.V25.Lib;

public class DataService : ISprint5Task4V25
{
    public double LoadFromDataFile(string path)
    {
        string strX = File.ReadAllText(path);
        double x = double.Parse(strX);
        double res = (Math.Pow(x, 4) + Math.Cos(x)) * Math.Sin(x);
        return Math.Round(res, 3);
    }
} 
