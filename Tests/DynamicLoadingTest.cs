﻿using NUnit.Framework;
using SeleniumCore.PageObjects;


namespace SeleniumCore.Tests
{
    [TestFixture]
    [Parallelizable]
    public class DynamicLoadingTest : BaseTest
    {
        DynamicLoadingPage DynamicLoading;

        [SetUp]
        public new void SetUp()
        {
            DynamicLoading = new DynamicLoadingPage(Driver);
        }

        [Test]
        public void ElementHidden()
        {
            DynamicLoading.LoadExample(1);
            Assert.That(DynamicLoading.FinishTextPresent);
        }

        [Test]
        public void ElementRendered()
        {
            DynamicLoading.LoadExample(2);
            Assert.That(DynamicLoading.FinishTextPresent);
        }
    }
}
