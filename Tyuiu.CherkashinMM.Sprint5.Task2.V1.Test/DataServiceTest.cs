using Tyuiu.CherkashinMM.Sprint5.Task2.V1.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint5.Task2.V1.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

        FileInfo fileInfo = new FileInfo(path);
        bool wait = true;
        Assert.AreEqual(wait, fileInfo.Exists);
    } 
} 
