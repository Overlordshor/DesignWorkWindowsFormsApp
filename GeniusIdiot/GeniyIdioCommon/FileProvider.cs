
using System;
using System.IO;
using System.Text;

namespace GeniyIdiotCommon
{
    public class FileProvider
    {
        public static void ReSave(string path, string data)
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

        public static bool Exist(string path)
        {
            return File.Exists(path);
        }
    }
}
