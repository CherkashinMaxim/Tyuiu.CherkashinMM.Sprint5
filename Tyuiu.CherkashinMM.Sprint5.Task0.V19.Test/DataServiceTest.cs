using Tyuiu.CherkashinMM.Sprint5.Task0.V19.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint5.Task0.V19.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   {
        string path = @"C:\Users\lans\source\repos\Tyuiu.CherkashinMM.Sprint5\Tyuiu.CherkashinMM.Sprint5.Task0.V19\bin\Debug\net8.0\OutPutFileTask0.txt";

        FileInfo fileInfo = new FileInfo(path);
        Assert.AreEqual(true, fileInfo.Exists);
   } 
} 
