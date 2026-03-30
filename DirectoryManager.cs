using System.ComponentModel.DataAnnotations;

namespace knightmoves;

public class DirectoryManager{

    public void Create(string directoryName){
        // Add your code here
        string classic = Path.GetTempPath() + directoryName;
        Directory.CreateDirectory(classic + "/test-directory");
        File.WriteAllText(classic + "/test-directory/test-file.txt", "This is a test file.");

        bool FirstDirectory = Directory.Exists(classic + "/test-directory");
        bool FirstFile = File.Exists(classic + "/test-directory/test-file.txt");
    }
}