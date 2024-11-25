using Tyuiu.CherkashinMM.Sprint5.Task6.V2.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint5.Task6.V2.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V2.txt");

        FileInfo fileInfo = new FileInfo(path);
        bool wait = true;
        Assert.AreEqual(wait, fileInfo.Exists);
    } 
} 
