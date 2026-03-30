using System.ComponentModel.DataAnnotations;

namespace knightmoves;

public class DirectoryManager{

    public void Create(string directoryName){
        // Add your code here
        Directory.CreateDirectory(directoryName + "test-directory");
        File.WriteAllText(directoryName, "test-directory");
    }
}