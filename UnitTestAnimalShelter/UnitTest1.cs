//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using AnimalShelter;

//namespace UnitTestAnimalShelter
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        [TestMethod]
//        public void TestDogConstructor()
//        {
            
//            Dog dog = new Dog("hond", 12, false, DateTime.Now);
//            Assert.AreEqual("hond", dog.Name);
//            Assert.AreEqual(12, dog.Age);
//            Assert.AreEqual(false, dog.Reserved);
//        }

//        [TestMethod]
//        public void TestCatConstructor()
//        {
//            Cat cat = new Cat("kat", 12, false, "yo");
//            Assert.AreEqual("kat", cat.Name);
//            Assert.AreEqual(12, cat.Age);
//            Assert.AreEqual(false, cat.Reserved);
//            Assert.AreEqual("yo", cat.Behavior);
//        }

//        [TestMethod]
//        public void TestPetConstructor()
//        {
//            Pet pet = new Pet("pet", 10, false);
//            Assert.AreEqual("pet", pet.Name);
//            Assert.AreEqual(10, pet.Age);
//            Assert.AreEqual(false, pet.Reserved);
//        }

//    }
//}
