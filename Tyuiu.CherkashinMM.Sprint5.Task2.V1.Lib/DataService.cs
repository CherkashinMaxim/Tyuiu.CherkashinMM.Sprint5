using System.Reflection.Metadata;
using tyuiu.cources.programming.interfaces.Sprint5; 
 
namespace Tyuiu.CherkashinMM.Sprint5.Task2.V1.Lib;

public class DataService : ISprint5Task2V1
{
    public string SaveToFileTextData(int[,] matrix)
    {
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.txt");
        string text = "";

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] % 2 != 0) matrix[i, j] = 0;
                text += $"{matrix[i, j].ToString()};";
            }
            text = text.Substring(0, text.Length - 1) + "\n";
        }

        File.WriteAllText(path, text);

        return path;
    }
} 
