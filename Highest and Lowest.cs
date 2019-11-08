using System;
using System.Linq;
using NUnit.Framework;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    var numbersInt = numbers.Split(' ').Select(Int32.Parse).ToList();
    int high = numbersInt.Max();
    int low = numbersInt.Min();
    return String.Format("{0} {1}", high, low);
  }
}


[TestFixture]
public class Tests
{
  [Test]
  public void Test1()
  {
    Assert.AreEqual("42 -9", Kata.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
    Assert.AreEqual("-5 -5", Kata.HighAndLow("-5"));
  }
}