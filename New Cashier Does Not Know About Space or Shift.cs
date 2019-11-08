using System;
using System.Linq;
using System.Text;
using NUnit.Framework;

public static class NewCashier {
    public static string GetOrder (string input) {
        var menu = new string[] { "Burger", "Fries", "Chicken", "Pizza", "Sandwich", "Onionrings", "Milkshake", "Coke" };

        var result = new StringBuilder ();
        foreach (var item in menu) {
            var countOfItem = input.Split (item.ToLower ()).Length - 1;
            result.Append (Repeat (item, countOfItem));
        }
        return result.ToString ().Trim ();
    }

    public static string Repeat (this string input, int count) {
        if (!string.IsNullOrEmpty (input)) {
            StringBuilder builder = new StringBuilder (input.Length * count);

            for (int i = 0; i < count; i++) builder.Append (input + " ");

            return builder.ToString ();
        }

        return string.Empty;
    }
}

[TestFixture]
public class OrderTest {
    [Test]
    public void Test1 () {
        Assert.AreEqual ("Burger Fries Chicken Pizza Pizza Pizza Sandwich Milkshake Milkshake Coke",
            NewCashier.GetOrder ("milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza"));
    }

    [Test]
    public void Test2 () {
        Assert.AreEqual ("Burger Fries Fries Chicken Pizza Sandwich Milkshake Coke",
            NewCashier.GetOrder ("pizzachickenfriesburgercokemilkshakefriessandwich"));
    }
}