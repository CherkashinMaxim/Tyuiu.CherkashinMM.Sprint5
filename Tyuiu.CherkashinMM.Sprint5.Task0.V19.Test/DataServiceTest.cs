using Tyuiu.CherkashinMM.Sprint5.Task0.V19.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint5.Task0.V19.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   {
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

        FileInfo fileInfo = new FileInfo(path);
        bool wait = true;
        Assert.AreEqual(wait, fileInfo.Exists);
   } 
} 
