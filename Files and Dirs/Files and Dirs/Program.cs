namespace Files_and_Dirs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            string path = Directory.GetCurrentDirectory();

            DirectoryInfo directoryInfo = Directory.GetParent(path);
            var parentDirectory = directoryInfo.Parent.Parent.Parent;

            File.Create($"{parentDirectory}\\.gitignore");

            #endregion



        }
    }
}