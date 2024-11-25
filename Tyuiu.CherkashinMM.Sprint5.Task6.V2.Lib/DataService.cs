using System.Text;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5; 
 
namespace Tyuiu.CherkashinMM.Sprint5.Task6.V2.Lib;

public class DataService : ISprint5Task6V2
{
    public int LoadFromDataFile(string path)
    {
        string cyr_alpha = "¸éöóêåíãøùçõúôûâàïğîëäæıÿ÷ñìèòüáşÉÖÓÊÅÍÃ¨ØÙÇÕÚÔÛÂÀÏĞÎËÄÆİß×ÑÌÈÒÜÁŞ";
        string text = File.ReadAllText(path, Encoding.UTF8);
        string pattern = "[À-ßà-ÿ¨¸]";
        int res = Regex.Matches(text, pattern).Count;
        return res;
    }
} 
