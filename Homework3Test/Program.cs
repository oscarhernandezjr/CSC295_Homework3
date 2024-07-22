using Homework3;

namespace Homework3Tests
{
    [TestClass]
    public class SortingTests
    {
        private Student[] students;

        [TestInitialize]
        public void Setup()
        {
            
            Student student1 = new Student("Melissa", 4.0);
            Student student2 = new Student("Rich", 3.0);
            Student student3 = new Student("Adam", 3.8);
            Student student4 = new Student("Madeline", 3.9);
            Student student5 = new Student("Kevin", 2.4);

            students = new Student[] { student1, student2, student3, student4, student5 };
        }

        [TestMethod]
        public void TestBubbleSort()
        {
            
            Program.BubbleSort(students);

            
            Assert.AreEqual("Kevin", students[0].Name); 
            Assert.AreEqual("Rich", students[1].Name);
            Assert.AreEqual("Adam", students[2].Name);
            Assert.AreEqual("Madeline", students[3].Name);
            Assert.AreEqual("Melissa", students[4].Name);
        }

        [TestMethod]
        public void TestSelectionSort()
        {
            
            Program.SelectionSort(students);

            
            Assert.AreEqual("Kevin", students[0].Name); 
            Assert.AreEqual("Rich", students[1].Name);
            Assert.AreEqual("Adam", students[2].Name);
            Assert.AreEqual("Madeline", students[3].Name);
            Assert.AreEqual("Melissa", students[4].Name);
        }

        [TestMethod]
        public void TestInsertionSort()
        {
            
            Program.InsertionSort(students);

            
            Assert.AreEqual("Kevin", students[0].Name);
            Assert.AreEqual("Rich", students[1].Name);
            Assert.AreEqual("Adam", students[2].Name);
            Assert.AreEqual("Madeline", students[3].Name);
            Assert.AreEqual("Melissa", students[4].Name);
        }
    }

}