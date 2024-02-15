using System;
using System.Text;
using NUnit.Framework;

public class RomanNumberTest
{
    [Test]
    public void TestNumberValid()
    {
        Assert.AreEqual("I", ConvertToRoman(1));
        Assert.AreEqual("V", ConvertToRoman(5));
        Assert.AreEqual("IV", ConvertToRoman(4));
    }

    [Test]
    public void TestNumberOutRango()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => ConvertToRoman(0));
        Assert.Throws<ArgumentOutOfRangeException>(() => ConvertToRoman(3999));
    }

    [Test]
    public void TestSpecialSymbo()
    {
        Assert.AreEqual("D", ConvertToRoman(500));
        Assert.AreEqual("C", ConvertToRoman(100));
        Assert.AreEqual("IX", ConvertToRoman(9));
    }

    [Test]
    public void TestDiferentError()
    {
        Assert.AreEqual("M", ConvertToRoman(500));
        Assert.AreEqual("I", ConvertToRoman(10));
        Assert.AreEqual("V", ConvertToRoman(1000));
    }

    [Test]
    public void TestIncorrect()
    {
        Assert.Throws<AssertionException>(() => ConvertToRoman("a"));

    }


    private static string ConvertToRoman(int number)
    {
        if (number <= 0 || number >= 4000)
        {
            throw new ArgumentOutOfRangeException("EL número fuera del rango 1 al 3999 no es valido");
        }

        string[] rangoNumber = { "M", "D", "C", "L", "X","IX", "V", "IV","I" };
        int[] value = { 1000, 500, 100, 50, 10, 9, 5, 4, 1 };

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < value.Length; i++)
        {
            while (number >= value[i])
            {
                if (i < rangoNumber.Length)
                {
                    sb.Append(rangoNumber[i]);
                }
                number -= value[i];
            }

        }
        return sb.ToString();
    }
}
