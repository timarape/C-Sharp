using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DocumentLibrary.Test
{
    [TestClass]
    public class FileProcessTests
    {
        FileProcess fileProcess;

        [TestInitialize]
        public void Setup()
        {
            fileProcess = new FileProcess();

        }

        [TestMethod]
        public void FileExists_FileDoesNotExist_ReturnsFalse()
        {
           
            bool result = fileProcess.FileExists(@"D:\GabbageFile.null");

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void FileExists_FileExist_ReturnsTrue()
        {      

            bool result = fileProcess.FileExists(@"C:\Windows\Regedit.exe");

            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileExists_NullOrEmpty_ThrowsArgumentNullException()
        {
            
            fileProcess.FileExists(null); ;
        }
    }
}
