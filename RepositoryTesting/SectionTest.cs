using System;
using NUnit.Framework;
using grade.Repository;

[TestFixture]
public class SectionTests
{
    private Section section;

    [SetUp]
    public void Setup()
    {
        section = new Section(1, 100.0, 10.0,100);
    }

    [Test]
    public void TestInitialValues()
    {
        NUnit.Framework.Assert.AreEqual(1, section.SectionId);
        NUnit.Framework.Assert.AreEqual(100.0, section.SectionArea);
        NUnit.Framework.Assert.AreEqual(10.0, section.SectionHigh);
        NUnit.Framework.Assert.AreEqual(100, section.NumOfItems);
    }

    [Test]
    public void TestAddProducts()
    {
        section.AddItems(5);
        NUnit.Framework.Assert.AreEqual(5, section.NumOfItems);
    }

    [Test]
    public void TestRemoveProducts()
    {
        section.AddItems(10);
        section.RemoveItems(5);
        NUnit.Framework.Assert.AreEqual(5, section.NumOfItems);
    }

    [Test]
    public void TestRemoveMoreThanAvailable()
    {
        section.AddItems(3);
        NUnit.Framework.Assert.Throws<InvalidOperationException>(() => section.RemoveItems(5));
    }
}
