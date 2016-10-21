using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Generic;
namespace GenericTest.cs
{
    [TestClass]
    public class GenericTest
    {
        RepositoryID CreationRepositoryID()
        {
            RepositoryID myRepository = new RepositoryID();
            int[] value = { 1, 2, 6, 7, 8 };
            for (int i = 0; i < value.Length; i++)
            {
                myRepository.CreateObj(value[i]);
            }
            return myRepository;
        }
        [TestMethod]
        public void CorrectWorkReturnArgCreateObj()
        {
            
         
        }
        [TestMethod]
        public void CorrectWorkOutputsGuidAndObj()
        {
            RepositoryID myRepository = new RepositoryID();
            int value = 6;
            myRepository.CreateObj(value);

        }
        [TestMethod]
        public void CorrectWorkOutputsObjByGuid()
        {
        }
    }
}
