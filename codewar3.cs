
// QUESTION:
// Your classmates asked you to copy some paperwork for them. You know that there are 'n' classmates and the paperwork has 'm' pages.
// Your task is to calculate how many blank pages do you need. If n < 0 or m < 0 return 0.

using System;
public static class Paper
{
    public static int Paperwork(int n, int m)
    {
        if (n < 0 || m < 0)
        {

            return 0;

        }
        else
        {
            return n * m;
        }

    }
}

//testes

//    using NUnit.Framework;
//   using System;

//   [TestFixture]
//   public class PaperWork
//   {
//     [Test]
//     public void Test()
//     {
//      Assert.AreEqual(25, Paper.Paperwork(5,5));
//      Assert.AreEqual(0, Paper.Paperwork(5,-5));
//      Assert.AreEqual(0, Paper.Paperwork(-5,-5));
//      Assert.AreEqual(0, Paper.Paperwork(-5,5));
//      Assert.AreEqual(0, Paper.Paperwork(5,0));
//     }
//   }
