namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Create_A_New_Directory_Named_Test_Directory_Within_The_Provided_DirectoryName_Provided_To_The_Create_Method(){
       string baseDirectory = Path.GetTempPath() + "assignment" ;
       Directory.CreateDirectory(baseDirectory);

       if(Directory.Exists(baseDirectory + "/test-directory")){
            Directory.Delete(baseDirectory + "/test-directory");
       }

       var directoryManager = new DirectoryManager();
       directoryManager.Create(baseDirectory);

       Assert.True(Directory.Exists(baseDirectory + "/test-directory"));
    }
}