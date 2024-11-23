using Tyuiu.CherkashinMM.Sprint5.Task1.V10.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint5.Task1.V10.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   {
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

        FileInfo fileInfo = new FileInfo(path);
        bool wait = true;
        Assert.AreEqual(wait, fileInfo.Exists);
    } 
} 
