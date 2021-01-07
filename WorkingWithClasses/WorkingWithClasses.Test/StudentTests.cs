using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WorkingWithClasses.Test
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AttendClass_WhenCalled_ReturnsAstring()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetStudent_WhenCalled_CanChangeTheObjectName()
        {
            var studentA = GetStudent("Ike", "Marape");
            SetStudentName(studentA, "magician","Mohlala");

            Assert.AreEqual("Ike", studentA.FirstName);
        }

        private void SetStudentName(Student student, string firstName, string lastName)
        {
            student = new Student(firstName,lastName);
        }


        [TestMethod]
        public void GetStudent_WhenCalled_CanSetNameFromReference()
        {
            var studentA = GetStudent("Ike", "Marape");
            SetName(studentA,"magician");

            Assert.AreEqual("magician", studentA.FirstName);
        }

        private void SetName(Student student, string name)
        {
            student.FirstName = name;
        }

        [TestMethod]
        public void GetStudent_WhenCalled_ReturnsDifferentObjects()
        {
            var studentA = GetStudent("Ike","Marape");
            var studentB = GetStudent("Tshepiso","Marape");

            Assert.AreEqual("Ike",studentA.FirstName);
            Assert.AreEqual("Marape", studentA.LastName);

            Assert.AreEqual("Tshepiso", studentB.FirstName);
            Assert.AreEqual("Marape", studentB.LastName);

        }


        [TestMethod]
        public void GetStudent_ReferencingTheSameObjec_Returnstrue()
        {
            var studentA = GetStudent("Ike", "Marape");

            var studentB = studentA;


            Assert.AreSame(studentA, studentB);

        }

        Student GetStudent(string firstName, string lastName)
        {

            return new Student(firstName, lastName);

        }
    }
}
