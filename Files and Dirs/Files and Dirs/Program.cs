namespace Files_and_Dirs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 3

            string projectPath = @"C:\Users\Miraziz_Khidoyatov\Documents\Pdp";
            string[] exeFiles = Directory.GetFiles(projectPath, "*.exe", SearchOption.AllDirectories);
            foreach (string file in exeFiles)
            {
                string fileName = Path.GetFileName(file);
                Console.WriteLine(fileName);
            }

            #endregion
        }
    }
}