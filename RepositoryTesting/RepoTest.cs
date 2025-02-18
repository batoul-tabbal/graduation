using System.Threading.Tasks;
using System.Threading.Tasks;
using grade.Repository;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Collections.Generic;


[TestFixture]
public class RepoTest
{
    private Repo _repo;

    [SetUp]
    public void Setup()
    {
        _repo = new Repo(1, 1000, 10, "123 Street",6);
    }

    [Test]
    public void AddSection_AddsSection_WhenNotExists()
    {
        _repo.AddSection(101);
        NUnit.Framework.Assert.Contains(101, _repo.NumOfSections);
    }

    [Test]
    public void AddSection_DoesNotAdd_WhenAlreadyExists()
    {
        _repo.AddSection(101);
        _repo.AddSection(101);
        NUnit.Framework.Assert.AreEqual(1, _repo.NumOfSections.Count);
    }

    [Test]
    public void RemoveSection_RemovesSection_WhenExists()
    {
        _repo.AddSection(101);
        _repo.RemoveSection(101);
        NUnit.Framework.Assert.IsFalse(_repo.NumOfSections.Contains(101));
    }

    [Test]
    public void RemoveSection_DoesNotRemove_WhenNotExists()
    {
        _repo.RemoveSection(101);
        NUnit.Framework.Assert.IsEmpty(_repo.NumOfSections);
    }
}
