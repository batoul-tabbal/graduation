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
        section = new Section(1, 100.0, 10.0,0,0);
    }

    [Test]
    public void TestInitialValues()
    {
        NUnit.Framework.Assert.AreEqual(1, section.SectionId);
        NUnit.Framework.Assert.AreEqual(100.0, section.SectionArea);
        NUnit.Framework.Assert.AreEqual(10.0, section.SectionHigh);
        NUnit.Framework.Assert.AreEqual(0, section.NumOfCategories);
        NUnit.Framework.Assert.AreEqual(0 , section.NumOfItems);

    }
    [Test]
    public void TestAddCategory()
    {
        section.AddCategory(1);
        NUnit.Framework.Assert.AreEqual(1, section.NumOfCategories);
    }
    [Test]
    public void TestRemoveCategory()
    {
        section.AddCategory(2);
        section.RemoveCategory(1);
        NUnit.Framework.Assert.AreEqual(1, section.NumOfCategories);

    }
    [Test]
    public void TestRemoveMoreThanAvailable1()
    {
        section.AddCategory(3);
        NUnit.Framework.Assert.Throws<InvalidOperationException>(() => section.RemoveCategory(5));
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
