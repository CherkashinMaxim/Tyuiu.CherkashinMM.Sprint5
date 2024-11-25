using Tyuiu.CherkashinMM.Sprint5.Task7.V13.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint5.Task7.V13.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        string path = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V13.txt");

        FileInfo fileInfo = new FileInfo(path);
        bool wait = true;
        Assert.AreEqual(wait, fileInfo.Exists);
    } 
} 
