using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

[TestClass]
public class CustomSetTests
{
    [TestMethod]
    public void Intersection_Basic()
    {
        var set1 = new HashSet<int> { 1, 2, 3 };
        var set2 = new HashSet<int> { 2, 3, 4 };
        var expected = new List<int> { 2, 3 };
        var result = new List<int>(Custom.CustomIntersection(set1, set2));
        CollectionAssert.AreEquivalent(expected, result);
    }

    [TestMethod]
    public void Intersection_Disjoint()
    {
        var set1 = new HashSet<int> { 1, 2 };
        var set2 = new HashSet<int> { 3, 4 };
        var expected = new List<int>();
        var result = new List<int>(Custom.CustomIntersection(set1, set2));
        CollectionAssert.AreEquivalent(expected, result);
    }

    [TestMethod]
    public void Intersection_EmptySet()
    {
        var set1 = new HashSet<int>();
        var set2 = new HashSet<int> { 1, 2 };
        var expected = new List<int>();
        var result = new List<int>(Custom.CustomIntersection(set1, set2));
        CollectionAssert.AreEquivalent(expected, result);
    }

    [TestMethod]
    public void Union_Basic()
    {
        var set1 = new HashSet<int> { 1, 2, 3 };
        var set2 = new HashSet<int> { 2, 3, 4 };
        var expected = new List<int> { 1, 2, 3, 4 };
        var result = new List<int>(Custom.CustomUnion(set1, set2));
        CollectionAssert.AreEquivalent(expected, result);
    }

    [TestMethod]
    public void Union_WithEmptySet()
    {
        var set1 = new HashSet<int>();
        var set2 = new HashSet<int> { 1, 2 };
        var expected = new List<int> { 1, 2 };
        var result = new List<int>(Custom.CustomUnion(set1, set2));
        CollectionAssert.AreEquivalent(expected, result);
    }

    [TestMethod]
    public void Union_BothEmpty()
    {
        var set1 = new HashSet<int>();
        var set2 = new HashSet<int>();
        var expected = new List<int>();
        var result = new List<int>(Custom.CustomUnion(set1, set2));
        CollectionAssert.AreEquivalent(expected, result);
    }
}