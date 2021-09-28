using System;  
using NUnit.Framework;  
using UnitTest;  
namespace UtilityLibTesting {  
    [TestFixture]  
    public classTestCase {  
        //__________Test for Expected Results__________  
        // Test Case#1: When I call the method calculateDiscount() with a SalesAmount equal to 1000, 
        //              I get the correct amount returned (=950)  
        [Test]  
        public void shouldReturn950whenIspend1000() { 


        }  
        // Find also the exception test case.
                
        // This test just makes sure that calculateDiscount throws an exception 
        // (any exception) when we call it with a negative SalesAmount.
        [Test]  
        public void shouldThrowExceptionWhenIaskForAnegativeSalesAmount() { 


        }
    }  
}  