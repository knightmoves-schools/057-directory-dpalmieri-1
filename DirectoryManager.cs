namespace knightmoves;

public class DirectoryManager{

    public void Create(string directoryName){
        // Add your code here
        string classic = Path.Combine(directoryName, "test-directory");

        Directory.CreateDirectory(classic);
    }
}
