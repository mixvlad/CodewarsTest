using System;
using System.Linq;
using NUnit.Framework;
public class Sum {
  public int GetSum (int a, int b) {
    return Enumerable.Range (Math.Min (a, b), Math.Abs (a - b) + 1).Sum ();
  }
}

[TestFixture]
public class SumTest1 {
  Sum s = new Sum ();

  [Test]
  public void Test1 () {
    Assert.AreEqual (1, s.GetSum (0, 1));
    Assert.AreEqual (-1, s.GetSum (0, -1));
    Assert.AreEqual (2, s.GetSum (-1, 2));

    Assert.AreEqual (13, s.GetSum (6, 7));

    Assert.AreEqual (5, s.GetSum (5, 5));

    Assert.AreEqual (-4, s.GetSum (-4, -4));
  }

}