using System.Threading.Tasks;
using System.Threading.Tasks;
using grade;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
[TestFixture]
public class RepoTest
{
    private Repo _repo;

    [SetUp]
    public void Setup()
    {
        _repo = new Repo(1, 1000, 10, "123 Street");
    }

    [Test]
    public void AddSection_AddsSection_WhenNotExists()
    {
        _repo.AddSection(101);
        Assert.Contains(101, _repo.Sections);
    }

    [Test]
    public void AddSection_DoesNotAdd_WhenAlreadyExists()
    {
        _repo.AddSection(101);
        _repo.AddSection(101);
        Assert.AreEqual(1, _repo.Sections.Count);
    }

    [Test]
    public void RemoveSection_RemovesSection_WhenExists()
    {
        _repo.AddSection(101);
        _repo.RemoveSection(101);
        Assert.IsFalse(_repo.Sections.Contains(101));
    }

    [Test]
    public void RemoveSection_DoesNotRemove_WhenNotExists()
    {
        _repo.RemoveSection(101);
        Assert.IsEmpty(_repo    .Sections);
    }
}
