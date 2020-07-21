using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace TableParser
{
    [TestFixture]
    public class QuotedFieldTaskTests
    {
        //[TestCase("''", 0, "", 2)]
        //[TestCase("'a'", 0, "a", 3)]
        [TestCase("a\"b", 0, "a\"b", 4)]
        public void Test(string line, int startIndex, string expectedValue, int expectedLength)
        {
            var actualToken = QuotedFieldTask.ReadQuotedField(line, startIndex);
            Assert.AreEqual(actualToken, new Token(expectedValue, startIndex, expectedLength));
        }

        // Добавьте свои тесты
        [Test]
        public void MyTest()
        {

        }
    }

    class QuotedFieldTask
    {
       
        public static Token ReadQuotedField(string line, int startIndex)
        {

            string tok = "";
            int count = 0;
            for (int i = startIndex; i < line.Length; i++)
            {
                if (line[i].Equals('"'))
                {
                    tok += line[i];
                    count +=2;
                }

                else if (!Char.IsLetterOrDigit(line, i))
                {
                    count++;
                    continue;
                }

                else
                {
                    tok += line[i];
                    count++;
                }

            }
            return new Token(tok, startIndex, count);
            //return new Token(line, startIndex, line.Length - startIndex);
        }
    }
}
