using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2_1_
{
    public class WriteErrorToFile
    {
        private static readonly Lazy<WriteErrorToFile> instance =
            new Lazy<WriteErrorToFile>(() => new WriteErrorToFile());

        public static WriteErrorToFile Instance { get => instance.Value; }

        private string FilePath { get; }

        public string Text { get; private set; }

        private WriteErrorToFile()
        {
            FilePath = @"C:\Users\goryn\Documents\projects\Task2[1]\Task2[1]\exception.txt";
        }

        public void WriteText(string text)
        {
            Text += text;
        }

        public void Save()
        {
            try
            {
                using (var writer = new StreamWriter(FilePath, true))
                {
                    writer.Write(Text);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }

}
