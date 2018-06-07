using System;
using SolutionPartA.Helpers;
using Xunit;

namespace SolutionPartA.Test
{
    public class UnitTest1
    {


        [Fact]
        public void LinkedLinkTest()
        {
            LinkList list = new LinkList();

            for (int i = 2; i < 12; i++)
            {
                list.AddAtLast(i);
            }

            var result = list.GetItemWithIndex(5);

            Console.WriteLine(result.Number);

            Assert.Equal(result.Number, 7);
        }

        [Fact]
        public void ReverseStringTest()
        {
            var result = ReverseStatement.Reverse("Cat and Dog");

            Assert.Equal(result, "taC dna goD");
        }
    }
}
