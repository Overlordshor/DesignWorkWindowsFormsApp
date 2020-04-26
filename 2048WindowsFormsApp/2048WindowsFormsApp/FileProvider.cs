using System.IO;
using System.Text;

namespace _2048WindowsFormsApp
{
    class FileProvider
    {
        public static void Save(string path, string data)
        {
            StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8);
            writer.WriteLine(data);
            writer.Close();
        }

        public static string Load(string path)
        {
            StreamReader reader = new StreamReader(path);
            var data = reader.ReadToEnd();
            reader.Close();
            return data;
        }

        public static bool TryGet (string path, out string data)
        {
            if (Exist(path))
            {
                data = Load(path);
                return true;
            }
            data = null;
            return false;
        }
        public static bool Exist(string path)
        {
            return File.Exists(path);
        }
    }
}

