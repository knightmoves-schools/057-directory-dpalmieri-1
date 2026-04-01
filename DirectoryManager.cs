using System.ComponentModel.DataAnnotations;

namespace knightmoves;

public class DirectoryManager{

    public bool Create(string directoryName){
        // Add your code here
        string classic = Path.GetTempPath() + directoryName;
        Directory.CreateDirectory(classic + "/test-directory");
        File.WriteAllText(classic + "/test-directory/test-file.txt", "This is a test file.");
    }
}
