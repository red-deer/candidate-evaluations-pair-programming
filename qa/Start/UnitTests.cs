using System;  
using NUnit.Framework;  
using UnitTest;  
namespace UtilityLibTesting {  
    [TestFixture]  
    public classTestCase {  
        //__________Test for Expected Results__________  
        // Test Case#1: Sales Amount is Greater or Equal than 1000 : Verification  
        [Test]  
        public void OneThousand_G_E() { 
            // REWRITE WITH GIVEN/WHEN/THEN 
            UtilityLib obj = new UtilityLib();  
            Assert.AreEqual(950, obj.calculateDiscount(1000));  
        }  
        // Find all the other test cases

    }  
}  