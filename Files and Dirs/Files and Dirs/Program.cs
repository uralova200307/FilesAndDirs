namespace Files_and_Dirs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 2

            string fullPath = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = new DirectoryInfo(fullPath).Parent.Parent.Parent.Parent;
            string[] directories = Directory.GetDirectories(directoryInfo.FullName, "*", SearchOption.AllDirectories);

            foreach (string directory in directories)
            {
                string folderName = Path.GetFileName(directory);
                if (folderName == "bin" || folderName == "obj")
                {
                    Console.WriteLine(directory);
                }
            }

            #endregion
        }
    }
}