using System;
using System.IO;

namespace DocumentLibrary
{
    public class FileProcess
    {
        public bool FileExists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("File is Null or Empty");
            }

            return File.Exists(fileName);
        }
    }
}