using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.CherkashinMM.Sprint5.Task1.V10.Lib;

public class DataService : ISprint5Task1V10
{
    public string SaveToFileTextData(int startValue, int stopValue)
    {
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
        string text = "";

        for (int x = startValue; x <= stopValue; x++) 
        {
            if((2 * x - 1) == 0)
            {
                text += "0\n";
                break;
            }
            text += Convert.ToString(Math.Round((2 * Math.Cos(x) + 2) / (2 * x - 1) + Math.Cos(x) - 5 * x + 3, 2)) + "\n";
        }

        File.WriteAllText(path, text);

        return path;
    }
} 
