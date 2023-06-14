namespace Files_and_Dirs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 4

            string path = @"C:\Users\ACER\Desktop\C#\.NET\Lesson";
            string[] directories = { "bin", "obj" };

            foreach (string directory in directories)
            {
                string folderPath = Path.Combine(path, directory);

                if (Directory.Exists(folderPath))
                {
                    Directory.Delete(folderPath, true);
                    Console.WriteLine($"{folderPath} o'chirildi.");
                }
                else
                {
                    Console.WriteLine($"{folderPath} topilmadi.");
                }
            }

            #endregion
        }
    }
}