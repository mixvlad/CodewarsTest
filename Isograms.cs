using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

public class Kata {
    public static bool IsIsogram (string str) {
        return !str.GroupBy (x => x.ToString (), StringComparer.InvariantCultureIgnoreCase).Any (x => x.Count () > 1);
    }
}

[TestFixture]
public class BasicTests {

    private static IEnumerable<TestCaseData> testCases {
        get {

            yield return new TestCaseData ("moOse").Returns (false);
            yield return new TestCaseData ("Dermatoglyphics").Returns (true);
            yield return new TestCaseData ("isogram").Returns (true);
            yield return new TestCaseData ("moose").Returns (false);
            yield return new TestCaseData ("isIsogram").Returns (false);
            yield return new TestCaseData ("aba").Returns (false);
            yield return new TestCaseData ("thumbscrewjapingly").Returns (true);
            yield return new TestCaseData ("").Returns (true);
        }
    }

    [Test, TestCaseSource ("testCases")]
    public bool Test (string str) => Kata.IsIsogram (str);
}