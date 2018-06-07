using System;
namespace SolutionPartA.Helpers
{
    public static class SolutionHelper
    {
        public static LinkList GetLinkedList(){
            
            LinkList linkedList = new LinkList();

            for (int i = 2; i < 12; i++)
            {
                linkedList.AddAtLast(i);
            }
            return linkedList;
        }
    }
}
