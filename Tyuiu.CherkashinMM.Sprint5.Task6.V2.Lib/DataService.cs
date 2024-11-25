using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5; 
 
namespace Tyuiu.CherkashinMM.Sprint5.Task6.V2.Lib;

public class DataService : ISprint5Task6V2
{
    public int LoadFromDataFile(string path)
    {
        string text = File.ReadAllText(path, Encoding.UTF8);
        int d = int.Parse(text.Substring(0, 1));
        int res = text.Count(c => (c >= 'À' && c <= 'ÿ') || c == '¸' || c == '¨');
        return res;
    }
} 
