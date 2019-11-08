using System.Linq;
using System.Numerics;

public class BetweenKata {
    public static BigInteger product (int a, int b) {
        if (a < 0 || b < 0 || (a >= b - 1)) throw new System.Exception ();

        return Enumerable.Range (a + 1, b - a - 1).Aggregate (BigInteger.One, (x, y) => x * y);
    }
}

namespace Solution {
    using System.Numerics;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class SolutionTest {
        [Test]
        public void BetweenTests () {
            Assert.AreEqual ((BigInteger) 60, BetweenKata.product (2, 6));
            Assert.Throws (typeof (Exception), delegate { BetweenKata.product (3, -1); });
            Assert.Throws (typeof (Exception), delegate { BetweenKata.product (2, 0); });
            Assert.Throws (typeof (Exception), delegate { BetweenKata.product (3, 2); });
            Assert.Throws (typeof (Exception), delegate { BetweenKata.product (1, 2); });
            Assert.AreEqual ((BigInteger) 2, BetweenKata.product (1, 3));
            Assert.AreEqual ((BigInteger) 59, BetweenKata.product (58, 60));

            Assert.AreEqual ((BigInteger) 1, BetweenKata.product (0, 2));
            Assert.Throws (typeof (Exception), delegate { BetweenKata.product (0, 1); });
        }
    }
}