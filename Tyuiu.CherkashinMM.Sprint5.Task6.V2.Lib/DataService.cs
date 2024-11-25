using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5; 
 
namespace Tyuiu.CherkashinMM.Sprint5.Task6.V2.Lib;

public class DataService : ISprint5Task6V2
{
    public int LoadFromDataFile(string path)
    {
        string cyr_alpha = "¸éöóêåíãøùçõúôûâàïğîëäæıÿ÷ñìèòüáşÉÖÓÊÅÍÃ¨ØÙÇÕÚÔÛÂÀÏĞÎËÄÆİß×ÑÌÈÒÜÁŞ";
        string text = File.ReadAllText(path, Encoding.UTF8);
        int res = 0;
        foreach(char c in text)
        {
            if (cyr_alpha.Contains(c))
                res++;
        }
        return res;
    }
} 
