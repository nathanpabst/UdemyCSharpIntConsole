using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testability.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        //METHODNAME_CONDITION_EXPECTATIONS
        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowsException()
        {
            var orderProcessor = new OrderProcessor();
        }
    }
}