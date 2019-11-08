using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

public class Bus {
    public static int Number (List<int[]> peopleListInOut) {
        return peopleListInOut.Sum (x => x[0] - x[1]);
    }
}

[TestFixture]
public class MyTest {
    [Test]
    public void FirstTest () {
        List<int[]> peopleList = new List<int[]> () { new [] { 10, 0 }, new [] { 3, 5 }, new [] { 5, 8 } };
        Assert.AreEqual (5, Bus.Number (peopleList));
    }

    [Test]
    public void SecondTest () {
        List<int[]> peopleList = new List<int[]> () { new [] { 3, 0 }, new [] { 9, 1 }, new [] { 4, 10 }, new [] { 12, 2 }, new [] { 6, 1 }, new [] { 7, 10 } };
        Assert.AreEqual (17, Bus.Number (peopleList));
    }

    [Test]
    public void ThirdTest () {
        List<int[]> peopleList = new List<int[]> () { new [] { 3, 0 }, new [] { 9, 1 }, new [] { 4, 8 }, new [] { 12, 2 }, new [] { 6, 1 }, new [] { 7, 8 } };
        Assert.AreEqual (21, Bus.Number (peopleList));
    }
}