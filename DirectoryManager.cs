using System.ComponentModel.DataAnnotations;

namespace knightmoves;

public class DirectoryManager{

    public void Create(string directoryName){
        // Add your code here
        string classic = Path.GetTempPath() + directoryName;
        Directory.CreateDirectory(classic + "/test-directory");
    }
}