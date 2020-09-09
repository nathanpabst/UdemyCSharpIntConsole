using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UdemyCsharpIntermediateConsoleApp.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        //METHODNAME_CONDITION_EXPECTATION
        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowsException()
        {
            var orderProcessor = new OrderProcessor();
        }
    }
}