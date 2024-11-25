using Tyuiu.CherkashinMM.Sprint5.Task4.V25.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint5.Task4.V25.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V25.txt");

        FileInfo fileInfo = new FileInfo(path);
        bool wait = true;
        Assert.AreEqual(wait, fileInfo.Exists);
    } 
} 
